using CarService.Model;
using CarService.Data;
using System.Diagnostics;

namespace CarService {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            // Создаем хранилище данных.
            applicationData = new ApplicationData();

            // Обнавляем представление выбора мастера.
            UpdateViewSelectMaster();
            // Обнавляем представление коллекции всех мастеров автосервиса.
            UpdateViewMasters();
            // Обнавляем представление коллекции всех возможных неисправностей.
            UpdateViewMalfunctions();
            // Обнавляем представление коллекции всех заказов.
            UpdateViewRepairOrders();
        }

        private ApplicationData applicationData;

        /// <summary>
        /// Обработчик события изменения текстового поля ввода марки автомобиля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextBoxCarModelTextChanged(object sender, EventArgs e) {
            // Обновляем представление возможных неисправностей для выбранной марки автомобиля.
            UpdateViewSelectMalfunctions();
        }

        /// <summary>
        /// Обработчик события установки галочки в представлении возможных неисправностей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckedListBoxMalfunctionsSelectedIndexChanged(object sender, EventArgs e) {
            decimal price = 0;
            TimeSpan repairTime = TimeSpan.Zero;

            // Перибираем в цикле все отмеченные неисправности
            foreach (Malfunction item in checkedListBoxMalfunctions.CheckedItems) {
                price += item.Price; // Сумируем стоимость работы.
                repairTime = repairTime.Add(item.RepairTime); // Сумируем время выполнения работы.
            }

            // Обновляем значение в поле 'Общее время ремонта'.
            textBoxAllRepairTime.Text = repairTime.ToString();
            // Обновляем значение в поле 'Стоимость'.
            textBoxPrice.Text = price.ToString();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку 'Заказать'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonAddRepairOrderClick(object sender, EventArgs e) {
            // Создаем объект типа автомобиль.
            Car car = new Car(Guid.NewGuid(), textBoxCarModel.Text, textBoxVinCode.Text);
            // Проверяем правильность заполнения полей, описываюших автомобиль.
            if (string.IsNullOrWhiteSpace(car.Model) || string.IsNullOrWhiteSpace(car.VinCode)) {
                MessageBox.Show("Заполните поля 'Марка автомобиля' и 'VIN номер'");
                return;
            }

            // Создаем объект типа владелец автомобиля.
            CarOwner carOwner = new CarOwner(Guid.NewGuid(), textBoxCarOwnerFirstName.Text, textBoxCarOwnerLastName.Text, textBoxCarOwnerPhone.Text);
            // Проверяем правильность заполнения полей, описываюших владельца автомобиля.
            if (string.IsNullOrWhiteSpace(carOwner.FirstName) || string.IsNullOrWhiteSpace(carOwner.LastName) || string.IsNullOrWhiteSpace(carOwner.Phone)) {
                MessageBox.Show("Заполните поля 'Имя', 'Фамилия' и 'Телефон'");
                return;
            }

            // Получаем выбранного мастера
            Master? master = comboBoxMaster.SelectedItem as Master;
            // Проверяем выбран ли мастер.
            if (master == null) {
                MessageBox.Show("Выберите мастера.");
                return;
            }

            // Получаем список неисправностей
            Malfunction[] malfunctions = checkedListBoxMalfunctions.CheckedItems.Cast<Malfunction>().ToArray();
            // Проверяем определен ли список неисправностей.
            if (checkedListBoxMalfunctions.CheckedItems.Count == 0) {
                MessageBox.Show("Выберите неисправности которые необходимо устранить.");
                return;
            }

            // Создаем заказ на ремонт автомобиля.
            RepairOrder order = new RepairOrder(Guid.NewGuid(), car, carOwner, master, malfunctions, DateTime.Now);
            // Добавляем заказ в коллекцию
            applicationData.RepairOrders.Add(order);
            // Обнавляем представление коллекции заказов
            UpdateViewRepairOrders();

            // Очистка полей.
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
        /// Обработчик события нажатия на кнопку 'Добавить' вкладка Мастера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddMasterButtonClick(object sender, EventArgs e) {
            // Проверяем правильность заполнения полей, описываюших мастера.
            if (string.IsNullOrWhiteSpace(textBoxMasterFirstName.Text) || string.IsNullOrWhiteSpace(textBoxMasterLastName.Text) || string.IsNullOrWhiteSpace(textBoxMasterPhone.Text)) {
                MessageBox.Show("Заполните поля 'Имя', 'Фамилия' и 'Телефон'");
                return;
            }

            // Создаем объект представляюший мастера.
            Master master = new Master(Guid.NewGuid(), textBoxMasterFirstName.Text, textBoxMasterLastName.Text, textBoxMasterPhone.Text);
            // Добавляем мастера в коллекцию.
            applicationData.Masters.Add(master);

            // Обнавляем представление коллекции мастеров
            UpdateViewMasters();
            // Обнавляем представление коллекции выбора мастера
            UpdateViewSelectMaster();

            // Очищаем поля ввода
            textBoxMasterFirstName.Text = string.Empty;
            textBoxMasterLastName.Text = string.Empty;
            textBoxMasterPhone.Text = string.Empty;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку 'Добавить' вкладка Неисправности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonAddMalfunction(object sender, EventArgs e) {

            // Создаем объект определяюший время выполнения работы. Часы и минуты получаем из элемента управления 'dateTimePickerMalfunctionRepairTime'.
            TimeSpan repairTime = new TimeSpan(dateTimePickerMalfunctionRepairTime.Value.Hour, dateTimePickerMalfunctionRepairTime.Value.Minute, 0);

            // Проверяем правильность заполнения полей, описываюших неисправность автомобиля.
            if (string.IsNullOrWhiteSpace(textBoxMalfunctionCarModel.Text) || string.IsNullOrWhiteSpace(textBoxMalfunctionName.Text) || numericUpDownMalfunctionPrice.Value <= 0 || repairTime == TimeSpan.Zero) {
                MessageBox.Show("Заполните поля 'Марка автомобиля', 'Название услуги', 'Цена' и 'Время работы'");
                return;
            }

            // Создаем объект описывающий неисправность автомобиля.
            Malfunction malfunction = new Malfunction(Guid.NewGuid(), textBoxMalfunctionCarModel.Text, textBoxMalfunctionName.Text, numericUpDownMalfunctionPrice.Value, repairTime);
            // Добовляем неисправность в коллекцию.
            applicationData.Malfunctions.Add(malfunction);

            // Обнавляем представление неисправностей автомобиля
            UpdateViewMalfunctions();
            // Обнавляем представление коллекции всех неисправностей для конкретной марки автомобиля.
            UpdateViewSelectMalfunctions();

            // Очищаем поля ввода
            textBoxMalfunctionCarModel.Text = string.Empty;
            textBoxMalfunctionName.Text = string.Empty;
            numericUpDownMalfunctionPrice.Value = 0;
            dateTimePickerMalfunctionRepairTime.Value = dateTimePickerMalfunctionRepairTime.MinDate;
        }

        /// <summary>
        /// Метод обнавляет представление выбора мастера.
        /// </summary>
        private void UpdateViewSelectMaster() {
            comboBoxMaster.BeginUpdate();
            comboBoxMaster.Items.Clear();
            comboBoxMaster.Items.AddRange(applicationData.Masters.ToArray());
            comboBoxMaster.EndUpdate();
        }

        /// <summary>
        /// Метод обнавляет представление коллекции всех мастеров автосервиса.
        /// </summary>
        private void UpdateViewMasters() {
            dataGridViewMaster.DataSource = null;
            dataGridViewMaster.DataSource = applicationData.Masters;
        }

        /// <summary>
        /// Метод обнавляет представление коллекции всех возможных неисправностей.
        /// </summary>
        private void UpdateViewMalfunctions() {
            dataGridViewMalfunctions.DataSource = null;
            dataGridViewMalfunctions.DataSource = applicationData.Malfunctions;
        }

        /// <summary>
        /// Метод обнавляет представление коллекции всех заказов.
        /// </summary>
        private void UpdateViewRepairOrders() {
            dataGridViewRepairOrders.DataSource = null;
            dataGridViewRepairOrders.DataSource = applicationData.RepairOrders;
        }

        /// <summary>
        /// Метод обнавляет представление коллекции всех неисправностей для конкретной марки автомобиля.
        /// </summary>
        private void UpdateViewSelectMalfunctions() {
            // Фильтруем коллекцию содержащую возможные неисправности. Отбираем только те которые совпадают с маркой автомобиля.
            Malfunction[] malfunctions = applicationData.Malfunctions.Where(m => m.CarModel == textBoxCarModel.Text).ToArray();

            // Обнавляем представление
            checkedListBoxMalfunctions.BeginUpdate();
            checkedListBoxMalfunctions.Items.Clear();
            checkedListBoxMalfunctions.Items.AddRange(malfunctions);
            checkedListBoxMalfunctions.EndUpdate();
        }
    }
}

