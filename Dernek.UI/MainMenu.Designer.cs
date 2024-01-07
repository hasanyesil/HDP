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
            this.btnPaymentList = new System.Windows.Forms.Button();
            this.btnNewPayment = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnPaymentList);
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
            // 
            // btnPaymentList
            // 
            this.btnPaymentList.Location = new System.Drawing.Point(961, 151);
            this.btnPaymentList.Name = "btnPaymentList";
            this.btnPaymentList.Size = new System.Drawing.Size(410, 43);
            this.btnPaymentList.TabIndex = 9;
            this.btnPaymentList.Text = "Payment List";
            this.btnPaymentList.UseVisualStyleBackColor = true;
            this.btnPaymentList.Click += new System.EventHandler(this.btnPaymentList_Click);
            // 
            // btnNewPayment
            // 
            this.btnNewPayment.Location = new System.Drawing.Point(961, 54);
            this.btnNewPayment.Name = "btnNewPayment";
            this.btnNewPayment.Size = new System.Drawing.Size(410, 37);
            this.btnNewPayment.TabIndex = 2;
            this.btnNewPayment.Text = "New Payment";
            this.btnNewPayment.UseVisualStyleBackColor = true;
            this.btnNewPayment.Click += new System.EventHandler(this.btnNewPayment_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(961, 268);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "FEE INFORMATI0N";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tb8);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tb7);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tb10);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tb9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tb12);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tb11);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tb6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(33, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 809);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "January : ";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(124, 73);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(138, 30);
            this.tb1.TabIndex = 12;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(124, 139);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(138, 30);
            this.tb2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "February : ";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(124, 201);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(138, 30);
            this.tb3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "March : ";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(124, 269);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(138, 30);
            this.tb4.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "April : ";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(124, 331);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(138, 30);
            this.tb5.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "May : ";
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(124, 398);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(138, 30);
            this.tb6.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "June : ";
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(489, 333);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(138, 30);
            this.tb11.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "November : ";
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(489, 398);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(138, 30);
            this.tb12.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "December : ";
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(489, 201);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(138, 30);
            this.tb9.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "September : ";
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(489, 266);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(138, 30);
            this.tb10.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "October : ";
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(489, 76);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(138, 30);
            this.tb7.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "July : ";
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(489, 144);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(138, 30);
            this.tb8.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(358, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "August : ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 64);
            this.button3.TabIndex = 35;
            this.button3.Text = "Update Fee Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnNewPayment;
        private System.Windows.Forms.Button btnPaymentList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

