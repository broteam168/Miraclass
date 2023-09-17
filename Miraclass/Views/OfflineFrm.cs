using DevExpress.Pdf;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraSpellChecker.Parser;
using Miraclass.Controllers;
using Miraclass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Linq;

namespace Miraclass.Views
{
    public partial class OfflineFrm : DevExpress.XtraEditors.XtraForm
    {
        private S_User _currentUser;
        private int _roomId;


        public OfflineFrm()
        {
            InitializeComponent();



        }

        private void mainPdf_Click(object sender, EventArgs e)
        {
            dockPanel3.HideImmediately();
            dockPanel2.HideImmediately();
          }
        private int currentPage = 1;
        private void mainPdf_MouseDown(object sender, MouseEventArgs e)
        {
         /*   try
            {
                Point position = mainPdf.PointToClient(e.Location);
                mainPdf.GetDocumentPosition(position);

                if (currentPage != mainPdf.CurrentPageNumber)
                {
                    currentPage = mainPdf.CurrentPageNumber;
                    cls.updatePresent(currentPresent, _roomId, currentPage);
                }
            }catch (Exception ex) { }*/
        }

        
       
        private void MainRoomFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void mainPdf_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ////handle
            ///
            cancellation = new CancellationTokenSource(); //resets the token when the server restarts
            startServer();
        }

        private void gridQA_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
                
            
        }
        TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 5000);
        TcpClient client;
        String clNo;
        Dictionary<string, TcpClient> clientList = new Dictionary<string, TcpClient>();
        CancellationTokenSource cancellation = new CancellationTokenSource();
        List<string> chat = new List<string>();
        public async void startServer()
        {
            listener.Start();
            txtLog.Text+=("Server Started at " + listener.LocalEndpoint);
            txtLog.Text += ("Waiting for Clients");
            try
            {
                int counter = 0;
                while (true)
                {
                    counter++;
                    //client = await listener.AcceptTcpClientAsync();
                    client = await Task.Run(() => listener.AcceptTcpClientAsync(), cancellation.Token);

                    /* get username */
                    byte[] name = new byte[50];
                    NetworkStream stre = client.GetStream(); //Gets The Stream of The Connection
                    stre.Read(name, 0, name.Length); //Receives Data 
                    String username = Encoding.ASCII.GetString(name); // Converts Bytes Received to String
                    username = username.Substring(0, username.IndexOf("$"));

                    /* add to dictionary, listbox and send userList  */
                    clientList.Add(username, client);
                    listBox1.Items.Add(username);
                    txtLog.Text += ("Connected to user " + username + " - " + client.Client.RemoteEndPoint);
                    announce(username + " Joined ", username, false);

                    await Task.Delay(1000).ContinueWith(t => sendUsersList());


                    var c = new Thread(() => ServerReceive(client, username));
                    c.Start();

                }
            }
            catch (Exception)
            {
                listener.Stop();
            }

        }

        public void announce(string msg, string uName, bool flag)
        {
            try
            {
                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    Byte[] broadcastBytes = null;

                    if (flag)
                    {
                        //broadcastBytes = Encoding.ASCII.GetBytes("gChat|*|" + uName + " says : " + msg);

                        chat.Add("gChat");
                        chat.Add(uName + " says : " + msg);
                        broadcastBytes = ObjectToByteArray(chat);
                    }
                    else
                    {
                        //broadcastBytes = Encoding.ASCII.GetBytes("gChat|*|" + msg);

                        chat.Add("gChat");
                        chat.Add(msg);
                        broadcastBytes = ObjectToByteArray(chat);

                    }

                    broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                    broadcastStream.Flush();
                    chat.Clear();
                }
            }
            catch (Exception er)
            {

            }
        }  //end broadcast function


        public Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

        public byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }



        public void ServerReceive(TcpClient clientn, String username)
        {
            byte[] data = new byte[1000];
            String text = null;
            while (true)
            {
                try
                {
                    NetworkStream stream = clientn.GetStream(); //Gets The Stream of The Connection
                    stream.Read(data, 0, data.Length); //Receives Data 
                    List<string> parts = (List<string>)ByteArrayToObject(data);

                    switch (parts[0])
                    {
                        case "gChat":
                            this.Invoke((MethodInvoker)delegate // To Write the Received data
                            {
                                txtLog.Text +=  username + ": " + parts[1] + Environment.NewLine;
                                if (parts[1]=="GET")
                                {
                                    Private_Click("A");
                                }
                            });
                            announce(parts[1], username, true);
                            break;

                        case "pChat":
                            privateChat(parts);
                            break;
                    }

                    parts.Clear();
                }
                catch (Exception r)
                {
                    //txtLog.Text += ("Client Disconnected: " + username);
                    announce("Client Disconnected: " + username + "$", username, false);
                    clientList.Remove(username);

                    this.Invoke((MethodInvoker)delegate
                    {
                        listBox1.Items.Remove(username);
                    });
                    sendUsersList();
                    break;
                }
            }
        }

        private void btnServerStop_Click(object sender, EventArgs e)
        {
            try
            {
                listener.Stop();
                txtLog.Text += ("Server Stopped");
                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    broadcastSocket.Close();
                }
            }
            catch (SocketException er)
            {

            }

            //cancellation.Cancel();
            //client.Close();   


        }

        private void Private_Click(string s)
        {
            
                String clientName = s;

                chat.Clear();
                chat.Add("pChat");
                //chat.Add("Admin : " + inputPrivate.Text);

                byte[] byData = ObjectToByteArray(chat);
                TcpClient workerSocket = null;
                workerSocket = (TcpClient)clientList.FirstOrDefault(x => x.Key == clientName).Value; //find the client by username in dictionary

                NetworkStream stm = workerSocket.GetStream();
                stm.Write(byData, 0, byData.Length);
                stm.Flush();
                chat.Clear();

            
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient workerSocket = null;

                String clientName = listBox1.GetItemText(listBox1.SelectedItem);
                workerSocket = (TcpClient)clientList.FirstOrDefault(x => x.Key == clientName).Value; //find the client by username in dictionary
                workerSocket.Close();

            }
            catch (SocketException se)
            {
            }
        }

        public void sendUsersList()
        {
            try
            {
                byte[] userList = new byte[1024];
                string[] clist = listBox1.Items.OfType<string>().ToArray();
                List<string> users = new List<string>();

                users.Add("userList");
                foreach (String name in clist)
                {
                    users.Add(name);
                }
                userList = ObjectToByteArray(users);

                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    broadcastStream.Write(userList, 0, userList.Length);
                    broadcastStream.Flush();
                    users.Clear();
                }
            }
            catch (SocketException se)
            {
            }
        }

        private void privateChat(List<string> text)
        {
            try
            {

                byte[] byData = ObjectToByteArray(text);

                TcpClient workerSocket = null;
                workerSocket = (TcpClient)clientList.FirstOrDefault(x => x.Key == text[1]).Value; //find the client by username in dictionary

                NetworkStream stm = workerSocket.GetStream();
                stm.Write(byData, 0, byData.Length);
                stm.Flush();

            }
            catch (SocketException se)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();*/
        }
    }
}