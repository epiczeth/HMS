using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dorm.Util;

namespace Dorm.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sql.IsExistingUser(textBox1.Text, textBox2.Text))
            {
                new frmMainMenu().Show();
                this.Hide();
            }
            else
            {
                textBox2.Clear();
                textBox2.Focus();
                MessageBox.Show(this,"ชื่อผู้ใช้หรือรหัสผ่านผิด","ล้มเหลว",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
