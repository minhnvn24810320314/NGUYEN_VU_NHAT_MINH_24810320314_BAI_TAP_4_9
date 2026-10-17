using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_9
{
    public partial class FormAppointmentManager : Form
    {
        // Danh sách gốc chứa toàn bộ lịch hẹn
        private BindingList<Appointment> masterList = new BindingList<Appointment>();

        // BindingSource để hỗ trợ lọc và hiển thị lên DataGridView
        private BindingSource bsAppointments = new BindingSource();

        public FormAppointmentManager()
        {
            InitializeComponent();
        }

        private void FormAppointmentManager_Load(object sender, EventArgs e)
        {
            // Tắt hiệu ứng nhấp nháy để Icon báo lỗi hiển thị rõ ràng khi chụp ảnh
            errorProviderApp.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            InitDropdownData();
            LoadSampleData();

            bsAppointments.DataSource = masterList;
            dgvAppointments.DataSource = bsAppointments;

            UpdateStatusCount();
            ClearInputForm();
        }

        private void InitDropdownData()
        {
            cboDoctor.Items.AddRange(new string[] {
                "BS. CKI Nguyễn Văn An",
                "BS. CKII Lê Thị Bích",
                "ThS.BS Trần Quốc Cường",
                "BS. Phạm Hoàng Nam"
            });
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;

            string[] statuses = new string[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" };
            cboStatus.Items.AddRange(statuses);
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;
        }

        private void LoadSampleData()
        {
            masterList.Add(new Appointment("LH001", "Trần Thị Cẩm Tú", "0912345678", DateTime.Now.AddDays(1), "BS. CKI Nguyễn Văn An", "Khám sức khỏe định kỳ", "Chờ khám"));
            masterList.Add(new Appointment("LH002", "Phạm Hoàng Long", "0987654321", DateTime.Now.AddHours(2), "BS. CKII Lê Thị Bích", "Đau đầu kinh niên", "Đang khám"));
            masterList.Add(new Appointment("LH003", "Lê Văn Hùng", "0905112233", DateTime.Now.AddDays(-1), "ThS.BS Trần Quốc Cường", "Tái khám hô hấp", "Hoàn tất"));
        }

        private void UpdateStatusCount()
        {
            int count = bsAppointments.Count;
            lblStatusCount.Text = $"Hiển thị: {count} lịch hẹn | Tổng cộng hệ thống: {masterList.Count} lịch hẹn";
        }

        // Chọn dòng trên DataGridView để nạp ngược lại dữ liệu lên Form
        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null && dgvAppointments.CurrentRow.DataBoundItem is Appointment app)
            {
                txtId.Text = app.AppointmentId;
                txtId.ReadOnly = true; // Không cho sửa Khóa chính khi Update

                txtName.Text = app.PatientName;
                txtPhone.Text = app.PhoneNumber;
                dtpDate.Value = app.AppointmentDate > dtpDate.MinDate ? app.AppointmentDate : DateTime.Now;
                cboDoctor.SelectedItem = app.DoctorName;
                cboStatus.SelectedItem = app.Status;
                txtReason.Text = app.Reason;

                errorProviderApp.Clear();
            }
        }

        // Hàm kiểm tra Validation đã căn chỉnh icon ErrorProvider
        private bool ValidateForm(bool isNew)
        {
            bool isValid = true;
            errorProviderApp.Clear();

            // Cấu hình vị trí xuất hiện của Icon báo lỗi để không đè lên chữ hoặc control bên cạnh
            errorProviderApp.SetIconAlignment(txtPhone, ErrorIconAlignment.MiddleLeft);
            errorProviderApp.SetIconPadding(txtPhone, 4);

            errorProviderApp.SetIconAlignment(dtpDate, ErrorIconAlignment.MiddleLeft);
            errorProviderApp.SetIconPadding(dtpDate, 4);

            // 1. Kiểm tra Mã lịch hẹn
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProviderApp.SetError(txtId, "Mã lịch hẹn không được để trống!");
                isValid = false;
            }
            else if (isNew && masterList.Any(a => a.AppointmentId.Equals(txtId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProviderApp.SetError(txtId, "Mã lịch hẹn đã tồn tại trong hệ thống!");
                isValid = false;
            }

            // 2. Kiểm tra Tên bệnh nhân
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProviderApp.SetError(txtName, "Họ tên bệnh nhân không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Số điện thoại (Bắt buộc 10 chữ số, bắt đầu bằng số 0)
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProviderApp.SetError(txtPhone, "Số điện thoại không được để trống!");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^0\d{9}$"))
            {
                errorProviderApp.SetError(txtPhone, "Số điện thoại không hợp lệ! (Phải đủ 10 chữ số và bắt đầu bằng 0)");
                isValid = false;
            }

            // 4. Kiểm tra Ngày hẹn (Không được nằm trong quá khứ)
            if (dtpDate.Value < DateTime.Now.AddMinutes(-5))
            {
                errorProviderApp.SetError(dtpDate, "Ngày hẹn không được nằm trong quá khứ!");
                isValid = false;
            }

            // 5. Kiểm tra Lý do khám
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProviderApp.SetError(txtReason, "Lý do khám không được để trống!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(isNew: true)) return;

            Appointment app = new Appointment(
                txtId.Text.Trim(),
                txtName.Text.Trim(),
                txtPhone.Text.Trim(),
                dtpDate.Value,
                cboDoctor.SelectedItem.ToString(),
                txtReason.Text.Trim(),
                cboStatus.SelectedItem.ToString()
            );

            masterList.Add(app);
            FilterAppointments(null, null);
            MessageBox.Show("Thêm lịch hẹn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm(isNew: false)) return;

            string id = txtId.Text.Trim();
            Appointment app = masterList.FirstOrDefault(a => a.AppointmentId == id);
            if (app != null)
            {
                app.PatientName = txtName.Text.Trim();
                app.PhoneNumber = txtPhone.Text.Trim();
                app.AppointmentDate = dtpDate.Value;
                app.DoctorName = cboDoctor.SelectedItem.ToString();
                app.Status = cboStatus.SelectedItem.ToString();
                app.Reason = txtReason.Text.Trim();

                bsAppointments.ResetBindings(false);
                UpdateStatusCount();
                MessageBox.Show("Cập nhật lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null || !(dgvAppointments.CurrentRow.DataBoundItem is Appointment app))
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa lịch hẹn [{app.AppointmentId}] của bệnh nhân [{app.PatientName}]?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                masterList.Remove(app);
                FilterAppointments(null, null);
                MessageBox.Show("Đã xóa lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputForm();
        }

        private void ClearInputForm()
        {
            txtId.ReadOnly = false;
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            dtpDate.Value = DateTime.Now.AddDays(1);
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            txtReason.Clear();

            dgvAppointments.ClearSelection();
            errorProviderApp.Clear();
        }

        // Chức năng Lọc & Tìm kiếm tức thời theo Tên, SĐT, Ngày và Trạng thái
        private void FilterAppointments(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            bool useDate = chkFilterDate.Checked;
            DateTime filterDate = dtpFilterDate.Value.Date;
            string status = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Tất cả";

            var filtered = masterList.Where(a =>
                (string.IsNullOrEmpty(keyword) || a.PatientName.ToLower().Contains(keyword) || a.PhoneNumber.Contains(keyword)) &&
                (!useDate || a.AppointmentDate.Date == filterDate) &&
                (status == "Tất cả" || a.Status == status)
            ).ToList();

            bsAppointments.DataSource = new BindingList<Appointment>(filtered);
            UpdateStatusCount();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            chkFilterDate.Checked = false;
            cboFilterStatus.SelectedIndex = 0;
            bsAppointments.DataSource = masterList;
            UpdateStatusCount();
        }

        // Xuất danh sách đang hiển thị ra file CSV bằng SaveFileDialog (Mã hóa UTF-8 tiếng Việt)
        private void mnuExportCsv_Click(object sender, EventArgs e)
        {
            if (bsAppointments.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu lịch hẹn để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV File (*.csv)|*.csv",
                FileName = $"DanhSachLichHen_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("Mã Lịch Hẹn,Họ Tên Bệnh Nhân,Số Điện Thoại,Ngày Giờ Hẹn,Bác Sĩ,Lý Do Khám,Trạng Thái");

                        foreach (Appointment app in bsAppointments)
                        {
                            string line = $"\"{app.AppointmentId}\",\"{app.PatientName}\",\"{app.PhoneNumber}\",\"{app.AppointmentDate:dd/MM/yyyy HH:mm}\",\"{app.DoctorName}\",\"{app.Reason}\",\"{app.Status}\"";
                            sw.WriteLine(line);
                        }
                    }

                    MessageBox.Show("Xuất dữ liệu lịch hẹn ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi trong quá trình xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}