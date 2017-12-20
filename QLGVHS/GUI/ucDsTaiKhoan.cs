using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGVHS.Data;

namespace QLGVHS.GUI
{
    public partial class ucDsTaiKhoan : UserControl
    {
        private PC_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDsTaiKhoan()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            ClearControl();
        }
        private void LoadDgvTAIKHOAN()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listTAIKHOAN = db.TAIKHOANs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  Quyen = (p.QUYEN == 1) ? "Quản trị" : "Nhân viên"
                              })
                              .ToList();

            dgvTAIKHOANMain.DataSource = listTAIKHOAN.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.Quyen.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                             Quyen = p.Quyen
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvTAIKHOAN.FocusedRowHandle = index;
                dgvTAIKHOANMain.Select();
            }
            catch
            {

            }
        }
        private void ucDsTAIKHOAN_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvTAIKHOAN();
            LockControl();

            if (Helper.taikhoan.QUYEN == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
            }
        }
        #endregion

        #region Hàm chức năng
        private TAIKHOAN getTAIKHOANByID()
        {
            try
            {
                int id = (int)dgvTAIKHOAN.GetFocusedRowCellValue("ID");
                TAIKHOAN ans = db.TAIKHOANs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new TAIKHOAN();
                return ans;
            }
            catch
            {
                return new TAIKHOAN();
            }
        }

        private TAIKHOAN getTAIKHOANByForm()
        {
            TAIKHOAN ans = new TAIKHOAN();

            try
            {
                ans.TEN = txtTen.Text;
                ans.QUYEN = cbxQuyen.SelectedIndex;
                ans.MATKHAU = "1";
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtTen.Text = "";
            cbxQuyen.SelectedIndex = 0;
        }

        private void UpdateDetail()
        {
            try
            {
                TAIKHOAN tg = getTAIKHOANByID();

                if (tg.ID == 0) return;

                txtTen.Text = tg.TEN;
                cbxQuyen.SelectedIndex = (int) tg.QUYEN;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTen.Enabled = false;
            cbxQuyen.Enabled = false;

            dgvTAIKHOANMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTen.Enabled = true;
            cbxQuyen.Enabled = true;

            dgvTAIKHOANMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            TAIKHOAN tg = getTAIKHOANByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có tài khoản nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref TAIKHOAN cu, TAIKHOAN moi)
        {
            cu.TEN = moi.TEN;
            cu.QUYEN = moi.QUYEN;
        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnSua.Enabled = false;
                btnThem.Text = "Lưu";
                btnXoa.Text = "Hủy";

                ClearControl();
                UnlockControl();


                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    LockControl();

                    TAIKHOAN moi = getTAIKHOANByForm();
                    db.TAIKHOANs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin tài khoản thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin tài khoản thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvTAIKHOAN();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            if (btnSua.Text == "Sửa")
            {
                TAIKHOAN z = getTAIKHOANByID();
                if (z.QUYEN == 1)
                {
                    MessageBox.Show("Bạn không có quyền sửa tài khoản này",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;

                UnlockControl();

                txtTen.Enabled = false;

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";

                    txtTen.Enabled = true;
                    LockControl();

                    TAIKHOAN cu = getTAIKHOANByID();
                    TAIKHOAN moi = getTAIKHOANByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin tài khoản thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin tài khoản thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvTAIKHOAN();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                TAIKHOAN z = getTAIKHOANByID();
                if (z.QUYEN == 1)
                {
                    MessageBox.Show("Bạn không có quyền xóa tài khoản này",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                TAIKHOAN cu = getTAIKHOANByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa tài khoản " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.TAIKHOANs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin tài khoản thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin tài khoản thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvTAIKHOAN();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }
        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvTAIKHOAN();
            txtTimKiem.Focus();
        }

        private void dgvMONHOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvTAIKHOAN.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
