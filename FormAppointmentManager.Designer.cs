namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_9
{
    partial class FormAppointmentManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExportCsv = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            lblStatusUser = new ToolStripStatusLabel();
            tlpMain = new TableLayoutPanel();
            grpInput = new GroupBox();
            tlpInput = new TableLayoutPanel();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDoctor = new Label();
            cboDoctor = new ComboBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblReason = new Label();
            txtReason = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpFilter = new GroupBox();
            flpFilter = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            chkFilterDate = new CheckBox();
            dtpFilterDate = new DateTimePicker();
            lblFilterStatus = new Label();
            cboFilterStatus = new ComboBox();
            btnResetFilter = new Button();
            dgvAppointments = new DataGridView();
            errorProviderApp = new ErrorProvider(components);
            menuStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            tlpMain.SuspendLayout();
            grpInput.SuspendLayout();
            tlpInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            grpFilter.SuspendLayout();
            flpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new Padding(8, 3, 0, 3);
            menuStripMain.Size = new Size(1344, 30);
            menuStripMain.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExportCsv, toolStripSeparator1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(85, 24);
            mnuFile.Text = "Hệ thống";
            // 
            // mnuExportCsv
            // 
            mnuExportCsv.Name = "mnuExportCsv";
            mnuExportCsv.Size = new Size(232, 26);
            mnuExportCsv.Text = "Xuất danh sách (CSV)";
            mnuExportCsv.Click += mnuExportCsv_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(229, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(232, 26);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { lblStatusCount, lblStatusUser });
            statusStripMain.Location = new Point(0, 991);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new Padding(1, 0, 19, 0);
            statusStripMain.Size = new Size(1344, 26);
            statusStripMain.TabIndex = 1;
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(1002, 20);
            lblStatusCount.Spring = true;
            lblStatusCount.Text = "Hiển thị: 0 lịch hẹn";
            lblStatusCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(322, 20);
            lblStatusUser.Text = "Sinh viên: Nguyễn Vũ Nhật Minh - 24810320314";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(grpInput, 0, 0);
            tlpMain.Controls.Add(grpFilter, 0, 1);
            tlpMain.Controls.Add(dgvAppointments, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 30);
            tlpMain.Margin = new Padding(4, 5, 4, 5);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 308F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1344, 961);
            tlpMain.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(tlpInput);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInput.Location = new Point(7, 8);
            grpInput.Margin = new Padding(7, 8, 7, 8);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(4, 5, 4, 5);
            grpInput.Size = new Size(1330, 292);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông Tin Lịch Hẹn";
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 4;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInput.Controls.Add(lblId, 0, 0);
            tlpInput.Controls.Add(txtId, 1, 0);
            tlpInput.Controls.Add(lblName, 2, 0);
            tlpInput.Controls.Add(txtName, 3, 0);
            tlpInput.Controls.Add(lblPhone, 0, 1);
            tlpInput.Controls.Add(txtPhone, 1, 1);
            tlpInput.Controls.Add(lblDate, 2, 1);
            tlpInput.Controls.Add(dtpDate, 3, 1);
            tlpInput.Controls.Add(lblDoctor, 0, 2);
            tlpInput.Controls.Add(cboDoctor, 1, 2);
            tlpInput.Controls.Add(lblStatus, 2, 2);
            tlpInput.Controls.Add(cboStatus, 3, 2);
            tlpInput.Controls.Add(lblReason, 0, 3);
            tlpInput.Controls.Add(txtReason, 1, 3);
            tlpInput.Controls.Add(pnlButtons, 0, 4);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Font = new Font("Segoe UI", 9F);
            tlpInput.Location = new Point(4, 25);
            tlpInput.Margin = new Padding(4, 5, 4, 5);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 5;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpInput.Size = new Size(1322, 262);
            tlpInput.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.Location = new Point(4, 5);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(133, 35);
            lblId.TabIndex = 0;
            lblId.Text = "Mã lịch hẹn (*):";
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(151, 5);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(506, 27);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.Location = new Point(665, 5);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 35);
            lblName.TabIndex = 2;
            lblName.Text = "Họ tên bệnh nhân (*):";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(812, 5);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(506, 27);
            txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.Location = new Point(4, 51);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(133, 35);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại (*):";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(151, 51);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(506, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.Location = new Point(665, 51);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(133, 35);
            lblDate.TabIndex = 6;
            lblDate.Text = "Ngày giờ hẹn (*):";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(812, 51);
            dtpDate.Margin = new Padding(4, 5, 4, 5);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(506, 27);
            dtpDate.TabIndex = 7;
            // 
            // lblDoctor
            // 
            lblDoctor.Anchor = AnchorStyles.Left;
            lblDoctor.Location = new Point(4, 97);
            lblDoctor.Margin = new Padding(4, 0, 4, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(133, 35);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "Bác sĩ khám:";
            // 
            // cboDoctor
            // 
            cboDoctor.Dock = DockStyle.Fill;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.Location = new Point(151, 97);
            cboDoctor.Margin = new Padding(4, 5, 4, 5);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(506, 28);
            cboDoctor.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.Location = new Point(665, 97);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(133, 35);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            cboStatus.Dock = DockStyle.Fill;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Location = new Point(812, 97);
            cboStatus.Margin = new Padding(4, 5, 4, 5);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(506, 28);
            cboStatus.TabIndex = 11;
            // 
            // lblReason
            // 
            lblReason.Anchor = AnchorStyles.Left;
            lblReason.Location = new Point(4, 147);
            lblReason.Margin = new Padding(4, 0, 4, 0);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(133, 35);
            lblReason.TabIndex = 12;
            lblReason.Text = "Lý do khám (*):";
            // 
            // txtReason
            // 
            tlpInput.SetColumnSpan(txtReason, 3);
            txtReason.Dock = DockStyle.Fill;
            txtReason.Location = new Point(151, 143);
            txtReason.Margin = new Padding(4, 5, 4, 5);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(1167, 27);
            txtReason.TabIndex = 13;
            // 
            // pnlButtons
            // 
            tlpInput.SetColumnSpan(pnlButtons, 4);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.RightToLeft;
            pnlButtons.Location = new Point(4, 197);
            pnlButtons.Margin = new Padding(4, 5, 4, 5);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1314, 60);
            pnlButtons.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1150, 5);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm lịch hẹn";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 122, 204);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1009, 5);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(881, 5);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(753, 5);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 46);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.Click += btnClear_Click;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(flpFilter);
            grpFilter.Dock = DockStyle.Fill;
            grpFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFilter.Location = new Point(7, 316);
            grpFilter.Margin = new Padding(7, 8, 7, 0);
            grpFilter.Name = "grpFilter";
            grpFilter.Padding = new Padding(4, 5, 4, 5);
            grpFilter.Size = new Size(1330, 84);
            grpFilter.TabIndex = 1;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm & Tra cứu nhanh";
            // 
            // flpFilter
            // 
            flpFilter.Controls.Add(lblSearch);
            flpFilter.Controls.Add(txtSearch);
            flpFilter.Controls.Add(chkFilterDate);
            flpFilter.Controls.Add(dtpFilterDate);
            flpFilter.Controls.Add(lblFilterStatus);
            flpFilter.Controls.Add(cboFilterStatus);
            flpFilter.Controls.Add(btnResetFilter);
            flpFilter.Dock = DockStyle.Fill;
            flpFilter.Font = new Font("Segoe UI", 9F);
            flpFilter.Location = new Point(4, 25);
            flpFilter.Margin = new Padding(4, 5, 4, 5);
            flpFilter.Name = "flpFilter";
            flpFilter.Size = new Size(1322, 54);
            flpFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(7, 8);
            lblSearch.Margin = new Padding(7, 8, 0, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(133, 35);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Từ khóa (Tên/SĐT):";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(144, 5);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(239, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += FilterAppointments;
            // 
            // chkFilterDate
            // 
            chkFilterDate.Location = new Point(407, 8);
            chkFilterDate.Margin = new Padding(20, 8, 0, 0);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Size = new Size(139, 37);
            chkFilterDate.TabIndex = 2;
            chkFilterDate.Text = "Lọc ngày:";
            chkFilterDate.CheckedChanged += FilterAppointments;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Format = DateTimePickerFormat.Short;
            dtpFilterDate.Location = new Point(550, 5);
            dtpFilterDate.Margin = new Padding(4, 5, 4, 5);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(145, 27);
            dtpFilterDate.TabIndex = 3;
            dtpFilterDate.ValueChanged += FilterAppointments;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.Location = new Point(719, 8);
            lblFilterStatus.Margin = new Padding(20, 8, 0, 0);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(133, 35);
            lblFilterStatus.TabIndex = 4;
            lblFilterStatus.Text = "Trạng thái:";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Location = new Point(856, 5);
            cboFilterStatus.Margin = new Padding(4, 5, 4, 5);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(159, 28);
            cboFilterStatus.TabIndex = 5;
            cboFilterStatus.SelectedIndexChanged += FilterAppointments;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(1039, 2);
            btnResetFilter.Margin = new Padding(20, 2, 0, 0);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(100, 35);
            btnResetFilter.TabIndex = 6;
            btnResetFilter.Text = "Xóa lọc";
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(7, 408);
            dgvAppointments.Margin = new Padding(7, 8, 7, 8);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1330, 545);
            dgvAppointments.TabIndex = 2;
            dgvAppointments.SelectionChanged += dgvAppointments_SelectionChanged;
            // 
            // errorProviderApp
            // 
            errorProviderApp.ContainerControl = this;
            // 
            // FormAppointmentManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 1017);
            Controls.Add(tlpMain);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1194, 898);
            Name = "FormAppointmentManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager - NGUYỄN VŨ NHẬT MINH - D19QTANM1";
            Load += FormAppointmentManager_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            tlpMain.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            flpFilter.ResumeLayout(false);
            flpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCsv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cboDoctor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}