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
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            string Query = "select * from DepartmentTable1";
            DepartmentsList.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Department_Name_Table.Text == "" || Details_Table.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string DName = Department_Name_Table.Text;
                    string Details = Details_Table.Text;
                    string Query = "insert into DepartmentTable1 values('{0}','{1}')";
                    Query = string.Format(Query, DName, Details);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void DepartmentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Department_Name_Table.Text = DepartmentsList.SelectedRows[0].Cells[1].Value.ToString();
            Details_Table.Text = DepartmentsList.SelectedRows[0].Cells[2].Value.ToString();
            if (Department_Name_Table.Text == "")
            {
                Key = 0;
            }
            else
            {
                // Here, we are assigning the value of the Department ID (Cells[0]) to the Key variable
                Key = Convert.ToInt32(DepartmentsList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            if (Department_Name_Table.Text == "" || Details_Table.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string DName = Department_Name_Table.Text;
                    string Details = Details_Table.Text;
                    string Query = "Update DepartmentTable1 set Department_Name = '{0}', Department_Details = '{1}' where Department_ID = {2} ";
                    Query = string.Format(Query, DName, Details, Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Clear()
        {
            Department_Name_Table.Text = "";
            Details_Table.Text = "";
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Department!!");
            }
            else
            {
                try
                {
                    string DName = Department_Name_Table.Text;
                    string Details = Details_Table.Text;
                    string Query = "Delete DepartmentTable1 where Department_ID = {0} ";
                    Query = string.Format(Query , Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login1 Obj = new Login1();
            Obj.Show();
            this.Close();
        }

        private void StudentLabel1_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Close();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Details_Table_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





