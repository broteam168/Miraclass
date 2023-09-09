namespace Miraclass.Views
{
    partial class ConfigFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.lbServer = new DevExpress.XtraEditors.LabelControl();
            this.groupParamater = new System.Windows.Forms.GroupBox();
            this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdTest = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDB = new DevExpress.XtraEditors.TextEdit();
            this.lbDB = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lbPass = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            this.lbTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            this.groupParamater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl2.Location = new System.Drawing.Point(0, 315);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(560, 104);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(560, 104);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 104);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup3;
            this.layoutControl3.Size = new System.Drawing.Size(560, 211);
            this.layoutControl3.TabIndex = 2;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(560, 211);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(31, 61);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Properties.Appearance.Options.UseFont = true;
            this.txtServer.Size = new System.Drawing.Size(349, 32);
            this.txtServer.TabIndex = 2;
            // 
            // lbServer
            // 
            this.lbServer.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.Appearance.Options.UseFont = true;
            this.lbServer.Location = new System.Drawing.Point(31, 29);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(104, 19);
            this.lbServer.TabIndex = 7;
            this.lbServer.Text = "Server address:";
            // 
            // groupParamater
            // 
            this.groupParamater.Controls.Add(this.txtPass);
            this.groupParamater.Controls.Add(this.lbPass);
            this.groupParamater.Controls.Add(this.txtUser);
            this.groupParamater.Controls.Add(this.lbUser);
            this.groupParamater.Controls.Add(this.txtDB);
            this.groupParamater.Controls.Add(this.lbDB);
            this.groupParamater.Controls.Add(this.txtServer);
            this.groupParamater.Controls.Add(this.lbServer);
            this.groupParamater.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupParamater.Location = new System.Drawing.Point(35, 73);
            this.groupParamater.Name = "groupParamater";
            this.groupParamater.Size = new System.Drawing.Size(419, 351);
            this.groupParamater.TabIndex = 8;
            this.groupParamater.TabStop = false;
            this.groupParamater.Text = "Connection paramaters";
            // 
            // cmdExit
            // 
            this.cmdExit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.cmdExit.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Appearance.Options.UseBackColor = true;
            this.cmdExit.Appearance.Options.UseFont = true;
            this.cmdExit.Location = new System.Drawing.Point(346, 27);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(134, 42);
            this.cmdExit.TabIndex = 11;
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.Options.UseBackColor = true;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Location = new System.Drawing.Point(188, 28);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(134, 42);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.cmdTest.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTest.Appearance.Options.UseBackColor = true;
            this.cmdTest.Appearance.Options.UseFont = true;
            this.cmdTest.Location = new System.Drawing.Point(29, 27);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(134, 42);
            this.cmdTest.TabIndex = 9;
            this.cmdTest.Text = "Test";
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lbTitle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(504, 53);
            this.panelControl1.TabIndex = 12;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(31, 136);
            this.txtDB.Name = "txtDB";
            this.txtDB.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDB.Properties.Appearance.Options.UseFont = true;
            this.txtDB.Size = new System.Drawing.Size(349, 32);
            this.txtDB.TabIndex = 8;
            // 
            // lbDB
            // 
            this.lbDB.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDB.Appearance.Options.UseFont = true;
            this.lbDB.Location = new System.Drawing.Point(31, 111);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(106, 19);
            this.lbDB.TabIndex = 9;
            this.lbDB.Text = "Database name:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmdExit);
            this.panelControl2.Controls.Add(this.cmdTest);
            this.panelControl2.Controls.Add(this.cmdSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 430);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(504, 100);
            this.panelControl2.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(31, 295);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Size = new System.Drawing.Size(349, 32);
            this.txtPass.TabIndex = 12;
            // 
            // lbPass
            // 
            this.lbPass.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Appearance.Options.UseFont = true;
            this.lbPass.Location = new System.Drawing.Point(31, 270);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(70, 19);
            this.lbPass.TabIndex = 13;
            this.lbPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(31, 220);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(349, 32);
            this.txtUser.TabIndex = 10;
            // 
            // lbUser
            // 
            this.lbUser.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Appearance.Options.UseFont = true;
            this.lbUser.Location = new System.Drawing.Point(31, 188);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(74, 19);
            this.lbUser.TabIndex = 11;
            this.lbUser.Text = "Username:";
            // 
            // lbTitle
            // 
            this.lbTitle.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbTitle.Appearance.Options.UseFont = true;
            this.lbTitle.Appearance.Options.UseForeColor = true;
            this.lbTitle.Location = new System.Drawing.Point(151, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(211, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Connect to Database";
            // 
            // ConfigFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 530);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupParamater);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            this.groupParamater.ResumeLayout(false);
            this.groupParamater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.LabelControl lbServer;
        private System.Windows.Forms.GroupBox groupParamater;
        private DevExpress.XtraEditors.SimpleButton cmdExit;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.SimpleButton cmdTest;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl lbPass;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl lbUser;
        private DevExpress.XtraEditors.TextEdit txtDB;
        private DevExpress.XtraEditors.LabelControl lbDB;
        private DevExpress.XtraEditors.LabelControl lbTitle;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}