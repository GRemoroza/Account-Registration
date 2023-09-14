using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAdress;
        private DelegateNumber DelContactNo { get; }
        public FrmConfirm()
        {
            InitializeComponent();

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAdress = new DelegateText(StudentInfoClass.GetAddress);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
            label2.Text = DelProgram(StudentInfoClass.Program);
            label3.Text = DelLastName(StudentInfoClass.LastName);
            label4.Text = DelFirstName(StudentInfoClass.FirstName);
            label5.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label6.Text = Convert.ToString(DelNumAge(StudentInfoClass.Age));
            label7.Text = Convert.ToString(DelContactNo(StudentInfoClass.ContactNo));
            label8.Text = DelAdress(StudentInfoClass.Address);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
