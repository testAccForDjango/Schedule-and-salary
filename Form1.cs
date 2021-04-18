using System;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optovik
{
    public partial class MainForm : Form
    {
        public string path = "";
        byte workDaysKanc = 0;
        byte workDaysFoto = 0;

        byte workDaysKancNow = 0;
        byte workDaysFotoNow = 0;
        byte combination = 0;
        byte chek = 0;

        public bool logIN = false;

        public MainForm()
        {
            InitializeComponent();
        }

        //Загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            Data.login = logIN;
            userControlZP1.BringToFront(); //показать панель с зарплатой
            monthLabel.Text = Convert.ToString(DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("ru-RU"))); //текущий месяц

            //Загрузка кол-ва дней
            userControlZP1.workDaysTotal = Properties.Settings.Default.workDaysTotalByte;

            switch (monthLabel.Text)
            {
                case "Январь":
                    path = Application.StartupPath.ToString() + "\\Schedule\\January.info";
                    break;
                case "Февраль":
                    path = Application.StartupPath.ToString() + "\\Schedule\\February.info";
                    break;
                case "Март":
                    path = Application.StartupPath.ToString() + "\\Schedule\\March.info";
                    break;
                case "Апрель":
                    path = Application.StartupPath.ToString() + "\\Schedule\\April.info";
                    break;
                case "Май":
                    path = Application.StartupPath.ToString() + "\\Schedule\\May.info";
                    break;
                case "Июнь":
                    path = Application.StartupPath.ToString() + "\\Schedule\\June.info";
                    break;
                case "Июль":
                    path = Application.StartupPath.ToString() + "\\Schedule\\July.info";
                    break;
                case "Август":
                    path = Application.StartupPath.ToString() + "\\Schedule\\August.info";
                    break;
                case "Сентябрь":
                    path = Application.StartupPath.ToString() + "\\Schedule\\September.info";
                    break;
                case "Октябрь":
                    path = Application.StartupPath.ToString() + "\\Schedule\\October.info";
                    break;
                case "Ноябрь":
                    path = Application.StartupPath.ToString() + "\\Schedule\\Noemberv.info";
                    break;
                case "Декабрь":
                    path = Application.StartupPath.ToString() + "\\Schedule\\December.info";
                    break;
            }
            Data.Value = path;

            userControlGraph1.load();
            userControlGraph1.dataGridView1.AutoResizeColumns();
            CreateUsers();

            userControlZP1.ZP();
        }

        //Перетаскивание формы
        private void MainFormZP_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        //Показать форму с зарплатой
        private void ButtonZP_Click(object sender, EventArgs e)
        {
            buttonZP.BackColor = Color.FromArgb(130, 130, 130);
            buttonGraph.BackColor = Color.FromArgb(50, 50, 50);
            userControlZP1.BringToFront();
            monthLabel.Visible = false;
        }

        //Показать форму с графиком
        private void ButtonGraph_Click(object sender, EventArgs e)
        {

            buttonGraph.BackColor = Color.FromArgb(130, 130, 130);
            buttonZP.BackColor = Color.FromArgb(50, 50, 50);
            userControlGraph1.BringToFront();
            monthLabel.Visible = true;
        }

        //Выбор пользователя
        private void Button_MyClick(object sender, EventArgs e)
        {
            workDaysFoto = 0;
            workDaysKanc = 0;

            workDaysFotoNow = 0;
            workDaysKancNow = 0;

            combination = 0;
            chek = 0;

            var button = (Button)sender;
            
            for (byte i = 2; i < 20; i++)
                if (button.Text == Convert.ToString(userControlGraph1.dataGridView1[0, i].Value))
                {

                    for (byte j = 1; j < userControlGraph1.dataGridView1.Columns.Count - 1; j++)
                    {
                        if (Convert.ToString(userControlGraph1.dataGridView1[j, 0].Value) == "Чек")
                            chek = Convert.ToByte(userControlGraph1.dataGridView1[j, i].Value);

                        if (Convert.ToString(userControlGraph1.dataGridView1[j, i].Value) != "")
                        {
                            if (Convert.ToString(userControlGraph1.dataGridView1[j, i].Value) == "канц")
                                workDaysKanc++;
                            else if (Convert.ToString(userControlGraph1.dataGridView1[j, i].Value) == "фото")
                                workDaysFoto++;

                            bool comb = true;
                            for (byte g = 2; g < userControlGraph1.dataGridView1.Rows.Count; g += 2)
                            {
                                if (g == i) continue;
                                if (Convert.ToString(userControlGraph1.dataGridView1[j, g].Value) != "")
                                    comb = false;
                            }

                            if (comb)
                                combination++;
                        }
                    }

                    userControlZP1.labelTotalDays.Text = Convert.ToString(workDaysFoto + workDaysKanc);
                    userControlZP1.labelDaysKanc.Text = Convert.ToString(workDaysKanc);
                    userControlZP1.labelDaysFoto.Text = Convert.ToString(workDaysFoto);
                    userControlZP1.labelUser.Text = Convert.ToString(userControlGraph1.dataGridView1[0, i].Value);

                    for (byte j = 0; j < DateTime.Now.Day; j++)
                    {
                        if (Convert.ToString(userControlGraph1.dataGridView1[j, i].Value) == "канц")
                            workDaysKancNow++;
                        else if (Convert.ToString(userControlGraph1.dataGridView1[j, i].Value) == "фото")
                            workDaysFotoNow++;
                    }

                    userControlZP1.label15.Text = Convert.ToString(workDaysFotoNow + workDaysKancNow);
                    userControlZP1.label16.Text = Convert.ToString(workDaysKancNow);
                    userControlZP1.label18.Text = Convert.ToString(workDaysFotoNow);

                    break;
                }

            for (int i = 2; i < userControlGraph1.dataGridView1.Rows.Count; i += 2)
                panel1.Controls[Convert.ToString(i)].Visible = false;
            switcher = true;
            button1.Visible = false;
            //Спрятать панель с паролем
            panel2.Visible = false;
            swither2 = true;

            userControlZP1.label37.Text = Convert.ToString(chek);
            userControlZP1.label55.Text = Convert.ToString(combination);

            userControlZP1.ZP();
        }

        //Удалить пользователей
        public void DeleteUsers()
        {
            for (int i = panel1.Controls.Count - 1; i >= 4; i--)
                panel1.Controls[i].Dispose();
        }

        //Создать кнопки пользователей
        public void CreateUsers()
        {
            // Кнопки пользователей
            for (int i = 2; i < userControlGraph1.dataGridView1.Rows.Count; i += 2)
            {
                //Создаем новую кнопку
                Button newbutton = new Button();
                //Настройки новой кнопки
                newbutton.Name = Convert.ToString(i);
                newbutton.Text = Convert.ToString(userControlGraph1.dataGridView1[0, i].Value);
                newbutton.Width = 50;
                newbutton.Height = 50;
                newbutton.BackColor = Color.FromArgb(50, 50, 50);
                newbutton.FlatStyle = FlatStyle.Flat;
                newbutton.FlatAppearance.BorderSize = 0;
                newbutton.Cursor = Cursors.Hand;

                newbutton.Visible = false;
                newbutton.Parent = this;

                //Расположение кнопки
                newbutton.Location = new Point(0, this.Height - (i/2  * newbutton.Height) - 100);
                //Добавляем событие нажатия на новую кнопку 
                newbutton.Click += new EventHandler(Button_MyClick);
                //Добавляем элемент на панель
                panel1.Controls.Add(newbutton);
            }
        }

        //Для разных действий при нажатии 1 кнопки
        bool switcher = true;
        //Кнопка показать пользователей
        private void ButtonUser_Click(object sender, EventArgs e)
        {
            if (switcher)
            {
                button1.Visible = true;
                for (int i = 2; i < userControlGraph1.dataGridView1.Rows.Count; i += 2)
                    panel1.Controls[Convert.ToString(i)].Visible = true;
                switcher = false;
            }
            else
            {
                panel2.Visible = false;
                button1.Visible = false;
                for (int i = 2; i < userControlGraph1.dataGridView1.Rows.Count; i += 2)
                    panel1.Controls[Convert.ToString(i)].Visible = false;
                switcher = true;
            }
        }

        //Закрыть приложения
        private void LabelClose_Click(object sender, EventArgs e)
        {
            //Сохранение рабочих дней
            Properties.Settings.Default.workDaysTotalByte = userControlZP1.workDaysTotal;
            Properties.Settings.Default.Save();

            if (userControlGraph1.changed)
            {
                panel3.Visible = true;
                panel3.BringToFront();
                labelClose.Enabled = false;
                buttonUser.Enabled = false;
                buttonZP.Enabled = false;
                buttonGraph.Enabled = false;
            }
            else Application.Exit();
        }

        //Спрятать месяцы
        private void HideLabels()
        {
            labelJan.Visible = false;
            labelFeb.Visible = false;
            labelMar.Visible = false;
            labelApr.Visible = false;
            labelMay.Visible = false;
            labelJune.Visible = false;
            labelJuly.Visible = false;
            labelAug.Visible = false;
            labelSep.Visible = false;
            labelOct.Visible = false;
            labelNov.Visible = false;
            labelDec.Visible = false;

            labelJan.ForeColor = Color.FromArgb(25, 25, 25);
            labelFeb.ForeColor = Color.FromArgb(25, 25, 25);
            labelMar.ForeColor = Color.FromArgb(25, 25, 25);
            labelApr.ForeColor = Color.FromArgb(25, 25, 25);
            labelMay.ForeColor = Color.FromArgb(25, 25, 25);
            labelJune.ForeColor = Color.FromArgb(25, 25, 25);
            labelJuly.ForeColor = Color.FromArgb(25, 25, 25);
            labelAug.ForeColor = Color.FromArgb(25, 25, 25);
            labelSep.ForeColor = Color.FromArgb(25, 25, 25);
            labelOct.ForeColor = Color.FromArgb(25, 25, 25);
            labelNov.ForeColor = Color.FromArgb(25, 25, 25);
            labelDec.ForeColor = Color.FromArgb(25, 25, 25);
        }

        //Показать месяцы
        async private void ShowLabels()
        {
            labelJan.Visible = true;
            labelFeb.Visible = true;
            labelMar.Visible = true;
            labelApr.Visible = true;
            labelMay.Visible = true;
            labelJune.Visible = true;
            labelJuly.Visible = true;
            labelAug.Visible = true;
            labelSep.Visible = true;
            labelOct.Visible = true;
            labelNov.Visible = true;
            labelDec.Visible = true;

            //плавное появление
            for (byte i = 0; i < 23; i++)
            {
                await Task.Delay(50);
                labelJan.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelFeb.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelMar.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelApr.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelMay.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelJune.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelJuly.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelAug.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelSep.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelOct.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelNov.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
                labelDec.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));

            }

        }

        //Нажатие на выбранный месяц
        private void Label14_Click(object sender, EventArgs e)
        {
            monthLabel.Visible = false;
            HideLabels();
            ShowLabels();
            DeleteUsers();
        }

        //Месяцы   \/\/\/
        private void Label2_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelJan.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\January.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelFeb.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\February.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelMar.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\March.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelApr.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\April.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelMay.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\May.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelJune.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\June.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelJuly.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\July.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelAug.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\August.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelSep.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\September.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelOct.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\October.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelNov.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\November.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            userControlGraph1.dataGridView1.Rows.Clear();
            monthLabel.Text = labelDec.Text;
            HideLabels();
            monthLabel.Visible = true;
            path = Application.StartupPath.ToString() + "\\Schedule\\December.info";
            Data.Value = path;
            userControlGraph1.load();

            CreateUsers();
        }

        //Плавное появления месяцев, нажатие на месяц
        async private void Label14_TextChanged(object sender, EventArgs e)
        {
            monthLabel.ForeColor = Color.FromArgb(25, 25, 25);
            Data.Month = monthLabel.Text;

            for (byte i = 0; i < 23; i++)
            {
                await Task.Delay(50);
                monthLabel.ForeColor = Color.FromArgb(25 + (i * 10), 25 + (i * 10), 25 + (i * 10));
            }
        }

        //Для разных действий при нажатии 1 кнопки
        bool swither2 = true;

        //Кнопка admin
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!logIN)
                if (swither2)
                {
                    panel2.BringToFront();
                    panel2.Visible = true;
                    swither2 = false;
                    textBox1.Focus();
                }
                else { panel2.Visible = false; swither2 = true; }
            else { logIN = false; log(); }
        }

        //Действия при входе
        private void log()
        {
            if (logIN)
            {
                userControlZP1.button7.Visible = true;
                userControlZP1.button8.Visible = true;
                userControlZP1.labelUser.Text = "Admin";

                userControlGraph1.button1.Visible = true;
                userControlGraph1.button2.Visible = true;
                userControlGraph1.button4.Visible = true;
                userControlGraph1.button5.Visible = true;
                userControlGraph1.checkBox1.Visible = true;

                userControlGraph1.dataGridView1.ReadOnly = false;
                userControlGraph1.dataGridView1.Rows[0].ReadOnly = true;
                userControlGraph1.dataGridView1.Rows[1].ReadOnly = true;
                userControlGraph1.dataGridView1.Refresh();
            }
            else
            {
                Data.login = logIN;
                userControlZP1.button7.Visible = false;
                userControlZP1.button8.Visible = false;
                userControlZP1.labelUser.Text = "Пользователь";

                userControlGraph1.button1.Visible = false;
                userControlGraph1.button2.Visible = false;
                userControlGraph1.button4.Visible = false;
                userControlGraph1.button5.Visible = false;
                userControlGraph1.checkBox1.Visible = false;

                userControlGraph1.dataGridView1.ReadOnly = true;
                userControlGraph1.dataGridView1.Refresh();
            }
        }

        //Нажатие на enter, ввод пароля
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "admin")
                {
                    logIN = true;
                    Data.login = logIN;
                    label1.Text = "Введите пароль";
                    panel2.Visible = false;
                    swither2 = true;
                    log();
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Неверный пароль";
                    textBox1.Text = "";
                }
            }
        }

        //Отмена
        private void Button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            labelClose.Enabled = true;
            buttonUser.Enabled = true;
            buttonZP.Enabled = true;
            buttonGraph.Enabled = true;
        }

        //Не сохранять
        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Сохранить
        private void Button2_Click(object sender, EventArgs e)
        {
            userControlGraph1.save();
            Application.Exit();
        }


    }

    //Для передачи данных между формой и юзерконтролом
    static class Data
    {
        public static string Value { get; set; }
        public static string Month { get; set; }
        public static bool login { get; set; }
    }
}
