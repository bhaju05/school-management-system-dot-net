
namespace School_Management_System.UI.Subject
{
    partial class FrmSubjectMaster
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSubExit = new System.Windows.Forms.Button();
            this.btnSubCancel = new System.Windows.Forms.Button();
            this.btnSubSave = new System.Windows.Forms.Button();
            this.btnSubEdit = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.btnSubDelete = new System.Windows.Forms.Button();
            this.btnSubRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.lableName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubExit);
            this.groupBox3.Controls.Add(this.btnSubCancel);
            this.groupBox3.Controls.Add(this.btnSubSave);
            this.groupBox3.Controls.Add(this.btnSubEdit);
            this.groupBox3.Controls.Add(this.btnSubAdd);
            this.groupBox3.Controls.Add(this.btnSubDelete);
            this.groupBox3.Controls.Add(this.btnSubRefresh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 101);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // btnSubExit
            // 
            this.btnSubExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubExit.Location = new System.Drawing.Point(690, 27);
            this.btnSubExit.Name = "btnSubExit";
            this.btnSubExit.Size = new System.Drawing.Size(75, 52);
            this.btnSubExit.TabIndex = 6;
            this.btnSubExit.Text = "Exit";
            this.btnSubExit.UseVisualStyleBackColor = false;
            this.btnSubExit.Click += new System.EventHandler(this.btnSubExit_Click);
            // 
            // btnSubCancel
            // 
            this.btnSubCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubCancel.Location = new System.Drawing.Point(607, 27);
            this.btnSubCancel.Name = "btnSubCancel";
            this.btnSubCancel.Size = new System.Drawing.Size(75, 52);
            this.btnSubCancel.TabIndex = 5;
            this.btnSubCancel.Text = "Cancel";
            this.btnSubCancel.UseVisualStyleBackColor = false;
            this.btnSubCancel.Click += new System.EventHandler(this.btnSubCancel_Click);
            // 
            // btnSubSave
            // 
            this.btnSubSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubSave.Location = new System.Drawing.Point(524, 27);
            this.btnSubSave.Name = "btnSubSave";
            this.btnSubSave.Size = new System.Drawing.Size(75, 52);
            this.btnSubSave.TabIndex = 4;
            this.btnSubSave.Text = "Save";
            this.btnSubSave.UseVisualStyleBackColor = false;
            this.btnSubSave.Click += new System.EventHandler(this.btnSubSave_Click);
            // 
            // btnSubEdit
            // 
            this.btnSubEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubEdit.Location = new System.Drawing.Point(441, 27);
            this.btnSubEdit.Name = "btnSubEdit";
            this.btnSubEdit.Size = new System.Drawing.Size(75, 52);
            this.btnSubEdit.TabIndex = 3;
            this.btnSubEdit.Text = "Edit";
            this.btnSubEdit.UseVisualStyleBackColor = false;
            this.btnSubEdit.Click += new System.EventHandler(this.btnSubEdit_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubAdd.Location = new System.Drawing.Point(358, 27);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(75, 52);
            this.btnSubAdd.TabIndex = 2;
            this.btnSubAdd.Text = "Add";
            this.btnSubAdd.UseVisualStyleBackColor = false;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // btnSubDelete
            // 
            this.btnSubDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubDelete.Location = new System.Drawing.Point(275, 27);
            this.btnSubDelete.Name = "btnSubDelete";
            this.btnSubDelete.Size = new System.Drawing.Size(75, 52);
            this.btnSubDelete.TabIndex = 1;
            this.btnSubDelete.Text = "Delete";
            this.btnSubDelete.UseVisualStyleBackColor = false;
            this.btnSubDelete.Click += new System.EventHandler(this.btnSubDelete_Click);
            // 
            // btnSubRefresh
            // 
            this.btnSubRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubRefresh.Location = new System.Drawing.Point(192, 27);
            this.btnSubRefresh.Name = "btnSubRefresh";
            this.btnSubRefresh.Size = new System.Drawing.Size(75, 52);
            this.btnSubRefresh.TabIndex = 0;
            this.btnSubRefresh.Text = "Refresh";
            this.btnSubRefresh.UseVisualStyleBackColor = false;
            this.btnSubRefresh.Click += new System.EventHandler(this.btnSubRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGroup);
            this.groupBox2.Controls.Add(this.txtOrder);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.labelGroup);
            this.groupBox2.Controls.Add(this.labelOrder);
            this.groupBox2.Controls.Add(this.lableName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(481, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 324);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 29);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number";
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(86, 92);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(215, 29);
            this.txtGroup.TabIndex = 5;
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrder.Location = new System.Drawing.Point(86, 178);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(215, 29);
            this.txtOrder.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(86, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 29);
            this.txtName.TabIndex = 3;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(22, 95);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 17);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Index";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(22, 181);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(43, 17);
            this.labelOrder.TabIndex = 1;
            this.labelOrder.Text = "Order";
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableName.Location = new System.Drawing.Point(22, 53);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(44, 17);
            this.lableName.TabIndex = 0;
            this.lableName.Text = "Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSubject);
            this.groupBox1.Location = new System.Drawing.Point(4, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgvSubject
            // 
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubject.Location = new System.Drawing.Point(3, 16);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.Size = new System.Drawing.Size(458, 304);
            this.dgvSubject.TabIndex = 1;
            // 
            // FrmSubjectMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSubjectMaster";
            this.Text = "FrmSubjectMaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSubjectMaster_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubExit;
        private System.Windows.Forms.Button btnSubCancel;
        private System.Windows.Forms.Button btnSubSave;
        private System.Windows.Forms.Button btnSubEdit;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.Button btnSubDelete;
        private System.Windows.Forms.Button btnSubRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}