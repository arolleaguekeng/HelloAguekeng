using HelloAguekeng.BLL;
using HelloAguekeng.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloAguekeng.WinForm
{
    public partial class FrmLogin : Form
    {
        private bool exiApp = false;
        private readonly UserManager userManager;
        public FrmLogin()
        {
            InitializeComponent();
            userManager = new UserManager();
        }
        public FrmLogin(User user):this()
        {
            txtUsername.Text = user.UserName;
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exiApp)
                Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var user = userManager.AuthenticateUser(txtUsername.Text, txtPassword.Text);
                FrmContainer container = new FrmContainer(user);
                container.Show();
                this.Close();
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
            catch(Exception ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                Console.Error.WriteLine($"--->{ex.Message}");
            }
        }
    }
}
