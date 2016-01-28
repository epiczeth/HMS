using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dorm.GUI
{
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void tb_roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!isdel)
            {
                if (roomnumberTextBox.Text.Length < 1 || roomratesTextBox.Text.Length < 1 || roomdetailsTextBox.Text.Length < 1 || statusComboBox.Text.Length < 1)
                {
                    MessageBox.Show(this, "ข้อมูลยังไม่ครบ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                this.Validate();
                this.tb_roomsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsMainMenu);

                MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Validate();
                this.tb_roomsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsMainMenu);

                MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMainMenu.tb_rooms' table. You can move, or remove it, as needed.
            this.tb_roomsTableAdapter.Fill(this.dsMainMenu.tb_rooms);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            roomnumberTextBox.Text = new Dorm.Util.SQL().GetNewRoomNumber().ToString();
        }

        private void roomratesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        bool isdel = false;
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, string.Format("เพิ่มห้องในรายการลบแล้ว คลิกที่ปุ่ม 'บันทึก' เพื่อลบข้อมูล", roomnumberTextBox.Text), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isdel = true;
        }

        private void statusComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            statusComboBox.Text = "";
        }
    }
}
