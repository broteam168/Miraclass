namespace Miraclass.Views
{
    partial class AddPresentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPresentFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lb_title1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.content = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roomId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ownerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridRoom = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cell_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cell_host = new DevExpress.XtraGrid.Columns.GridColumn();
            this.password = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.panelControl1.Controls.Add(this.cmdDelete);
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
            // cmdDelete
            // 
            this.cmdDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.cmdDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Appearance.Options.UseBackColor = true;
            this.cmdDelete.Appearance.Options.UseFont = true;
            this.cmdDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.ImageOptions.Image")));
            this.cmdDelete.Location = new System.Drawing.Point(1631, 7);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(151, 43);
            this.cmdDelete.TabIndex = 11;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.cmdAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Appearance.Options.UseBackColor = true;
            this.cmdAdd.Appearance.Options.UseFont = true;
            this.cmdAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.Image")));
            this.cmdAdd.Location = new System.Drawing.Point(1437, 8);
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
            this.panelControl2.Controls.Add(this.gridLookUpEdit1);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.lbName);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(1279, 62);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(529, 698);
            this.panelControl2.TabIndex = 1;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(51, 458);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(452, 22);
            this.gridLookUpEdit1.TabIndex = 11;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.gridControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(525, 308);
            this.panelControl4.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(525, 308);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.content,
            this.description,
            this.roomId,
            this.status,
            this.CateId,
            this.ownerId});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // id
            // 
            this.id.Caption = "Id";
            this.id.CustomizationCaption = "Id";
            this.id.FieldName = "id";
            this.id.MinWidth = 25;
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 94;
            // 
            // name
            // 
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.MinWidth = 25;
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            this.name.Width = 94;
            // 
            // content
            // 
            this.content.Caption = "Content";
            this.content.FieldName = "content";
            this.content.MinWidth = 25;
            this.content.Name = "content";
            this.content.Width = 94;
            // 
            // description
            // 
            this.description.Caption = "Description";
            this.description.FieldName = "description";
            this.description.MinWidth = 25;
            this.description.Name = "description";
            this.description.Visible = true;
            this.description.VisibleIndex = 2;
            this.description.Width = 94;
            // 
            // roomId
            // 
            this.roomId.Caption = "room ID";
            this.roomId.FieldName = "roomId";
            this.roomId.MinWidth = 25;
            this.roomId.Name = "roomId";
            this.roomId.Visible = true;
            this.roomId.VisibleIndex = 3;
            this.roomId.Width = 94;
            // 
            // status
            // 
            this.status.Caption = "status";
            this.status.FieldName = "status";
            this.status.MinWidth = 25;
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 4;
            this.status.Width = 94;
            // 
            // CateId
            // 
            this.CateId.Caption = "Category Id";
            this.CateId.FieldName = "cateId";
            this.CateId.MinWidth = 25;
            this.CateId.Name = "CateId";
            this.CateId.Visible = true;
            this.CateId.VisibleIndex = 5;
            this.CateId.Width = 94;
            // 
            // ownerId
            // 
            this.ownerId.Caption = "ownerId";
            this.ownerId.FieldName = "ownerId";
            this.ownerId.MinWidth = 25;
            this.ownerId.Name = "ownerId";
            this.ownerId.Visible = true;
            this.ownerId.VisibleIndex = 6;
            this.ownerId.Width = 94;
            // 
            // lbName
            // 
            this.lbName.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Appearance.Options.UseFont = true;
            this.lbName.Location = new System.Drawing.Point(51, 398);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(101, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Student id:";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridRoom);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 62);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1279, 698);
            this.panelControl3.TabIndex = 2;
            // 
            // gridRoom
            // 
            this.gridRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRoom.Location = new System.Drawing.Point(2, 2);
            this.gridRoom.MainView = this.gridView1;
            this.gridRoom.Name = "gridRoom";
            this.gridRoom.Size = new System.Drawing.Size(1275, 694);
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
            this.cell_host,
            this.password});
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
            // password
            // 
            this.password.Caption = "Password";
            this.password.FieldName = "password";
            this.password.MinWidth = 25;
            this.password.Name = "password";
            this.password.Visible = true;
            this.password.VisibleIndex = 6;
            this.password.Width = 94;
            // 
            // AddPresentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 760);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "AddPresentFrm";
            this.Text = "Add room";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraEditors.LabelControl lb_title1;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn content;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn roomId;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraGrid.Columns.GridColumn CateId;
        private DevExpress.XtraGrid.Columns.GridColumn ownerId;
        private DevExpress.XtraGrid.GridControl gridRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cell_id;
        private DevExpress.XtraGrid.Columns.GridColumn cell_name;
        private DevExpress.XtraGrid.Columns.GridColumn cell_desc;
        private DevExpress.XtraGrid.Columns.GridColumn cell_date;
        private DevExpress.XtraGrid.Columns.GridColumn cell_status;
        private DevExpress.XtraGrid.Columns.GridColumn cell_host;
        private DevExpress.XtraGrid.Columns.GridColumn password;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}