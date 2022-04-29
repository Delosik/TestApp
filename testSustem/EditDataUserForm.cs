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
    public partial class EditDataUserForm : Form
    {
        public EditDataUserForm(Model.User user)
        {
            InitializeComponent();
            EditHelper.userId = user.UsersID;
            EditHelper.previousLogin = user.Login;
            loginField.Text = user.Login;
            fullNameField.Text = user.Surname + " " + user.Name + " " + user.Patronymic;
            passwordField.Text = user.Password;
            password2Field.Text = user.Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginField.Clear();
            fullNameField.Clear();
            passwordField.Clear();
            password2Field.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "" || fullNameField.Text == "" || passwordField.Text == "" || password2Field.Text == "" || passwordField.Text != password2Field.Text) MessageBox.Show("Поля не заполнены или пароли не совпадают");
            else if (!ValidateSystem.ValidatePassword(passwordField.Text)) MessageBox.Show("Пароль должен содержать заглавные и строчные латинские буквы, цифры, и быть длиной минимум в 6 символов");
            else if (!ValidateSystem.ValidateFullName(fullNameField.Text)) MessageBox.Show("ФИО должно состоять из трёх слов и разделено пробелом.\n Пример: Гатунов Александр Павлович");
            else if (!ValidateSystem.ValidateLogin(loginField.Text)) MessageBox.Show("Логин должен состоять из латинских букв и не содержать пробелов");
            else
            {
                using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
                {
                    var editUser = db.User.Where(x => x.UsersID == EditHelper.userId).FirstOrDefault();
                    string[] fullNameArray = fullNameField.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    editUser.Name = fullNameArray[1];
                    editUser.Surname = fullNameArray[0];
                    editUser.Patronymic = fullNameArray[2];
                    editUser.Password = passwordField.Text;
                    if (loginField.Text != EditHelper.previousLogin)
                    {
                        var searchLogin = db.User.Where(x => x.Login == loginField.Text).FirstOrDefault();
                        if (searchLogin == null)
                        {
                            editUser.Login = loginField.Text;
                            db.SaveChanges();
                            MessageBox.Show("Успешно!\nАвторизуйтесь под новыми данными");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Логин занят");
                        }
                    }
                    else
                    {
                        db.SaveChanges();
                        MessageBox.Show("Успешно!\nАвторизуйтесь под новыми данными");
                        this.Close();
                    }
                }
            }
        }
    }
}
