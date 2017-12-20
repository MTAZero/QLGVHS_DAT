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
    public partial class ucPhanCongGiangDay : UserControl
    {
        private PC_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucPhanCongGiangDay()
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

            cbxGiaoVien.Properties.DataSource = db.GIAOVIENs.Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxGiaoVien.Properties.DisplayMember = "Ten";
            cbxGiaoVien.Properties.ValueMember = "ID";
            cbxGiaoVien.ItemIndex = 0;

            cbxMonHoc.Properties.DataSource = db.MONHOCs.Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxMonHoc.Properties.DisplayMember = "Ten";
            cbxMonHoc.Properties.ValueMember = "ID";
            cbxMonHoc.ItemIndex = 0;

            ClearControl();
        }
        private void LoadDgvPHANCONG()
        {
            int LopID = (int)cbxLop.EditValue;
            int i = 0;
            var listPHANCONG = db.PHANCONGs.Where(p=>p.LOPHOCID == LopID).ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  MonHoc = db.MONHOCs.Where(z=>z.ID == p.MONHOCID).FirstOrDefault().TEN,
                                  GiaoVien = db.GIAOVIENs.Where(z=>z.ID == p.GIAOVIENID).FirstOrDefault().TEN
                              })
                              .ToList();

            dgvPhanCongMain.DataSource = listPHANCONG.ToList()
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             MonHoc = p.MonHoc,
                                             GiaoVien = p.GiaoVien
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvPHANCONG.FocusedRowHandle = index;
                dgvPhanCongMain.Select();
            }
            catch
            {

            }
        }
        private void ucPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvPHANCONG();
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
        private PHANCONG getPHANCONGByID()
        {
            try
            {
                int id = (int)dgvPHANCONG.GetFocusedRowCellValue("ID");
                PHANCONG ans = db.PHANCONGs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new PHANCONG();
                return ans;
            }
            catch
            {
                return new PHANCONG();
            }
        }

        private PHANCONG getPHANCONGByForm()
        {
            PHANCONG ans = new PHANCONG();

            try
            {
                ans.LOPHOCID = (int) cbxLop.EditValue;
                ans.MONHOCID = (int)cbxMonHoc.EditValue;
                ans.GIAOVIENID = (int)cbxGiaoVien.EditValue;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            cbxMonHoc.ItemIndex = 0;
            cbxGiaoVien.ItemIndex = 0;
        }

        private void UpdateDetail()
        {
            try
            {
                PHANCONG tg = getPHANCONGByID();

                if (tg.ID == 0) return;

                cbxMonHoc.EditValue = tg.MONHOCID;
                cbxGiaoVien.EditValue = tg.GIAOVIENID;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            cbxGiaoVien.Enabled = false;
            cbxMonHoc.Enabled = false;

            dgvPhanCongMain.Enabled = true;
            cbxLop.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            cbxGiaoVien.Enabled = true;
            cbxMonHoc.Enabled = true;

            dgvPhanCongMain.Enabled = false;
            cbxLop.Enabled = false;
        }

        private bool Check()
        {
            PHANCONG pc = getPHANCONGByForm();

            int id = getPHANCONGByID().ID;
            if (btnThem.Enabled) id = 0;
             
            int cnt = db.PHANCONGs.Where(p =>p.ID != id && p.LOPHOCID == pc.LOPHOCID && p.MONHOCID == pc.MONHOCID).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Môn học này đã được phân công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool CheckLuaChon()
        {
            PHANCONG tg = getPHANCONGByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có phân công nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref PHANCONG cu, PHANCONG moi)
        {
            cu.MONHOCID = moi.MONHOCID;
            cu.LOPHOCID = moi.LOPHOCID;
            cu.GIAOVIENID = moi.GIAOVIENID;
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

                    PHANCONG moi = getPHANCONGByForm();
                    db.PHANCONGs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin phân công thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin phân công thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvPHANCONG();
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

                    PHANCONG cu = getPHANCONGByID();
                    PHANCONG moi = getPHANCONGByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin phân công thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin phân công thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvPHANCONG();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                PHANCONG cu = getPHANCONGByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa phân công này ?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.PHANCONGs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin phân công thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin phân công thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvPHANCONG();

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
        private void dgvPHANCONG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            

            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvPHANCONG.FocusedRowHandle;
            }
            catch { }
        }

        private void cbxLop_EditValueChanged(object sender, EventArgs e)
        {
            LoadDgvPHANCONG();
        }
        #endregion

    }
}
