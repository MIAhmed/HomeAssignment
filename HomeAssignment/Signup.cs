using HomeAssignment.Models;
using HomeAssignment.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
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

        public async Task CreateAccount()
        {
            MakeFormEnable(false);
            ChangeResultText("Please wait while creating account...", Color.Black);

            if (txtEmail.Text == "")
            {
                ChangeResultText("Please enter the Email", Color.Red);
                MakeFormEnable(true);
                return;
            }

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

            if (txtFullName.Text == "")
            {
                ChangeResultText("Please enter the Full Name", Color.Red);
                MakeFormEnable(true);
                return;
            }

            if (txtSite.Text == "")
            {
                ChangeResultText("Please enter Site", Color.Red);
                MakeFormEnable(true);
                return;
            }

            if (txtSite.Text == "")
            {
                ChangeResultText("Please enter Company Name", Color.Red);
                MakeFormEnable(true);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                ChangeResultText("Password and confirm password should be same", Color.Red);
                MakeFormEnable(true);
                return;
            }

            if (txtPassword.Text.Trim().Length < 6)
            {
                ChangeResultText("Password must contain atleast 6 characters", Color.Red);
                MakeFormEnable(true);
                return;
            }

            try
            {
                using (var dbx = new AppDBContext())
                {
                    var user = dbx.AppUsers.Where(x => x.Username == txtUserName.Text.Trim() || x.Email == txtEmail.Text.Trim()).FirstOrDefault();

                    if (user != null)
                    {

                        if (user.Email == txtEmail.Text.Trim())
                        {
                            ChangeResultText("Email already exists", Color.Red);
                            MakeFormEnable(true);
                            return;
                        }

                        if (user.Username == txtUserName.Text.Trim())
                        {
                            ChangeResultText("Username already exists", Color.Red);
                            MakeFormEnable(true);
                            return;
                        }



                    }
                    else
                    {

                        var newUser = new AppUser();
                        newUser.Username = txtUserName.Text.Trim();
                        newUser.Name = txtFullName.Text.Trim();
                        newUser.Site = txtSite.Text.Trim();
                        newUser.CompanyName = txtCompany.Text.Trim();
                        newUser.Email = txtEmail.Text.Trim();

                        newUser.Password = Cryptographer.Encrypt(txtPassword.Text.Trim());

                        dbx.AppUsers.Add(newUser);
                        dbx.SaveChanges();


                        ChangeResultText("User created successfully ", Color.Green);
                        MakeFormEnable(true);
                        return;


                    }



                }

                MakeFormEnable(true);
            }
            catch (DbEntityValidationException ex)
            {
                var error = ex.EntityValidationErrors.First().ValidationErrors.First();
                ChangeResultText(error.ErrorMessage , Color.Red);
                MakeFormEnable(true);
            }
            catch (Exception ex)
            {
                ChangeResultText("There was an error processing request", Color.Red);
                MakeFormEnable(true);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
