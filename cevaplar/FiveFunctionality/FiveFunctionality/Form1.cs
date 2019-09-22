using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveFunctionality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstFuncTxtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstFunctionButton1_Click(object sender, EventArgs e)
        {
            firstFuncTxtBox4.Text = Convert.ToString((Convert.ToDouble(firstFuncTxtBox1.Text.ToString()) + Convert.ToDouble(firstFuncTxtBox2.Text.ToString())) * Convert.ToDouble(firstFuncTxtBox3.Text.ToString()));
        }

        private void FifthFuncBotton1_Click(object sender, EventArgs e)
        {
            string fibonacci = "";
            int number1 = 1;
            int number2 = 1;
            int fibonacciResult = 0;
            fibonacci = fifthFuncTxtBox1.Text.ToString();
            int fibonacciSayisi = Convert.ToInt32(fibonacci);

            if (fibonacciSayisi == 1)
            {
                fibonacciResult = 0;
            }
            else if (fibonacciSayisi == 2)
            {
                fibonacciResult = 1;
            }
            else if (fibonacciSayisi == 3)
            {
                fibonacciResult = 1;
            }
            else
            {
                for (int i = 3; i < fibonacciSayisi; i++)
                {
                        fibonacciResult = number1 + number2;
                        number1 = number2;
                        number2 = fibonacciResult;
                }
            }
                
            
            fifthFuncTxtBox2.Text = Convert.ToString(fibonacciResult);

        }

        private void SecondFuncButton1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 200; i++)
            {
                
                if (i % 3 == 0 && i % 5 == 0&&i>=100)
                {
                    SecondFuncTxtBox1.Text += "zagzig  ";
                    continue;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    SecondFuncTxtBox1.Text += "zigzag  ";
                    continue;
                }

                if(i % 3 == 0)
                {
                    SecondFuncTxtBox1.Text += "zig  ";
                    continue;
                }
                if (i % 5 == 0)
                {
                    SecondFuncTxtBox1.Text += "zag  ";
                    continue;
                }
                

                SecondFuncTxtBox1.Text += i + "  ";

            }
        }

        private void ThirdFuncButton1_Click(object sender, EventArgs e)
        {
            string thirdFuncString = thirdFuncTxtBox1.Text.ToString();
            int thirdFuncSayac = Convert.ToInt32(thirdFuncString);
            thirdFuncTxtBox2.Clear();
            if (thirdFuncSayac > 15)
            {
                thirdFuncTxtBox2.Text = "Lütfen 1 den 15 e kadar bir tam sayı giriniz...";
            }
            else
            {
                for (int i = 0; i <= thirdFuncSayac; i++)
                {

                    for (int j = 0; j <= thirdFuncSayac; j++)
                    {
                        if (i * j >= 100)
                        {
                            thirdFuncTxtBox2.Text += String.Format("{0,6}", i * j);
                            //thirdFuncTxtBox2.Text += i * j + "";
                            continue;
                        }
                        if (i * j >= 10)
                        {
                            thirdFuncTxtBox2.Text += String.Format("{0,7}", i * j);
                            //thirdFuncTxtBox2.Text += i * j + "  ";
                            continue;
                        }
                        if (j == 0 && i != 0)
                        {
                            if (i >= 10)
                            {
                                thirdFuncTxtBox2.Text += String.Format("{0,7}", i);
                            }
                            else
                            {
                                thirdFuncTxtBox2.Text += String.Format("{0,8}", i);
                            }
                            

                            //thirdFuncTxtBox2.Text += i + "    ";
                            continue;
                        }
                        if (i == 0)
                        {
                            if (j >= 10)
                            {
                                thirdFuncTxtBox2.Text += String.Format("{0,7}", j);
                            }
                            else
                            {
                                thirdFuncTxtBox2.Text += String.Format("{0,8}", j);
                            }
                            
                            //thirdFuncTxtBox2.Text += j + "    ";
                            continue;
                        }
                        
                        
                        thirdFuncTxtBox2.Text += String.Format("{0,8}",i*j);
                        //thirdFuncTxtBox2.Text += i * j + "    ";
                    }

                    thirdFuncTxtBox2.AppendText(Environment.NewLine);
                }
            }
            

        } 

        private void FourthFuncButton1_Click(object sender, EventArgs e)
        {
            fourthFuncTxtBox1.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string directoryFile = string.Empty;
            string fileName = string.Empty;
            openFileDialog.Filter = "Text File | *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                directoryFile = openFileDialog.FileName;
                fileName = openFileDialog.SafeFileName;
                string file = directoryFile;
                FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);

                StreamReader streamReader = new StreamReader(fileStream);
                string words = streamReader.ReadToEnd();
                string wordsTrim = Regex.Replace(words, @"s+", "").Trim();
                wordsTrim = wordsTrim.Replace('\t', 'x');
                wordsTrim = wordsTrim.Replace('\n', 'x');
                wordsTrim = wordsTrim.Replace('\r', 'x');
                wordsTrim = wordsTrim.Replace(' ' , 'x');
                wordsTrim = wordsTrim.Replace("xx","x");
                wordsTrim = wordsTrim.Replace("xxx", "x");
                wordsTrim = wordsTrim.Replace("xxxx", "x");
                wordsTrim = wordsTrim.Replace("xxxxx", "x");
                wordsTrim = wordsTrim.Replace("xx", "x");
                char [] hole = {'x'};
                string[] wordsSplit = wordsTrim.Split(hole);
                double[] value = new double[wordsSplit.Length];
                for(int i = 0; i < wordsSplit.Length; i++)
                {
                    double.TryParse(wordsSplit[i], out value[i]);
                    
                }
                double tempValue = 0;
                for (int j = 0; j < wordsSplit.Length-1; j++)
                {
                    for (int k = 1; k < wordsSplit.Length-j; k++)
                    {
                        if (value[k] > value[k - 1])
                        {
                            tempValue = value[k - 1];
                            value[k - 1] = value[k];
                            value[k] = tempValue;
                        }
                    }
                }
                for(int t = 0; t < wordsSplit.Length; t++)
                {
                    fourthFuncTxtBox1.Text += value[t] + "   ";
                }

                streamReader.Close();
                fileStream.Close();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
