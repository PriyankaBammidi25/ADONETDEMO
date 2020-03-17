namespace ADONETDEMO
{
    partial class ConnectionLessEx1
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
            this.txtDeptno = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cpbBox = new System.Windows.Forms.ComboBox();
            this.btnbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EnterDeptno";
            // 
            // txtDeptno
            // 
            this.txtDeptno.Location = new System.Drawing.Point(617, 71);
            this.txtDeptno.Name = "txtDeptno";
            this.txtDeptno.Size = new System.Drawing.Size(100, 20);
            this.txtDeptno.TabIndex = 1;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(475, 67);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(122, 196);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(508, 148);
            this.dgvData.TabIndex = 3;
            // 
            // cpbBox
            // 
            this.cpbBox.FormattingEnabled = true;
            this.cpbBox.Location = new System.Drawing.Point(236, 71);
            this.cpbBox.Name = "cpbBox";
            this.cpbBox.Size = new System.Drawing.Size(121, 21);
            this.cpbBox.TabIndex = 4;
            this.cpbBox.SelectedIndexChanged += new System.EventHandler(this.cpbBox_SelectedIndexChanged);
            // 
            // btnbutton1
            // 
            this.btnbutton1.Location = new System.Drawing.Point(475, 140);
            this.btnbutton1.Name = "btnbutton1";
            this.btnbutton1.Size = new System.Drawing.Size(75, 23);
            this.btnbutton1.TabIndex = 5;
            this.btnbutton1.Text = "Button";
            this.btnbutton1.UseVisualStyleBackColor = true;
            this.btnbutton1.Click += new System.EventHandler(this.btnbutton1_Click);
            // 
            // ConnectionLessEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbutton1);
            this.Controls.Add(this.cpbBox);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.txtDeptno);
            this.Controls.Add(this.label1);
            this.Name = "ConnectionLessEx1";
            this.Text = "ConnectionLessEx1";
            this.Load += new System.EventHandler(this.ConnectionLessEx1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptno;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cpbBox;
        private System.Windows.Forms.Button btnbutton1;
    }
}