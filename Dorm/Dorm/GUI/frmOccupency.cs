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
    public partial class frmOccupency : Form
    {
        public frmOccupency()
        {
            InitializeComponent();
        }

        private void tb_occupenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (isdel == false)
            {
                if (namelastTextBox.Text.Length < 1 || ageTextBox.Text.Length < 1 || occupationTextBox.Text.Length < 1 ||
                    personalidTextBox.Text.Length < 1 || addressTextBox.Text.Length < 1 || districtTextBox.Text.Length < 1 || provinceComboBox.Text.Length < 1 ||
                    postcodeTextBox.Text.Length < 1)
                {
                    MessageBox.Show(this, "ข้อมูลยังไม่ครบ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                this.Validate();
                this.tb_occupenciesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsOccu);
                MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Validate();
                this.tb_occupenciesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsOccu);
                MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isdel = false;
                this.Close();
            }

        }

        private void frmOccupency_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsOccu.tb_occupencies' table. You can move, or remove it, as needed.
            this.tb_occupenciesTableAdapter.Fill(this.dsOccu.tb_occupencies);

        }

        private void postcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void personalidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ocidTextBox.Text = new Dorm.Util.SQL().GetNewOccuId().ToString();
        }
        bool isdel = false;
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, string.Format("เพิ่มผู้เช่าในรายการลบแล้ว คลิกที่ปุ่ม 'บันทึก' เพื่อลบข้อมูล", namelastTextBox.Text ), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isdel = true;
        }

        private void provinceComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            provinceComboBox.Text = "";
        }
    }
}
