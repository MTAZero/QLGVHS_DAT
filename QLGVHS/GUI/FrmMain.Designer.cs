namespace QLGVHS.GUI
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.barHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.barLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barPhanCong = new DevExpress.XtraBars.BarButtonItem();
            this.barDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 701);
            this.panel1.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barMonHoc,
            this.barGiaoVien,
            this.barHocSinh,
            this.barLopHoc,
            this.barPhanCong,
            this.barDoiMatKhau,
            this.barDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1334, 140);
            // 
            // barMonHoc
            // 
            this.barMonHoc.Caption = "Môn học";
            this.barMonHoc.Glyph = ((System.Drawing.Image)(resources.GetObject("barMonHoc.Glyph")));
            this.barMonHoc.Id = 1;
            this.barMonHoc.Name = "barMonHoc";
            this.barMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMonHoc_ItemClick);
            // 
            // barGiaoVien
            // 
            this.barGiaoVien.Caption = "Giáo viên";
            this.barGiaoVien.Glyph = ((System.Drawing.Image)(resources.GetObject("barGiaoVien.Glyph")));
            this.barGiaoVien.Id = 2;
            this.barGiaoVien.Name = "barGiaoVien";
            this.barGiaoVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barGiaoVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barGiaoVien_ItemClick);
            // 
            // barHocSinh
            // 
            this.barHocSinh.Caption = "Học sinh";
            this.barHocSinh.Glyph = ((System.Drawing.Image)(resources.GetObject("barHocSinh.Glyph")));
            this.barHocSinh.Id = 3;
            this.barHocSinh.Name = "barHocSinh";
            this.barHocSinh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barLopHoc
            // 
            this.barLopHoc.Caption = "Lớp học";
            this.barLopHoc.Glyph = ((System.Drawing.Image)(resources.GetObject("barLopHoc.Glyph")));
            this.barLopHoc.Id = 4;
            this.barLopHoc.Name = "barLopHoc";
            this.barLopHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barPhanCong
            // 
            this.barPhanCong.Caption = "Phân công giảng dạy";
            this.barPhanCong.Glyph = ((System.Drawing.Image)(resources.GetObject("barPhanCong.Glyph")));
            this.barPhanCong.Id = 5;
            this.barPhanCong.Name = "barPhanCong";
            this.barPhanCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barDoiMatKhau
            // 
            this.barDoiMatKhau.Caption = "Đổi mật khẩu";
            this.barDoiMatKhau.Glyph = ((System.Drawing.Image)(resources.GetObject("barDoiMatKhau.Glyph")));
            this.barDoiMatKhau.Id = 6;
            this.barDoiMatKhau.Name = "barDoiMatKhau";
            this.barDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barDangXuat
            // 
            this.barDangXuat.Caption = "Đăng xuất";
            this.barDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("barDangXuat.Glyph")));
            this.barDangXuat.Id = 7;
            this.barDangXuat.Name = "barDangXuat";
            this.barDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageQuanTri,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageQuanTri
            // 
            this.ribbonPageQuanTri.ItemLinks.Add(this.barGiaoVien);
            this.ribbonPageQuanTri.ItemLinks.Add(this.barHocSinh);
            this.ribbonPageQuanTri.ItemLinks.Add(this.barMonHoc);
            this.ribbonPageQuanTri.ItemLinks.Add(this.barLopHoc);
            this.ribbonPageQuanTri.ItemLinks.Add(this.barPhanCong);
            this.ribbonPageQuanTri.Name = "ribbonPageQuanTri";
            this.ribbonPageQuanTri.Text = "Quản trị";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barDoiMatKhau);
            this.ribbonPageGroup2.ItemLinks.Add(this.barDangXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Chức năng";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1334, 561);
            this.panelMain.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 701);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageQuanTri;
        private DevExpress.XtraBars.BarButtonItem barMonHoc;
        private DevExpress.XtraBars.BarButtonItem barGiaoVien;
        private DevExpress.XtraBars.BarButtonItem barHocSinh;
        private DevExpress.XtraBars.BarButtonItem barLopHoc;
        private DevExpress.XtraBars.BarButtonItem barPhanCong;
        private DevExpress.XtraBars.BarButtonItem barDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barDangXuat;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Panel panelMain;
    }
}