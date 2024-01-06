using Dernek.Business;
using Dernek.DataAccess.Concrates;
using Dernek.Entity.Enums;
using Dernek.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.TopLevel = true;
            getMembers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbBloodType.DataSource = Enum.GetValues(typeof(BloodTypes));
            cbStatus.DataSource = Enum.GetValues(typeof(MemberStatuses));
            cbCity.DataSource = Enum.GetValues(typeof(Cities));
            getMembers();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "BloodType")
            {
                if(e.Value != null)
                {
                    BloodTypes t = (BloodTypes)e.Value;
                    string enumStr = Enum.GetName(typeof(BloodTypes), t);
                    e.Value = enumStr;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "City")
            {
                if(e.Value != null)
                {
                    Cities c = (Cities)Convert.ToInt32(e.Value);
                    string cityStr = Enum.GetName(typeof(Cities), c);
                    e.Value = cityStr;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "MemberStatus")
            {
                if(e.Value != null)
                {
                    MemberStatuses m = (MemberStatuses)Convert.ToInt32(e.Value);
                    string statusStr = Enum.GetName(typeof(MemberStatuses), m);
                    e.Value = statusStr;
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void getMembers()
        {
            MemberService memberService = new MemberService();
            DataTable dt = memberService.GetAllMembersAsDataTable();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filterStr = "";
            if((BloodTypes)cbBloodType.SelectedValue != BloodTypes.None)
            {
                filterStr += string.Format("BloodType = '{0}'", Convert.ToByte(cbBloodType.SelectedValue));
            }

            if((MemberStatuses)cbStatus.SelectedValue != MemberStatuses.None)
            {
                if (!string.IsNullOrEmpty(filterStr))
                {
                    filterStr += " AND ";
                }

                filterStr += string.Format(" MemberStatus = '{0}'", Convert.ToByte(cbStatus.SelectedValue));
            }

            if((Cities)cbCity.SelectedValue != Cities.None)
            {
                if (!string.IsNullOrEmpty(filterStr))
                {
                    filterStr += " AND ";
                }

                filterStr += string.Format(" City = '{0}'", Convert.ToInt32(cbCity.SelectedValue));
            }

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterStr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
        }
    }
}
