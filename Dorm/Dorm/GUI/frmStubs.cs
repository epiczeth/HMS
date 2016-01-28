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
    public partial class frmStubs : Form
    {
        public frmStubs()
        {
            InitializeComponent();
        }

        private void tb_stubsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!isdel)
            {
                if (stnameTextBox.Text.Length < 1)
                {
                    MessageBox.Show(this, "ข้อมูลยังไม่ครบ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                this.Validate();
                this.tb_stubsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsStubs);
                MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Validate();
                this.tb_stubsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsStubs);
                MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isdel = false;
                this.Close();
            }

        }

        private void frmStubs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsStubs.tb_stubs' table. You can move, or remove it, as needed.
            this.tb_stubsTableAdapter.Fill(this.dsStubs.tb_stubs);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            stidTextBox.Text = new Dorm.Util.SQL().GetNewSId().ToString();
        }
        bool isdel = false;
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "เพิ่มข้อมูลในรายการลบแล้ว คลิกที่ปุ่ม 'บันทึก' เพื่อลบข้อมูล", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isdel = true;
        }
    }
}
