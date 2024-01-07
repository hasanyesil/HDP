using Dernek.Business;
using Dernek.Business.Abstract;
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
    public partial class DebtorList : Form
    {
        IPaymentService paymentService;
        IMemberService memberService;

        public DebtorList()
        {
            InitializeComponent();
        }

        private void DebtorList_Load(object sender, EventArgs e)
        {
            paymentService = new PaymentService();
            memberService = new MemberService();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbThisMonth.Checked)
            {
                dataGridView1.DataSource = memberService.GetDebtorsByMonth(DateTime.Now.Month);
            }
        }
    }
}
