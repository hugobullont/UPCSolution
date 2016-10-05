using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.StudentService;
using Entities;

namespace UPC
{
    public partial class FrmStudents : Form
    {
        private IStudentService studentService = new StudentService();
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (ValidateFields())
                {
                    
                    Student newStudent = new Student();
                    newStudent.Age = Convert.ToInt32(this.txtAge.Text);
                    newStudent.Code = this.txtCode.Text;
                    newStudent.GradeAverage = Convert.ToDecimal(this.txtGradeAverage.Text);
                    newStudent.Name = this.txtName.Text;

                    studentService.InsertStudent(newStudent);
                    UpdateStudentList();
                    MessageBox.Show("Student saved correctly!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred. Please try later.", "Error");
            }

            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            Student newStudent = new Student();
            newStudent.Id = Convert.ToInt32(this.txtId.Text);
            

            studentService.DeleteStudent(newStudent);
            UpdateStudentList();
            MessageBox.Show("Student deleted correctly!", "Success");
            
        }

        public bool ValidateFields()
        {
            bool result = true;
            string msg1 = "";
            string msg2 = "";
            string msg3 = "";
            string msg4 = "";
            //validate age
            int age;
            if(!int.TryParse(this.txtAge.Text,out age))
            {
                result = false;
                msg1="\nEnter a Valid Age";
            }

            decimal grade;
            if(!decimal.TryParse(this.txtGradeAverage.Text,out grade))
            {
                result = false;
                msg2="\nEnter a Valid Grade Average";
            }

            
            if (this.txtName.Text.Length==0)
            {
                result = false;
                msg3 = "\nEnter a Valid Name";
            }

            if (this.txtCode.Text.Length == 0)
            {
                result = false;
                msg4 = "\nEnter a Valid Code";
            }

            if (result == false)
            {
                MessageBox.Show(msg1 + msg2 + msg3 + msg4, "Error!!");
            }
            
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            try
            {
                if(ValidateFields())
                {
                    
                    Student newStudent = new Student();
                    newStudent.Id = Convert.ToInt32(this.txtId.Text);
                    newStudent.Age = Convert.ToInt32(this.txtAge.Text);
                    newStudent.Code = this.txtCode.Text;
                    newStudent.GradeAverage = Convert.ToDecimal(this.txtGradeAverage.Text);
                    newStudent.Name = this.txtName.Text;

                    studentService.UpdateStudent(newStudent);
                    UpdateStudentList();

                    MessageBox.Show("Student updated correctly!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred. Please try later.", "Error");
            }

            
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            UpdateStudentList();
        }

        private void UpdateStudentList()
        {
            dgvStudents.DataSource = studentService.GetAllStudent();
        }

        private void gbStudentInformation_Enter(object sender, EventArgs e)
        {

        }

        private void gbOptions_Enter(object sender, EventArgs e)
        {

        }

       

        

        
    }
}
