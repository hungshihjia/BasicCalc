using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        int numberA, numberB;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumA.Text.Trim(), out numberA) && int.TryParse(txtNumB.Text.Trim(), out numberB))
            {
                switch (txtLogic.Text.Trim())
                {
                    case "":
                    case "1":
                        Show(numberA, numberB, "+");
                        break;
                    case "2":
                        Show(numberA, numberB, "-");
                        break;
                    case "3":
                        Show(numberA, numberB, "*");
                        break;
                    case "4":
                        Show(numberA, numberB, "/");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("請輸入要計算的數字!!");
            }
        }

        private void Show(int intA, int intB, string strLogic)
        {
            if (!(intB == 0 && strLogic == "/"))
            {
                MessageBox.Show((intA + strLogic + intB).ToString());
            }
            else
            {
                MessageBox.Show("無法除於0，數字B請輸入非0值 !!");
            }
        }
    }
}
