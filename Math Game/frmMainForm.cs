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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        struct stGameSystem
        {
            public string stHardLevel;
            public string stTypeOption;
            public int stNumberQuestions;
            public string stLanguage;
        }
        struct stForm1Info
        {
            public string stMark;
            public string stEnterInputString;
            public string stCheck;
            public string stNext;
        }
        stForm1Info From1Info;
        stGameSystem GameSystem;
       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameSystem.stHardLevel= cbLevel.Text;   
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameSystem.stTypeOption= cbOperation.Text;
        }

        private void txtNumberQuestions_TextChanged(object sender, EventArgs e)
        {
            if(txtNumberQuestions.Text!="")
            {
                GameSystem.stNumberQuestions = Convert.ToInt32(txtNumberQuestions.Text);
            }
            else
            {
                MessageBox.Show("Number of Question Shouldn't be Empty!");
            }
        }
        void FillstSystemInfo(string Mark,string EnterInput,string Check,string Next)
        {
            From1Info.stMark = Mark;
            From1Info.stEnterInputString = EnterInput;
            From1Info.stCheck = Check;
            From1Info.stNext = Next;
        }
        void FillInfoForm1()
        {
            Form1 frm1 = new Form1();

            frm1.HardLevel = GameSystem.stHardLevel;
            frm1.TypeOption = GameSystem.stTypeOption;
            frm1.NumberQuestions = GameSystem.stNumberQuestions;
            frm1.stMark = From1Info.stMark;
            frm1.stEnterInputString = From1Info.stEnterInputString;
            frm1.stCheck = From1Info.stCheck;
            frm1.stNext = From1Info.stNext;
            frm1.NumberQuestions = GameSystem.stNumberQuestions;
            frm1.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

            if(GameSystem.stLanguage=="عربي")
            {
                FillstSystemInfo("احسنت اجابه صحيحه", "ادخل الاجابه الصحيحه", "فحص الاجابه", "التالي");
              
            }
            else
            {
                FillstSystemInfo("Very Good", "Enter The Input ", "Check", "Next");
            
            }
            FillInfoForm1();
        }

        void FillMainFormInfo(string LanguageString,string ChoiseLangeueString,string LevelString,
            string TypeOpString,string NumberOfQuestionsString,string StrartString)
        {
            GameSystem.stLanguage = cbLanguage.Text.ToString();
            GameSystem.stLanguage = LanguageString;
            lblChoseLanguage.Text = ChoiseLangeueString;
            lblLevel.Text = LevelString;
            lblOpType.Text =TypeOpString;
            lblNumberOfQuestions.Text =NumberOfQuestionsString;
            btStart.Text = StrartString;
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cbLanguage.SelectedIndex==0)
            {
                FillMainFormInfo("عربي", "اختيار اللغه", "مستوى الصعوبه", "نوع العمليه", "عدد الاسئله", "البدأ");
            }
            else
            {
                FillMainFormInfo("English", "Chose Language", "Level", "Type Opration", "Number Of Questions", "Start");
            }
        }
      
            void DefultChoise()
        {
            cbLanguage.SelectedIndex = 0;
            cbLevel.SelectedIndex = 0;
            cbOperation.SelectedIndex = 0;
            txtNumberQuestions.Text = 2.ToString();
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            DefultChoise();
            GameSystem.stLanguage = "عربي";
        }
    }
}
