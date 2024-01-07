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
    public partial class PaymentList : Form
    {
        IPaymentService paymentService;
        public PaymentList()
        {
            InitializeComponent();
        }

        private void PaymentList_Load(object sender, EventArgs e)
        {
            paymentService = new PaymentService();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker2.Value.Date;
            DateTime endDate = dateTimePicker1.Value.Date;

            dataGridView1.DataSource = paymentService.GetByDate(startDate, endDate);
        }
    }
}
