using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        BL.Calc C;
        int k; // С помощью k будем считать количество нажатий кнопки MRC
        public Form1()
        {
            InitializeComponent();

            C = new BL.Calc();

            lbDistpley.Text = "0";

        }

        #region Вспомагательые методы
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (lbDistpley.Text.IndexOf("∞") != -1)
            {
                lbDistpley.Text = lbDistpley.Text.Substring(0, lbDistpley.Text.Length - 1);
            }

            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (lbDistpley.Text[0] == '0' && (lbDistpley.Text.IndexOf(",") != 1))
            {
                lbDistpley.Text = lbDistpley.Text.Remove(0, 1);
            }

            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (lbDistpley.Text[0] == '-')
            {
                if (lbDistpley.Text[1] == '0' && (lbDistpley.Text.IndexOf(",") != 2))
                {
                    lbDistpley.Text = lbDistpley.Text.Remove(1, 1);
                }
            }
        }

        /// <summary>
        /// Проверка для недопущения нажатия других мат. операций, если какая-либо уже нажата.
        /// </summary>
        /// <returns></returns>
        private bool CanPress()
        {
            if (!btMultiplication.Enabled)
            {
                return false;
            }
            if (!btDivision.Enabled)
            {
                return false;
            }
            if (!btSum.Enabled)
            {
                return false;
            }
            if (!btSubtraction.Enabled)
            {
                return false;
            }
            if (!btSqrtX.Enabled)
            {
                return false;
            }
            if (!btXSquareY.Enabled)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Снимает нажатия со всех кнопок математических операций калькулятора, требующих два операнда.
        /// </summary>
        private void FreeButtons()
        {
            btMultiplication.Enabled = true;
            btDivision.Enabled = true;
            btSum.Enabled = true;
            btSubtraction.Enabled = true;
            btSqrtX.Enabled = true;
            btXSquareY.Enabled = true;
        }
        #endregion

        /// <summary>
        /// Очистка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCE_Click(object sender, EventArgs e)
        {
            lbDistpley.Text = "0";

            C.Clear_A();
            FreeButtons();
            k = 0;
        }

        /// <summary>
        /// Изменения знака
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRev_Click(object sender, EventArgs e)
        {
            if (lbDistpley.Text[0] == '-')
            {
                lbDistpley.Text = lbDistpley.Text.Remove(0, 1);
            }
            else
            {
                lbDistpley.Text = "-" + lbDistpley.Text;
            }
        }

        private void btZapitai_Click(object sender, EventArgs e)
        {
            if((lbDistpley.Text.IndexOf(",")==-1)&& lbDistpley.Text.IndexOf("∞") == -1)
            {
                lbDistpley.Text += ",";
            }
        }


        #region 0,1,2,3,4,5,6,7,8,,9
        private void btZero_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "0";
            CorrectNumber();
        }

        private void btOne_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "1";
            CorrectNumber();
        }

        private void btTwo_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "2";
            CorrectNumber();
        }

        private void btThree_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "3";
            CorrectNumber();
        }

        private void btFour_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "4";
            CorrectNumber();
        }

        private void btFife_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "5";
            CorrectNumber();
        }

        private void btSix_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "6";
            CorrectNumber();
        }

        private void btSeven_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "7";
            CorrectNumber();
        }

        private void btEig_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "8";
            CorrectNumber();
        }

        private void btNine_Click(object sender, EventArgs e)
        {
            lbDistpley.Text += "9";
            CorrectNumber();
        }


        #endregion

        private void btRavno_Click(object sender, EventArgs e)
        {
            if (!btMultiplication.Enabled)
            {
                lbDistpley.Text = C.Multiplication(Convert.ToDouble(lbDistpley.Text)).ToString();
            }
            if (!btDivision.Enabled)
            {
                lbDistpley.Text = C.Division(Convert.ToDouble(lbDistpley.Text)).ToString();
            }
            if (!btSum.Enabled)
            {
                lbDistpley.Text = C.Sum(Convert.ToDouble(lbDistpley.Text)).ToString();
            }
            if (!btSubtraction.Enabled)
            {
                lbDistpley.Text = C.Subtraction(Convert.ToDouble(lbDistpley.Text)).ToString();
            }
            if (!btSqrtX.Enabled)
            {
                lbDistpley.Text = C.SqrtX(Convert.ToDouble(lbDistpley.Text)).ToString();
            }
            if (!btXSquareY.Enabled)
            {
                 lbDistpley.Text = C.Degree(Convert.ToDouble(lbDistpley.Text)).ToString();
            }

            C.Clear_A();
            FreeButtons();
            k = 0;
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));

                btMultiplication.Enabled = false;
                lbDistpley.Text = "0";
            }
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));
                btDivision.Enabled = false;
                lbDistpley.Text = "0";
            }
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));
                btSum.Enabled = false;
                lbDistpley.Text = "0";
            }
        }

        private void btSubtraction_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));
                btSubtraction.Enabled = false;
                lbDistpley.Text = "0";
            }
        }

        private void btXSquareY_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));
                btXSquareY.Enabled = false;
                lbDistpley.Text = "0";
            }
        }

        private void btSqrtX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));
                btSqrtX.Enabled = false;
                lbDistpley.Text = "0";
            }
        }

        private void btSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));

                lbDistpley.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void btSquareX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lbDistpley.Text));

                lbDistpley.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void btFactiroal_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(lbDistpley.Text) == (int)(Convert.ToDouble(lbDistpley.Text))) &&
                    ((Convert.ToDouble(lbDistpley.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(lbDistpley.Text));

                    lbDistpley.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }

        #region M
        private void btMSum_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(lbDistpley.Text));
        }

        private void btMSubtraction_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(lbDistpley.Text));
        }

        private void btMMultiplication_Click(object sender, EventArgs e)
        {
            C.M_Multiplication(Convert.ToDouble(lbDistpley.Text));
        }

        private void btMDivision_Click(object sender, EventArgs e)
        {
            C.M_Division(Convert.ToDouble(lbDistpley.Text));
        }

        #endregion

        private void btMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;
                if (k == 1)
                {
                    lbDistpley.Text = C.MemoryShow().ToString();
                }
                if (k == 2)
                {
                    C.Memory_Clear();
                    lbDistpley.Text = "0";
                    k = 0;
                }
            }
        }
    }
}