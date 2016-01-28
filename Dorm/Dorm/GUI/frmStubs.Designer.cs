﻿namespace Dorm.GUI
{
    partial class frmStubs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStubs));
            System.Windows.Forms.Label stidLabel;
            System.Windows.Forms.Label stnameLabel;
            this.dsStubs = new Dorm.dsStubs();
            this.tb_stubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_stubsTableAdapter = new Dorm.dsStubsTableAdapters.tb_stubsTableAdapter();
            this.tableAdapterManager = new Dorm.dsStubsTableAdapters.TableAdapterManager();
            this.tb_stubsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_stubsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stidTextBox = new System.Windows.Forms.TextBox();
            this.stnameTextBox = new System.Windows.Forms.TextBox();
            stidLabel = new System.Windows.Forms.Label();
            stnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsStubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_stubsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_stubsBindingNavigator)).BeginInit();
            this.tb_stubsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsStubs
            // 
            this.dsStubs.DataSetName = "dsStubs";
            this.dsStubs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_stubsBindingSource
            // 
            this.tb_stubsBindingSource.DataMember = "tb_stubs";
            this.tb_stubsBindingSource.DataSource = this.dsStubs;
            // 
            // tb_stubsTableAdapter
            // 
            this.tb_stubsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_stubsTableAdapter = this.tb_stubsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Dorm.dsStubsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_stubsBindingNavigator
            // 
            this.tb_stubsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_stubsBindingNavigator.BindingSource = this.tb_stubsBindingSource;
            this.tb_stubsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_stubsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_stubsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_stubsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tb_stubsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_stubsBindingNavigatorSaveItem});
            this.tb_stubsBindingNavigator.Location = new System.Drawing.Point(0, 176);
            this.tb_stubsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_stubsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_stubsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_stubsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_stubsBindingNavigator.Name = "tb_stubsBindingNavigator";
            this.tb_stubsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tb_stubsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_stubsBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.tb_stubsBindingNavigator.TabIndex = 0;
            this.tb_stubsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorDeleteItem.Text = "ลบ";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tb_stubsBindingNavigatorSaveItem
            // 
            this.tb_stubsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_stubsBindingNavigatorSaveItem.Image")));
            this.tb_stubsBindingNavigatorSaveItem.Name = "tb_stubsBindingNavigatorSaveItem";
            this.tb_stubsBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 22);
            this.tb_stubsBindingNavigatorSaveItem.Text = "บันทึก";
            this.tb_stubsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_stubsBindingNavigatorSaveItem_Click);
            // 
            // stidLabel
            // 
            stidLabel.AutoSize = true;
            stidLabel.Location = new System.Drawing.Point(18, 17);
            stidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stidLabel.Name = "stidLabel";
            stidLabel.Size = new System.Drawing.Size(68, 18);
            stidLabel.TabIndex = 1;
            stidLabel.Text = "รหัสสิ่งของ";
            // 
            // stidTextBox
            // 
            this.stidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_stubsBindingSource, "stid", true));
            this.stidTextBox.Enabled = false;
            this.stidTextBox.Location = new System.Drawing.Point(93, 13);
            this.stidTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stidTextBox.Name = "stidTextBox";
            this.stidTextBox.Size = new System.Drawing.Size(264, 24);
            this.stidTextBox.TabIndex = 2;
            this.stidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stnameLabel
            // 
            stnameLabel.AutoSize = true;
            stnameLabel.Location = new System.Drawing.Point(18, 53);
            stnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stnameLabel.Name = "stnameLabel";
            stnameLabel.Size = new System.Drawing.Size(71, 18);
            stnameLabel.TabIndex = 3;
            stnameLabel.Text = "รายละเอียด";
            // 
            // stnameTextBox
            // 
            this.stnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_stubsBindingSource, "stname", true));
            this.stnameTextBox.Location = new System.Drawing.Point(93, 49);
            this.stnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stnameTextBox.Multiline = true;
            this.stnameTextBox.Name = "stnameTextBox";
            this.stnameTextBox.Size = new System.Drawing.Size(264, 105);
            this.stnameTextBox.TabIndex = 4;
            // 
            // frmStubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 201);
            this.Controls.Add(stidLabel);
            this.Controls.Add(this.stidTextBox);
            this.Controls.Add(stnameLabel);
            this.Controls.Add(this.stnameTextBox);
            this.Controls.Add(this.tb_stubsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStubs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการข้อมูลสิ่งของ";
            this.Load += new System.EventHandler(this.frmStubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsStubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_stubsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_stubsBindingNavigator)).EndInit();
            this.tb_stubsBindingNavigator.ResumeLayout(false);
            this.tb_stubsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsStubs dsStubs;
        private System.Windows.Forms.BindingSource tb_stubsBindingSource;
        private dsStubsTableAdapters.tb_stubsTableAdapter tb_stubsTableAdapter;
        private dsStubsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_stubsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_stubsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stidTextBox;
        private System.Windows.Forms.TextBox stnameTextBox;
    }
}