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
        // List para pang store sa students
        private List<Models.Student> studentList = new List<Models.Student>();
        public StudentForm()
        {
            InitializeComponent();
        }
        // Loads the student list sa grid control
        private void loadBTN_Click(object sender, EventArgs e)
        {
            gcStudent.DataSource = studentList;
        }
        
        private void createBTN_Click(object sender, EventArgs e)
        {
            // declare and initialize student values nga e add
            Models.Student student = new Models.Student();
            student.StudentID = int.Parse(idTE.Text);
            student.StudentName = nameTE.Text;
            student.StudentAge = int.Parse(ageTE.Text);
            student.StudentBirthday = Convert.ToDateTime(bdayDE.EditValue);
            student.StudentYearSection = yearsectionTE.Text;
            //e add si student sa list
            studentList.Add(student); 
        }

        // Event handler for the Update button click event
        // This function updates the details of an existing student based on the StudentID
        private void updateBTN_Click(object sender, EventArgs e)
        {
            // Get Student ID from input field
            int studentID = int.Parse(idTE.Text);

            //Loop through the student list to find the student with the matching ID
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].StudentID == studentID)
                {
                    studentList[i].StudentName = nameTE.Text;
                    studentList[i].StudentAge = int.Parse(ageTE.Text);
                    studentList[i].StudentBirthday = Convert.ToDateTime(bdayDE.EditValue);
                    studentList[i].StudentYearSection = yearsectionTE.Text;
                    // Refresh the table to show the updated details
                    gcStudent.RefreshDataSource(); 
                }
            }
        }

        // This function runs when the "Delete" button is clicked
        // i-removes ang student from the list using their Student ID
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(idTE.Text); // Get Student ID from input field

            // Find the student with the matching ID and remove them from the list
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].StudentID == studentID)
                { 
                    studentList.RemoveAt(i);// Remove the student
                    gcStudent.RefreshDataSource();// Update the table
                }
            }
            
        }

        // This function runs when the "Clear" button is clicked
        // I-clear tanan input fields
        private void clearBTN_Click(object sender, EventArgs e)
         {
            idTE.Text = string.Empty;
            nameTE.Text = string.Empty;
            ageTE.Text = string.Empty;
            bdayDE.Text = string.Empty;
            yearsectionTE.Text = string.Empty;

         }

        // This function runs when a row in the table is clicked
        // i-fill ang mga input fields with the selected student's details, para pagclick sa row, mudisplay sa mga textedit ang mga values
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
