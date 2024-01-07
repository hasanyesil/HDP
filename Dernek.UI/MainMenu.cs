using Dernek.Business;
using Dernek.Business.Abstract;
using Dernek.Business.Concrates;
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
    public partial class MainMenu : Form
    {
        IMemberService memberService;
        IOrganizationService organizationService;

        public MainMenu()
        {
            InitializeComponent();
        }

        //new member
        private void button1_Click(object sender, EventArgs e)
        {
            NewMember form2 = new NewMember();
            form2.ShowDialog();
            form2.TopLevel = true;

            //get all members again, new one added
            getMembers();
        }

        //initialize services and combos 
        private void Form1_Load(object sender, EventArgs e)
        {
            memberService = new MemberService();
            organizationService = new OrganizationService();

            cbBloodType.DataSource = Enum.GetValues(typeof(BloodTypes));
            cbStatus.DataSource = Enum.GetValues(typeof(MemberStatuses));
            cbCity.DataSource = Enum.GetValues(typeof(Cities));
            
            getMembers();
            getFeeInfo();
        }

        //get fee info
        private void getFeeInfo()
        {
            List<OrganizationFee> organizationFees = organizationService.GetAll();
            tb1.Text = organizationFees[0].ToString();
            tb2.Text = organizationFees[1].ToString();
            tb3.Text = organizationFees[2].ToString();
            tb4.Text = organizationFees[3].ToString();
            tb5.Text = organizationFees[4].ToString();
            tb6.Text = organizationFees[5].ToString();
            tb7.Text = organizationFees[6].ToString();
            tb8.Text = organizationFees[7].ToString();
            tb9.Text = organizationFees[8].ToString();
            tb10.Text = organizationFees[9].ToString();
            tb11.Text = organizationFees[10].ToString();
            tb12.Text = organizationFees[11].ToString();
        }

        //get all members
        private void getMembers()
        {
            DataTable dt = memberService.GetAllMembersAsDataTable();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region Events
        //for enums
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

        //Datagrid filter
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

        //new payment
        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            NewPayment newPayment = new NewPayment();
            newPayment.ShowDialog();
        }

        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            PaymentList paymentList = new PaymentList();
            paymentList.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DebtorList debtorList = new DebtorList();
            debtorList.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //User info and update screen
            string memberId = ((DataGridView)sender).SelectedRows[0].Cells[0].Value.ToString();
            Member member = memberService.GetMemberById(memberId);
            
            NewMember newMember = new NewMember(member);
            newMember.ShowDialog();
            getMembers();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        #endregion Events

    }
}
