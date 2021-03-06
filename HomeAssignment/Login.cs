﻿using HomeAssignment.Models;
using HomeAssignment.Utilities;
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


        private void Login_Load(object sender, EventArgs e)
        {
            lblResults.Text = "";
            //ShowMainForm();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var task = Task.Factory.StartNew(() => DoLogin());
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
                        if (Cryptographer.Decrypt(user.Password) != txtPassword.Text.Trim())
                        {
                            ChangeResultText("Invalid Password.", Color.Red);
                            MakeFormEnable(true);
                        }
                        else {
                            ShowMainForm(user);
                        }
                        

                    }
                    else
                    {
                        ChangeResultText("Invalid Username.", Color.Red);
                        MakeFormEnable(true);
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

        private void lnklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            Signup frmSignup = new Signup();
            this.Hide();
            frmSignup.Closed += (s, args) => this.Show();
            frmSignup.Show();
            

        }

        public void ShowMainForm(AppUser user)
        {
            this.BeginInvoke((Action)(() => {
                var frmOrder = new FormOrders();
                this.Hide();
                frmOrder.passedUser = user;
                frmOrder.Closed += (s, args) => this.Close();
                frmOrder.Show();
            }));

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }
    }
}
