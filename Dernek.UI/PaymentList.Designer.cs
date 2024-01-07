namespace Dernek.UI
{
    partial class PaymentList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbPayments = new System.Windows.Forms.RadioButton();
            this.rbDebtors = new System.Windows.Forms.RadioButton();
            this.rbPayingUser = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 676);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(83, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(267, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbPayments
            // 
            this.rbPayments.AutoSize = true;
            this.rbPayments.Location = new System.Drawing.Point(16, 98);
            this.rbPayments.Name = "rbPayments";
            this.rbPayments.Size = new System.Drawing.Size(95, 17);
            this.rbPayments.TabIndex = 6;
            this.rbPayments.TabStop = true;
            this.rbPayments.Text = "Payments Only";
            this.rbPayments.UseVisualStyleBackColor = true;
            // 
            // rbDebtors
            // 
            this.rbDebtors.AutoSize = true;
            this.rbDebtors.Location = new System.Drawing.Point(16, 121);
            this.rbDebtors.Name = "rbDebtors";
            this.rbDebtors.Size = new System.Drawing.Size(121, 17);
            this.rbDebtors.TabIndex = 7;
            this.rbDebtors.TabStop = true;
            this.rbDebtors.Text = "Not Paying User List";
            this.rbDebtors.UseVisualStyleBackColor = true;
            // 
            // rbPayingUser
            // 
            this.rbPayingUser.AutoSize = true;
            this.rbPayingUser.Location = new System.Drawing.Point(16, 144);
            this.rbPayingUser.Name = "rbPayingUser";
            this.rbPayingUser.Size = new System.Drawing.Size(101, 17);
            this.rbPayingUser.TabIndex = 8;
            this.rbPayingUser.TabStop = true;
            this.rbPayingUser.Text = "Paying User List";
            this.rbPayingUser.UseVisualStyleBackColor = true;
            // 
            // PaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 901);
            this.Controls.Add(this.rbPayingUser);
            this.Controls.Add(this.rbDebtors);
            this.Controls.Add(this.rbPayments);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaymentList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaymentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbPayments;
        private System.Windows.Forms.RadioButton rbDebtors;
        private System.Windows.Forms.RadioButton rbPayingUser;
    }
}