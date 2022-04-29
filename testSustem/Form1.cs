using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSustem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "" || passwordField.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
                {
                    var user = db.User.Where(x => x.Login == loginField.Text && x.Password == passwordField.Text).FirstOrDefault();
                    if (user != null)
                    {
                        switch (user.RoleID)
                        {
                            case 1:
                                menuAdmin controlPanelAdminForm = new menuAdmin(user);
                                controlPanelAdminForm.Show();
                                break;
                            case 2:
                                menuKlient controlPanelUserForm = new menuKlient(user);
                                controlPanelUserForm.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginField.Clear();
            passwordField.Clear();
        }
    }
}
