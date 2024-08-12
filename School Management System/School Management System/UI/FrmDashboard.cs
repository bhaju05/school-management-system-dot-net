using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Student.FrmStudentMaster f = new Student.FrmStudentMaster();
            f.MdiParent = this;
            f.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Subject.FrmSubjectMaster f = new Subject.FrmSubjectMaster();
            f.MdiParent = this; // show form within dashboard form , avoid to go back side of dashboard form
            f.Show();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Grade.FrmGradeMaster f = new Grade.FrmGradeMaster();
            f.MdiParent = this;
            f.Show();
        }

        private void FrmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
