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
    public partial class ucDsGiaoVien : UserControl
    {
        private PC_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDsGiaoVien()
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
        private void LoadDgvGIAOVIEN()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listGIAOVIEN = db.GIAOVIENs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  MaGV = p.MAGV,
                                  HoTen = p.TEN,
                                  GioiTinh = ((int) p.GIOITINH == 1) ? "Nam" : "Nữ",
                                  NgaySinh = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy")
                              })
                              .ToList();

            dgvGIAOVIENMain.DataSource = listGIAOVIEN.ToList()
                                         .Where(p => p.HoTen.ToUpper().Contains(keyWord) || p.MaGV.ToUpper().Contains(keyWord) || p.GioiTinh.ToUpper().Contains(keyWord) || p.NgaySinh.Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             MaGV = p.MaGV,
                                             STT = ++i,
                                             HoTen = p.HoTen,
                                             GioiTinh = p.GioiTinh,
                                             NgaySinh = p.NgaySinh
                              
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvGIAOVIEN.FocusedRowHandle = index;
                dgvGIAOVIENMain.Select();
            }
            catch
            {

            }
        }
        private void ucDsMonHoc_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvGIAOVIEN();
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
        private GIAOVIEN getGIAOVIENByID()
        {
            try
            {
                int id = (int)dgvGIAOVIEN.GetFocusedRowCellValue("ID");
                GIAOVIEN ans = db.GIAOVIENs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new GIAOVIEN();
                return ans;
            }
            catch
            {
                return new GIAOVIEN();
            }
        }

        private GIAOVIEN getGIAOVIENByForm()
        {
            GIAOVIEN ans = new GIAOVIEN();

            try
            {
                ans.MAGV = txtMaGV.Text;
                ans.TEN = txtHoTen.Text;
                ans.CHUCVU = txtChucVu.Text;
                ans.DIACHI = txtDiaChi.Text;
                ans.GIOITINH = cbxGioiTinh.SelectedIndex;
                ans.NGAYSINH = dateNgaySinh.DateTime;
                ans.QUEQUAN = txtQueQuan.Text;
                ans.SDT = txtSDT.Text;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            cbxGioiTinh.SelectedIndex = 0;
            dateNgaySinh.DateTime = DateTime.Now;
            txtQueQuan.Text = "";
            txtSDT.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                GIAOVIEN tg = getGIAOVIENByID();

                if (tg.ID == 0) return;

                txtMaGV.Text = tg.MAGV;
                txtHoTen.Text = tg.TEN;
                txtChucVu.Text = tg.CHUCVU;
                txtDiaChi.Text = tg.DIACHI;
                cbxGioiTinh.SelectedIndex = (int) tg.GIOITINH;
                dateNgaySinh.DateTime = (DateTime) tg.NGAYSINH;
                txtQueQuan.Text = tg.QUEQUAN;
                txtSDT.Text = tg.SDT;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtMaGV.Enabled = false;
            txtHoTen.Enabled = false;
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = false;
            cbxGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;
            txtQueQuan.Enabled = false;
            txtSDT.Enabled = false;

            dgvGIAOVIENMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtMaGV.Enabled = true;
            txtHoTen.Enabled = true;
            txtChucVu.Enabled = true;
            txtDiaChi.Enabled = true;
            cbxGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtSDT.Enabled = true;

            dgvGIAOVIENMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Mã giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            GIAOVIEN gv = getGIAOVIENByID();
            if (btnSua.Enabled == false) gv = new GIAOVIEN(); 
            int cnt = db.GIAOVIENs.Where(p => p.MAGV == txtMaGV.Text && p.MAGV != gv.MAGV).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Mã giáo viên đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Tên giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtChucVu.Text == "")
            {
                MessageBox.Show("Chức vụ của giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại của giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtQueQuan.Text == "")
            {
                MessageBox.Show("Quê quán của giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ của giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            GIAOVIEN tg = getGIAOVIENByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có giáo viên nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref GIAOVIEN cu, GIAOVIEN moi)
        {
            cu.MAGV = moi.MAGV;
            cu.TEN = moi.TEN;
            cu.CHUCVU = moi.CHUCVU;
            cu.DIACHI = moi.DIACHI;
            cu.GIOITINH = moi.GIOITINH;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.QUEQUAN = moi.QUEQUAN;
            cu.SDT = moi.SDT;
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

                    GIAOVIEN moi = getGIAOVIENByForm();
                    db.GIAOVIENs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin giáo viên thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin giáo viên thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvGIAOVIEN();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";

                    LockControl();

                    GIAOVIEN cu = getGIAOVIENByID();
                    GIAOVIEN moi = getGIAOVIENByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin giáo viên thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin giáo viên thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvGIAOVIEN();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                GIAOVIEN cu = getGIAOVIENByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa giáo viên " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.GIAOVIENs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin giáo viên thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin giáo viên thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvGIAOVIEN();

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
            LoadDgvGIAOVIEN();
            txtTimKiem.Focus();
        }

        private void dgvMONHOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvGIAOVIEN.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
