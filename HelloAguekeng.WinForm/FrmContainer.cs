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
    public partial class FrmContainer : Form
    {
        private bool exiApp = true;

        private readonly User user;

        public FrmContainer()
        {
            InitializeComponent();
            tsslReady.Text = "Ready";
            tsslUser.Text = string.Empty;
            tsslDate.Text = DateTime.Now.ToString();
        }

        public FrmContainer(User user) : this()
        {
            this.user = user;
            tsslUser.Text = $"{user.FullName} -  {user.Profile}";
        }



        private void FrmContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exiApp)
                Application.Exit();
        }

        private void FrmContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exiApp)
            {
                var result = MessageBox.Show
                    (
                        "Do you realy want to close this app ?",
                        "Warnig",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2
                    );
                if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin(user);
            login.Show();
            exiApp = false;
            this.Close();
        }

        private void fsdfsdfs(object sender, PaintEventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserEdit frm = new FrmUserEdit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmsUserList frm = new FrmsUserList();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
