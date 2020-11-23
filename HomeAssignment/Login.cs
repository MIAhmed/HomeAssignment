using HomeAssignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
