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
    public partial class ucDsHocSinh : UserControl
    {
        private PC_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDsHocSinh()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            cbxLop.Properties.DataSource = db.LOPHOCs.Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxLop.Properties.DisplayMember = "Ten";
            cbxLop.Properties.ValueMember = "ID";

            cbxLop.ItemIndex = 0;

            ClearControl();
        }
        private void LoadDgvHOCSINH()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listHOCSINH = db.HOCSINHs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  MaHS = p.MASV,
                                  HoTen = p.TEN,
                                  GioiTinh = ((int) p.GIOITINH == 1) ? "Nam" : "Nữ",
                                  NgaySinh = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                                  Lop = db.LOPHOCs.Where(z=>z.ID == p.LOPHOCID).FirstOrDefault().TEN
                              })
                              .ToList();

            dgvHOCSINHMain.DataSource = listHOCSINH.ToList()
                                         .Where(p => p.HoTen.ToUpper().Contains(keyWord) || p.MaHS.ToUpper().Contains(keyWord) || p.GioiTinh.ToUpper().Contains(keyWord) || p.NgaySinh.Contains(keyWord) || p.Lop.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             MaHS = p.MaHS,
                                             STT = ++i,
                                             HoTen = p.HoTen,
                                             GioiTinh = p.GioiTinh,
                                             NgaySinh = p.NgaySinh,
                                             Lop = p.Lop
                              
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvHOCSINH.FocusedRowHandle = index;
                dgvHOCSINHMain.Select();
            }
            catch
            {

            }
        }
        private void ucDsMonHoc_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvHOCSINH();
            LockControl();
        }
        #endregion

        #region Hàm chức năng
        private HOCSINH getHOCSINHByID()
        {
            try
            {
                int id = (int)dgvHOCSINH.GetFocusedRowCellValue("ID");
                HOCSINH ans = db.HOCSINHs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new HOCSINH();
                return ans;
            }
            catch
            {
                return new HOCSINH();
            }
        }

        private HOCSINH getHOCSINHByForm()
        {
            HOCSINH ans = new HOCSINH();

            try
            {
                ans.MASV = txtMaGV.Text;
                ans.TEN = txtHoTen.Text;
                ans.GIOITINH = cbxGioiTinh.SelectedIndex;
                ans.NGAYSINH = dateNgaySinh.DateTime;
                ans.QUEQUAN = txtQueQuan.Text;
                ans.SDT = txtSDT.Text;
                ans.LOPHOCID = (int) cbxLop.EditValue;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            cbxGioiTinh.SelectedIndex = 0;
            dateNgaySinh.DateTime = DateTime.Now;
            txtQueQuan.Text = "";
            txtSDT.Text = "";
            cbxLop.ItemIndex = 0;
        }

        private void UpdateDetail()
        {
            try
            {
                HOCSINH tg = getHOCSINHByID();

                if (tg.ID == 0) return;

                txtMaGV.Text = tg.MASV;
                txtHoTen.Text = tg.TEN;
                cbxGioiTinh.SelectedIndex = (int) tg.GIOITINH;
                dateNgaySinh.DateTime = (DateTime) tg.NGAYSINH;
                txtQueQuan.Text = tg.QUEQUAN;
                txtSDT.Text = tg.SDT;
                cbxLop.EditValue = tg.LOPHOCID;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtMaGV.Enabled = false;
            txtHoTen.Enabled = false;
            cbxGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;
            txtQueQuan.Enabled = false;
            txtSDT.Enabled = false;
            cbxLop.Enabled = false;

            dgvHOCSINHMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtMaGV.Enabled = true;
            txtHoTen.Enabled = true;
            cbxGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtSDT.Enabled = true;
            cbxLop.Enabled = true;

            dgvHOCSINHMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Mã học sinh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            HOCSINH gv = getHOCSINHByID();
            if (btnSua.Enabled == false) gv = new HOCSINH(); 
            int cnt = db.HOCSINHs.Where(p => p.MASV == txtMaGV.Text && p.MASV != gv.MASV).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Mã học sinh đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Tên học sinh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại của học sinh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtQueQuan.Text == "")
            {
                MessageBox.Show("Quê quán của học sinh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            HOCSINH tg = getHOCSINHByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có học sinh nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref HOCSINH cu, HOCSINH moi)
        {
            cu.MASV = moi.MASV;
            cu.TEN = moi.TEN;
            cu.GIOITINH = moi.GIOITINH;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.QUEQUAN = moi.QUEQUAN;
            cu.SDT = moi.SDT;
            cu.LOPHOCID = moi.LOPHOCID;
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

                    HOCSINH moi = getHOCSINHByForm();
                    db.HOCSINHs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin học sinh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin học sinh thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvHOCSINH();
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

                    HOCSINH cu = getHOCSINHByID();
                    HOCSINH moi = getHOCSINHByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin học sinh thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin học sinh thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvHOCSINH();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                HOCSINH cu = getHOCSINHByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa học sinh " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.HOCSINHs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin học sinh thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin học sinh thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvHOCSINH();

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
            LoadDgvHOCSINH();
            txtTimKiem.Focus();
        }

        private void dgvMONHOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvHOCSINH.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
