﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.Grade
{
    public partial class FrmGradeMaster : Form
    {
        
        Boolean is_addNew = false;
        public FrmGradeMaster()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
        }

        private void ButtonEnable(bool is_True)
        {
            is_addNew = is_True;
            btnAdd.Enabled = !is_True;
            btnDelete.Enabled = !is_True;
            btnEdit.Enabled = !is_True;
            btnExit.Enabled = !is_True;
            btnRefresh.Enabled = !is_True;
            btnCancel.Enabled = is_True;
            btnSave.Enabled = is_True;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonEnable(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_addNew)
            {
                DAL.GradeDal.insert(txtName.Text.Trim(), txtGroup.Text.Trim(), txtOrder.Text.Trim());
                MessageBox.Show("Save Sucessfully....!");
                DataTable dt = DAL.GradeDal.GetAll();
                dgvGrade.DataSource = dt;
                txtName.Text = null;
                txtGroup.Text = null;
                txtOrder.Text = null;
            }
            else
            {
                //update function
            }
            ButtonEnable(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          //  DialogResult dr = MessageBox.Show("Do you want close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          //  if (dr == DialogResult.Yes)
           // {
                this.Close();
           // }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DAL.GradeDal.delete(10);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           DataTable dt = DAL.GradeDal.GetAll();
       
            dgvGrade.DataSource = dt;
        }

        private void FrmGradeMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }

        private void FrmGradeMaster_Load(object sender, EventArgs e)
        {
            DataTable dt = DAL.GradeDal.GetAll();
            dgvGrade.DataSource = dt;
        }
    }
}
