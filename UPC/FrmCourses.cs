using BusinessLogic.CareerService;
using BusinessLogic.CourseService;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPC
{
    public partial class FrmCourses : Form
    {
        private ICareerService CareerService = new CareerService();
        private ICourseService CourseService = new CourseService();
        public FrmCourses()
        {
            InitializeComponent();
        }

        private void FrmCourses_Load(object sender, EventArgs e)
        {

            try
            {
                this.CareerService = new CareerService();
                cbCareer.DataSource = this.CareerService.GetAllCareers();
                cbCareer.SelectedIndex = 0;
                UpdateCourseList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

            
        }

        private void cbCareer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.CourseService = new CourseService();
            try
            {
                Course newCourse = new Course();
                newCourse.Name = this.txtName.Text;
                newCourse.Area = this.txtArea.Text;
                newCourse.Credits = Convert.ToInt32(this.txtCredits.Text);
                newCourse.CareerId = Convert.ToInt32(this.cbCareer.SelectedValue);


                CourseService.InsertCourse(newCourse);
                UpdateCourseList();
                
                MessageBox.Show("Course saved correctly!", "Success");
                    //studentService.InsertStudent(newStudent);
                    //UpdateStudentList();
                    //MessageBox.Show("Student saved correctly!", "Success");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred. Please try later.", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.CourseService = new CourseService();
            Course newCourse = new Course();
            newCourse.Id = Convert.ToInt32(this.txtId.Text);
            CourseService.DeleteCourse(newCourse);
            //UpdateStudentList();
            UpdateCourseList();
            MessageBox.Show("Course deleted correctly!", "Success");
        }

        private void UpdateCourseList()
        {
            dgvCourse.DataSource = CourseService.GetAllCourse();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.CourseService = new CourseService();

            Course newCourse = new Course();
            newCourse.Id = Convert.ToInt32(this.txtId.Text);
            newCourse.Name = this.txtName.Text;
            newCourse.Area = this.txtArea.Text;
            newCourse.Credits = Convert.ToInt32(this.txtCredits.Text);
            newCourse.CareerId = Convert.ToInt32(this.cbCareer.SelectedValue);
            CourseService.UpdateCourse(newCourse);
            UpdateCourseList();
            MessageBox.Show("Course updated correctly!", "Success");
        }

        private void dgvCourse_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                int courseId = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["ColumnId"].Value);
                Course objCourse = this.CourseService.GetCourse(courseId);
                this.txtId.Text = objCourse.Id.ToString();
                this.txtName.Text = objCourse.Name;
                this.txtArea.Text = objCourse.Area;
                this.txtCredits.Text = objCourse.Credits.ToString();
                this.cbCareer.SelectedValue = objCourse.CareerId;
                
            }
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

    }
}
