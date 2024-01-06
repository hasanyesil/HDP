using Dernek.DataAccess.Concrates;
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
            MemberRepository memberRepository = new MemberRepository();
            Random rnd = new Random();
            memberRepository.Insert(new Entity.Models.Member
            {
                Id = rnd.Next(Int32.MaxValue).ToString(),
                BloodType = Entity.Enums.BloodTypes.AN,
                City = Entity.Enums.Cities.Ankara,
                IsActive = true,
                MemberSurname = "test",
                BirthDate = DateTime.Today,
                MemberName = "hasan",
                PhoneNumber = "1234567890"
            });
        }
    }
}
