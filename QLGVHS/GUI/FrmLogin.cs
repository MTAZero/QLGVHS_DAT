using QLGVHS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGVHS.GUI
{
    public partial class FrmLogin : Form
    {
        private PC_Context db = Helper.db;
        public FrmLogin()
        {
            InitializeComponent();
            Helper.Reload();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int cnt = db.TAIKHOANs.Where(p => p.TEN == txtTaiKhoan.Text && p.MATKHAU == txtMatKhau.Text).ToList().Count;
            if (cnt == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Helper.taikhoan = db.TAIKHOANs.Where(p => p.TEN == txtTaiKhoan.Text && p.MATKHAU == txtMatKhau.Text).FirstOrDefault();

            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
