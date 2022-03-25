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
    public partial class FrmsUserList : Form
    {
        private readonly UserManager manager;
        public FrmsUserList()
        {
            InitializeComponent();
            manager = new UserManager();
            dataGridView1.AutoGenerateColumns = false;
        }
        private void LoadData(IEnumerable<User> users)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            lbItems.Text = $"{dataGridView1.Rows.Count} item(s)";
        }

        private void FrmsUserList_Load(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData(manager.FindUser());
            dataGridView1.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            User user = new User { UserName = txtSearch.Text};
            var user1 = manager.FindUser(user);


            user = new User { FullName = txtSearch.Text };
            var user2 = manager.FindUser(user);
            LoadData(user1.Union(user2).ToList());

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserEdit form = new FrmUserEdit(LoadData);
            form.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count >0)
            {
                var user = dataGridView1.SelectedRows[0].DataBoundItem as User;
                FrmUserEdit form = new FrmUserEdit(LoadData,user);
                form.Show();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show
                (
                    "Do you  really want to delete this item(s) ?",
                    "Warnig",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            if(result == DialogResult.OK)
            {
                for (var i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    var user = dataGridView1.SelectedRows[i].DataBoundItem as User;
                    manager.DeleteUser(user.Id);
                }
                LoadData(manager.FindUser());
            }

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button ==MouseButtons.Right)
            {
                var rowINdex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if(rowINdex >=0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowINdex].Selected = true;
                }
            }
        }



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var rowINdex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowINdex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowINdex].Selected = true;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }
    }
}
