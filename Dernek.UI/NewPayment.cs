using Dernek.Business;
using Dernek.Business.Abstract;
using Dernek.Business.Concrates;
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
    public partial class NewPayment : Form
    {
        IMemberService memberService;
        IPaymentService paymentService;
        IOrganizationService organizationService;
        Member member;

        public NewPayment()
        {
            InitializeComponent();
        }

        private void NewPayment_Load(object sender, EventArgs e)
        {
            memberService = new MemberService();
            paymentService = new PaymentService();
            organizationService = new OrganizationService();
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren(ValidationConstraints.Enabled)) 
            {
                return;
            }

            
            member = memberService.GetMemberById(tbId.Text);

            if(member == null || string.IsNullOrEmpty(member.Id))
            {
                MessageBox.Show("No member found");
                return;
            }

            
            tbName.Text = member.MemberName;
            tbPhone.Text = member.PhoneNumber;
            tbSurname.Text = member.MemberSurname;
            btnFindMember.Enabled = false;
            btnTakePayment.Enabled = true;
            tbId.Enabled = false;
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if(tbId.Text.Length != 11)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbId, "Must be 11 digit");
            }
            else
            {
                errorProvider1.SetError(tbId, "");
            }
        }

        private void btnTakePayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Price = organizationService.GetOrganizationFeeByMonth(DateTime.Now.Month);
            payment.PaymentDate = DateTime.Today;
            payment.MemberId = tbId.Text;

            paymentService.AddPayment(payment);
            MessageBox.Show("Payment Succeded");
        }
    }
}
