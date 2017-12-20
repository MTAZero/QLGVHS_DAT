namespace QLGVHS.GUI
{
    partial class ucPhanCongGiangDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhanCongGiangDay));
            this.panelMain = new System.Windows.Forms.Panel();
            this.cbxLop = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxGiaoVien = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhanCongMain = new DevExpress.XtraGrid.GridControl();
            this.dgvPHANCONG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLop.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGiaoVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMonHoc.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCongMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHANCONG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.cbxLop);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.groupBox3);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1334, 561);
            this.panelMain.TabIndex = 0;
            // 
            // cbxLop
            // 
            this.cbxLop.Location = new System.Drawing.Point(98, 19);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxLop.Properties.Appearance.Options.UseFont = true;
            this.cbxLop.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxLop.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxLop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLop.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxLop.Properties.ShowHeader = false;
            this.cbxLop.Size = new System.Drawing.Size(247, 26);
            this.cbxLop.TabIndex = 10;
            this.cbxLop.EditValueChanged += new System.EventHandler(this.cbxLop_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lớp học : ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Location = new System.Drawing.Point(887, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 52);
            this.panel3.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 44);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(283, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 44);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(143, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 44);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbxGiaoVien);
            this.groupBox3.Controls.Add(this.cbxMonHoc);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(887, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 161);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phân công";
            // 
            // cbxGiaoVien
            // 
            this.cbxGiaoVien.Location = new System.Drawing.Point(119, 90);
            this.cbxGiaoVien.Name = "cbxGiaoVien";
            this.cbxGiaoVien.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxGiaoVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxGiaoVien.Properties.Appearance.Options.UseFont = true;
            this.cbxGiaoVien.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxGiaoVien.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxGiaoVien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxGiaoVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGiaoVien.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxGiaoVien.Properties.ShowHeader = false;
            this.cbxGiaoVien.Size = new System.Drawing.Size(247, 26);
            this.cbxGiaoVien.TabIndex = 6;
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.Location = new System.Drawing.Point(119, 38);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxMonHoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxMonHoc.Properties.Appearance.Options.UseFont = true;
            this.cbxMonHoc.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxMonHoc.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxMonHoc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMonHoc.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxMonHoc.Properties.ShowHeader = false;
            this.cbxMonHoc.Size = new System.Drawing.Size(247, 26);
            this.cbxMonHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giáo viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn học : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPhanCongMain);
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 483);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phân công";
            // 
            // dgvPhanCongMain
            // 
            this.dgvPhanCongMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanCongMain.Location = new System.Drawing.Point(3, 20);
            this.dgvPhanCongMain.MainView = this.dgvPHANCONG;
            this.dgvPhanCongMain.Name = "dgvPhanCongMain";
            this.dgvPhanCongMain.Size = new System.Drawing.Size(854, 460);
            this.dgvPhanCongMain.TabIndex = 2;
            this.dgvPhanCongMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvPHANCONG});
            // 
            // dgvPHANCONG
            // 
            this.dgvPHANCONG.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvPHANCONG.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvPHANCONG.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvPHANCONG.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvPHANCONG.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvPHANCONG.Appearance.Row.Options.UseFont = true;
            this.dgvPHANCONG.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvPHANCONG.ColumnPanelRowHeight = 30;
            this.dgvPHANCONG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.GiaoVien});
            this.dgvPHANCONG.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvPHANCONG.GridControl = this.dgvPhanCongMain;
            this.dgvPHANCONG.Name = "dgvPHANCONG";
            this.dgvPHANCONG.OptionsBehavior.Editable = false;
            this.dgvPHANCONG.OptionsBehavior.ReadOnly = true;
            this.dgvPHANCONG.OptionsCustomization.AllowColumnMoving = false;
            this.dgvPHANCONG.OptionsCustomization.AllowColumnResizing = false;
            this.dgvPHANCONG.OptionsCustomization.AllowFilter = false;
            this.dgvPHANCONG.OptionsCustomization.AllowGroup = false;
            this.dgvPHANCONG.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvPHANCONG.OptionsFind.AllowFindPanel = false;
            this.dgvPHANCONG.OptionsView.ShowGroupPanel = false;
            this.dgvPHANCONG.PaintStyleName = "UltraFlat";
            this.dgvPHANCONG.RowHeight = 30;
            this.dgvPHANCONG.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvPHANCONG_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "TT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 112;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên môn học";
            this.Ten.FieldName = "MonHoc";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 399;
            // 
            // GiaoVien
            // 
            this.GiaoVien.Caption = "Giáo viên";
            this.GiaoVien.FieldName = "GiaoVien";
            this.GiaoVien.Name = "GiaoVien";
            this.GiaoVien.Visible = true;
            this.GiaoVien.VisibleIndex = 2;
            this.GiaoVien.Width = 522;
            // 
            // ucPhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "ucPhanCongGiangDay";
            this.Size = new System.Drawing.Size(1334, 561);
            this.Load += new System.EventHandler(this.ucPhanCongGiangDay_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLop.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGiaoVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMonHoc.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCongMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHANCONG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvPhanCongMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvPHANCONG;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn GiaoVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LookUpEdit cbxGiaoVien;
        private DevExpress.XtraEditors.LookUpEdit cbxMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LookUpEdit cbxLop;
        private System.Windows.Forms.Label label1;
    }
}
