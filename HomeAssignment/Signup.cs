using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            lblResults.Text = "";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var task = Task.Factory.StartNew(() => CreateAccount());
        }



        public void ChangeResultText(string strMsg, Color color)
        {
            lblResults.BeginInvoke((Action)(() => {
                lblResults.Text = strMsg;
                lblResults.ForeColor = color;
            }));

        }

        public void MakeFormEnable(bool enableForm)
        {
            panelMainContainer.BeginInvoke((Action)(() => {
                panelMainContainer.Enabled = enableForm;
            }));

        }

        public async Task DoLogin()
        {
            MakeFormEnable(false);
            ChangeResultText("Please wait while logging you in...", Color.Black);

            if (txtUserName.Text == "")
            {
                ChangeResultText("Please enter the Username", Color.Red);
                MakeFormEnable(true);
                return;
            }

            if (txtPassword.Text == "")
            {
                ChangeResultText("Please enter the Password", Color.Red);
                MakeFormEnable(true);
                return;
            }

            try
            {
                using (var dbx = new AppDBContext())
                {
                    var user = dbx.AppUsers.Where(x => x.Username == txtUserName.Text.Trim()).FirstOrDefault();

                    if (user != null)
                    {

                        ChangeResultText("Got User", Color.Green);

                    }
                    else
                    {
                        ChangeResultText("Not Found", Color.Red);
                    }



                }

                MakeFormEnable(true);
            }
            catch (Exception ex)
            {
                ChangeResultText("There was an error processing request", Color.Red);
                MakeFormEnable(true);
            }

        }


    }
}
