using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.Student
{
    public partial class FrmStudentMaster : Form
    {
        public FrmStudentMaster()
        {
            InitializeComponent();
        }

        private void btnStuAdd_Click(object sender, EventArgs e)
        {
            FrmStudentCreate f = new FrmStudentCreate();
            f.ShowDialog();
        }

        private void btnStuEdit_Click(object sender, EventArgs e)
        {
            FrmStudentEdit f = new FrmStudentEdit();
            f.ShowDialog();
        }

        private void btnStuDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //delete function
            }
        }

        private void btnStuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudentMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnStuRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = DAL.SubjectDal.GetAll();

            dgvStudent.DataSource = dt;
        }
    }
}
