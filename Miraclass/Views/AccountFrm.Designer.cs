namespace Miraclass.Views
{
    partial class AccountFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRemovePass = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lb_title1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbGroup = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkTeacher = new DevExpress.XtraEditors.CheckEdit();
            this.checkActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridUser = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.userId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isTeacher = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cmdCancel);
            this.panelControl1.Controls.Add(this.cmdRemovePass);
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
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.cmdCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Appearance.Options.UseBackColor = true;
            this.cmdCancel.Appearance.Options.UseFont = true;
            this.cmdCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.ImageOptions.Image")));
            this.cmdCancel.Location = new System.Drawing.Point(1632, 7);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(158, 43);
            this.cmdCancel.TabIndex = 14;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdRemovePass
            // 
            this.cmdRemovePass.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.cmdRemovePass.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemovePass.Appearance.Options.UseBackColor = true;
            this.cmdRemovePass.Appearance.Options.UseFont = true;
            this.cmdRemovePass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRemovePass.ImageOptions.Image")));
            this.cmdRemovePass.Location = new System.Drawing.Point(665, 8);
            this.cmdRemovePass.Name = "cmdRemovePass";
            this.cmdRemovePass.Size = new System.Drawing.Size(171, 43);
            this.cmdRemovePass.TabIndex = 13;
            this.cmdRemovePass.Text = "Remove password";
            this.cmdRemovePass.Click += new System.EventHandler(this.cmdRemovePass_Click);
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
            this.cmdSave.Location = new System.Drawing.Point(1439, 7);
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
            this.cmdDelete.Location = new System.Drawing.Point(1257, 7);
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
            this.cmdEdit.Location = new System.Drawing.Point(1067, 7);
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
            this.cmdAdd.Location = new System.Drawing.Point(876, 7);
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
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Controls.Add(this.checkActive);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtPhone);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.txtFullName);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.lbName);
            this.panelControl2.Controls.Add(this.txtUser);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(1416, 62);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(392, 698);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbGroup);
            this.groupControl2.Controls.Add(this.checkTeacher);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(11, 431);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(373, 122);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Permission";
            // 
            // cbGroup
            // 
            this.cbGroup.Location = new System.Drawing.Point(16, 77);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroup.Properties.Appearance.Options.UseFont = true;
            this.cbGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGroup.Properties.DisplayMember = "GroupName";
            this.cbGroup.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbGroup.Properties.ValueMember = "GroupId";
            this.cbGroup.Size = new System.Drawing.Size(349, 28);
            this.cbGroup.TabIndex = 12;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GroupId,
            this.GroupName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // GroupId
            // 
            this.GroupId.Caption = "GroupId";
            this.GroupId.FieldName = "GroupId";
            this.GroupId.Name = "GroupId";
            this.GroupId.Visible = true;
            this.GroupId.VisibleIndex = 0;
            // 
            // GroupName
            // 
            this.GroupName.Caption = "Group Name";
            this.GroupName.FieldName = "GroupName";
            this.GroupName.Name = "GroupName";
            this.GroupName.Visible = true;
            this.GroupName.VisibleIndex = 1;
            // 
            // checkTeacher
            // 
            this.checkTeacher.Location = new System.Drawing.Point(18, 29);
            this.checkTeacher.Name = "checkTeacher";
            this.checkTeacher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTeacher.Properties.Appearance.Options.UseFont = true;
            this.checkTeacher.Properties.Caption = "Is teacher?";
            this.checkTeacher.Size = new System.Drawing.Size(109, 25);
            this.checkTeacher.TabIndex = 11;
            // 
            // checkActive
            // 
            this.checkActive.Location = new System.Drawing.Point(25, 363);
            this.checkActive.Name = "checkActive";
            this.checkActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActive.Properties.Appearance.Options.UseFont = true;
            this.checkActive.Properties.Caption = "Is active?";
            this.checkActive.Size = new System.Drawing.Size(109, 25);
            this.checkActive.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 283);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 26);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(25, 315);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(349, 28);
            this.txtPhone.TabIndex = 9;
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
            this.panelControl4.Size = new System.Drawing.Size(388, 38);
            this.panelControl4.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(153, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 31);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Account ";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(25, 231);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(349, 23);
            this.txtFullName.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 26);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Full name:";
            // 
            // lbName
            // 
            this.lbName.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Appearance.Options.UseFont = true;
            this.lbName.Location = new System.Drawing.Point(25, 104);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(92, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(23, 136);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(349, 28);
            this.txtUser.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 62);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1416, 698);
            this.panelControl3.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridUser);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1412, 694);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "List user account";
            // 
            // gridUser
            // 
            this.gridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUser.Location = new System.Drawing.Point(2, 26);
            this.gridUser.MainView = this.gridView1;
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(1408, 666);
            this.gridUser.TabIndex = 1;
            this.gridUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.userId,
            this.userName,
            this.userPassword,
            this.userGroup,
            this.userFullName,
            this.LastLogin,
            this.isActive,
            this.Phone,
            this.isTeacher});
            this.gridView1.GridControl = this.gridUser;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // userId
            // 
            this.userId.Caption = "userId";
            this.userId.FieldName = "userId";
            this.userId.MinWidth = 25;
            this.userId.Name = "userId";
            this.userId.Visible = true;
            this.userId.VisibleIndex = 0;
            this.userId.Width = 94;
            // 
            // userName
            // 
            this.userName.Caption = "userName";
            this.userName.FieldName = "userName";
            this.userName.MinWidth = 25;
            this.userName.Name = "userName";
            this.userName.Visible = true;
            this.userName.VisibleIndex = 1;
            this.userName.Width = 94;
            // 
            // userPassword
            // 
            this.userPassword.Caption = "userPassword";
            this.userPassword.FieldName = "userPassword";
            this.userPassword.MinWidth = 25;
            this.userPassword.Name = "userPassword";
            this.userPassword.Visible = true;
            this.userPassword.VisibleIndex = 2;
            this.userPassword.Width = 94;
            // 
            // userGroup
            // 
            this.userGroup.Caption = "userGroup";
            this.userGroup.FieldName = "userGroup";
            this.userGroup.MinWidth = 25;
            this.userGroup.Name = "userGroup";
            this.userGroup.Visible = true;
            this.userGroup.VisibleIndex = 3;
            this.userGroup.Width = 94;
            // 
            // userFullName
            // 
            this.userFullName.Caption = "userFullName";
            this.userFullName.FieldName = "userFullName";
            this.userFullName.MinWidth = 25;
            this.userFullName.Name = "userFullName";
            this.userFullName.Visible = true;
            this.userFullName.VisibleIndex = 4;
            this.userFullName.Width = 94;
            // 
            // LastLogin
            // 
            this.LastLogin.Caption = "LastLogin";
            this.LastLogin.FieldName = "LastLogin";
            this.LastLogin.MinWidth = 25;
            this.LastLogin.Name = "LastLogin";
            this.LastLogin.Visible = true;
            this.LastLogin.VisibleIndex = 5;
            this.LastLogin.Width = 94;
            // 
            // isActive
            // 
            this.isActive.Caption = "isActive";
            this.isActive.FieldName = "isActive";
            this.isActive.MinWidth = 25;
            this.isActive.Name = "isActive";
            this.isActive.Visible = true;
            this.isActive.VisibleIndex = 6;
            this.isActive.Width = 94;
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone";
            this.Phone.FieldName = "Phone";
            this.Phone.MinWidth = 25;
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 7;
            this.Phone.Width = 94;
            // 
            // isTeacher
            // 
            this.isTeacher.Caption = "isTeacher";
            this.isTeacher.FieldName = "isTeacher";
            this.isTeacher.MinWidth = 25;
            this.isTeacher.Name = "isTeacher";
            this.isTeacher.Visible = true;
            this.isTeacher.VisibleIndex = 8;
            this.isTeacher.Width = 94;
            // 
            // AccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 760);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "AccountFrm";
            this.Text = "Manage account";
            this.Load += new System.EventHandler(this.AccountFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraEditors.LabelControl lb_title1;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GridLookUpEdit cbGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit checkTeacher;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.SimpleButton cmdRemovePass;
        private DevExpress.XtraGrid.Columns.GridColumn userId;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn userPassword;
        private DevExpress.XtraGrid.Columns.GridColumn userGroup;
        private DevExpress.XtraGrid.Columns.GridColumn userFullName;
        private DevExpress.XtraGrid.Columns.GridColumn LastLogin;
        private DevExpress.XtraGrid.Columns.GridColumn isActive;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn isTeacher;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit checkActive;
        private DevExpress.XtraGrid.Columns.GridColumn GroupId;
        private DevExpress.XtraGrid.Columns.GridColumn GroupName;
    }
}