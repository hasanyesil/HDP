using Dernek.Business;
using Dernek.Business.Abstract;
using Dernek.Business.Concrates;
using Dernek.DataAccess.Concrates;
using Dernek.Entity.Enums;
using Dernek.Entity.Models;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Dernek.UI
{
    public partial class MainMenu : Form
    {
        IMemberService memberService;
        IOrganizationService organizationService;
        IPaymentService paymentService;

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
            rbMonth.Checked = true;
            memberService = new MemberService();
            organizationService = new OrganizationService();
            paymentService = new PaymentService();

            cbBloodType.DataSource = Enum.GetValues(typeof(BloodTypes));
            cbStatus.DataSource = Enum.GetValues(typeof(MemberStatuses));
            cbCity.DataSource = Enum.GetValues(typeof(Cities));

            getMembers();
            getFeeInfo();
            setupCharts();
        }

        private void setupCharts()
        {
            setupMemberCityChart();

            // get a reference to the GraphPane
            setupRevenueChart();
        }

        private void setupRevenueChart()
        {
            zedGraphControl2.Refresh();
            GraphPane pane = zedGraphControl2.GraphPane;
            pane.CurveList.Clear();
            pane.GraphObjList.Clear();

            DateTime startDate;
            DateTime endDate = DateTime.Now.Date;

            if (rbMonth.Checked)
            {
                startDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            else
            {
                startDate = DateTime.MinValue.Date;
            }

            List<Payment> payments = paymentService.GetByDateList(startDate, endDate);

            if (rbMonth.Checked)
            {
                pane.Title.Text = "Revenue Chart";
                pane.XAxis.Title.Text = "Month";
                pane.YAxis.Title.Text = "Total Revenue";

                // Make up some random data points
                string[] labels = { "January", "February", "March",
                      "April", "May", "June", "July", "August", "September",
                      "October", "November", "December"};


                double[] y = new double[12];

                for (int i = 0; i < 12; i++)
                {
                    y[i] = (Convert.ToDouble(payments.Where(p => p.PaymentDate.Month == i + 1).Sum(p => p.Price)));
                }

                // Generate a red bar with "Curve 1" in the legend
                BarItem myBar = pane.AddBar("Curve 1", null, y,
                                                            Color.Red);
                myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                            Color.Red);

                // Draw the X tics between the labels instead of 
                // at the labels
                pane.XAxis.MajorTic.IsBetweenLabels = false;

                // Set the XAxis labels
                pane.XAxis.Scale.TextLabels = labels;
                // Set the XAxis to Text type
                pane.XAxis.Type = AxisType.Text;

                // Fill the Axis and Pane backgrounds
                pane.Chart.Fill = new Fill(Color.White,
                      Color.FromArgb(255, 255, 166), 90F);
                pane.Fill = new Fill(Color.FromArgb(250, 250, 255));

                // Tell ZedGraph to refigure the
                // axes since the data have changed
                zedGraphControl2.AxisChange();
            }
            else
            {
                pane.Title.Text = "Revenue Chart";
                pane.XAxis.Title.Text = "Year";
                pane.YAxis.Title.Text = "Total Revenue";

                var group = payments.GroupBy(p => p.PaymentDate.Year);

                string[] labels = new string[group.Count()];
                double[] y = new double[group.Count()];
                for (int i = 0; i < group.Count(); i++)
                {
                    labels[i] = group.ElementAt(i).First().PaymentDate.Year.ToString();
                    y[i] = Convert.ToDouble(group.ElementAt(i).Sum(p => p.Price));
                }

                // Generate a red bar with "Curve 1" in the legend
                BarItem myBar = pane.AddBar("Curve 1", null, y,
                                                            Color.Red);
                myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                            Color.Red);

                // Draw the X tics between the labels instead of 
                // at the labels
                pane.XAxis.MajorTic.IsBetweenLabels = false;

                // Set the XAxis labels
                pane.XAxis.Scale.TextLabels = labels;
                // Set the XAxis to Text type
                pane.XAxis.Type = AxisType.Text;

                // Fill the Axis and Pane backgrounds
                pane.Chart.Fill = new Fill(Color.White,
                      Color.FromArgb(255, 255, 166), 90F);
                pane.Fill = new Fill(Color.FromArgb(250, 250, 255));

                // Tell ZedGraph to refigure the
                // axes since the data have changed
                zedGraphControl2.AxisChange();
            }

            zedGraphControl2.Invalidate();

        }

        private void setupMemberCityChart()
        {
            #region Member - City chart
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Members - City";

            List<Member> members = memberService.GetAllMembers();

            var groups = members.GroupBy(mem => mem.City);

            Random rnd = new Random();

            foreach (var group in groups)
            {
                PieItem pieSlice1 = myPane.AddPieSlice(group.Count(), Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), 0F, Enum.GetName(typeof(Cities), group.First().City));
                pieSlice1.LabelType = PieLabelType.Name_Percent;
            }

            // optional depending on whether you want labels within the graph legend
            myPane.Legend.IsVisible = false;
            myPane.YAxis.IsVisible = false;
            myPane.XAxis.IsVisible = false;
            #endregion Member - City chart
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
                if (e.Value != null)
                {
                    BloodTypes t = (BloodTypes)e.Value;
                    string enumStr = Enum.GetName(typeof(BloodTypes), t);
                    e.Value = enumStr;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "City")
            {
                if (e.Value != null)
                {
                    Cities c = (Cities)Convert.ToInt32(e.Value);
                    string cityStr = Enum.GetName(typeof(Cities), c);
                    e.Value = cityStr;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "MemberStatus")
            {
                if (e.Value != null)
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
            if ((BloodTypes)cbBloodType.SelectedValue != BloodTypes.None)
            {
                filterStr += string.Format("BloodType = '{0}'", Convert.ToByte(cbBloodType.SelectedValue));
            }

            if ((MemberStatuses)cbStatus.SelectedValue != MemberStatuses.None)
            {
                if (!string.IsNullOrEmpty(filterStr))
                {
                    filterStr += " AND ";
                }

                filterStr += string.Format(" MemberStatus = '{0}'", Convert.ToByte(cbStatus.SelectedValue));
            }

            if ((Cities)cbCity.SelectedValue != Cities.None)
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

            feeList.Add(new OrganizationFee { FeeMonth = 1, Fee = tb1.Value });
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

            foreach (var fee in feeList)
            {
                organizationService.UpdateFee(fee);
            }

        }

        #endregion Events

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            setupRevenueChart();
        }
    }
}
