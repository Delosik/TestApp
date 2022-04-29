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
    public partial class TestForm : Form
    {
        public TestForm(Model.Test test, Model.User user)
        {
            InitializeComponent();
            fullNameLabel.Text = $"Ваше Ф.И.О: {user.Surname} {user.Name} {user.Patronymic}";
            testNameLabel.Text = test.Name;
            TestHelper.startTime = System.DateTime.Now;
            TestHelper.countRightAnswers = 0;
            TestHelper.testStartTime = System.DateTime.Now;
            TestHelper.testFininshTime = System.DateTime.Now.AddMinutes(60);
            TestHelper.testTimeDiff = TestHelper.testFininshTime.Subtract(TestHelper.testStartTime);
            TestHelper.testId = test.TestID;
            TestHelper.userId = user.UsersID;
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                var questions = db.Question.Where(x => x.TestID == test.TestID);
                TestHelper.currentQuestion = 1;
                TestHelper.allCountQuestions = questions.Count();
            }
            TestHelper.pointsForQuestion = 100 / TestHelper.allCountQuestions;
            NextQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (TestHelper.rightAnswer)
            {
                case 1:
                    if (answer1Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
                case 2:
                    if (answer2Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
                case 3:
                    if (answer3Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
                case 4:
                    if (answer4Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
            }
            NextQuestion();
        }
        public void NextQuestion()
        {
            if (TestHelper.currentQuestion == TestHelper.allCountQuestions) MessageBox.Show("Вы ответили на все вопросы, завершите тест.");
            else
            {
                TestHelper.questionStartTime = System.DateTime.Now;
                TestHelper.questionFinishTime = System.DateTime.Now.AddMinutes(2);
                TestHelper.questionTimeDiff = TestHelper.questionFinishTime.Subtract(TestHelper.questionStartTime);
                using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
                {
                    int i = 1;
                    var questions = db.Question.Where(x => x.TestID == TestHelper.testId);
                    foreach (var question in questions)
                    {
                        if (i == TestHelper.currentQuestion)
                        {
                            questionNameField.Text = question.Content;
                            var answers = db.Answer.Where(x => x.QuestionID == question.QuestionID);
                            int j = 1;
                            foreach (var answer in answers)
                            {
                                switch (j)
                                {
                                    case 1:
                                        answer1Button.Text = answer.Content;
                                        if ((bool)answer.Right) TestHelper.rightAnswer = 1;
                                        j++;
                                        break;
                                    case 2:
                                        answer2Button.Text = answer.Content;
                                        if ((bool)answer.Right) TestHelper.rightAnswer = 2;
                                        j++;
                                        break;
                                    case 3:
                                        answer3Button.Text = answer.Content;
                                        if ((bool)answer.Right) TestHelper.rightAnswer = 3;
                                        j++;
                                        break;
                                    case 4:
                                        answer4Button.Text = answer.Content;
                                        if ((bool)answer.Right) TestHelper.rightAnswer = 4;
                                        j++;
                                        break;
                                }

                            }
                            break;
                        }
                        i++;
                    }
                    TestHelper.currentQuestion = TestHelper.currentQuestion + 1;

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestHelper.finishTime = System.DateTime.Now;
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                var finishTest = new Model.FinishedTest
                {
                    TestID = TestHelper.testId,
                    UsersID = TestHelper.userId,
                    Points = TestHelper.countRightAnswers * TestHelper.pointsForQuestion,
                    Time = TestHelper.finishTime.Subtract(TestHelper.startTime),
                    DateEnd = TestHelper.testFininshTime
                };
                db.FinishedTest.Add(finishTest);
                db.SaveChanges();
            }
            this.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TestHelper.questionStartTime = System.DateTime.Now;
            TestHelper.questionTimeDiff = TestHelper.questionFinishTime.Subtract(TestHelper.questionStartTime);
            DateTime.Text = $"Времени на данный вопрос: {TestHelper.questionTimeDiff.Minutes}:{TestHelper.questionTimeDiff.Seconds}";
            TestHelper.testStartTime = System.DateTime.Now;
            TestHelper.testTimeDiff = TestHelper.testFininshTime.Subtract(TestHelper.testStartTime);
            timeTestLabel.Text = $"Времени на весь тест: {TestHelper.testTimeDiff.Minutes}:{TestHelper.testTimeDiff.Seconds}";
            if (TestHelper.questionStartTime > TestHelper.questionFinishTime) NextQuestion();
            if (TestHelper.testStartTime > TestHelper.testFininshTime) button2_Click(sender, e);
        }

        private void questionField_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                

            }



        }

        private void timeQuestionLabel_Click(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
