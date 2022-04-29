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
    public partial class EditDataTestForm : Form
    {
        public EditDataTestForm()
        {
            InitializeComponent();
            RefreshPage();
        }
        public void RefreshPage() //Перезагрузка страницы
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                comboBox1.Items.Clear();
                var tests = db.Test;
                foreach (var test in tests)
                {
                    comboBox1.Items.Add(test.Name);
                }
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void RefreshQuestionsList()
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                questionListBox.Items.Clear();
                var currentTest = db.Test.Where(x => x.Name == RefreshPageHelper.selectedTest).FirstOrDefault();
                var questions = db.Question;
                foreach (var question in questions)
                {
                    if (question.TestID == currentTest.TestID)
                    {
                        questionListBox.Items.Add(question.Content);
                    }
                }
            }
        }
        private void EditDataTestForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                if (questionNameField.Text == "" || answer1Field.Text == "" || answer2Field.Text == "" || answer3Field.Text == "" || answer4Field.Text == "") MessageBox.Show("Поля не заполнены");
                else if (!asnwer1RightButton.Checked && !asnwer2RightButton.Checked && !asnwer3RightButton.Checked && !asnwer4RightButton.Checked) MessageBox.Show("Должен быть выбран правильный ответ");
                else
                {
                    int i = 1;
                    var question = db.Question.Where(x => x.QuestionID == RefreshPageHelper.selectedQuestionId).FirstOrDefault();
                    question.Content = questionNameField.Text;
                    var answers = db.Answer.Where(x => x.QuestionID == question.QuestionID);
                    foreach (var answer in answers)
                    {
                        switch (i)
                        {
                            case 1:
                                answer.Content = answer1Field.Text;
                                answer.Right = asnwer1RightButton.Checked;
                                i++;
                                break;
                            case 2:
                                answer.Content = answer2Field.Text;
                                answer.Right = asnwer2RightButton.Checked;
                                i++;
                                break;
                            case 3:
                                answer.Content = answer3Field.Text;
                                answer.Right = asnwer3RightButton.Checked;
                                i++;
                                break;
                            case 4:
                                answer.Content = answer4Field.Text;
                                answer.Right = asnwer4RightButton.Checked;
                                i++;
                                break;
                        }

                    }
                    db.SaveChanges();
                    RefreshQuestionsList();
                }
            }
        }

        private void asnwer1RightButton_CheckedChanged_1(object sender, EventArgs e) //Выбор правильного ответа 1
        {
            asnwer2RightButton.Checked = false;
            asnwer3RightButton.Checked = false;
            asnwer4RightButton.Checked = false;
        }

        private void asnwer2RightButton_CheckedChanged_1(object sender, EventArgs e) //Выбор правильного ответа 2
        {
            asnwer1RightButton.Checked = false;
            asnwer3RightButton.Checked = false;
            asnwer4RightButton.Checked = false;
        }

        private void asnwer3RightButton_CheckedChanged_1(object sender, EventArgs e) //Выбор правильного ответа 3
        {
            asnwer2RightButton.Checked = false;
            asnwer1RightButton.Checked = false;
            asnwer4RightButton.Checked = false;
        }

        private void asnwer4RightButton_CheckedChanged_1(object sender, EventArgs e) //Выбор правильного ответа 4
        {
            asnwer2RightButton.Checked = false;
            asnwer3RightButton.Checked = false;
            asnwer1RightButton.Checked = false;
        }

        private void questionListBox_SelectedIndexChanged_1(object sender, EventArgs e) // Выбор вопроса
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                int i = 1;
                var question = db.Question.Where(x => x.TestID == RefreshPageHelper.selectedTestId && x.Content == questionListBox.SelectedItem.ToString()).FirstOrDefault();
                RefreshPageHelper.selectedQuestionId = question.QuestionID;
                questionNameField.Text = question.Content;
                var answers = db.Answer.Where(x => x.QuestionID == question.QuestionID);
                foreach (var answer in answers)
                {
                    switch (i)
                    {
                        case 1:
                            answer1Field.Text = answer.Content;
                            asnwer1RightButton.Checked = (bool)answer.Right;
                            i++;
                            break;
                        case 2:
                            answer2Field.Text = answer.Content;
                            asnwer2RightButton.Checked = (bool)answer.Right;
                            i++;
                            break;
                        case 3:
                            answer3Field.Text = answer.Content;
                            asnwer3RightButton.Checked = (bool)answer.Right;
                            i++;
                            break;
                        case 4:
                            answer4Field.Text = answer.Content;
                            asnwer4RightButton.Checked = (bool)answer.Right;
                            i++;
                            break;
                    }

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //выбор теста
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                questionListBox.Items.Clear();
                var currentTest = db.Test.Where(x => x.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault();
                RefreshPageHelper.selectedTest = currentTest.Name;
                RefreshPageHelper.selectedTestId = currentTest.TestID;
                var questions = db.Question;
                foreach (var question in questions)
                {
                    if (question.TestID == currentTest.TestID)
                    {
                        questionListBox.Items.Add(question.Content);
                    }
                }
            }
            questionNameField.Clear();
            answer1Field.Clear();
            answer2Field.Clear();
            answer3Field.Clear();
            answer4Field.Clear();
            RefreshQuestionsList();
        }

        private void questionNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1()) //Удаление вопроса
            {
                var deleteQuestion = db.Question.Where(x => x.Content == questionListBox.SelectedItem.ToString()).FirstOrDefault();
                var deleteAnswers = db.Answer.Where(x => x.QuestionID == deleteQuestion.QuestionID);
                db.Answer.RemoveRange(deleteAnswers);
                db.Question.Remove(deleteQuestion);
                db.SaveChanges();
            }
            RefreshPage();
            RefreshQuestionsList();
        }

        private void button2_Click(object sender, EventArgs e) // Добавить новый вопрос
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                var currentTest = db.Test.Where(x => x.Name == RefreshPageHelper.selectedTest).FirstOrDefault();
                var questions = db.Question.Where(x => x.TestID == currentTest.TestID);
                var newQuestion = new Model.Question
                {
                    Content = "Новый вопрос" + (questions.Count() + 1).ToString(),
                    TestID = currentTest.TestID
                };

                db.Question.Add(newQuestion);

                for (int i = 0; i < 4; i++)
                {
                    var newAnswer = new Model.Answer
                    {
                        Content = "Введите ответ",
                        QuestionID = newQuestion.QuestionID,
                        Right = false
                    };
                    db.Answer.Add(newAnswer);
                }




                db.SaveChanges();

            }
            RefreshPage();
            RefreshQuestionsList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
            {
                var deleteTest = db.Test.Where(x => x.Name == RefreshPageHelper.selectedTest).FirstOrDefault();
                var deleteFinishedTest = db.FinishedTest.Where(x => x.TestID == deleteTest.TestID);
                var deleteQuestions = db.Question.Where(x => x.TestID == deleteTest.TestID);
                foreach (var deleteQuestion in deleteQuestions)
                {
                    var deleteAnswers = db.Answer.Where(x => x.QuestionID == deleteQuestion.QuestionID);
                    db.Answer.RemoveRange(deleteAnswers);
                }
                
                db.Question.RemoveRange(deleteQuestions);
                db.Test.Remove(deleteTest);
                db.FinishedTest.RemoveRange(deleteFinishedTest);
                db.SaveChanges();
                RefreshPage();
            }
        }

        private void button4_Click(object sender, EventArgs e) //Добавить новый тест
        {
            newTestNameField.Visible = true;
            saveTestButton.Visible = true;
        }

        private void saveTestButton_Click(object sender, EventArgs e) //Сохранить тест
        {
            if (newTestNameField.Text == "") MessageBox.Show("Введите название теста");
            else
            {
                using (Model.TestirovanieEntities1 db = new Model.TestirovanieEntities1())
                {
                    var searchTest = db.Test.Where(x => x.Name == newTestNameField.Text).FirstOrDefault();
                    if (searchTest != null)
                    {
                        MessageBox.Show("Тест с таким названием уже существует");
                    }
                    else
                    {
                        var newTest = new Model.Test
                        {
                            Name = newTestNameField.Text
                        };
                        db.Test.Add(newTest);
                        db.SaveChanges();
                        newTestNameField.Clear();
                        newTestNameField.Visible = false;
                        saveTestButton.Visible = false;
                        RefreshPage();
                    }
                }
            }
        }
    }
}
