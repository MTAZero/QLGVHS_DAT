namespace QLGVHS.GUI
{
    partial class ucDsLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDsLop));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLOPHOCMain = new DevExpress.XtraGrid.GridControl();
            this.dgvLOPHOC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSiSo = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOPHOCMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOPHOC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm lớp học :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvLOPHOCMain);
            this.groupBox1.Location = new System.Drawing.Point(26, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 475);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp học";
            // 
            // dgvLOPHOCMain
            // 
            this.dgvLOPHOCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLOPHOCMain.Location = new System.Drawing.Point(3, 19);
            this.dgvLOPHOCMain.MainView = this.dgvLOPHOC;
            this.dgvLOPHOCMain.Name = "dgvLOPHOCMain";
            this.dgvLOPHOCMain.Size = new System.Drawing.Size(807, 453);
            this.dgvLOPHOCMain.TabIndex = 2;
            this.dgvLOPHOCMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLOPHOC});
            // 
            // dgvLOPHOC
            // 
            this.dgvLOPHOC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvLOPHOC.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvLOPHOC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvLOPHOC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvLOPHOC.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvLOPHOC.Appearance.Row.Options.UseFont = true;
            this.dgvLOPHOC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvLOPHOC.ColumnPanelRowHeight = 30;
            this.dgvLOPHOC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.SiSo});
            this.dgvLOPHOC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvLOPHOC.GridControl = this.dgvLOPHOCMain;
            this.dgvLOPHOC.Name = "dgvLOPHOC";
            this.dgvLOPHOC.OptionsBehavior.Editable = false;
            this.dgvLOPHOC.OptionsBehavior.ReadOnly = true;
            this.dgvLOPHOC.OptionsCustomization.AllowColumnMoving = false;
            this.dgvLOPHOC.OptionsCustomization.AllowColumnResizing = false;
            this.dgvLOPHOC.OptionsCustomization.AllowFilter = false;
            this.dgvLOPHOC.OptionsCustomization.AllowGroup = false;
            this.dgvLOPHOC.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvLOPHOC.OptionsFind.AllowFindPanel = false;
            this.dgvLOPHOC.OptionsView.ShowGroupPanel = false;
            this.dgvLOPHOC.PaintStyleName = "UltraFlat";
            this.dgvLOPHOC.RowHeight = 30;
            this.dgvLOPHOC.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvLOPHOC_FocusedRowChanged);
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
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 492;
            // 
            // SiSo
            // 
            this.SiSo.Caption = "Sĩ số";
            this.SiSo.FieldName = "SiSo";
            this.SiSo.Name = "SiSo";
            this.SiSo.Visible = true;
            this.SiSo.VisibleIndex = 2;
            this.SiSo.Width = 429;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sĩ số: ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(171, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(405, 23);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSiSo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenLop);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(845, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết lớp học";
            // 
            // txtSiSo
            // 
            this.txtSiSo.AutoSize = true;
            this.txtSiSo.Location = new System.Drawing.Point(142, 93);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(22, 16);
            this.txtSiSo.TabIndex = 4;
            this.txtSiSo.Text = "20";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(145, 37);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(270, 23);
            this.txtTenLop.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(224, 44);
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
            this.btnXoa.Location = new System.Drawing.Point(3, 53);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(464, 44);
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
            this.btnSua.Location = new System.Drawing.Point(233, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(234, 44);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Location = new System.Drawing.Point(845, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 105);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 561);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 561);
            this.panel2.TabIndex = 1;
            // 
            // ucDsLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucDsLop";
            this.Size = new System.Drawing.Size(1334, 561);
            this.Load += new System.EventHandler(this.ucDsLOPHOC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOPHOCMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOPHOC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenLop;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgvLOPHOCMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLOPHOC;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn SiSo;
        private System.Windows.Forms.Label txtSiSo;
    }
}
