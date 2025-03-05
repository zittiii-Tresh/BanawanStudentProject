using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BanawanStudentProject.Models;

namespace BanawanStudentProject
{
    public partial class StudentForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Models.Student> studentList = new List<Models.Student>();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            Models.Student student = new Models.Student();
            student.StudentID = int.Parse(idTE.Text);
            student.StudentName = nameTE.Text;
            student.StudentAge = int.Parse(ageTE.Text);
            student.StudentBirthday = Convert.ToDateTime(bdayDE.EditValue);
            student.StudentYearSection = yearsectionTE.Text;

            studentList.Add(student);
            gcStudent.DataSource = studentList;
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(idTE.Text);

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].StudentID == studentID)
                {
                    studentList[i].StudentName = nameTE.Text;
                    studentList[i].StudentAge = int.Parse(ageTE.Text);
                    studentList[i].StudentBirthday = Convert.ToDateTime(bdayDE.EditValue);
                    studentList[i].StudentYearSection = yearsectionTE.Text;

                    gcStudent.RefreshDataSource(); 
                }
            }
        }
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(idTE.Text);

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].StudentID == studentID)
                { 
                }
            }
            
        }

        private void clearBTN_Click(object sender, EventArgs e)
         {
            idTE.Text = string.Empty;
            nameTE.Text = string.Empty;
            ageTE.Text = string.Empty;
            bdayDE.Text = string.Empty;
            yearsectionTE.Text = string.Empty;

         }
        private void gvStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idTE.Text = Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentID"));
            nameTE.Text = Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentName"));
            ageTE.Text = Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentAge"));
            bdayDE.Text = Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentBirthday"));
            yearsectionTE.Text = Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentYearSection"));
        }

       
    }
}
