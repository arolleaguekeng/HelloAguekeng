using HelloAguekeng.BLL;
using HelloAguekeng.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloAguekeng.WinForm
{
    public partial class FrmUserEdit : Form
    {
        private readonly Action<IEnumerable<User>>  CallBack;
        private readonly User user;
        private readonly UserManager userManager;
        public FrmUserEdit()
        {
            InitializeComponent();
            userManager = new UserManager();
            InitForm();
        }
        public FrmUserEdit(Action<IEnumerable<User>> callBack):this()
        {
            this.CallBack = callBack;
        }
        public FrmUserEdit(Action<IEnumerable<User>> callBack , User user) : this(callBack)
        {
            this.user = user;
            txtFullName.Text = user.FullName;
            txtPassword.Text = user.Password;
            txtUserName.Text = user.UserName;
            cbbProfile.SelectedIndex = (int)user.Profile;
            chkStaus.Checked = user.Statues ?? false;
            if(user.Picture != null)
                pbPicture.Image = Image.FromStream(new MemoryStream(user.Picture));
        }
        private void InitForm()
        {
            txtFullName.Clear();
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            llShowHidePassword.Text = "Show";
            txtUserName.Clear();
            cbbProfile.DataSource = Enum.GetNames(typeof(User.ProfileOptions));
            cbbProfile.SelectedIndex = -1;
            chkStaus.Checked = true;
            chkStaus.Text = "Enable";
            pbPicture.Image = null;
            pbPicture.ImageLocation = null;
            txtFullName.Focus();
        }
        private void ValidateForm()
        {
            string error = string.Empty;
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
                error += "Fullname can not empty ! /n";
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
                error += "Username can not empty ! /n";
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                error += "Password can not empty ! /n";
            if (cbbProfile.SelectedIndex < 0)
                error += "You must choose  a profile";
            if (!string.IsNullOrEmpty(error))
                throw new InvalidExpressionException(error);

        }

        private void ShowHidePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llShowHidePassword.Text = llShowHidePassword.Text == "Show" ? "Hide" : "Show";
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void chkStaus_CheckedChanged(object sender, EventArgs e)
        {
            chkStaus.Text = chkStaus.Checked ? "Enable" : "Desable";
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif;*.tiff";
            if(dialog.ShowDialog() == DialogResult.OK )
            {
                pbPicture.ImageLocation = dialog.FileName;
            }
        }

        private void llRemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPicture.ImageLocation = null;
            pbPicture.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
                byte[] picture = this.user?.Picture;
                if(!string.IsNullOrEmpty(pbPicture.ImageLocation) && File.Exists(pbPicture.ImageLocation))
                {
                    picture = File.ReadAllBytes(pbPicture.ImageLocation);
                }
                else if(pbPicture.Image != null)
                {
                    picture = this.user.Picture;
                }
                User newUser = new User
                (
                    this.user?.Id ?? 0,
                    txtUserName.Text,
                    txtPassword.Text,
                    txtFullName.Text,
                    (User.ProfileOptions)cbbProfile.SelectedIndex,
                    chkStaus.Checked,
                    picture,
                    DateTime.Now
                );
                if(this.user == null)
                {
                    userManager.CreateUser(newUser);
                }
                else
                {
                    userManager.EditUser(newUser);
                }
                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if(this.CallBack != null)
                {
                    CallBack(userManager.FindUser());
                }

                if (this.user != null)
                    this.Close();
                InitForm();

            }

            catch(InvalidExpressionException ex)
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
