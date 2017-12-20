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
    public partial class ucDsLop : UserControl
    {
        private PC_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDsLop()
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
        private void LoadDgvLOPHOC()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listLOPHOC = db.LOPHOCs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  SiSo = p.SISO
                              })
                              .ToList();

            dgvLOPHOCMain.DataSource = listLOPHOC.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.SiSo.ToString().ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                             SiSo = p.SiSo
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvLOPHOC.FocusedRowHandle = index;
                dgvLOPHOCMain.Select();
            }
            catch
            {

            }
        }
        private void ucDsLOPHOC_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvLOPHOC();
            LockControl();
        }
        #endregion

        #region Hàm chức năng
        private LOPHOC getLOPHOCByID()
        {
            try
            {
                int id = (int)dgvLOPHOC.GetFocusedRowCellValue("ID");
                LOPHOC ans = db.LOPHOCs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new LOPHOC();
                return ans;
            }
            catch
            {
                return new LOPHOC();
            }
        }

        private LOPHOC getLOPHOCByForm()
        {
            LOPHOC ans = new LOPHOC();

            try
            {
                ans.TEN = txtTenLop.Text;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtTenLop.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                LOPHOC tg = getLOPHOCByID();

                if (tg.ID == 0) return;

                txtTenLop.Text = tg.TEN;
                txtSiSo.Text = tg.SISO.ToString();
                
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenLop.Enabled = false;
            

            dgvLOPHOCMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenLop.Enabled = true;
            

            dgvLOPHOCMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Tên môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckLuaChon()
        {
            LOPHOC tg = getLOPHOCByID();
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

        private void CapNhat(ref LOPHOC cu, LOPHOC moi)
        {
            cu.TEN = moi.TEN;
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

                    LOPHOC moi = getLOPHOCByForm();
                    db.LOPHOCs.Add(moi);

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
                    LoadDgvLOPHOC();
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

                    LOPHOC cu = getLOPHOCByID();
                    LOPHOC moi = getLOPHOCByForm();
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
                    LoadDgvLOPHOC();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                LOPHOC cu = getLOPHOCByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa môn học " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.LOPHOCs.Remove(cu);
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
                LoadDgvLOPHOC();

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
            LoadDgvLOPHOC();
            txtTimKiem.Focus();
        }

        private void dgvLOPHOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvLOPHOC.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
