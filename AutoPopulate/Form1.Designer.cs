namespace AutoPopulate
{
    partial class Form1
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
            this.txtConString = new System.Windows.Forms.TextBox();
            this.lblConString = new System.Windows.Forms.Label();
            this.sbmtConnect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTblName = new System.Windows.Forms.TextBox();
            this.lblTbleName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConString
            // 
            this.txtConString.Location = new System.Drawing.Point(189, 27);
            this.txtConString.Name = "txtConString";
            this.txtConString.Size = new System.Drawing.Size(301, 20);
            this.txtConString.TabIndex = 0;
            // 
            // lblConString
            // 
            this.lblConString.AutoSize = true;
            this.lblConString.Location = new System.Drawing.Point(89, 30);
            this.lblConString.Name = "lblConString";
            this.lblConString.Size = new System.Drawing.Size(94, 13);
            this.lblConString.TabIndex = 1;
            this.lblConString.Text = "ConnectionString :";
            // 
            // sbmtConnect
            // 
            this.sbmtConnect.Location = new System.Drawing.Point(257, 79);
            this.sbmtConnect.Name = "sbmtConnect";
            this.sbmtConnect.Size = new System.Drawing.Size(75, 23);
            this.sbmtConnect.TabIndex = 2;
            this.sbmtConnect.Text = "Connect";
            this.sbmtConnect.UseVisualStyleBackColor = true;
            this.sbmtConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 220);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(503, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTblName
            // 
            this.txtTblName.Location = new System.Drawing.Point(189, 53);
            this.txtTblName.Name = "txtTblName";
            this.txtTblName.Size = new System.Drawing.Size(163, 20);
            this.txtTblName.TabIndex = 6;
            // 
            // lblTbleName
            // 
            this.lblTbleName.AutoSize = true;
            this.lblTbleName.Location = new System.Drawing.Point(109, 56);
            this.lblTbleName.Name = "lblTbleName";
            this.lblTbleName.Size = new System.Drawing.Size(74, 13);
            this.lblTbleName.TabIndex = 7;
            this.lblTbleName.Text = "Table Name : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 373);
            this.Controls.Add(this.lblTbleName);
            this.Controls.Add(this.txtTblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sbmtConnect);
            this.Controls.Add(this.lblConString);
            this.Controls.Add(this.txtConString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConString;
        private System.Windows.Forms.Label lblConString;
        private System.Windows.Forms.Button sbmtConnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTblName;
        private System.Windows.Forms.Label lblTbleName;
    }
}

