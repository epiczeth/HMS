namespace Dorm.GUI
{
    partial class frmRooms
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
            System.Windows.Forms.Label roomnumberLabel;
            System.Windows.Forms.Label roomratesLabel;
            System.Windows.Forms.Label roomdetailsLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRooms));
            this.dsMainMenu = new Dorm.dsMainMenu();
            this.tb_roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_roomsTableAdapter = new Dorm.dsMainMenuTableAdapters.tb_roomsTableAdapter();
            this.tableAdapterManager = new Dorm.dsMainMenuTableAdapters.TableAdapterManager();
            this.tb_roomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_roomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.roomnumberTextBox = new System.Windows.Forms.TextBox();
            this.roomratesTextBox = new System.Windows.Forms.TextBox();
            this.roomdetailsTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            roomnumberLabel = new System.Windows.Forms.Label();
            roomratesLabel = new System.Windows.Forms.Label();
            roomdetailsLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_roomsBindingNavigator)).BeginInit();
            this.tb_roomsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomnumberLabel
            // 
            roomnumberLabel.AutoSize = true;
            roomnumberLabel.Location = new System.Drawing.Point(22, 18);
            roomnumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomnumberLabel.Name = "roomnumberLabel";
            roomnumberLabel.Size = new System.Drawing.Size(59, 18);
            roomnumberLabel.TabIndex = 1;
            roomnumberLabel.Text = "เลขที่ห้อง";
            // 
            // roomratesLabel
            // 
            roomratesLabel.AutoSize = true;
            roomratesLabel.Location = new System.Drawing.Point(22, 55);
            roomratesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomratesLabel.Name = "roomratesLabel";
            roomratesLabel.Size = new System.Drawing.Size(35, 18);
            roomratesLabel.TabIndex = 3;
            roomratesLabel.Text = "ราคา";
            // 
            // roomdetailsLabel
            // 
            roomdetailsLabel.AutoSize = true;
            roomdetailsLabel.Location = new System.Drawing.Point(22, 91);
            roomdetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomdetailsLabel.Name = "roomdetailsLabel";
            roomdetailsLabel.Size = new System.Drawing.Size(71, 18);
            roomdetailsLabel.TabIndex = 5;
            roomdetailsLabel.Text = "รายละเอียด";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(22, 179);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(69, 18);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "สถานะห้อง";
            // 
            // dsMainMenu
            // 
            this.dsMainMenu.DataSetName = "dsMainMenu";
            this.dsMainMenu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_roomsBindingSource
            // 
            this.tb_roomsBindingSource.DataMember = "tb_rooms";
            this.tb_roomsBindingSource.DataSource = this.dsMainMenu;
            // 
            // tb_roomsTableAdapter
            // 
            this.tb_roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_roomsTableAdapter = this.tb_roomsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Dorm.dsMainMenuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_roomsBindingNavigator
            // 
            this.tb_roomsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_roomsBindingNavigator.BindingSource = this.tb_roomsBindingSource;
            this.tb_roomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_roomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_roomsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_roomsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tb_roomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_roomsBindingNavigatorSaveItem});
            this.tb_roomsBindingNavigator.Location = new System.Drawing.Point(0, 256);
            this.tb_roomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_roomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_roomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_roomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_roomsBindingNavigator.Name = "tb_roomsBindingNavigator";
            this.tb_roomsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tb_roomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_roomsBindingNavigator.Size = new System.Drawing.Size(457, 25);
            this.tb_roomsBindingNavigator.TabIndex = 0;
            this.tb_roomsBindingNavigator.Text = "bindingNavigator1";
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
            // tb_roomsBindingNavigatorSaveItem
            // 
            this.tb_roomsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_roomsBindingNavigatorSaveItem.Image")));
            this.tb_roomsBindingNavigatorSaveItem.Name = "tb_roomsBindingNavigatorSaveItem";
            this.tb_roomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 22);
            this.tb_roomsBindingNavigatorSaveItem.Text = "บันทึก";
            this.tb_roomsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_roomsBindingNavigatorSaveItem_Click);
            // 
            // roomnumberTextBox
            // 
            this.roomnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_roomsBindingSource, "roomnumber", true));
            this.roomnumberTextBox.Enabled = false;
            this.roomnumberTextBox.Location = new System.Drawing.Point(132, 15);
            this.roomnumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomnumberTextBox.Name = "roomnumberTextBox";
            this.roomnumberTextBox.ReadOnly = true;
            this.roomnumberTextBox.Size = new System.Drawing.Size(260, 24);
            this.roomnumberTextBox.TabIndex = 2;
            this.roomnumberTextBox.TabStop = false;
            this.roomnumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomratesTextBox
            // 
            this.roomratesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_roomsBindingSource, "roomrates", true));
            this.roomratesTextBox.Location = new System.Drawing.Point(132, 51);
            this.roomratesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomratesTextBox.Name = "roomratesTextBox";
            this.roomratesTextBox.Size = new System.Drawing.Size(260, 24);
            this.roomratesTextBox.TabIndex = 4;
            this.roomratesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomratesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomratesTextBox_KeyPress);
            // 
            // roomdetailsTextBox
            // 
            this.roomdetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_roomsBindingSource, "roomdetails", true));
            this.roomdetailsTextBox.Location = new System.Drawing.Point(132, 87);
            this.roomdetailsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomdetailsTextBox.Multiline = true;
            this.roomdetailsTextBox.Name = "roomdetailsTextBox";
            this.roomdetailsTextBox.Size = new System.Drawing.Size(260, 80);
            this.roomdetailsTextBox.TabIndex = 6;
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_roomsBindingSource, "status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "ว่าง",
            "ไม่ว่าง"});
            this.statusComboBox.Location = new System.Drawing.Point(132, 175);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(260, 26);
            this.statusComboBox.TabIndex = 8;
            this.statusComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.statusComboBox_KeyUp);
            // 
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 281);
            this.Controls.Add(roomnumberLabel);
            this.Controls.Add(this.roomnumberTextBox);
            this.Controls.Add(roomratesLabel);
            this.Controls.Add(this.roomratesTextBox);
            this.Controls.Add(roomdetailsLabel);
            this.Controls.Add(this.roomdetailsTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.tb_roomsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการข้อมูลห้อง";
            this.Load += new System.EventHandler(this.frmRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_roomsBindingNavigator)).EndInit();
            this.tb_roomsBindingNavigator.ResumeLayout(false);
            this.tb_roomsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsMainMenu dsMainMenu;
        private System.Windows.Forms.BindingSource tb_roomsBindingSource;
        private dsMainMenuTableAdapters.tb_roomsTableAdapter tb_roomsTableAdapter;
        private dsMainMenuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_roomsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_roomsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox roomnumberTextBox;
        private System.Windows.Forms.TextBox roomratesTextBox;
        private System.Windows.Forms.TextBox roomdetailsTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}