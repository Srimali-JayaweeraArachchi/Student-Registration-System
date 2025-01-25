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
    public partial class Dashboard : Form
    {
            Functions Con;
            public Dashboard()
            {
                InitializeComponent();
                Con = new Functions();
                CountMaleStudents();
                CountFeMaleStudents();
                CountDepartments();
            }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void CountMaleStudents()
        {
            String Gender = "Male";
            string Query = "select Count (*) as Male from StudentTable1 where Gender = '{0}'";
            Query = string.Format(Query, Gender);
            foreach(DataRow dr in Con.GetData(Query).Rows)
            {
                MaleStudentNumLable1.Text = dr["Male"].ToString();
            }         
        }
        private void CountFeMaleStudents()
        {
            String Gender = "FeMale"; 
            string Query = "select Count (*) as Female from StudentTable1 where Gender = '{0}'";
            Query = string.Format(Query, Gender);
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                FemaleStudentNumLable1.Text = dr["Female"].ToString();
            }
        }
        private void CountDepartments()
        {
            string Query = "select Count (*) as Department from DepartmentTable1";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DepartmentsNumLable1.Text = dr["Department"].ToString();
            }
        }
        private void StudentLabel1_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Close();
        }

        private void DepartmentLabel1_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login1 Obj = new Login1();
            Obj.Show();
            this.Close();
        }

        private void MaleStudentNumLable1_Click(object sender, EventArgs e)
        {

        }
    }
}
