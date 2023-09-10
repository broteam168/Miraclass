namespace Miraclass.Views
{
    partial class RoomFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lb_title1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkActive = new DevExpress.XtraEditors.CheckEdit();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridRoom = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cell_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_host = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cmdRefresh);
            this.panelControl1.Controls.Add(this.lb_title1);
            this.panelControl1.Controls.Add(this.cmdSave);
            this.panelControl1.Controls.Add(this.cmdDelete);
            this.panelControl1.Controls.Add(this.cmdEdit);
            this.panelControl1.Controls.Add(this.cmdAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1808, 62);
            this.panelControl1.TabIndex = 0;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdRefresh.Appearance.Options.UseBackColor = true;
            this.cmdRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.ImageOptions.Image")));
            this.cmdRefresh.Location = new System.Drawing.Point(156, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.cmdRefresh.Size = new System.Drawing.Size(41, 38);
            this.cmdRefresh.TabIndex = 3;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // lb_title1
            // 
            this.lb_title1.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.Appearance.ForeColor = System.Drawing.Color.White;
            this.lb_title1.Appearance.Options.UseFont = true;
            this.lb_title1.Appearance.Options.UseForeColor = true;
            this.lb_title1.Location = new System.Drawing.Point(12, 12);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(138, 37);
            this.lb_title1.TabIndex = 1;
            this.lb_title1.Text = "Miraclass";
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.Options.UseBackColor = true;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.ImageOptions.Image")));
            this.cmdSave.Location = new System.Drawing.Point(1630, 7);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(158, 43);
            this.cmdSave.TabIndex = 12;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.cmdDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Appearance.Options.UseBackColor = true;
            this.cmdDelete.Appearance.Options.UseFont = true;
            this.cmdDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.ImageOptions.Image")));
            this.cmdDelete.Location = new System.Drawing.Point(1448, 7);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(151, 43);
            this.cmdDelete.TabIndex = 11;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.cmdEdit.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Appearance.Options.UseBackColor = true;
            this.cmdEdit.Appearance.Options.UseFont = true;
            this.cmdEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdit.ImageOptions.Image")));
            this.cmdEdit.Location = new System.Drawing.Point(1258, 7);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(158, 43);
            this.cmdEdit.TabIndex = 10;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.cmdAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Appearance.Options.UseBackColor = true;
            this.cmdAdd.Appearance.Options.UseFont = true;
            this.cmdAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.Image")));
            this.cmdAdd.Location = new System.Drawing.Point(1067, 7);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(158, 43);
            this.cmdAdd.TabIndex = 9;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.txtDesc);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.checkActive);
            this.panelControl2.Controls.Add(this.lbName);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(1416, 62);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(392, 698);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(388, 68);
            this.panelControl4.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(91, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(217, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Room information";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(25, 242);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(349, 115);
            this.txtDesc.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 26);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Room description:";
            // 
            // checkActive
            // 
            this.checkActive.Location = new System.Drawing.Point(25, 389);
            this.checkActive.Name = "checkActive";
            this.checkActive.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActive.Properties.Appearance.Options.UseFont = true;
            this.checkActive.Properties.Caption = "is Active?";
            this.checkActive.Size = new System.Drawing.Size(127, 26);
            this.checkActive.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Appearance.Options.UseFont = true;
            this.lbName.Location = new System.Drawing.Point(25, 104);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(119, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Room name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 136);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(349, 28);
            this.txtName.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridRoom);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 62);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1416, 698);
            this.panelControl3.TabIndex = 2;
            // 
            // gridRoom
            // 
            this.gridRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRoom.Location = new System.Drawing.Point(2, 2);
            this.gridRoom.MainView = this.gridView1;
            this.gridRoom.Name = "gridRoom";
            this.gridRoom.Size = new System.Drawing.Size(1412, 694);
            this.gridRoom.TabIndex = 0;
            this.gridRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridRoom.Load += new System.EventHandler(this.gridRoom_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cell_id,
            this.cell_name,
            this.cell_desc,
            this.cell_date,
            this.cell_status,
            this.cell_host});
            this.gridView1.GridControl = this.gridRoom;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // cell_id
            // 
            this.cell_id.Caption = "ID";
            this.cell_id.FieldName = "id";
            this.cell_id.MinWidth = 25;
            this.cell_id.Name = "cell_id";
            this.cell_id.Visible = true;
            this.cell_id.VisibleIndex = 0;
            this.cell_id.Width = 94;
            // 
            // cell_name
            // 
            this.cell_name.Caption = "Name room";
            this.cell_name.FieldName = "RoomName";
            this.cell_name.MinWidth = 30;
            this.cell_name.Name = "cell_name";
            this.cell_name.Visible = true;
            this.cell_name.VisibleIndex = 1;
            this.cell_name.Width = 94;
            // 
            // cell_desc
            // 
            this.cell_desc.Caption = "Description";
            this.cell_desc.FieldName = "RoomDesc";
            this.cell_desc.MinWidth = 25;
            this.cell_desc.Name = "cell_desc";
            this.cell_desc.Visible = true;
            this.cell_desc.VisibleIndex = 2;
            this.cell_desc.Width = 94;
            // 
            // cell_date
            // 
            this.cell_date.Caption = "Created Date";
            this.cell_date.FieldName = "CreatedAt";
            this.cell_date.MinWidth = 25;
            this.cell_date.Name = "cell_date";
            this.cell_date.Visible = true;
            this.cell_date.VisibleIndex = 3;
            this.cell_date.Width = 94;
            // 
            // cell_status
            // 
            this.cell_status.Caption = "Status";
            this.cell_status.FieldName = "status";
            this.cell_status.MinWidth = 25;
            this.cell_status.Name = "cell_status";
            this.cell_status.Visible = true;
            this.cell_status.VisibleIndex = 4;
            this.cell_status.Width = 94;
            // 
            // cell_host
            // 
            this.cell_host.Caption = "Id Host";
            this.cell_host.FieldName = "hostId";
            this.cell_host.MinWidth = 25;
            this.cell_host.Name = "cell_host";
            this.cell_host.Visible = true;
            this.cell_host.VisibleIndex = 5;
            this.cell_host.Width = 94;
            // 
            // RoomFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 760);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "RoomFrm";
            this.Text = "Add room";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.CheckEdit checkActive;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtDesc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraEditors.LabelControl lb_title1;
        private DevExpress.XtraGrid.Columns.GridColumn cell_id;
        private DevExpress.XtraGrid.Columns.GridColumn cell_name;
        private DevExpress.XtraGrid.Columns.GridColumn cell_desc;
        private DevExpress.XtraGrid.Columns.GridColumn cell_date;
        private DevExpress.XtraGrid.Columns.GridColumn cell_status;
        private DevExpress.XtraGrid.Columns.GridColumn cell_host;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
    }
}