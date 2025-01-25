using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_System__
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UserNameTable.Text == "" || PasswordTable.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else if(UserNameTable.Text == "user" && PasswordTable.Text == "aaa")
            {
                Students Obj = new Students();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name Or Password!");
                UserNameTable.Text = "";
                PasswordTable.Text = "";
            }
        }

        private void UserNameTable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
