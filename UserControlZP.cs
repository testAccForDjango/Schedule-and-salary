using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Printing;

namespace Optovik
{
    public partial class UserControlZP : UserControl
    {
        byte planKanc = 80;
        byte planFoto = 80;
        double script = 2.5;
        byte conf = 0;
        byte answ = 0;
        public byte workDaysTotal = 0;

        public UserControlZP()
        {
            InitializeComponent();
        }

        //Загрузка формы
        private void UserControlZP_Load(object sender, EventArgs e)
        {
            label11.Text = Convert.ToString(DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
            workDaysTotal = Properties.Settings.Default.workDaysTotalByte;
            label4.Text = Convert.ToString(workDaysTotal);
        }

        // "+" kanc
        private void Button1_Click(object sender, EventArgs e)
        {
            planKanc++;
            if (planKanc > 150) planKanc = 150;
            label35.Text = Convert.ToString(planKanc);
        }
        // "-" kanc
        private void Button2_Click(object sender, EventArgs e)
        {
            planKanc--;
            if (planKanc == 255) planKanc = 0;
            label35.Text = Convert.ToString(planKanc);
        }
        // "+" foto
        private void Button4_Click(object sender, EventArgs e)
        {
            planFoto++;
            if (planFoto > 150) planFoto = 150;
            label36.Text = Convert.ToString(planFoto);
        }
        // "-" foto
        private void Button3_Click(object sender, EventArgs e)
        {
            planFoto--;
            if (planFoto == 255) planFoto = 0;
            label36.Text = Convert.ToString(planFoto);
        }
        // "-" script
        private void Button5_Click(object sender, EventArgs e)
        {
            script -= 0.1;
            if (script < 0.1) script = 0;
            label38.Text = Convert.ToString(script);
        }
        // "+" script
        private void Button6_Click(object sender, EventArgs e)
        {
            script += 0.1;
            if (script > 5) script = 5;
            label38.Text = Convert.ToString(script);
        }
        // "+" sobran
        private void Button10_Click(object sender, EventArgs e)
        {
            conf++;
            if (conf > 12) conf = 12;
            label41.Text = Convert.ToString(conf);
        }
        // "-" sobran
        private void Button9_Click(object sender, EventArgs e)
        {
            conf--;
            if (conf == 255) conf = 0;
            label41.Text = Convert.ToString(conf);
        }
        //Телефон
        private void CheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label43.ForeColor = Color.Green;
                label43.Text = "+250";
            }
            else
            {
                label43.ForeColor = Color.Gray;
                label43.Text = "0";
            }

            ZP();
        }
        //Форма
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label44.ForeColor = Color.Green;
                label44.Text = "+250";
            }
            else
            {
                label44.ForeColor = Color.Gray;
                label44.Text = "0";
            }

            ZP();
        }
        //Антитабак
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label45.ForeColor = Color.Green;
                label45.Text = "+250";
            }
            else
            {
                label45.ForeColor = Color.Gray;
                label45.Text = "0";
            }

            ZP();
        }
        //Распорядок дня
        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                label46.ForeColor = Color.Green;
                label46.Text = "+500";
            }
            else
            {
                label46.ForeColor = Color.Gray;
                label46.Text = "0";
            }

            ZP();
        }
        //Ревизия
        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                label47.ForeColor = Color.Green;
                label47.Text = "+500";
                label47.Visible = true;
            }
            else
            {
                label47.ForeColor = Color.Gray;
                label47.Text = "0";
                label47.Visible = false;
            }

            ZP();
        }
        // "+" Рабочих дней в месяце
        private void Button8_Click(object sender, EventArgs e)
        {
            workDaysTotal++;
            if (workDaysTotal > 31) workDaysTotal = 31;
            label4.Text = Convert.ToString(workDaysTotal);
        }
        // "-" Рабочих дней в месяце
        private void Button7_Click(object sender, EventArgs e)
        {
            workDaysTotal--;
            if (workDaysTotal == 255) workDaysTotal = 0;
            label4.Text = Convert.ToString(workDaysTotal);
        }
        // План канц (+3500)
        private void Label35_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label35.Text) < 80)
            {
                label50.Text = "0";
                label50.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(label35.Text) >= 80 && Convert.ToInt32(label35.Text) < 90)
            {
                label50.Text = "+3500";
                label50.ForeColor = Color.Gray;
            }
            else if (Convert.ToInt32(label35.Text) >= 90 && Convert.ToInt32(label35.Text) < 98)
            {
                label50.Text = "+5600";
                label50.ForeColor = Color.Orange;
            }
            else if (Convert.ToInt32(label35.Text) >= 98 && Convert.ToInt32(label35.Text) < 104)
            {
                label50.Text = "+7000";
                label50.ForeColor = Color.Green;
            }
            else if (Convert.ToInt32(label35.Text) >= 104)
            {
                label50.Text = "+8400";
                label50.ForeColor = Color.Purple;
            }

            ZP();
        }
        // План фото (+3500)
        private void Label36_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label36.Text) < 80)
            {
                label51.Text = "0";
                label51.ForeColor = Color.Red;
            }
            else if (Convert.ToInt32(label36.Text) >= 80 && Convert.ToInt32(label36.Text) < 90)
            {
                label51.Text = "+3500";
                label51.ForeColor = Color.Gray;
            }
            else if (Convert.ToInt32(label36.Text) >= 90 && Convert.ToInt32(label36.Text) < 98)
            {
                label51.Text = "+5600";
                label51.ForeColor = Color.Orange;
            }
            else if (Convert.ToInt32(label36.Text) >= 98 && Convert.ToInt32(label36.Text) < 104)
            {
                label51.Text = "+7000";
                label51.ForeColor = Color.Green;
            }
            else if (Convert.ToInt32(label36.Text) >= 104)
            {
                label51.Text = "+8400";
                label51.ForeColor = Color.Purple;
            }

            ZP();
        }
        // Скрипты (+2500)
        private void Label38_TextChanged(object sender, EventArgs e)
        {
            label52.Text = "+" + Convert.ToString(Convert.ToDouble(label38.Text) * 1000);
            ZP();
        }
        // "+" Otvet
        private void Button12_Click(object sender, EventArgs e)
        {
            answ++;
            if (answ > 12) answ = 12;
            label48.Text = Convert.ToString(answ);
        }
        // "-" Otvet
        private void Button11_Click(object sender, EventArgs e)
        {
            answ--;
            if (answ == 255) answ = 0;
            label48.Text = Convert.ToString(answ);
        }

        double zp = 0;
        public void ZP()
        {
            zp = (Convert.ToDouble(labelTotalDays.Text) / Convert.ToDouble(label4.Text)) * (Convert.ToInt32(label50.Text) + Convert.ToInt32(label51.Text) + Convert.ToInt32(label52.Text) + Convert.ToInt32(label53.Text) + Convert.ToInt32(label54.Text) +
                Convert.ToInt32(label54.Text) + Convert.ToInt32(label43.Text) + Convert.ToInt32(label44.Text) + Convert.ToInt32(label45.Text) + Convert.ToInt32(label46.Text) +
              Convert.ToInt32(label47.Text) + (Convert.ToInt32(label55.Text) * 200) + ((Convert.ToInt32(labelDaysFoto.Text) - Convert.ToInt32(label55.Text)) * 25) + Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
            label21.Text = Convert.ToString((int)zp);
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                ZP();
        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") textBox2.Text = "0";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                ZP();
        }

        // текст для печати
        private string name = "";
        private string result = "";

        // обработчик события нажатия на кнопку Печать
        private void Button13_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            name = labelUser.Text + "             " + label11.Text;

            result = "\n\n\nКоличество рабочих дней в месяце: " + label4.Text + "\n";
            result += "Количество смен в месяце: " + labelTotalDays.Text + "\n";
            result += "Дней в канцтоварах: " + labelDaysKanc.Text + "\n";
            result += "Дней в фото: " + labelDaysFoto.Text + "\n";
            result += "Совмещение: " + label55.Text + "\n\n";

            result += "Средний чек: " + label37.Text + "\n\n";

            result += "Выполнение плана (канц): " + label35.Text + "%" + "  " + label50.Text + "\n";
            result += "Выполнение плана (фото): " + label36.Text + "%" + "  " + label51.Text + "\n";
            result += "Скрипты (оценка): " + label38.Text + " балла" + "  " + label52.Text + "\n\n";

            result += "Количество провеленных собраний: " + label41.Text + "" + "  " + label53.Text + "\n";
            result += "Ответы на собраниях: " + label48.Text + "" + "  " + label54.Text + "\n\n";

            result += "БОНУСЫ" + "\n";
            result += "Телефон: " + label43.Text + "\n";
            result += "Форма: " + label44.Text + "\n";
            result += "Антитабак: " + label45.Text + "\n";
            result += "Распорядок дня: " + label46.Text + "\n";
            result += "Ревизия: " + label47.Text + "\n\n";

            result += "Отпускные: " + textBox1.Text + "\n";
            result += "Премия: " + textBox2.Text + "\n\n\n";

            result += "Итоговая зарплата: " + label21.Text;


            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(name, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 0, 0);
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
