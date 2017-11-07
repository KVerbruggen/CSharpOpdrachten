using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsOfTheWorld
{
    public partial class FormQuiz : Form
    {
        private int numberOfQuestions = 10;

        new private Form ParentForm { get; set; }
        private Button SubmitButton;

        private Quiz Quiz { get; set; }
        private Flag CurrentFlag { get; set; }

        public FormQuiz(Form parentForm, Category category)
        {
            ParentForm = parentForm;
            this.AcceptButton = btSubmit;

            this.StartPosition = new FormStartPosition();
            Main.ConvertCoordinates(ParentForm, this);

            InitializeComponent();

            SubmitButton = btSubmit;
            this.Text = "Flags of the World - " + category.Name;
            Quiz = new Quiz(category.Flags, numberOfQuestions);
            LoadNextQuestion();
            ShowQuestion();
        }

        private void UpdateControls()
        {
            pbFlag.Image = CurrentFlag.Image;
            lblQuestionNumber.Text = "Question " + Quiz.QuestionIndex + "/" + numberOfQuestions;
            tbAnswer.Text = String.Empty;
        }

        private void LoadNextQuestion()
        {
            CurrentFlag = Quiz.GetNextQuestion();
            if (CurrentFlag == null)
            {
                Finish();
            }
            else
            {
                UpdateControls();
            }
        }

        private void Submit()
        {
            bool correct = Quiz.Answer(tbAnswer.Text);
            UpdateControls();
            HideQuestion();
            ShowAnswer(correct);
        }

        private void ShowQuestion()
        {
            pbFlag.Visible = true;
            lblQuestion.Visible = true;
            tbAnswer.Visible = true;
            btSubmit.Visible = true;
            SubmitButton = btSubmit;
            UpdateControls();
            tbAnswer.Select();
        }

        private void HideQuestion()
        {
            pbFlag.Visible = false;
            lblQuestion.Visible = false;
            tbAnswer.Visible = false;
            btSubmit.Visible = false;
        }

        private void ShowAnswer(bool isCorrect)
        {
            if (isCorrect)
            {
                this.BackColor = Color.Green;
                lblInfo.Text = "Correct!";
                lblInfo2.Text = String.Empty;
            }
            else
            {
                this.BackColor = Color.Red;
                lblInfo.Text = "Incorrect!";
                lblInfo2.Text = "The correct answer is: " + Environment.NewLine + CurrentFlag.Country[0];
            }
            lblInfo.Visible = true;
            lblInfo2.Visible = true;
            btNext.Visible = true;
            SubmitButton = btNext;
            btNext.Focus();
        }

        private void HideAnswer()
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
            lblInfo.Visible = false;
            lblInfo2.Visible = false;
            btNext.Visible = false;
            lblInfo.Text = String.Empty;
            lblInfo2.Text = String.Empty;
        }

        private void Finish()
        {
            HideQuestion();
            HideAnswer();
            lblInfo.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            lblInfo.Text = "You scored " + Quiz.Score + "/" + Quiz.GetMaxScore();
            lblInfo2.Text = String.Empty;
            if (Quiz.Score >= (Quiz.GetMaxScore() * 0.8))
            {
                lblInfo2.Text += "Great job!";
            }
            btBack.Visible = false;
            lblQuestionNumber.Visible = false;
            lblInfo.Visible = true;
            lblInfo2.Visible = true;
            btFinished.Visible = true;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (Quiz.CheckFinished())
            {
                Finish();
            }
            else
            {
                CurrentFlag = Quiz.GetNextQuestion();
                HideAnswer();
                LoadNextQuestion();
                ShowQuestion();
            }
        }

        private void FormQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ConvertCoordinates(this, ParentForm);
            ParentForm.Visible = true;
        }

        // Submit the answer when pressing Enter, without annoying 'Ding' sound.
        // source: https://stackoverflow.com/questions/25012924/accept-button-doesnt-work
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (SubmitButton != btSubmit || tbAnswer.Text != String.Empty)
                {
                    SubmitButton.PerformClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btFinished_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
