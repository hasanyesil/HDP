using Dernek.Business;
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
    public partial class NewMember : Form
    {
        Member member;
        public NewMember()
        {
            InitializeComponent();
        }

        public NewMember(Member member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbBloodType.DataSource = Enum.GetValues(typeof(BloodTypes));
            cbStatus.DataSource = Enum.GetValues(typeof(MemberStatuses));
            cbCity.DataSource = Enum.GetValues(typeof(Cities));

            //Opened for update
            if (member != null)
            {
                tbId.Text = member.Id;
                tbName.Text = member.MemberName;
                tbPhone.Text = member.PhoneNumber;
                tbSurname.Text = member.MemberSurname;
                button1.Text = "Update Member";

                cbBloodType.SelectedItem = member.BloodType;
                cbCity.SelectedItem = member.City;
                cbStatus.SelectedItem = member.MemberStatus;
                dateTimePicker1.Value = member.BirthDate;

                tbId.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            Member member = new Member
            {
                Id = tbId.Text,
                MemberStatus = (MemberStatuses)cbStatus.SelectedValue,
                BloodType = (BloodTypes)cbBloodType.SelectedValue,
                City = (Cities)cbCity.SelectedValue,
                MemberName = tbName.Text,
                MemberSurname = tbSurname.Text,
                PhoneNumber = tbPhone.Text,
                CreatedDate = DateTime.Today,
                BirthDate = dateTimePicker1.Value.Date
            };

            MemberService memberService = new MemberService();
            
            if(button1.Text == "Update Member")
            {
                memberService.UpdateMember(member);
            }
            else
            {
                memberService.AddMember(member);
            }

            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Required");
            }
            else
            {
                errorProvider1.SetError(tbName, "");
            }
        }

        private void tbSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSurname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSurname, "Required");
            }
            else
            {
                errorProvider1.SetError(tbSurname, "");
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPhone, "Required");
            }
            else
            {
                errorProvider1.SetError(tbPhone, "");
            }
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbId, "Required");
            }
            else if (tbId.Text.Length != 11)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbId, "Must be 11 digit");
            }
            else
            {
                errorProvider1.SetError(tbId, "");
            }
        }

        private void cbBloodType_Validating(object sender, CancelEventArgs e)
        {
            if (cbBloodType.SelectedValue == null || (BloodTypes)cbBloodType.SelectedValue == BloodTypes.None)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbBloodType, "Required");
            }
            else
            {
                errorProvider1.SetError(cbBloodType, "");
            }
        }

        private void cbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (cbStatus.SelectedValue == null || (MemberStatuses)cbStatus.SelectedValue == MemberStatuses.None)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbStatus, "Required");
            }
            else
            {
                errorProvider1.SetError(cbStatus, "");
            }
        }

        private void cbCity_Validating(object sender, CancelEventArgs e)
        {
            if (cbCity.SelectedValue == null || (Cities)cbCity.SelectedValue == Cities.None)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbCity, "Required");
            }
            else
            {
                errorProvider1.SetError(cbCity, "");
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if ((DateTime.Today - dateTimePicker1.Value).TotalDays / 365.2425 < 18)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimePicker1, "Must be 18 or more");
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }
    }
}
