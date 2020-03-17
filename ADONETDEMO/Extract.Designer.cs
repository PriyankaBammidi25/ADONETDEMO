namespace ADONETDEMO
{
    partial class Extract
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.btnButton = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnbutton1 = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(158, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Deptno";
            // 
            // txtDeptno
            // 
            this.txtDeptno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDeptno.Location = new System.Drawing.Point(351, 86);
            this.txtDeptno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeptno.Name = "txtDeptno";
            this.txtDeptno.Size = new System.Drawing.Size(148, 26);
            this.txtDeptno.TabIndex = 1;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(580, 77);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(112, 35);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "GetData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(66, 185);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(410, 128);
            this.dgvData.TabIndex = 3;
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(80, 142);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(163, 26);
            this.dtp1.TabIndex = 4;
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(311, 142);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 26);
            this.dtp2.TabIndex = 5;
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(580, 142);
            this.btnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(112, 35);
            this.btnButton.TabIndex = 6;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(66, 349);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(410, 110);
            this.dgv1.TabIndex = 7;
            // 
            // btnbutton1
            // 
            this.btnbutton1.Location = new System.Drawing.Point(727, 277);
            this.btnbutton1.Name = "btnbutton1";
            this.btnbutton1.Size = new System.Drawing.Size(75, 36);
            this.btnbutton1.TabIndex = 8;
            this.btnbutton1.Text = "button1";
            this.btnbutton1.UseVisualStyleBackColor = true;
            this.btnbutton1.Click += new System.EventHandler(this.btnbutton1_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(66, 503);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(410, 110);
            this.dgv2.TabIndex = 9;
            // 
            // Extract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnbutton1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.txtDeptno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Extract";
            this.Text = "Extract";
            this.Load += new System.EventHandler(this.Extract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptno;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnbutton1;
        private System.Windows.Forms.DataGridView dgv2;
    }
}