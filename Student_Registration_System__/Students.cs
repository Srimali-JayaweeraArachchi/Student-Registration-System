using StudentRegistration;
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
    public partial class Students : Form
    {
        Functions Con;
        public Students()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStudents();
            GetDepartment();
        }
        private void ShowStudents()
        {
            string Query = "select * from StudentTable1";
            StudentsList.DataSource = Con.GetData(Query);
        }
        private void GetDepartment()
        {
            string Query = "select * from DepartmentTable1";
            Department_Combo_Box.DisplayMember = Con.GetData(Query).Columns["Department_Name"].ToString();
            Department_Combo_Box.ValueMember = Con.GetData(Query).Columns["Department_ID"].ToString();
            Department_Combo_Box.DataSource = Con.GetData(Query);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            Student_Name_Table.Text = "";
            Student_Contact_Table.Text = "";
            Email_Table.Text = "";
            Address_Table.Text = "";
            Gender_Table.SelectedIndex = -1;
        }
        private void Add_Click(object sender, EventArgs e)
        {

            if (Student_Name_Table.Text == "" || Student_Contact_Table.Text == "" || Email_Table.Text == "" || Address_Table.Text == "" || Department_Combo_Box.SelectedIndex == -1 || Gender_Table.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string TName = Student_Name_Table.Text;
                    string Gender = Gender_Table.SelectedItem.ToString();
                    string Phone = Student_Contact_Table.Text;
                    string Email = Email_Table.Text;
                    string Address = Address_Table.Text;
                    int Dep = Convert.ToInt32(Department_Combo_Box.SelectedValue);
                    string Query = "insert into StudentTable1 values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, TName, Gender, Phone, Email, Address, Dep);
                    Con.SetData(Query);
                    ShowStudents();
                    MessageBox.Show("Student Added!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

            if (Student_Name_Table.Text == "" || Student_Contact_Table.Text == "" || Email_Table.Text == "" || Address_Table.Text == "" || Department_Combo_Box.SelectedIndex == -1 || Gender_Table.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string TName = Student_Name_Table.Text;
                    string Gender = Gender_Table.SelectedItem.ToString();
                    string Phone = Student_Contact_Table.Text;
                    string Email = Email_Table.Text;
                    string Address = Address_Table.Text;
                    int Dep = Convert.ToInt32(Department_Combo_Box.SelectedValue.ToString());
                    string Query = "Update StudentTable1 set Student_Name = '{0}',Gender = '{1}',Contact_Number = '{2}',Email = '{3}',Address = '{4}',Department = {5} where Student_ID = {6}";
                    Query = string.Format(Query, TName, Gender, Phone, Email, Address, Dep, Key);
                    Con.SetData(Query);
                    ShowStudents();
                    MessageBox.Show("Student Updated!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string TName = Student_Name_Table.Text;
                    string Gender = Gender_Table.SelectedItem.ToString();
                    string Phone = Student_Contact_Table.Text;
                    string Email = Email_Table.Text;
                    string Address = Address_Table.Text;
                    int Dep = Convert.ToInt32(Department_Combo_Box.SelectedValue.ToString());
                    string Query = "Delete from StudentTable1 where Student_ID = {0}";
                    Query = string.Format(Query,Key);
                    Con.SetData(Query);
                    ShowStudents();
                    MessageBox.Show("Student Deleted!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void StudentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student_Name_Table.Text = StudentsList.SelectedRows[0].Cells[1].Value.ToString();
            Gender_Table.SelectedItem = StudentsList.SelectedRows[0].Cells[2].Value.ToString();
            Student_Contact_Table.Text = StudentsList.SelectedRows[0].Cells[3].Value.ToString();
            Email_Table.Text = StudentsList.SelectedRows[0].Cells[4].Value.ToString();
            Address_Table.Text = StudentsList.SelectedRows[0].Cells[5].Value.ToString();
            Department_Combo_Box.SelectedValue = StudentsList.SelectedRows[0].Cells[6].Value.ToString();
            if (Student_Name_Table.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            Login1 Obj = new Login1();
            Obj.Show();
            this.Close();
        }
    }
}

