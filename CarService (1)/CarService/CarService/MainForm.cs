using CarService.Model;
using CarService.Data;
using System.Diagnostics;

namespace CarService {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            // ������� ��������� ������.
            applicationData = new ApplicationData();

            // ��������� ������������� ������ �������.
            UpdateViewSelectMaster();
            // ��������� ������������� ��������� ���� �������� �����������.
            UpdateViewMasters();
            // ��������� ������������� ��������� ���� ��������� ��������������.
            UpdateViewMalfunctions();
            // ��������� ������������� ��������� ���� �������.
            UpdateViewRepairOrders();
        }

        private ApplicationData applicationData;

        /// <summary>
        /// ���������� ������� ��������� ���������� ���� ����� ����� ����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextBoxCarModelTextChanged(object sender, EventArgs e) {
            // ��������� ������������� ��������� �������������� ��� ��������� ����� ����������.
            UpdateViewSelectMalfunctions();
        }

        /// <summary>
        /// ���������� ������� ��������� ������� � ������������� ��������� ��������������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckedListBoxMalfunctionsSelectedIndexChanged(object sender, EventArgs e) {
            decimal price = 0;
            TimeSpan repairTime = TimeSpan.Zero;

            // ���������� � ����� ��� ���������� �������������
            foreach (Malfunction item in checkedListBoxMalfunctions.CheckedItems) {
                price += item.Price; // �������� ��������� ������.
                repairTime = repairTime.Add(item.RepairTime); // �������� ����� ���������� ������.
            }

            // ��������� �������� � ���� '����� ����� �������'.
            textBoxAllRepairTime.Text = repairTime.ToString();
            // ��������� �������� � ���� '���������'.
            textBoxPrice.Text = price.ToString();
        }

        /// <summary>
        /// ���������� ������� ������� �� ������ '��������'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonAddRepairOrderClick(object sender, EventArgs e) {
            // ������� ������ ���� ����������.
            Car car = new Car(Guid.NewGuid(), textBoxCarModel.Text, textBoxVinCode.Text);
            // ��������� ������������ ���������� �����, ����������� ����������.
            if (string.IsNullOrWhiteSpace(car.Model) || string.IsNullOrWhiteSpace(car.VinCode)) {
                MessageBox.Show("��������� ���� '����� ����������' � 'VIN �����'");
                return;
            }

            // ������� ������ ���� �������� ����������.
            CarOwner carOwner = new CarOwner(Guid.NewGuid(), textBoxCarOwnerFirstName.Text, textBoxCarOwnerLastName.Text, textBoxCarOwnerPhone.Text);
            // ��������� ������������ ���������� �����, ����������� ��������� ����������.
            if (string.IsNullOrWhiteSpace(carOwner.FirstName) || string.IsNullOrWhiteSpace(carOwner.LastName) || string.IsNullOrWhiteSpace(carOwner.Phone)) {
                MessageBox.Show("��������� ���� '���', '�������' � '�������'");
                return;
            }

            // �������� ���������� �������
            Master? master = comboBoxMaster.SelectedItem as Master;
            // ��������� ������ �� ������.
            if (master == null) {
                MessageBox.Show("�������� �������.");
                return;
            }

            // �������� ������ ��������������
            Malfunction[] malfunctions = checkedListBoxMalfunctions.CheckedItems.Cast<Malfunction>().ToArray();
            // ��������� ��������� �� ������ ��������������.
            if (checkedListBoxMalfunctions.CheckedItems.Count == 0) {
                MessageBox.Show("�������� ������������� ������� ���������� ���������.");
                return;
            }

            // ������� ����� �� ������ ����������.
            RepairOrder order = new RepairOrder(Guid.NewGuid(), car, carOwner, master, malfunctions, DateTime.Now);
            // ��������� ����� � ���������
            applicationData.RepairOrders.Add(order);
            // ��������� ������������� ��������� �������
            UpdateViewRepairOrders();

            // ������� �����.
            textBoxCarModel.Text = string.Empty;
            textBoxVinCode.Text = string.Empty;
            textBoxCarOwnerFirstName.Text = string.Empty;
            textBoxCarOwnerLastName.Text = string.Empty;
            textBoxCarOwnerPhone.Text = string.Empty;
            comboBoxMaster.SelectedItem = null;
            textBoxAllRepairTime.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
        }

        /// <summary>
        /// ���������� ������� ������� �� ������ '��������' ������� �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddMasterButtonClick(object sender, EventArgs e) {
            // ��������� ������������ ���������� �����, ����������� �������.
            if (string.IsNullOrWhiteSpace(textBoxMasterFirstName.Text) || string.IsNullOrWhiteSpace(textBoxMasterLastName.Text) || string.IsNullOrWhiteSpace(textBoxMasterPhone.Text)) {
                MessageBox.Show("��������� ���� '���', '�������' � '�������'");
                return;
            }

            // ������� ������ �������������� �������.
            Master master = new Master(Guid.NewGuid(), textBoxMasterFirstName.Text, textBoxMasterLastName.Text, textBoxMasterPhone.Text);
            // ��������� ������� � ���������.
            applicationData.Masters.Add(master);

            // ��������� ������������� ��������� ��������
            UpdateViewMasters();
            // ��������� ������������� ��������� ������ �������
            UpdateViewSelectMaster();

            // ������� ���� �����
            textBoxMasterFirstName.Text = string.Empty;
            textBoxMasterLastName.Text = string.Empty;
            textBoxMasterPhone.Text = string.Empty;
        }

        /// <summary>
        /// ���������� ������� ������� �� ������ '��������' ������� �������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonAddMalfunction(object sender, EventArgs e) {

            // ������� ������ ������������ ����� ���������� ������. ���� � ������ �������� �� �������� ���������� 'dateTimePickerMalfunctionRepairTime'.
            TimeSpan repairTime = new TimeSpan(dateTimePickerMalfunctionRepairTime.Value.Hour, dateTimePickerMalfunctionRepairTime.Value.Minute, 0);

            // ��������� ������������ ���������� �����, ����������� ������������� ����������.
            if (string.IsNullOrWhiteSpace(textBoxMalfunctionCarModel.Text) || string.IsNullOrWhiteSpace(textBoxMalfunctionName.Text) || numericUpDownMalfunctionPrice.Value <= 0 || repairTime == TimeSpan.Zero) {
                MessageBox.Show("��������� ���� '����� ����������', '�������� ������', '����' � '����� ������'");
                return;
            }

            // ������� ������ ����������� ������������� ����������.
            Malfunction malfunction = new Malfunction(Guid.NewGuid(), textBoxMalfunctionCarModel.Text, textBoxMalfunctionName.Text, numericUpDownMalfunctionPrice.Value, repairTime);
            // ��������� ������������� � ���������.
            applicationData.Malfunctions.Add(malfunction);

            // ��������� ������������� �������������� ����������
            UpdateViewMalfunctions();
            // ��������� ������������� ��������� ���� �������������� ��� ���������� ����� ����������.
            UpdateViewSelectMalfunctions();

            // ������� ���� �����
            textBoxMalfunctionCarModel.Text = string.Empty;
            textBoxMalfunctionName.Text = string.Empty;
            numericUpDownMalfunctionPrice.Value = 0;
            dateTimePickerMalfunctionRepairTime.Value = dateTimePickerMalfunctionRepairTime.MinDate;
        }

        /// <summary>
        /// ����� ��������� ������������� ������ �������.
        /// </summary>
        private void UpdateViewSelectMaster() {
            comboBoxMaster.BeginUpdate();
            comboBoxMaster.Items.Clear();
            comboBoxMaster.Items.AddRange(applicationData.Masters.ToArray());
            comboBoxMaster.EndUpdate();
        }

        /// <summary>
        /// ����� ��������� ������������� ��������� ���� �������� �����������.
        /// </summary>
        private void UpdateViewMasters() {
            dataGridViewMaster.DataSource = null;
            dataGridViewMaster.DataSource = applicationData.Masters;
        }

        /// <summary>
        /// ����� ��������� ������������� ��������� ���� ��������� ��������������.
        /// </summary>
        private void UpdateViewMalfunctions() {
            dataGridViewMalfunctions.DataSource = null;
            dataGridViewMalfunctions.DataSource = applicationData.Malfunctions;
        }

        /// <summary>
        /// ����� ��������� ������������� ��������� ���� �������.
        /// </summary>
        private void UpdateViewRepairOrders() {
            dataGridViewRepairOrders.DataSource = null;
            dataGridViewRepairOrders.DataSource = applicationData.RepairOrders;
        }

        /// <summary>
        /// ����� ��������� ������������� ��������� ���� �������������� ��� ���������� ����� ����������.
        /// </summary>
        private void UpdateViewSelectMalfunctions() {
            // ��������� ��������� ���������� ��������� �������������. �������� ������ �� ������� ��������� � ������ ����������.
            Malfunction[] malfunctions = applicationData.Malfunctions.Where(m => m.CarModel == textBoxCarModel.Text).ToArray();

            // ��������� �������������
            checkedListBoxMalfunctions.BeginUpdate();
            checkedListBoxMalfunctions.Items.Clear();
            checkedListBoxMalfunctions.Items.AddRange(malfunctions);
            checkedListBoxMalfunctions.EndUpdate();
        }
    }
}

