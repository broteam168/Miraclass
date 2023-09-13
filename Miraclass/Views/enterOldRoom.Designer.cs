namespace Miraclass.Views
{
    partial class enterOldRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enterOldRoom));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lb_title1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lb_title1);
            this.panelControl1.Controls.Add(this.cmdSave);
            this.panelControl1.Controls.Add(this.cmdDelete);
            this.panelControl1.Controls.Add(this.cmdEdit);
            this.panelControl1.Controls.Add(this.cmdAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(569, 62);
            this.panelControl1.TabIndex = 1;
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
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "3w3";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(35, 118);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DisplayMember = "RoomName";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(499, 30);
            this.gridLookUpEdit1.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.RoomName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            // 
            // RoomName
            // 
            this.RoomName.Caption = "RoomName";
            this.RoomName.FieldName = "RoomName";
            this.RoomName.Name = "RoomName";
            this.RoomName.Visible = true;
            this.RoomName.VisibleIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(128, 187);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(277, 65);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Start";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(128, 285);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(277, 65);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "List of rooms working: ";
            // 
            // enterOldRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 374);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "enterOldRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "enterOldRoom";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lb_title1;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private DevExpress.XtraEditors.SimpleButton cmdEdit;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn RoomName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}