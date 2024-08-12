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
                DAL.SubjectDal.insert(txtNameSub.Text.Trim(), txtIndexSub.Text.Trim(), txtNumberSub.Text.Trim(), txtOrderSub.Text.Trim());
                MessageBox.Show("Save Sucessfully....!");
                DataTable dt = DAL.SubjectDal.GetAll();
                dgvSubject.DataSource = dt;
                txtNameSub.Text = null;
                txtIndexSub.Text = null;
                txtNumberSub.Text = null;
                txtOrderSub.Text = null;
            }
            else
            {
                //int selectedId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["Id"].Value);
                //DAL.SubjectDal.update(selectedId, txtNameSub.Text.Trim(), txtIndexSub.Text.Trim(), txtNumberSub.Text.Trim(), txtOrderSub.Text.Trim());
                //MessageBox.Show("Update Successfully....!");

                //DataTable dt = DAL.SubjectDal.GetAll();
                //dgvSubject.DataSource = dt;

                //txtNameSub.Text = null;
                //txtIndexSub.Text = null;
                //txtNumberSub.Text = null;
                //txtOrderSub.Text = null;
                ////update function
                //ButtonEnable(false);
            }
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
         
            
                if (dgvSubject.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int selectedId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["Id"].Value);
                        DAL.SubjectDal.delete(selectedId);
                        MessageBox.Show("Deleted Successfully....!");
                        DataTable dt = DAL.SubjectDal.GetAll();
                        dgvSubject.DataSource = dt;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.","Alert Message!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                //delete function
            
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

        private void FrmSubjectMaster_Load(object sender, EventArgs e)
        {
            DataTable dt = DAL.SubjectDal.GetAll();
            dgvSubject.DataSource = dt;
        }
    }
}
