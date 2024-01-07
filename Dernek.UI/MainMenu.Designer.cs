namespace Dernek.UI
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOrganizationName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrganization = new System.Windows.Forms.Button();
            this.nbFee = new System.Windows.Forms.NumericUpDown();
            this.cbPricePeriods = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewPayment = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPaymentList = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(100, 100);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(100, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1808, 1035);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.cbStatus);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbCity);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbBloodType);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ForeColor = System.Drawing.Color.OliveDrab;
            this.tabPage1.Location = new System.Drawing.Point(4, 104);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1800, 927);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Members";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1219, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(806, 14);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 33);
            this.cbStatus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Member Status :";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(443, 14);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 33);
            this.cbCity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "City :";
            // 
            // cbBloodType
            // 
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.Location = new System.Drawing.Point(157, 14);
            this.cbBloodType.Name = "cbBloodType";
            this.cbBloodType.Size = new System.Drawing.Size(121, 33);
            this.cbBloodType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Type : ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1406, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(23, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1285, 854);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPaymentList);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnNewPayment);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tabPage2.Location = new System.Drawing.Point(4, 104);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1800, 927);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finance";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbOrganizationName);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnOrganization);
            this.panel1.Controls.Add(this.nbFee);
            this.panel1.Controls.Add(this.cbPricePeriods);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(26, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 714);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Organization Name : ";
            // 
            // tbOrganizationName
            // 
            this.tbOrganizationName.Location = new System.Drawing.Point(215, 47);
            this.tbOrganizationName.Name = "tbOrganizationName";
            this.tbOrganizationName.Size = new System.Drawing.Size(362, 30);
            this.tbOrganizationName.TabIndex = 10;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(215, 267);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(362, 155);
            this.tbDescription.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Organization Fee :";
            // 
            // btnOrganization
            // 
            this.btnOrganization.Location = new System.Drawing.Point(183, 531);
            this.btnOrganization.Name = "btnOrganization";
            this.btnOrganization.Size = new System.Drawing.Size(228, 42);
            this.btnOrganization.TabIndex = 7;
            this.btnOrganization.Text = "Update Organization";
            this.btnOrganization.UseVisualStyleBackColor = true;
            this.btnOrganization.Click += new System.EventHandler(this.btnOrganization_Click);
            // 
            // nbFee
            // 
            this.nbFee.Location = new System.Drawing.Point(215, 130);
            this.nbFee.Name = "nbFee";
            this.nbFee.Size = new System.Drawing.Size(362, 30);
            this.nbFee.TabIndex = 4;
            // 
            // cbPricePeriods
            // 
            this.cbPricePeriods.FormattingEnabled = true;
            this.cbPricePeriods.Location = new System.Drawing.Point(215, 190);
            this.cbPricePeriods.Name = "cbPricePeriods";
            this.cbPricePeriods.Size = new System.Drawing.Size(362, 33);
            this.cbPricePeriods.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fee Period  :";
            // 
            // btnNewPayment
            // 
            this.btnNewPayment.Location = new System.Drawing.Point(1299, 46);
            this.btnNewPayment.Name = "btnNewPayment";
            this.btnNewPayment.Size = new System.Drawing.Size(410, 37);
            this.btnNewPayment.TabIndex = 2;
            this.btnNewPayment.Text = "New Payment";
            this.btnNewPayment.UseVisualStyleBackColor = true;
            this.btnNewPayment.Click += new System.EventHandler(this.btnNewPayment_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1299, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(410, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "Debtor List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 104);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1800, 927);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notification";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPaymentList
            // 
            this.btnPaymentList.Location = new System.Drawing.Point(1299, 129);
            this.btnPaymentList.Name = "btnPaymentList";
            this.btnPaymentList.Size = new System.Drawing.Size(410, 43);
            this.btnPaymentList.TabIndex = 9;
            this.btnPaymentList.Text = "Payment List";
            this.btnPaymentList.UseVisualStyleBackColor = true;
            this.btnPaymentList.Click += new System.EventHandler(this.btnPaymentList_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 1039);
            this.Controls.Add(this.tabControl);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewPayment;
        private System.Windows.Forms.ComboBox cbPricePeriods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrganizationName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrganization;
        private System.Windows.Forms.Button btnPaymentList;
    }
}

