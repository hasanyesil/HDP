using Dernek.Business;
using Dernek.Business.Abstract;
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
    public partial class PaymentList : Form
    {
        IPaymentService paymentService;
        IMemberService memberService;
        public PaymentList()
        {
            InitializeComponent();
        }

        private void PaymentList_Load(object sender, EventArgs e)
        {
            paymentService = new PaymentService();
            memberService = new MemberService();

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker2.Value.Date;
            DateTime endDate = dateTimePicker1.Value.Date;

            if (rbPayments.Checked)
            {
                dataGridView1.DataSource = paymentService.GetByDate(startDate, endDate);
            }
            else if(rbDebtors.Checked)
            {
                dataGridView1.DataSource = memberService.GetDebtorsByDate(startDate, endDate);
            }
            else if(rbPayingUser.Checked)
            {
                dataGridView1.DataSource = memberService.GetPayingUserByDate(startDate, endDate);
            }
        }
    }
}
