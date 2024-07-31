
namespace School_Management_System.UI.Student
{
    partial class FrmStudentMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStuExit = new System.Windows.Forms.Button();
            this.btnStuEdit = new System.Windows.Forms.Button();
            this.btnStuAdd = new System.Windows.Forms.Button();
            this.btnStuDelete = new System.Windows.Forms.Button();
            this.btnStuRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStudent);
            this.groupBox1.Location = new System.Drawing.Point(4, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 323);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(3, 16);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(790, 304);
            this.dgvStudent.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStuExit);
            this.groupBox3.Controls.Add(this.btnStuEdit);
            this.groupBox3.Controls.Add(this.btnStuAdd);
            this.groupBox3.Controls.Add(this.btnStuDelete);
            this.groupBox3.Controls.Add(this.btnStuRefresh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 101);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnStuExit
            // 
            this.btnStuExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStuExit.Location = new System.Drawing.Point(689, 27);
            this.btnStuExit.Name = "btnStuExit";
            this.btnStuExit.Size = new System.Drawing.Size(75, 52);
            this.btnStuExit.TabIndex = 6;
            this.btnStuExit.Text = "Exit";
            this.btnStuExit.UseVisualStyleBackColor = false;
            this.btnStuExit.Click += new System.EventHandler(this.btnStuExit_Click);
            // 
            // btnStuEdit
            // 
            this.btnStuEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStuEdit.Location = new System.Drawing.Point(606, 27);
            this.btnStuEdit.Name = "btnStuEdit";
            this.btnStuEdit.Size = new System.Drawing.Size(75, 52);
            this.btnStuEdit.TabIndex = 3;
            this.btnStuEdit.Text = "Edit";
            this.btnStuEdit.UseVisualStyleBackColor = false;
            this.btnStuEdit.Click += new System.EventHandler(this.btnStuEdit_Click);
            // 
            // btnStuAdd
            // 
            this.btnStuAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStuAdd.Location = new System.Drawing.Point(523, 27);
            this.btnStuAdd.Name = "btnStuAdd";
            this.btnStuAdd.Size = new System.Drawing.Size(75, 52);
            this.btnStuAdd.TabIndex = 2;
            this.btnStuAdd.Text = "Add";
            this.btnStuAdd.UseVisualStyleBackColor = false;
            this.btnStuAdd.Click += new System.EventHandler(this.btnStuAdd_Click);
            // 
            // btnStuDelete
            // 
            this.btnStuDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStuDelete.Location = new System.Drawing.Point(440, 27);
            this.btnStuDelete.Name = "btnStuDelete";
            this.btnStuDelete.Size = new System.Drawing.Size(75, 52);
            this.btnStuDelete.TabIndex = 1;
            this.btnStuDelete.Text = "Delete";
            this.btnStuDelete.UseVisualStyleBackColor = false;
            this.btnStuDelete.Click += new System.EventHandler(this.btnStuDelete_Click);
            // 
            // btnStuRefresh
            // 
            this.btnStuRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStuRefresh.Location = new System.Drawing.Point(357, 27);
            this.btnStuRefresh.Name = "btnStuRefresh";
            this.btnStuRefresh.Size = new System.Drawing.Size(75, 52);
            this.btnStuRefresh.TabIndex = 0;
            this.btnStuRefresh.Text = "Refresh";
            this.btnStuRefresh.UseVisualStyleBackColor = false;
            this.btnStuRefresh.Click += new System.EventHandler(this.btnStuRefresh_Click);
            // 
            // FrmStudentMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudentMaster";
            this.ShowIcon = false;
            this.Text = "FrmStudentMaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStudentMaster_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStuExit;
        private System.Windows.Forms.Button btnStuEdit;
        private System.Windows.Forms.Button btnStuAdd;
        private System.Windows.Forms.Button btnStuDelete;
        private System.Windows.Forms.Button btnStuRefresh;
    }
}