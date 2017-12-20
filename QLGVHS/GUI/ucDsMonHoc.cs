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
    public partial class ucDsMonHoc : UserControl
    {
        private PC_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDsMonHoc()
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
        private void LoadDgvMONHOC()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listMONHOC = db.MONHOCs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  GhiChu = p.GHICHU
                              })
                              .ToList();

            dgvMONHOCMain.DataSource = listMONHOC.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.GhiChu.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                             GhiChu = p.GhiChu
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvMONHOC.FocusedRowHandle = index;
                dgvMONHOCMain.Select();
            }
            catch
            {

            }
        }
        private void ucDsMonHoc_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvMONHOC();
            LockControl();
        }
        #endregion

        #region Hàm chức năng
        private MONHOC getMONHOCByID()
        {
            try
            {
                int id = (int)dgvMONHOC.GetFocusedRowCellValue("ID");
                MONHOC ans = db.MONHOCs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new MONHOC();
                return ans;
            }
            catch
            {
                return new MONHOC();
            }
        }

        private MONHOC getMONHOCByForm()
        {
            MONHOC ans = new MONHOC();

            try
            {
                ans.TEN = txtTenMon.Text;
                ans.GHICHU = txtGhiChu.Text;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtTenMon.Text = "";
            txtGhiChu.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                MONHOC tg = getMONHOCByID();

                if (tg.ID == 0) return;

                txtTenMon.Text = tg.TEN;
                txtGhiChu.Text = tg.GHICHU;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenMon.Enabled = false;
            txtGhiChu.Enabled = false;

            dgvMONHOCMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenMon.Enabled = true;
            txtGhiChu.Enabled = true;

            dgvMONHOCMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenMon.Text == "")
            {
                MessageBox.Show("Tên môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckLuaChon()
        {
            MONHOC tg = getMONHOCByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có môn học nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref MONHOC cu, MONHOC moi)
        {
            cu.TEN = moi.TEN;
            cu.GHICHU = moi.GHICHU;
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

                    MONHOC moi = getMONHOCByForm();
                    db.MONHOCs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin môn học thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin môn học thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvMONHOC();
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

                    MONHOC cu = getMONHOCByID();
                    MONHOC moi = getMONHOCByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin môn học thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin môn học thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvMONHOC();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                MONHOC cu = getMONHOCByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa môn học " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.MONHOCs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin môn học thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin môn học thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvMONHOC();

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
            LoadDgvMONHOC();
            txtTimKiem.Focus();
        }

        private void dgvMONHOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvMONHOC.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
