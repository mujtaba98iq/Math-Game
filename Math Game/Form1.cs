using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form1 : Form
    {
        public string HardLevel { get; set; }
        public string TypeOption { get; set; }
        public int NumberQuestions { get; set; }

      public string stMark { get; set; }
      public string stEnterInputString { get; set; }
      public string stCheck{ get; set; }
      public  string stNext{ get; set; }
        int To;
        int From;
        public Form1()
        {
            InitializeComponent();
        }

       struct stGameStatue
        {
           public int RandomNumberOne;
          public int RandomNumberTow;
          public int NumberTrueAnswer;
          public int NumberFalseAnswer;
            public int NumberOfRound;
        }
        stGameStatue GameInfo;
        enum enHardLevel
        {
            enEsey,
            enMidum,
            enHard,
            enMix
        }
        enum enTypeOfOperation
        {
            enSum,
            enSub,
            enMuti,
            enDiv,
            enMix
        }
      
      
      
        void ShowTypeOperator()
        {
            lblOpType.Text = TypeOption;
        }


        void GenerateRandomTowNumbers(int From, int To)
        {
            Random random = new Random();

            GameInfo.RandomNumberOne = random.Next(From, To);
            GameInfo. RandomNumberTow = random.Next(From, To);

        }


       


        private void label2_Click(object sender, EventArgs e)
        {

        }

        void ShowQuestion()
        {
            lblNumberOne.Text = GameInfo.RandomNumberOne.ToString();
            lblNumberTow.Text = GameInfo.RandomNumberTow.ToString();
        }

        void ShowNumberOfRounds()
        {
            GameInfo.NumberOfRound += 1;
            lblNumberRound.Text = GameInfo.NumberOfRound.ToString() + "/" + NumberQuestions;
        }
        void ShowGameStatus(int From, int To)
        {
            GenerateRandomTowNumbers(From, To);
            ShowTypeOperator();
            ShowQuestion();
            ShowNumberOfRounds();
        }
        void StartGame()
        {
            lblEnterInput.Text = stEnterInputString;
            btCheck.Text = stCheck;
            btNext.Text = stNext;
            switch (HardLevel)
            {
                case "سهل":
                    ShowGameStatus(1, 10);
                    To = 10;
                    From = 1;
                    break;
                case "متوسط":
                    ShowGameStatus(10, 100);
                    From = 10;
                    To = 100;
                    break;
                case "صعب":
                    ShowGameStatus(100, 1000);
                    From = 100;
                    To = 1000;
                    break;
                case "مشكل يالوز":
                    ShowGameStatus(1, 1000);
                    From = 1;
                    To = 1000;
                    break;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();


        }

        float CalculateTheResult()
        {
            switch (TypeOption)
            {
                case "+":
                    return GameInfo.RandomNumberOne + GameInfo.RandomNumberTow;

                case "-":
                    return GameInfo.RandomNumberOne - GameInfo.RandomNumberTow;

                case "*":
                    return GameInfo.RandomNumberOne * GameInfo.RandomNumberTow;

                case "/":
                    return GameInfo.RandomNumberOne / GameInfo.RandomNumberTow;

                case "Mix":

                    return GameInfo.RandomNumberOne + GameInfo.RandomNumberTow;

            }
            return 0;
        }
        bool IsEndOfGame()
        {
            if(GameInfo.NumberOfRound >= NumberQuestions)
            {
                return true;
            }
            return false;
        }
        void RestartOfGame()
        {
            if( MessageBox.Show("انتهت اللعبه! هل تريد اللعب مجددا؟","العب مجددا", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                lblNumberOfTrue.Text = "0";
                lblNumberOfFalse.Text = "0";
                GameInfo.NumberOfRound = 0;
                GameInfo.NumberFalseAnswer = 0;
                GameInfo.NumberTrueAnswer = 0;
                lblNumberRound.Text = GameInfo.NumberOfRound.ToString()+"/"+NumberQuestions;
                btCheck.Visible = true;
                btNext.Visible = true;
                btNext.Enabled = false;
                txtAnswer.Enabled = true;
                ShowGameStatus(1, To);
            }
            else
            {
                this.Close();
            }
            
        }
        void EndOfGame()
        {
            btCheck.Visible = false;
            btNext.Visible = false;
            txtAnswer.Enabled = false;
            RestartOfGame();

        }
        void ShowTheResult(bool IsAnswerTrue)
        {
            txtAnswer.Text = "";
           
            if (IsAnswerTrue)
            {
                lblMark.BackColor = Color.Green;
                lblMark.Text = stMark;
                lblMark.Visible = true;
                GameInfo.NumberTrueAnswer +=1;
                lblNumberOfTrue.Text = GameInfo.NumberTrueAnswer.ToString();
            }
            else
            {
                lblMark.BackColor = Color.Red;
                if(stMark== "Very Good")
                {
                    lblMark.Text = "Wrong Answer!:-(";
                }
                else
                {
                    lblMark.Text = " اجابه غير صحيحيه";

                }
                lblMark.Visible = true;
                GameInfo.NumberFalseAnswer +=1;
                lblNumberOfFalse.Text = GameInfo.NumberFalseAnswer.ToString();
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            txtAnswer.Enabled = false;
            btCheck.Enabled = false;
            btNext.Enabled = true;
            if(txtAnswer.Text==(CalculateTheResult().ToString()))
            {
                ShowTheResult(true);
            }
            else
            {
                ShowTheResult(false);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsEndOfGame())
            {
                EndOfGame();
                return;
            }
            txtAnswer.Enabled = true;
            btCheck.Enabled=true;
            btNext.Enabled=false;
            txtAnswer.Focus();
            ShowGameStatus(From,To);
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if(txtAnswer.Text != "")
            {
                btCheck.Enabled = true;
            }
            else
            {
                btCheck.Enabled = false;
                
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
