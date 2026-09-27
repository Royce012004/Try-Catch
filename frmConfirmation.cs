using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Catch
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text =
                StudentInformationClass.SetStudentNo.ToString();

            lblName.Text =
                StudentInformationClass.SetFullName;

            lblProgram.Text =
                StudentInformationClass.SetProgram;

            lblAge.Text =
                StudentInformationClass.SetAge.ToString();

            lblBirthday.Text =
                StudentInformationClass.SetBirthday;

            lblGender.Text =
                StudentInformationClass.SetGender;

            lblContactNo.Text =
                StudentInformationClass.SetContactNo.ToString();
        }
    }
}
