using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string kq = "";
                string[] mang = textBox1.Text.Split(' ');
                for (int i = 0; i < mang.Length; i++)
                {
                    for (int j = 0; j < mang[i].Length; j++)
                    {
                        if (mang[i][j] == 'A' || mang[i][j] == 'a')
                        {
                            kq += ".-|";
                            textBox2.Text = kq;

                        }
                        else if (mang[i][j] == 'B' || mang[i][j] == 'b')
                        {
                            kq += "-...|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'C' || mang[i][j] == 'c')
                        {
                            kq += "-.-.|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'D' || mang[i][j] == 'd')
                        {
                            kq += "-..|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'E' || mang[i][j] == 'e')
                        {
                            kq += ".|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'F' || mang[i][j] == 'f')
                        {
                            kq += "..-.|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'G' || mang[i][j] == 'g')
                        {
                            kq += "--.|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'H' || mang[i][j] == 'h')
                        {
                            kq += "....|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'I' || mang[i][j] == 'i')
                        {
                            kq += "..|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'J' || mang[i][j] == 'j')
                        {
                            kq += ".---|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'K' || mang[i][j] == 'k')
                        {
                            kq += "-.-|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'L' || mang[i][j] == 'l')
                        {
                            kq += ".-..|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'M' || mang[i][j] == 'm')
                        {
                            kq += "--|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'N' || mang[i][j] == 'n')
                        {
                            kq += "-.|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'O' || mang[i][j] == 'o')
                        {
                            kq += "---|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'P' || mang[i][j] == 'p')
                        {
                            kq += ".--.|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'Q' || mang[i][j] == 'q')
                        {
                            kq += "--.-|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'R' || mang[i][j] == 'r')
                        {
                            kq += ".-.|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'S' || mang[i][j] == 's')
                        {
                            kq += "...|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'T' || mang[i][j] == 't')
                        {
                            kq += "-|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'U' || mang[i][j] == 'u')
                        {
                            kq += "..-|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'V' || mang[i][j] == 'v')
                        {
                            kq += "...-|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'W' || mang[i][j] == 'w')
                        {
                            kq += ".--|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'X' || mang[i][j] == 'x')
                        {
                            kq += "-..-|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'Y' || mang[i][j] == 'y')
                        {
                            kq += "-.--|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == 'Z' || mang[i][j] == 'z')
                        {
                            kq += "--..|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '0')
                        {
                            kq += "-----|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '1')
                        {
                            kq += ".----|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '2')
                        {
                            kq += "..---";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '3')
                        {
                            kq += "...--|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '4')
                        {
                            kq += "....-|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '5')
                        {
                            kq += ".....|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '6')
                        {
                            kq += "-....|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '7')
                        {
                            kq += "--...|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '8')
                        {
                            kq += "---..|";
                            textBox2.Text = kq;
                        }
                        else if (mang[i][j] == '9')
                        {
                            kq += "----.|";
                            textBox2.Text = kq;
                        }
                    }
                    kq += "/";
                }
            }
            else
            {
                string[] mang = textBox1.Text.Split('/');
                textBox2.Text = "";
                for (int i = 0; i < mang.Length; i++)
                {
                    string kq = "";
                    string[] kyTuTrongTu = mang[i].Split('|');
                    for (int j = 0; j < kyTuTrongTu.Length; j++)
                    {
                        if (kyTuTrongTu[j] == ".-")
                        {
                            if (j == 0)
                            {
                                kq += "A";
                            }
                            else
                            {
                                kq += "a";

                            }
                        }
                        else if (kyTuTrongTu[j] == "-...")
                        {
                            if (j == 0)
                            {
                                kq += "B";

                            }
                            else
                            {
                                kq += "b";

                            }
                        }
                        else if (kyTuTrongTu[j] == "-.-.")
                        {
                            if (j == 0)
                            {
                                kq += "C";

                            }
                            else
                            {
                                kq += "c";

                            }
                        }
                        else if (kyTuTrongTu[j] == "-..")
                        {
                            if (j == 0)
                            {
                                kq += "D";

                            }
                            else
                            {
                                kq += "d";

                            }
                        }
                        else if (kyTuTrongTu[j] == ".")
                        {
                            if (j == 0)
                            {
                                kq += "E";

                            }
                            else
                            {
                                kq += "e";

                            }
                        }
                        else if (kyTuTrongTu[j] == "..-.")
                        {
                            if (j == 0)
                            {
                                kq += "F";

                            }
                            else
                            {
                                kq += "f";

                            }
                        }
                        else if (kyTuTrongTu[j] == "--.")
                        {
                            if (j == 0)
                            {
                                kq += "G";

                            }
                            else
                            {
                                kq += "g";

                            }
                        }
                        else if (kyTuTrongTu[j] == "....")
                        {
                            if (j == 0)
                            {
                                kq += "H";

                            }
                            else
                            {
                                kq += "h";

                            }
                        }
                        else if (kyTuTrongTu[j] == "..")
                        {
                            if (j == 0)
                            {
                                kq += "I";

                            }
                            else
                            {
                                kq += "i";

                            }
                        }
                        else if (kyTuTrongTu[j] == ".---")
                        {
                            if (j == 0)
                            {
                                kq += "J";

                            }
                            else
                            {
                                kq += "j";

                            }
                        }
                        else if (kyTuTrongTu[j] == "-.-")
                        {
                            if (j == 0)
                            {
                                kq += "K";

                            }
                            else
                            {
                                kq += "k";

                            }
                        }
                        else if (kyTuTrongTu[j] == ".-..")
                        {
                            if (j == 0)
                            {
                                kq += "L";

                            }
                            else
                            {
                                kq += "l";
                            }
                        }
                        else if (kyTuTrongTu[j] == "--")
                        {
                            if (j == 0)
                            {
                                kq += "M";
                            }
                            else
                            {
                                kq += "m";
                            }
                        }
                        else if (kyTuTrongTu[j] == "-.")
                        {
                            if (j == 0)
                            {
                                kq += "N";
                            }
                            else
                            {
                                kq += "n";
                            }
                        }
                        else if (kyTuTrongTu[j] == "---")
                        {
                            if (j == 0)
                            {
                                kq += "O";
                            }
                            else
                            {
                                kq += "o";
                            }
                        }
                        else if (kyTuTrongTu[j] == ".--.")
                        {
                            if (j == 0)
                            {
                                kq += "P";
                            }
                            else
                            {
                                kq += "p";
                            }
                        }
                        else if (kyTuTrongTu[j] == "--.-")
                        {
                            if (j == 0)
                            {
                                kq += "Q";
                            }
                            else
                            {
                                kq += "q";
                            }
                        }
                        else if (kyTuTrongTu[j] == ".-.")
                        {
                            if (j == 0)
                            {
                                kq += "R";
                            }
                            else
                            {
                                kq += "r";
                            }
                        }
                        else if (kyTuTrongTu[j] == "...")
                        {
                            if (j == 0)
                            {
                                kq += "S";
                            }
                            else
                            {
                                kq += "s";
                            }
                        }
                        else if (kyTuTrongTu[j] == "-")
                        {
                            if (j == 0)
                            {
                                kq += "T";
                            }
                            else
                            {
                                kq += "t";
                            }
                        }
                        else if (kyTuTrongTu[j] == "..-")
                        {
                            if (j == 0)
                            {
                                kq += "U";
                            }
                            else
                            {
                                kq += "u";
                            }
                        }
                        else if (kyTuTrongTu[j] == "...-")
                        {
                            if (j == 0)
                            {
                                kq += "V";

                            }
                            else
                            {
                                kq += "v";

                            }
                        }
                        else if (kyTuTrongTu[j] == ".--")
                        {
                            if (j == 0)
                            {
                                kq += "W";

                            }
                            else
                            {
                                kq += "w";

                            }
                        }
                        else if (kyTuTrongTu[j] == "-..-")
                        {
                            if (j == 0)
                            {
                                kq += "X";

                            }
                            else
                            {
                                kq += "x";

                            }
                        }
                        else if (kyTuTrongTu[j] == "-.--")
                        {
                            if (j == 0)
                            {
                                kq += "Y";

                            }
                            else
                            {
                                kq += "y";

                            }
                        }
                        else if (kyTuTrongTu[j] == "--..")
                        {
                            if (j == 0)
                            {
                                kq += "Z";

                            }
                            else
                            {
                                kq += "z";

                            }
                        }
                        else if (kyTuTrongTu[j] == "-----")
                        {
                            kq += "0";

                        }
                        else if (kyTuTrongTu[j] == ".----")
                        {
                            kq += "1";

                        }
                        else if (kyTuTrongTu[j] == "..---")
                        {
                            kq += "2";

                        }
                        else if (kyTuTrongTu[j] == "...--")
                        {
                            kq += "3";

                        }
                        else if (kyTuTrongTu[j] == "....-")
                        {
                            kq += "4";

                        }
                        else if (kyTuTrongTu[j] == ".....")
                        {
                            kq += "5";

                        }
                        else if (kyTuTrongTu[j] == "-....")
                        {
                            kq += "6";

                        }
                        else if (kyTuTrongTu[j] == "--...")
                        {
                            kq += "7";

                        }
                        else if (kyTuTrongTu[j] == "---..")
                        {
                            kq += "8";

                        }
                        else if (kyTuTrongTu[j] == "----.")
                        {
                            kq += "9";

                        }
                    }
                    textBox2.Text += kq + " ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Check - Chuyển đổi từ chữ sang mã Morse" + "\nUncheck - Chuyển từ mã Morse sang chữ" +
                "\n\nLưu ý: Mỗi kí tự Morse cách nhau bằng dấu | và mỗi từ cách nhau bởi dấu / ", "Cách sử dụng");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check - Chuyển từ chữ sang mã Vigenère" + "\nUncheck - Chuyển từ mã Vigenère sang chữ",
                "Cách sử dụng");
            MessageBox.Show("- Trước hết bạn phải có từ gốc và từ Key" +
                            "\n- Key được tạo ra bằng cách chọn một từ và lặp lại cho đến khi" + "\n" +
                            "tổng kí tự của Key = tổng kí tự của từ gốc " + "\n\nVD:" +
                            "\nTừ gốc: AttackAtFiveAM có 14 kí tự" + "\nKey: SchoolSchoolSc có 14 kí tự" +
                            "\n\nĐể giải mã bạn cần có Key và mật mã cần giải", "Qui tắc");
        }

        private char[,] bangMa = new char[26, 26];
        private char[] cotDoc = new char[26];
        private char[] cotNgang = new char[26];

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cotDoc.Length; i++)
            {
                cotDoc[i] = Convert.ToChar('A' + i);
                cotNgang[i] = Convert.ToChar('A' + i);
            }

            for (int i = 0; i < bangMa.GetLength(0); i++)
            {
                bool zYet = false;
                int phu = 0;
                for (int j = 0; j < bangMa.GetLength(1); j++)
                {
                    if (zYet)
                    {
                        bangMa[i, j] = Convert.ToChar('Z' - 25 + phu);
                        phu++;
                    }
                    else
                    {
                        bangMa[i, j] = Convert.ToChar('A' + i + j);
                        if (Convert.ToChar('A' + i + j) == 'Z')
                        {
                            zYet = true;
                        }
                    }
                }
            }
            if (textBox3.Text.Length != textBox4.Text.Length)
            {
                MessageBox.Show("Số kí tự của từ gốc phải bằng số kí tự của từ", "Nhập sai rồi nè!");
            }
            else
            {
                if (checkBox2.Checked)
                {
                    // Chuyen tu chu sang Ma
                    textBox5.Text = "";
                    string tuGoc = textBox3.Text.ToUpper();
                    string key = textBox4.Text.ToUpper();
                    int ketThucChuoi = 0;
                    int viTriCotNgang = 0, viTriCotDoc = 0;
                    while (ketThucChuoi < tuGoc.Length)
                    {
                        for (int i = 0; i < cotDoc.Length; i++)
                        {
                            if (cotDoc[i] == tuGoc[ketThucChuoi])
                            {
                                viTriCotDoc = i;
                                break;
                            }
                        }
                        for (int j = 0; j < cotNgang.Length; j++)
                        {
                            if (cotNgang[j] == key[ketThucChuoi])
                            {
                                viTriCotNgang = j;
                                break;
                            }
                        }
                        textBox5.Text += bangMa[viTriCotDoc, viTriCotNgang];
                        ketThucChuoi++;
                    }
                }
                else
                {
                    //Chuyen tu ma sang chu
                    textBox5.Text = "";
                    string tuGoc = textBox3.Text.ToUpper();
                    string key = textBox4.Text.ToUpper();
                    int ketThucChuoi = 0;
                    int viTriHang = 0;
                    while (ketThucChuoi < tuGoc.Length)
                    {
                        for (int i = 0; i < cotDoc.Length; i++)
                        {
                            if (cotDoc[i]==key[ketThucChuoi])
                            {
                                viTriHang = i;
                                break;
                            }
                        }
                        for (int j = 0; j < bangMa.GetLength(1); j++)
                        {
                            if (bangMa[viTriHang,j]==tuGoc[ketThucChuoi])
                            {
                                textBox5.Text += cotNgang[j];
                                break;
                            }
                        }
                        ketThucChuoi++;
                    }
                }
            }
        }
    }
}
