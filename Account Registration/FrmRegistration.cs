namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass studentInfo = new StudentInfoClass();

            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text.ToString());
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.FirstName = txtFirstName.Text.ToString();
            StudentInfoClass.MiddleName = txtMiddleName.Text.ToString();
            StudentInfoClass.LastName = txtLastName.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt32(txtAge.Text.ToString());
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text.ToString());

            using (FrmConfirm form2 = new FrmConfirm())
            {
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtStudentNo.Clear();
                    cbProgram.SelectedIndex = 1;
                    txtFirstName.Clear();
                    txtMiddleName.Clear();
                    txtLastName.Clear();
                    txtAge.Clear();
                    txtAddress.Clear();
                    txtContactNo.Clear();
                }
            }
        }
    }
}