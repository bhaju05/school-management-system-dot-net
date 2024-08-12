using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.GradeSubject
{
    public partial class FrmGradeSubjectMaster : Form
    {
        public FrmGradeSubjectMaster()
        {
            InitializeComponent();
        }

        private void FrmGradeSubjectMaster_Load(object sender, EventArgs e)
        {
            DataTable dt = DAL.GradeSubjectDal.GetAll();
            dgvGradeSubject.DataSource = dt;

            DataTable dtGrade = DAL.GradeDal.GetAll();
            cmboxGrade.DataSource = dtGrade;
            cmboxGrade.DisplayMember = "grade_name";
            cmboxGrade.ValueMember = "id";

            DataTable dtSubject = DAL.SubjectDal.GetAll();
            cmboxSubject.DataSource = dtSubject;
            cmboxSubject.DisplayMember = "subject_name";
            cmboxSubject.ValueMember = "id";
        }

        private void FrmGradeSubjectMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
