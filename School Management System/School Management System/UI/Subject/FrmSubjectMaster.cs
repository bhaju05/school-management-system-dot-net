using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.Subject
{
    public partial class FrmSubjectMaster : Form
    {
        Boolean is_addNew = false;
        public FrmSubjectMaster()
        {
            InitializeComponent();
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
        }
        private void ButtonEnable(bool is_True)
        {
            is_addNew = is_True;
            btnSubAdd.Enabled = !is_True;
            btnSubDelete.Enabled = !is_True;
            btnSubEdit.Enabled = !is_True;
            btnSubExit.Enabled = !is_True;
            btnSubRefresh.Enabled = !is_True;
            btnSubCancel.Enabled = is_True;
            btnSubSave.Enabled = is_True;
        }

        private void btnSubCancel_Click(object sender, EventArgs e)
        {
            ButtonEnable(false);
        }

        private void btnSubSave_Click(object sender, EventArgs e)
        {
            if (is_addNew)
            {
                //insert function
            }
            else
            {
                //update function
            }
            ButtonEnable(false);
        }

        private void btnSubEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew = false;
        }

        private void btnSubExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //delete function
            }
        }

        private void btnSubRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = DAL.SubjectDal.GetAll();

            dgvSubject.DataSource = dt;
        }

        private void FrmSubjectMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
