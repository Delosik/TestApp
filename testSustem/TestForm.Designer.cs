
namespace testSustem
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.answer4Button = new System.Windows.Forms.RadioButton();
            this.answer3Button = new System.Windows.Forms.RadioButton();
            this.answer2Button = new System.Windows.Forms.RadioButton();
            this.answer1Button = new System.Windows.Forms.RadioButton();
            this.questionNameField = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timeTestLabel = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.timeQuestionLabel = new System.Windows.Forms.Timer(this.components);
            this.questionStartTime = new System.Windows.Forms.Timer(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.testStartTime = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.testTimeDiff = new System.Windows.Forms.Timer(this.components);
            this.user123 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.testirovanieDataSet = new testSustem.TestirovanieDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.testirovanieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(363, 9);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(90, 17);
            this.fullNameLabel.TabIndex = 25;
            this.fullNameLabel.Text = "Ваше Ф.И.О";
            // 
            // answer4Button
            // 
            this.answer4Button.AutoSize = true;
            this.answer4Button.Location = new System.Drawing.Point(81, 378);
            this.answer4Button.Name = "answer4Button";
            this.answer4Button.Size = new System.Drawing.Size(17, 16);
            this.answer4Button.TabIndex = 20;
            this.answer4Button.TabStop = true;
            this.answer4Button.UseVisualStyleBackColor = true;
            // 
            // answer3Button
            // 
            this.answer3Button.AutoSize = true;
            this.answer3Button.Location = new System.Drawing.Point(81, 350);
            this.answer3Button.Name = "answer3Button";
            this.answer3Button.Size = new System.Drawing.Size(17, 16);
            this.answer3Button.TabIndex = 19;
            this.answer3Button.TabStop = true;
            this.answer3Button.UseVisualStyleBackColor = true;
            // 
            // answer2Button
            // 
            this.answer2Button.AutoSize = true;
            this.answer2Button.Location = new System.Drawing.Point(81, 322);
            this.answer2Button.Name = "answer2Button";
            this.answer2Button.Size = new System.Drawing.Size(17, 16);
            this.answer2Button.TabIndex = 18;
            this.answer2Button.TabStop = true;
            this.answer2Button.UseVisualStyleBackColor = true;
            // 
            // answer1Button
            // 
            this.answer1Button.AutoSize = true;
            this.answer1Button.Location = new System.Drawing.Point(81, 294);
            this.answer1Button.Name = "answer1Button";
            this.answer1Button.Size = new System.Drawing.Size(17, 16);
            this.answer1Button.TabIndex = 17;
            this.answer1Button.TabStop = true;
            this.answer1Button.UseVisualStyleBackColor = true;
            // 
            // questionNameField
            // 
            this.questionNameField.FormattingEnabled = true;
            this.questionNameField.ItemHeight = 16;
            this.questionNameField.Items.AddRange(new object[] {
            "СУБД по характеру использования бывают:",
            "СУБД по модели данных бывают:",
            "СУБД по способу доступа бывают:",
            "Что такое кортеж ?",
            "Базы данных - это:",
            "Основные понятия иерархической БД:",
            "Записью реляционной базы данных является:",
            "Выберите из приведённых ниже вариантов ответов основной объект БД:",
            "Где хранятся таблицы БД ?",
            "Какие БД называются реляционными?",
            "Таблицы в базах данных предназначены:",
            "Основные объекты базы данных это:",
            "Наиболее распространенными базами данных являются:",
            "Выберите из приведённых ниже вариантов ответов требование к проектировки базы дан" +
                "ных:",
            "На этапе логического проектирования осуществляется:",
            "На этапе физического проектирования осуществляется:",
            "На этапе концептуального проектирования осуществляется:",
            "Базовым элементом физического проектирования является:",
            "Фокусами моделирования физического проектирования является:",
            "Выберите из приведённых ниже вариантов ответов компонент архитектуры среды СУБД:"});
            this.questionNameField.Location = new System.Drawing.Point(81, 82);
            this.questionNameField.Name = "questionNameField";
            this.questionNameField.Size = new System.Drawing.Size(677, 196);
            this.questionNameField.TabIndex = 16;
            this.questionNameField.SelectedIndexChanged += new System.EventHandler(this.questionField_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Вопрос";
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Location = new System.Drawing.Point(340, 39);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(113, 17);
            this.testNameLabel.TabIndex = 14;
            this.testNameLabel.Text = "Название теста";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ответить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "Завершить тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timeTestLabel
            // 
            this.timeTestLabel.AutoSize = true;
            this.timeTestLabel.Location = new System.Drawing.Point(78, 459);
            this.timeTestLabel.Name = "timeTestLabel";
            this.timeTestLabel.Size = new System.Drawing.Size(156, 17);
            this.timeTestLabel.TabIndex = 29;
            this.timeTestLabel.Text = "Времени на весь тест:";
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(78, 418);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(194, 17);
            this.DateTime.TabIndex = 30;
            this.DateTime.Text = "Времени на данный вопрос:";
            this.DateTime.Click += new System.EventHandler(this.timeQuestionLabel_Click);
            // 
            // questionStartTime
            // 
            this.questionStartTime.Enabled = true;
            this.questionStartTime.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // testirovanieDataSet
            // 
            this.testirovanieDataSet.DataSetName = "TestirovanieDataSet";
            this.testirovanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.timeTestLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.answer4Button);
            this.Controls.Add(this.answer3Button);
            this.Controls.Add(this.answer2Button);
            this.Controls.Add(this.answer1Button);
            this.Controls.Add(this.questionNameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.testNameLabel);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testirovanieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.RadioButton answer4Button;
        private System.Windows.Forms.RadioButton answer3Button;
        private System.Windows.Forms.RadioButton answer2Button;
        private System.Windows.Forms.RadioButton answer1Button;
        private System.Windows.Forms.ListBox questionNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label timeTestLabel;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Timer timeQuestionLabel;
        private System.Windows.Forms.Timer questionStartTime;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Timer testStartTime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer testTimeDiff;
        private System.Windows.Forms.Timer user123;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private TestirovanieDataSet testirovanieDataSet;
    }
}