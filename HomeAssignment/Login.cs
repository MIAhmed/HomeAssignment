using HomeAssignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var task = DoLogin();

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
            this.BeginInvoke((Action)(() => {
                this.Enabled = enableForm;
            }));

        }



        public async Task DoLogin()
        {
            MakeFormEnable(false);
            ChangeResultText("", Color.Black);

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

                        txtPassword.Text = "Got User";
                    }
                    else
                    {
                        txtPassword.Text = "Not Found";
                    }



                }
            }
            catch (Exception ex)
            {
                ChangeResultText("There was an error processing request", Color.Red);
                MakeFormEnable(true);
            }

        }


    }
}
