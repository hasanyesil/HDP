using Dernek.Business;
using Dernek.DataAccess.Concrates;
using Dernek.Entity.Enums;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            MemberService memberService = new MemberService();
            DataTable dt = memberService.GetAllMembersAsDataTable();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "IsActive")
            {
                if(e.Value != null)
                {
                    if(Convert.ToInt32(e.Value) == 1)
                    {
                        e.Value = "Active";
                    }
                    else
                    {
                        e.Value = "Inactive";
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
