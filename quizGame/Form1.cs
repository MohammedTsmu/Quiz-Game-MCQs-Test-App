using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer = 0;
        int correctAnswers = 0;
        int wrongAnswers = 0;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int currentQuestionNumber = 1;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 20;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            
            if (buttonTag == correctAnswer)
            {
                // set button color to green with white text
                score++;
                correctAnswers++;
                currentQuestionNumber++; 
                senderObject.BackColor = Color.DarkGreen;
                correctAnswersLabel.Text = "الأجابات الصحيحة: " + correctAnswers;
            }
            else
            {
                wrongAnswers++;
                currentQuestionNumber++;
                // set button color to red with white text
                senderObject.BackColor = Color.DarkRed;
                WrongAnswersLabel.Text = "الأجابات الخاطئة: " + wrongAnswers;
            }

            // disable all answer buttons until next question
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);

                // show message box with score and percentage
                DialogResult dialogResult = MessageBox.Show("أنتهى الأختبار" + Environment.NewLine +Environment.NewLine +
                                "لقد أجبت/ي على " + score + " سؤال صحيح" + Environment.NewLine +
                                " %" +"نسبتك الكلية هي " + percentage + Environment.NewLine +
                                "هل التريد اللعب مجداد؟", "نتائج الأختبار", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    // reset score and question number and start quiz again
                    score = 0;
                    correctAnswer = 0;
                    correctAnswers = 0;
                    wrongAnswers = 0;
                    questionNumber = 1;
                    correctAnswersLabel.Text = "الأجابات الصحيحة: " + 0;
                    WrongAnswersLabel.Text = "الأجابات الخاطئة: " + 0;
                    askQuestion(questionNumber);
                }
                else
                {
                    // close the program
                    this.Close();
                }
            }
            else
            {
                // increment question number and ask next question
                questionNumber++;
                askQuestion(questionNumber);
            }
        }

        
        private void askQuestion(int qnum)
        {
            if (questionNumber != 21)
            {
                currentQuestion.Text = "السؤال رقم: " + questionNumber;
                
            }

            switch (qnum)
            {
                case 1:

                    //pictureBox1.Image = Properties.Resources.questions;
                    pictureBox1.Image = Properties.Resources.sky;
                    lblQuestion.Text = "ما هو لون السماء؟";

                    button1.Text = "أزرق";
                    button2.Text = "أصفر";
                    button3.Text = "بنفسجي";
                    button4.Text = "أحمر";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.ironMan;
                    lblQuestion.Text = "ما هو أسم الشخصية الرئيسية من فلم الرجل الحديدي؟";

                    button1.Text = "توني ستانك";
                    button2.Text = "توني ستارك";
                    button3.Text = "رودي";
                    button4.Text = "بيتر كويل";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.fortnite;

                    lblQuestion.Text = "أي ناشر لعبة صنع اللعبة أعلاه؟";

                    button1.Text = "EA";
                    button2.Text = "Activision";
                    button3.Text = "Square Enix";
                    button4.Text = "Epic Games";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.london;

                    lblQuestion.Text = "ما هي عاصمة انجلترا؟";

                    button1.Text = "برمنغهام";
                    button2.Text = "لندن";
                    button3.Text = "برايتون";
                    button4.Text = "ليفربول";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.gears_of_war;

                    lblQuestion.Text = "ما هو اسم هذه اللعبة؟";

                    button1.Text = "Gears Of War - معدات الحرب";
                    button2.Text = "Call of Duty - نداء الواجب";
                    button3.Text = "Battlefield - ساحة المعركة";
                    button4.Text = "Bionic Commando - كوماندوز الكترونية";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.halo;

                    lblQuestion.Text = "ما هو اسم الشخصيات الرئيسية في هذه اللعبة؟";

                    button1.Text = "Altair - النسر";
                    button2.Text = "Lara Croft - لارا كروفت";
                    button3.Text = "Master Cheif - الطاهي الكبير";
                    button4.Text = "Drake - دريك";

                    correctAnswer = 4;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.csgo;

                    lblQuestion.Text = "ما هو اسم هذه اللعبة؟";

                    button1.Text = "Counter Strike Go - كاونتر سترايك كو";
                    button2.Text = "Call of Duty - نداء الواجب";
                    button3.Text = "Battlefield - ساحة المعركة";
                    button4.Text = "Half Life 3 - نصف الحياة 3";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.chrinaGreatWall;

                    lblQuestion.Text = "ما هي الدولة الأكثر سكانًا في العالم؟";

                    button1.Text = "الصين";
                    button2.Text = "الهند";
                    button3.Text = "الولايات المتحدة الأمريكية";
                    button4.Text = "روسيا";

                    correctAnswer = 1;

                    break;

                case 9:

                    pictureBox1.Image = Properties.Resources.mars;

                    lblQuestion.Text = "ما هو الكوكب الذي يعرف باسم الكوكب الأحمر؟\r\n";

                    button1.Text = "المريخ";
                    button2.Text = "الزهرة";
                    button3.Text = "المشتري";
                    button4.Text = "زحل";

                    correctAnswer = 1;

                    break;

                case 10:

                    pictureBox1.Image = Properties.Resources.brazil;

                    lblQuestion.Text = "ما هي اللغة الرسمية في البرازيل؟";

                    button1.Text = "الإسبانية";
                    button2.Text = "الفرنسية";
                    button3.Text = "الإنجليزية";
                    button4.Text = "البرتغالية";

                    correctAnswer = 4;

                    break;
                case 11:

                    pictureBox1.Image = Properties.Resources.oscar;

                    lblQuestion.Text = "ما هو الفيلم الذي حصل على جائزة أفضل فيلم في حفل الأوسكار عام 2021؟\r\n";

                    button1.Text = "Nomadland";
                    button2.Text = "The Trial of the Chicago 7";
                    button3.Text = "Minari";
                    button4.Text = "Sound of Metal";

                    correctAnswer = 1;

                    break;
                case 12:

                    pictureBox1.Image = Properties.Resources.japan;

                    lblQuestion.Text = "ما هو عاصمة اليابان؟";

                    button1.Text = "كيوتو";
                    button2.Text = "طوكيو";
                    button3.Text = "أوساكا";
                    button4.Text = "هيروشيما";

                    correctAnswer = 2;

                    break;
                case 13:

                    pictureBox1.Image = Properties.Resources.everest;

                    lblQuestion.Text = "ما هو الجبل الأعلى في العالم؟";

                    button1.Text = "جبل إيفرست";
                    button2.Text = "جبل كيليمنجارو";
                    button3.Text = "جبل ماكينلي";
                    button4.Text = "جبل مونت بلانك";

                    correctAnswer = 1;

                    break;
                case 14:

                    pictureBox1.Image = Properties.Resources.earth;

                    lblQuestion.Text = "ما هو العنصر الأكثر وفرة في الغلاف الجوي؟";

                    button1.Text = "الأكسجين";
                    button2.Text = "النيتروجين";
                    button3.Text = "الهيدروجين";
                    button4.Text = "الكربون";

                    correctAnswer = 2;

                    break;
                case 15:

                    pictureBox1.Image = Properties.Resources.Aristotle;

                    lblQuestion.Text = "ما هو اسم الفيلسوف اليوناني الذي عاش في القرن الرابع قبل الميلاد ويعتبر أحد أشهر الفلاسفة في التاريخ؟";

                    button1.Text = "سقراط";
                    button2.Text = "أرسطو";
                    button3.Text = "بلاتون";
                    button4.Text = "ديمقراطيس";

                    correctAnswer = 2;

                    break;
                case 16:

                    pictureBox1.Image = Properties.Resources.coding;

                    lblQuestion.Text = "ما هي لغة البرمجة التي تستخدم في تطوير تطبيقات الأندرويد؟\r\n";

                    button1.Text = "جافا";
                    button2.Text = "سي شارب";
                    button3.Text = "بيثون";
                    button4.Text = "جافا سكريبت";

                    correctAnswer = 1;

                    break;
                case 17:

                    pictureBox1.Image = Properties.Resources.leonardoDaVinci;

                    lblQuestion.Text = "من هو الرسام الإيطالي المشهور لوحته الشهيرة العشاء الأخير؟";

                    button1.Text = "ليوناردو دافنشي";
                    button2.Text = "رافائيل";
                    button3.Text = "مايكل أنجلو";
                    button4.Text = "بيكاسو";

                    correctAnswer = 1;

                    break;
                case 18:

                    pictureBox1.Image = Properties.Resources.lang;

                    lblQuestion.Text = "ما هي اللغة الأكثر تحدثاً في العالم؟";

                    button1.Text = "الإنجليزية";
                    button2.Text = "الصينية";
                    button3.Text = "الهندية";
                    button4.Text = "الإسبانية";

                    correctAnswer = 2;

                    break;

                case 19:

                    pictureBox1.Image = Properties.Resources.countires;

                    lblQuestion.Text = "كم عدد دول العالم؟";

                    button1.Text = "177";
                    button2.Text = "195";
                    button3.Text = "212";
                    button4.Text = "243";

                    correctAnswer = 2;

                    break;

                case 20:

                    pictureBox1.Image = Properties.Resources.moonWalker;

                    lblQuestion.Text = "ما هو اسم أول رائد فضاء يمشي على سطح القمر؟";

                    button1.Text = "بوز ألدرين";
                    button2.Text = "نيل أرمسترونج";
                    button3.Text = "مايكل كولينز";
                    button4.Text = "يوري غاغارين";

                    correctAnswer = 2;

                    break;

            }
            // Pause the program execution for 1 second
            System.Threading.Thread.Sleep(500);

            // reset button colors and enable answer buttons
            button1.BackColor = Color.DarkCyan;
            button2.BackColor = Color.DarkCyan;
            button3.BackColor = Color.DarkCyan;
            button4.BackColor = Color.DarkCyan;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TotalQuestionsLabel.Text = "عدد الأسئلة: " + totalQuestions;
            correctAnswersLabel.Text = "الأجابات الصحيحة: " + 0;
            WrongAnswersLabel.Text = "الأجابات الخاطئة: " + 0;
        }

        private void FullScreenClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ExitFullScreenClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }


        private void finishClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void playAgainClick(object sender, EventArgs e)
        {
            if (questionNumber > 1)
            {
                // reset score and question number and start quiz again
                score = 0;
                correctAnswer = 0;
                correctAnswers = 0;
                wrongAnswers = 0;
                questionNumber = 1;
                correctAnswersLabel.Text = "الأجابات الصحيحة: " + 0;
                WrongAnswersLabel.Text = "الأجابات الخاطئة: " + 0;
                askQuestion(questionNumber);
            }
        }
    }
}