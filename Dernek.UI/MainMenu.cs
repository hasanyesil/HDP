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
            tb1.Value = organizationFees[0].Fee;
            tb2.Value = organizationFees[1].Fee;
            tb3.Value = organizationFees[2].Fee;
            tb4.Value = organizationFees[3].Fee;
            tb5.Value = organizationFees[4].Fee;
            tb6.Value = organizationFees[5].Fee;
            tb7.Value = organizationFees[6].Fee;
            tb8.Value = organizationFees[7].Fee;
            tb9.Value = organizationFees[8].Fee;
            tb10.Value = organizationFees[9].Fee;
            tb11.Value = organizationFees[10].Fee;
            tb12.Value = organizationFees[11].Fee;
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
            List<OrganizationFee> feeList = new List<OrganizationFee>();
            
            feeList.Add(new OrganizationFee { FeeMonth = 1, Fee = tb1.Value});
            feeList.Add(new OrganizationFee { FeeMonth = 2, Fee = tb2.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 3, Fee = tb3.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 4, Fee = tb4.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 5, Fee = tb5.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 6, Fee = tb6.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 7, Fee = tb7.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 8, Fee = tb8.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 9, Fee = tb9.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 10, Fee = tb10.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 11, Fee = tb11.Value });
            feeList.Add(new OrganizationFee { FeeMonth = 12, Fee = tb12.Value });

            foreach(var fee in feeList)
            {
                organizationService.UpdateFee(fee);
            }

        }

        #endregion Events

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
