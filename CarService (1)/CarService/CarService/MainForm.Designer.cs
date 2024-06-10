namespace CarService {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabPageAddRepairOrder = new TabPage();
            groupBox6 = new GroupBox();
            checkedListBoxMalfunctions = new CheckedListBox();
            groupBox5 = new GroupBox();
            textBoxAllRepairTime = new TextBox();
            label10 = new Label();
            textBoxPrice = new TextBox();
            buttonAddRepairOrder = new Button();
            label9 = new Label();
            groupBox4 = new GroupBox();
            comboBoxMaster = new ComboBox();
            groupBox3 = new GroupBox();
            textBoxCarOwnerPhone = new TextBox();
            label8 = new Label();
            textBoxCarOwnerLastName = new TextBox();
            label7 = new Label();
            textBoxCarOwnerFirstName = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            textBoxVinCode = new TextBox();
            label5 = new Label();
            textBoxCarModel = new TextBox();
            label4 = new Label();
            tabPageMasters = new TabPage();
            dataGridViewMaster = new DataGridView();
            groupBox1 = new GroupBox();
            buttonAddMaster = new Button();
            label3 = new Label();
            textBoxMasterPhone = new TextBox();
            label2 = new Label();
            textBoxMasterLastName = new TextBox();
            label1 = new Label();
            textBoxMasterFirstName = new TextBox();
            tabPageMalfunctions = new TabPage();
            groupBox7 = new GroupBox();
            dateTimePickerMalfunctionRepairTime = new DateTimePicker();
            numericUpDownMalfunctionPrice = new NumericUpDown();
            buttonAddMalfunction = new Button();
            label15 = new Label();
            label14 = new Label();
            textBoxMalfunctionName = new TextBox();
            label13 = new Label();
            textBoxMalfunctionCarModel = new TextBox();
            label12 = new Label();
            dataGridViewMalfunctions = new DataGridView();
            tabPageRepairs = new TabPage();
            dataGridViewRepairOrders = new DataGridView();
            applicationDataBindingSource = new BindingSource(components);
            tabControl.SuspendLayout();
            tabPageAddRepairOrder.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPageMasters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaster).BeginInit();
            groupBox1.SuspendLayout();
            tabPageMalfunctions.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMalfunctionPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMalfunctions).BeginInit();
            tabPageRepairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRepairOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageAddRepairOrder);
            tabControl.Controls.Add(tabPageMasters);
            tabControl.Controls.Add(tabPageMalfunctions);
            tabControl.Controls.Add(tabPageRepairs);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1160, 657);
            tabControl.TabIndex = 0;
            // 
            // tabPageAddRepairOrder
            // 
            tabPageAddRepairOrder.Controls.Add(groupBox6);
            tabPageAddRepairOrder.Controls.Add(groupBox5);
            tabPageAddRepairOrder.Controls.Add(groupBox4);
            tabPageAddRepairOrder.Controls.Add(groupBox3);
            tabPageAddRepairOrder.Controls.Add(groupBox2);
            tabPageAddRepairOrder.Location = new Point(4, 24);
            tabPageAddRepairOrder.Name = "tabPageAddRepairOrder";
            tabPageAddRepairOrder.Padding = new Padding(3);
            tabPageAddRepairOrder.Size = new Size(1152, 629);
            tabPageAddRepairOrder.TabIndex = 0;
            tabPageAddRepairOrder.Text = "Заказать ремонт";
            tabPageAddRepairOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(checkedListBoxMalfunctions);
            groupBox6.Location = new Point(6, 267);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1140, 306);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Неисправности:";
            // 
            // checkedListBoxMalfunctions
            // 
            checkedListBoxMalfunctions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxMalfunctions.CheckOnClick = true;
            checkedListBoxMalfunctions.FormattingEnabled = true;
            checkedListBoxMalfunctions.Location = new Point(5, 24);
            checkedListBoxMalfunctions.Name = "checkedListBoxMalfunctions";
            checkedListBoxMalfunctions.Size = new Size(1129, 256);
            checkedListBoxMalfunctions.TabIndex = 0;
            checkedListBoxMalfunctions.SelectedIndexChanged += OnCheckedListBoxMalfunctionsSelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(textBoxAllRepairTime);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(textBoxPrice);
            groupBox5.Controls.Add(buttonAddRepairOrder);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(6, 579);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1140, 44);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // textBoxAllRepairTime
            // 
            textBoxAllRepairTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxAllRepairTime.Location = new Point(571, 16);
            textBoxAllRepairTime.Name = "textBoxAllRepairTime";
            textBoxAllRepairTime.ReadOnly = true;
            textBoxAllRepairTime.Size = new Size(200, 23);
            textBoxAllRepairTime.TabIndex = 4;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(417, 19);
            label10.Name = "label10";
            label10.Size = new Size(136, 15);
            label10.TabIndex = 3;
            label10.Text = "Общее время ремонта:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxPrice.Location = new Point(853, 15);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(200, 23);
            textBoxPrice.TabIndex = 2;
            // 
            // buttonAddRepairOrder
            // 
            buttonAddRepairOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddRepairOrder.Location = new Point(1059, 15);
            buttonAddRepairOrder.Name = "buttonAddRepairOrder";
            buttonAddRepairOrder.Size = new Size(75, 23);
            buttonAddRepairOrder.TabIndex = 1;
            buttonAddRepairOrder.Text = "Заказать";
            buttonAddRepairOrder.UseVisualStyleBackColor = true;
            buttonAddRepairOrder.Click += OnButtonAddRepairOrderClick;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(777, 19);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 0;
            label9.Text = "Стоимость:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(comboBoxMaster);
            groupBox4.Location = new Point(6, 204);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1140, 57);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Автомеханик";
            // 
            // comboBoxMaster
            // 
            comboBoxMaster.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMaster.FormattingEnabled = true;
            comboBoxMaster.Location = new Point(6, 22);
            comboBoxMaster.Name = "comboBoxMaster";
            comboBoxMaster.Size = new Size(1128, 23);
            comboBoxMaster.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBoxCarOwnerPhone);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBoxCarOwnerLastName);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBoxCarOwnerFirstName);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(6, 91);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1140, 107);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Владелец";
            // 
            // textBoxCarOwnerPhone
            // 
            textBoxCarOwnerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCarOwnerPhone.Location = new Point(127, 75);
            textBoxCarOwnerPhone.Name = "textBoxCarOwnerPhone";
            textBoxCarOwnerPhone.Size = new Size(1007, 23);
            textBoxCarOwnerPhone.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 6;
            label8.Text = "Телефон:";
            // 
            // textBoxCarOwnerLastName
            // 
            textBoxCarOwnerLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCarOwnerLastName.Location = new Point(127, 46);
            textBoxCarOwnerLastName.Name = "textBoxCarOwnerLastName";
            textBoxCarOwnerLastName.Size = new Size(1007, 23);
            textBoxCarOwnerLastName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 49);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 4;
            label7.Text = "Фамилия:";
            // 
            // textBoxCarOwnerFirstName
            // 
            textBoxCarOwnerFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCarOwnerFirstName.Location = new Point(127, 17);
            textBoxCarOwnerFirstName.Name = "textBoxCarOwnerFirstName";
            textBoxCarOwnerFirstName.Size = new Size(1007, 23);
            textBoxCarOwnerFirstName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 20);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 2;
            label6.Text = "Имя:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBoxVinCode);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxCarModel);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1140, 79);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Автомобиль";
            // 
            // textBoxVinCode
            // 
            textBoxVinCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVinCode.Location = new Point(127, 47);
            textBoxVinCode.Name = "textBoxVinCode";
            textBoxVinCode.Size = new Size(1007, 23);
            textBoxVinCode.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 50);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 2;
            label5.Text = "VIN номер:";
            // 
            // textBoxCarModel
            // 
            textBoxCarModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCarModel.Location = new Point(127, 18);
            textBoxCarModel.Name = "textBoxCarModel";
            textBoxCarModel.Size = new Size(1007, 23);
            textBoxCarModel.TabIndex = 1;
            textBoxCarModel.TextChanged += OnTextBoxCarModelTextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 21);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 0;
            label4.Text = "Марка автомобиля:";
            // 
            // tabPageMasters
            // 
            tabPageMasters.Controls.Add(dataGridViewMaster);
            tabPageMasters.Controls.Add(groupBox1);
            tabPageMasters.Location = new Point(4, 24);
            tabPageMasters.Name = "tabPageMasters";
            tabPageMasters.Padding = new Padding(3);
            tabPageMasters.Size = new Size(1152, 629);
            tabPageMasters.TabIndex = 1;
            tabPageMasters.Text = "Мастера";
            tabPageMasters.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMaster
            // 
            dataGridViewMaster.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaster.Location = new Point(6, 6);
            dataGridViewMaster.Name = "dataGridViewMaster";
            dataGridViewMaster.Size = new Size(1140, 441);
            dataGridViewMaster.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonAddMaster);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxMasterPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxMasterLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxMasterFirstName);
            groupBox1.Location = new Point(6, 453);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1140, 141);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить";
            // 
            // buttonAddMaster
            // 
            buttonAddMaster.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddMaster.Location = new Point(1059, 112);
            buttonAddMaster.Name = "buttonAddMaster";
            buttonAddMaster.Size = new Size(75, 23);
            buttonAddMaster.TabIndex = 6;
            buttonAddMaster.Text = "Добавить";
            buttonAddMaster.UseVisualStyleBackColor = true;
            buttonAddMaster.Click += OnAddMasterButtonClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Телефон:";
            // 
            // textBoxMasterPhone
            // 
            textBoxMasterPhone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMasterPhone.Location = new Point(73, 83);
            textBoxMasterPhone.Name = "textBoxMasterPhone";
            textBoxMasterPhone.Size = new Size(1061, 23);
            textBoxMasterPhone.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Фамилия:";
            // 
            // textBoxMasterLastName
            // 
            textBoxMasterLastName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMasterLastName.Location = new Point(73, 54);
            textBoxMasterLastName.Name = "textBoxMasterLastName";
            textBoxMasterLastName.Size = new Size(1061, 23);
            textBoxMasterLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя:";
            // 
            // textBoxMasterFirstName
            // 
            textBoxMasterFirstName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMasterFirstName.Location = new Point(73, 25);
            textBoxMasterFirstName.Name = "textBoxMasterFirstName";
            textBoxMasterFirstName.Size = new Size(1061, 23);
            textBoxMasterFirstName.TabIndex = 0;
            // 
            // tabPageMalfunctions
            // 
            tabPageMalfunctions.Controls.Add(groupBox7);
            tabPageMalfunctions.Controls.Add(dataGridViewMalfunctions);
            tabPageMalfunctions.Location = new Point(4, 24);
            tabPageMalfunctions.Name = "tabPageMalfunctions";
            tabPageMalfunctions.Padding = new Padding(3);
            tabPageMalfunctions.Size = new Size(1152, 629);
            tabPageMalfunctions.TabIndex = 2;
            tabPageMalfunctions.Text = "Неисправности";
            tabPageMalfunctions.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox7.Controls.Add(dateTimePickerMalfunctionRepairTime);
            groupBox7.Controls.Add(numericUpDownMalfunctionPrice);
            groupBox7.Controls.Add(buttonAddMalfunction);
            groupBox7.Controls.Add(label15);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(textBoxMalfunctionName);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(textBoxMalfunctionCarModel);
            groupBox7.Controls.Add(label12);
            groupBox7.Location = new Point(6, 463);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1140, 160);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Неисправность:";
            // 
            // dateTimePickerMalfunctionRepairTime
            // 
            dateTimePickerMalfunctionRepairTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerMalfunctionRepairTime.CustomFormat = "HH:mm";
            dateTimePickerMalfunctionRepairTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerMalfunctionRepairTime.Location = new Point(128, 103);
            dateTimePickerMalfunctionRepairTime.Name = "dateTimePickerMalfunctionRepairTime";
            dateTimePickerMalfunctionRepairTime.ShowUpDown = true;
            dateTimePickerMalfunctionRepairTime.Size = new Size(1006, 23);
            dateTimePickerMalfunctionRepairTime.TabIndex = 12;
            dateTimePickerMalfunctionRepairTime.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // numericUpDownMalfunctionPrice
            // 
            numericUpDownMalfunctionPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMalfunctionPrice.DecimalPlaces = 2;
            numericUpDownMalfunctionPrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownMalfunctionPrice.Location = new Point(128, 74);
            numericUpDownMalfunctionPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMalfunctionPrice.Name = "numericUpDownMalfunctionPrice";
            numericUpDownMalfunctionPrice.Size = new Size(1006, 23);
            numericUpDownMalfunctionPrice.TabIndex = 11;
            // 
            // buttonAddMalfunction
            // 
            buttonAddMalfunction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddMalfunction.Location = new Point(1059, 131);
            buttonAddMalfunction.Name = "buttonAddMalfunction";
            buttonAddMalfunction.Size = new Size(75, 23);
            buttonAddMalfunction.TabIndex = 10;
            buttonAddMalfunction.Text = "Добавить";
            buttonAddMalfunction.UseVisualStyleBackColor = true;
            buttonAddMalfunction.Click += OnButtonAddMalfunction;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(0, 109);
            label15.Name = "label15";
            label15.Size = new Size(89, 15);
            label15.TabIndex = 6;
            label15.Text = "Время работы:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 77);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 4;
            label14.Text = "Цена:";
            // 
            // textBoxMalfunctionName
            // 
            textBoxMalfunctionName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMalfunctionName.Location = new Point(128, 45);
            textBoxMalfunctionName.Name = "textBoxMalfunctionName";
            textBoxMalfunctionName.Size = new Size(1006, 23);
            textBoxMalfunctionName.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 48);
            label13.Name = "label13";
            label13.Size = new Size(102, 15);
            label13.TabIndex = 2;
            label13.Text = "Название услуги:";
            // 
            // textBoxMalfunctionCarModel
            // 
            textBoxMalfunctionCarModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMalfunctionCarModel.Location = new Point(128, 16);
            textBoxMalfunctionCarModel.Name = "textBoxMalfunctionCarModel";
            textBoxMalfunctionCarModel.Size = new Size(1006, 23);
            textBoxMalfunctionCarModel.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(116, 15);
            label12.TabIndex = 0;
            label12.Text = "Марка автомобиля:";
            // 
            // dataGridViewMalfunctions
            // 
            dataGridViewMalfunctions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMalfunctions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMalfunctions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMalfunctions.Location = new Point(3, 3);
            dataGridViewMalfunctions.Name = "dataGridViewMalfunctions";
            dataGridViewMalfunctions.Size = new Size(1146, 454);
            dataGridViewMalfunctions.TabIndex = 0;
            // 
            // tabPageRepairs
            // 
            tabPageRepairs.Controls.Add(dataGridViewRepairOrders);
            tabPageRepairs.Location = new Point(4, 24);
            tabPageRepairs.Name = "tabPageRepairs";
            tabPageRepairs.Padding = new Padding(3);
            tabPageRepairs.Size = new Size(1152, 629);
            tabPageRepairs.TabIndex = 3;
            tabPageRepairs.Text = "Заказы";
            tabPageRepairs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRepairOrders
            // 
            dataGridViewRepairOrders.AllowUserToAddRows = false;
            dataGridViewRepairOrders.AllowUserToDeleteRows = false;
            dataGridViewRepairOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRepairOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRepairOrders.Dock = DockStyle.Fill;
            dataGridViewRepairOrders.Location = new Point(3, 3);
            dataGridViewRepairOrders.Name = "dataGridViewRepairOrders";
            dataGridViewRepairOrders.ReadOnly = true;
            dataGridViewRepairOrders.Size = new Size(1146, 623);
            dataGridViewRepairOrders.TabIndex = 0;;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Автосервис";
            tabControl.ResumeLayout(false);
            tabPageAddRepairOrder.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPageMasters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaster).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageMalfunctions.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMalfunctionPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMalfunctions).EndInit();
            tabPageRepairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRepairOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageAddRepairOrder;
        private TabPage tabPageMasters;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxMasterFirstName;
        private Button buttonAddMaster;
        private Label label3;
        private TextBox textBoxMasterPhone;
        private Label label2;
        private TextBox textBoxMasterLastName;
        private GroupBox groupBox2;
        private TextBox textBoxVinCode;
        private Label label5;
        private TextBox textBoxCarModel;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox textBoxCarOwnerFirstName;
        private Label label6;
        private TextBox textBoxCarOwnerPhone;
        private Label label8;
        private TextBox textBoxCarOwnerLastName;
        private Label label7;
        private GroupBox groupBox4;
        private ComboBox comboBoxMaster;
        private GroupBox groupBox5;
        private TextBox textBoxPrice;
        private Button buttonAddRepairOrder;
        private Label label9;
        private TextBox textBoxStartDate;
        private Label label11;
        private TextBox textBoxAllRepairTime;
        private Label label10;
        private GroupBox groupBox6;
        private CheckedListBox checkedListBoxMalfunctions;
        private TabPage tabPageMalfunctions;
        private DataGridView dataGridViewMalfunctions;
        private BindingSource applicationDataBindingSource;
        private DataGridView dataGridViewMaster;
        private GroupBox groupBox7;
        private Label label12;
        private Button buttonAddMalfunction;
        private Label label15;
        private Label label14;
        private TextBox textBoxMalfunctionName;
        private Label label13;
        private TextBox textBoxMalfunctionCarModel;
        private TabPage tabPageRepairs;
        private DataGridView dataGridViewRepairOrders;
        private NumericUpDown numericUpDownMalfunctionPrice;
        private DateTimePicker dateTimePickerMalfunctionRepairTime;
    }
}

