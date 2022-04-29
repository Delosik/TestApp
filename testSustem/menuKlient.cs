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
    public partial class menuKlient : Form
    {
        public menuKlient(Model.User user)
        {
            InitializeComponent();
            loginFieldLabel.Text = user.Login;
            fullnameFieldLabel.Text = user.Surname + " " + user.Name + " " + user.Patronymic;
            EditHelper.userId = user.UsersID;
            RefreshPage();
        }
        public struct TestResult
        {
            public string testName;
            public string result;
            public TimeSpan time;
            public int points;
            public DateTime dateEnd;

            public TestResult(string _testName, string _result, TimeSpan _time, int _points, DateTime _dateEnd)
            {
                testName = _testName;
                result = _result;
                time = _time;
                points = _points;
                dateEnd = _dateEnd;
            }

        }
        List<TestResult> testResults = new List<TestResult>();
        public void RefreshPage() //Перезагрузка страницы
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                testsComboBox.Items.Clear();
                var tests = db.Test;
                foreach (var test in tests)
                {
                    testsComboBox.Items.Add(test.Name);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (testsComboBox.SelectedItem.ToString() == "") MessageBox.Show("Вы должны выбрать тест");
            else
            {
                using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
                {
                    var test = db.Test.Where(x => x.Name == testsComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var user = db.User.Where(x => x.UsersID == EditHelper.userId).FirstOrDefault();
                    TestForm testForm = new TestForm(test, user);
                    testForm.Show();
                    this.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                testHistoryDataGrid.Rows.Clear();
                testHistoryDataGrid.Refresh();
                testResults = new List<TestResult>();
                var finishTests = db.FinishedTest.Where(x => x.UsersID == EditHelper.userId);
                foreach (var finishTest in finishTests)
                {
                    var test = db.Test.Where(x => x.TestID == finishTest.TestID).FirstOrDefault();
                    string result = "";
                    if (finishTest.Points >= 70) result = "Зачёт";
                    else result = "Незачёт";
                    TimeSpan time = (TimeSpan)finishTest.Time;
                    int points = (int)finishTest.Points;
                    DateTime dateEnd = (DateTime)finishTest.DateEnd;
                    testResults.Add(new TestResult(test.Name, result, time, points, dateEnd));
                }
                foreach (var testResult in testResults)
                {
                    testHistoryDataGrid.Rows.Add(testResult.testName, testResult.result, testResult.time, testResult.points, testResult.dateEnd);
                }
            }
        }
        

        private void loginFieldLabel_Click(object sender, EventArgs e)
        {

        }

        private void testsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                var user = db.User.Where(x => x.Login == loginFieldLabel.Text).FirstOrDefault();
                EditDataUserForm editDataUserForm = new EditDataUserForm(user);
                editDataUserForm.Show();
                this.Close();
            }
        }
    }
}
