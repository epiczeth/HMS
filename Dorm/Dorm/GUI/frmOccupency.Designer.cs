namespace Dorm.GUI
{
    partial class frmOccupency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ocidLabel;
            System.Windows.Forms.Label namelastLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label personalidLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label districtLabel;
            System.Windows.Forms.Label provinceLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOccupency));
            this.dsOccu = new Dorm.dsOccu();
            this.tb_occupenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_occupenciesTableAdapter = new Dorm.dsOccuTableAdapters.tb_occupenciesTableAdapter();
            this.tableAdapterManager = new Dorm.dsOccuTableAdapters.TableAdapterManager();
            this.tb_occupenciesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_occupenciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ocidTextBox = new System.Windows.Forms.TextBox();
            this.namelastTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.personalidTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            ocidLabel = new System.Windows.Forms.Label();
            namelastLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            personalidLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            districtLabel = new System.Windows.Forms.Label();
            provinceLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsOccu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_occupenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_occupenciesBindingNavigator)).BeginInit();
            this.tb_occupenciesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ocidLabel
            // 
            ocidLabel.AutoSize = true;
            ocidLabel.Location = new System.Drawing.Point(29, 17);
            ocidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ocidLabel.Name = "ocidLabel";
            ocidLabel.Size = new System.Drawing.Size(58, 18);
            ocidLabel.TabIndex = 1;
            ocidLabel.Text = "รหัสผู้เช่า";
            // 
            // namelastLabel
            // 
            namelastLabel.AutoSize = true;
            namelastLabel.Location = new System.Drawing.Point(29, 53);
            namelastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            namelastLabel.Name = "namelastLabel";
            namelastLabel.Size = new System.Drawing.Size(60, 18);
            namelastLabel.TabIndex = 3;
            namelastLabel.Text = "ชื่อ - สกุล";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(29, 91);
            birthdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(44, 18);
            birthdateLabel.TabIndex = 5;
            birthdateLabel.Text = "วันเกิด";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(29, 125);
            ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(30, 18);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "อายุ";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Location = new System.Drawing.Point(29, 161);
            occupationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(40, 18);
            occupationLabel.TabIndex = 9;
            occupationLabel.Text = "อาชีพ";
            // 
            // personalidLabel
            // 
            personalidLabel.AutoSize = true;
            personalidLabel.Location = new System.Drawing.Point(29, 197);
            personalidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            personalidLabel.Name = "personalidLabel";
            personalidLabel.Size = new System.Drawing.Size(78, 18);
            personalidLabel.TabIndex = 11;
            personalidLabel.Text = "เลขประจำตัว";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(29, 233);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(33, 18);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "ที่อยู่";
            // 
            // districtLabel
            // 
            districtLabel.AutoSize = true;
            districtLabel.Location = new System.Drawing.Point(29, 319);
            districtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            districtLabel.Name = "districtLabel";
            districtLabel.Size = new System.Drawing.Size(43, 18);
            districtLabel.TabIndex = 15;
            districtLabel.Text = "อำเภอ";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Location = new System.Drawing.Point(29, 355);
            provinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new System.Drawing.Size(45, 18);
            provinceLabel.TabIndex = 17;
            provinceLabel.Text = "จังหวัด";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(29, 393);
            postcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(84, 18);
            postcodeLabel.TabIndex = 19;
            postcodeLabel.Text = "รหัสไปรษณีย์";
            // 
            // dsOccu
            // 
            this.dsOccu.DataSetName = "dsOccu";
            this.dsOccu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_occupenciesBindingSource
            // 
            this.tb_occupenciesBindingSource.DataMember = "tb_occupencies";
            this.tb_occupenciesBindingSource.DataSource = this.dsOccu;
            // 
            // tb_occupenciesTableAdapter
            // 
            this.tb_occupenciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_occupenciesTableAdapter = this.tb_occupenciesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Dorm.dsOccuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_occupenciesBindingNavigator
            // 
            this.tb_occupenciesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_occupenciesBindingNavigator.BindingSource = this.tb_occupenciesBindingSource;
            this.tb_occupenciesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_occupenciesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_occupenciesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_occupenciesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tb_occupenciesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_occupenciesBindingNavigatorSaveItem});
            this.tb_occupenciesBindingNavigator.Location = new System.Drawing.Point(0, 434);
            this.tb_occupenciesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_occupenciesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_occupenciesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_occupenciesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_occupenciesBindingNavigator.Name = "tb_occupenciesBindingNavigator";
            this.tb_occupenciesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tb_occupenciesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_occupenciesBindingNavigator.Size = new System.Drawing.Size(386, 25);
            this.tb_occupenciesBindingNavigator.TabIndex = 0;
            this.tb_occupenciesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(45, 22);
            this.bindingNavigatorAddNewItem.Text = "เพิ่ม";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorDeleteItem.Text = "ลบ";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_occupenciesBindingNavigatorSaveItem
            // 
            this.tb_occupenciesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_occupenciesBindingNavigatorSaveItem.Image")));
            this.tb_occupenciesBindingNavigatorSaveItem.Name = "tb_occupenciesBindingNavigatorSaveItem";
            this.tb_occupenciesBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 22);
            this.tb_occupenciesBindingNavigatorSaveItem.Text = "บันทึก";
            this.tb_occupenciesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_occupenciesBindingNavigatorSaveItem_Click);
            // 
            // ocidTextBox
            // 
            this.ocidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "ocid", true));
            this.ocidTextBox.Enabled = false;
            this.ocidTextBox.Location = new System.Drawing.Point(133, 13);
            this.ocidTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ocidTextBox.Name = "ocidTextBox";
            this.ocidTextBox.Size = new System.Drawing.Size(218, 24);
            this.ocidTextBox.TabIndex = 2;
            this.ocidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // namelastTextBox
            // 
            this.namelastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "namelast", true));
            this.namelastTextBox.Location = new System.Drawing.Point(133, 49);
            this.namelastTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.namelastTextBox.Name = "namelastTextBox";
            this.namelastTextBox.Size = new System.Drawing.Size(218, 24);
            this.namelastTextBox.TabIndex = 4;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_occupenciesBindingSource, "birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(133, 85);
            this.birthdateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(218, 24);
            this.birthdateDateTimePicker.TabIndex = 6;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(133, 121);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(218, 24);
            this.ageTextBox.TabIndex = 8;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "occupation", true));
            this.occupationTextBox.Location = new System.Drawing.Point(133, 157);
            this.occupationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(218, 24);
            this.occupationTextBox.TabIndex = 10;
            // 
            // personalidTextBox
            // 
            this.personalidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "personalid", true));
            this.personalidTextBox.Location = new System.Drawing.Point(133, 193);
            this.personalidTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.personalidTextBox.Name = "personalidTextBox";
            this.personalidTextBox.Size = new System.Drawing.Size(218, 24);
            this.personalidTextBox.TabIndex = 12;
            this.personalidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personalidTextBox_KeyPress);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(133, 229);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(218, 78);
            this.addressTextBox.TabIndex = 14;
            // 
            // districtTextBox
            // 
            this.districtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "district", true));
            this.districtTextBox.Location = new System.Drawing.Point(133, 315);
            this.districtTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(218, 24);
            this.districtTextBox.TabIndex = 16;
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "province", true));
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Items.AddRange(new object[] {
            "กรุงเทพมหานคร ",
            "กระบี่ ",
            "กาญจนบุรี ",
            "กาฬสินธุ์ ",
            "กำแพงเพชร ",
            "ขอนแก่น ",
            "จันทบุรี ",
            "ฉะเชิงเทรา ",
            "ชลบุรี ",
            "ชัยนาท ",
            "ชัยภูมิ ",
            "ชุมพร ",
            "เชียงราย ",
            "เชียงใหม่ ",
            "ตรัง ",
            "ตราด ",
            "ตาก ",
            "นครนายก ",
            "นครปฐม ",
            "นครพนม ",
            "นครราชสีมา ",
            "นครศรีธรรมราช ",
            "นครสวรรค์ ",
            "นนทบุรี ",
            "นราธิวาส ",
            "น่าน ",
            "บึงกาฬ ",
            "บุรีรัมย์ ",
            "ปทุมธานี ",
            "ประจวบคีรีขันธ์ ",
            "ปราจีนบุรี ",
            "ปัตตานี ",
            "พระนครศรีอยุธยา ",
            "พังงา ",
            "พัทลุง ",
            "พิจิตร ",
            "พิษณุโลก ",
            "เพชรบุรี ",
            "เพชรบูรณ์ ",
            "แพร่ ",
            "พะเยา ",
            "ภูเก็ต ",
            "มหาสารคาม ",
            "มุกดาหาร ",
            "แม่ฮ่องสอน ",
            "ยะลา ",
            "ยโสธร ",
            "ร้อยเอ็ด ",
            "ระนอง ",
            "ระยอง ",
            "ราชบุรี ",
            "ลพบุรี ",
            "ลำปาง ",
            "ลำพูน ",
            "เลย ",
            "ศรีสะเกษ ",
            "สกลนคร ",
            "สงขลา ",
            "สตูล ",
            "สมุทรปราการ ",
            "สมุทรสงคราม ",
            "สมุทรสาคร ",
            "สระแก้ว ",
            "สระบุรี ",
            "สิงห์บุรี ",
            "สุโขทัย ",
            "สุพรรณบุรี ",
            "สุราษฎร์ธานี ",
            "สุรินทร์ ",
            "หนองคาย ",
            "หนองบัวลำภู ",
            "อ่างทอง ",
            "อุดรธานี ",
            "อุทัยธานี ",
            "อุตรดิตถ์ ",
            "อุบลราชธานี ",
            "อำนาจเจริญ"});
            this.provinceComboBox.Location = new System.Drawing.Point(133, 351);
            this.provinceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(218, 26);
            this.provinceComboBox.TabIndex = 18;
            this.provinceComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.provinceComboBox_KeyUp);
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_occupenciesBindingSource, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(133, 389);
            this.postcodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(218, 24);
            this.postcodeTextBox.TabIndex = 20;
            this.postcodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postcodeTextBox_KeyPress);
            // 
            // frmOccupency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 459);
            this.Controls.Add(ocidLabel);
            this.Controls.Add(this.ocidTextBox);
            this.Controls.Add(namelastLabel);
            this.Controls.Add(this.namelastTextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(occupationLabel);
            this.Controls.Add(this.occupationTextBox);
            this.Controls.Add(personalidLabel);
            this.Controls.Add(this.personalidTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(districtLabel);
            this.Controls.Add(this.districtTextBox);
            this.Controls.Add(provinceLabel);
            this.Controls.Add(this.provinceComboBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(this.tb_occupenciesBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOccupency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการข้อมูลผู้เช่า";
            this.Load += new System.EventHandler(this.frmOccupency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsOccu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_occupenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_occupenciesBindingNavigator)).EndInit();
            this.tb_occupenciesBindingNavigator.ResumeLayout(false);
            this.tb_occupenciesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsOccu dsOccu;
        private System.Windows.Forms.BindingSource tb_occupenciesBindingSource;
        private dsOccuTableAdapters.tb_occupenciesTableAdapter tb_occupenciesTableAdapter;
        private dsOccuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_occupenciesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_occupenciesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ocidTextBox;
        private System.Windows.Forms.TextBox namelastTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.TextBox personalidTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.ComboBox provinceComboBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
    }
}