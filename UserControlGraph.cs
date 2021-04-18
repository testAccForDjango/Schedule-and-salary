using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Optovik
{
    public partial class UserControlGraph : UserControl
    {
        //string path = "";
        public bool changed = false;
        bool ChangedMod = true;
        public UserControlGraph()
        {
            InitializeComponent();
        }

        //Загрузка формы
        private void UserControlGraph_Load(object sender, EventArgs e)
        {
            //Настройка шрифта таблицы
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 8f);
            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 8f);
        }

        // Создать таблицу
        public void Create()
        {
            create = true;
            dataGridView1.Rows.Clear();
            byte month = 0;

            for (byte i = 1; i <= 12; i++)
            {
                if (Data.Month == Convert.ToString(new DateTime(DateTime.Now.Year, i, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("ru-RU"))))
                {
                    month = i;
                    break;
                }
            }
            dataGridView1.Rows.Add(); // строка для 1-31

            for (int i = 0; i <= DateTime.DaysInMonth(DateTime.Now.Year, month); i++)
            {
                if (i == 0)
                    dataGridView1[i, 0].Value = "";
                else
                    dataGridView1[i, 0].Value = Convert.ToString(i);


                dataGridView1[i, 0].Style.BackColor = Color.FromArgb(50, 50, 50);
                dataGridView1.Columns[i].ReadOnly = false;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1[DateTime.DaysInMonth(DateTime.Now.Year, month) + 1, 0].Value = "Чек";
            dataGridView1.Rows.Add(); // строка для дней недели

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, month); i++) // дни недели
            {
                DateTime dt = new DateTime(DateTime.Now.Year, month, i);
                dataGridView1.Rows[1].Cells[i].Value = dt.ToString("ddd");
                dataGridView1[i, 1].Style.BackColor = Color.FromArgb(45, 45, 45);
                if (Convert.ToString(dataGridView1.Rows[1].Cells[i].Value) == "Вс" || Convert.ToString(dataGridView1.Rows[1].Cells[i].Value) == "Сб")
                    dataGridView1[i, 1].Style.BackColor = Color.FromArgb(255, 208, 201);
            }

            //Скрыть столбцы без значений
            for (int i = 32; i > 25; i--)
            {
                if (Convert.ToString(dataGridView1[i, 0].Value) == "")
                {
                    dataGridView1.Columns[i].Visible = false;
                }
                else dataGridView1.Columns[i].Visible = true;
            }
            create = false;
        }
        bool create = false;

        // Добавить строку
        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            for (byte i = 2; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 1) dataGridView1.Rows[i].Visible = false;
            }
            ((MainForm)this.TopLevelControl).DeleteUsers();
            ((MainForm)this.TopLevelControl).CreateUsers();
        }

        // Клик по ячейке (канц, фото)
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Data.login && ChangedMod)
            {
                if (Control.ModifierKeys == Keys.Shift && e.RowIndex > 0 && e.ColumnIndex > 0 && e.RowIndex > 1)
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "фото";
                else
                if (e.RowIndex > 0 && e.ColumnIndex > 0 && e.RowIndex > 1)
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "канц";

                changed = true;
            }
        }

        //Масштабирование таблицы от текста
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0 && e.RowIndex != 1)
                dataGridView1.AutoResizeColumns();

            if (!create)
            { 
            int chek = 0;
            byte count = 0;
                if (e.RowIndex % 2 == 1)
                {
                    for (byte i = 1; i < dataGridView1.Columns.Count; i++)
                    {
                        if (Convert.ToString(dataGridView1[i, e.RowIndex].Value) != "")
                        {
                            chek += Convert.ToInt32(dataGridView1[i, e.RowIndex].Value);
                            count++;
                        }
                    }

                    for (byte i = 1; i < dataGridView1.Columns.Count; i++)
                        if (Convert.ToString(dataGridView1[i, 0].Value) == "Чек")
                        {
                            if (count == 0) break;
                            dataGridView1[i, e.RowIndex - 1].Value = chek / count;
                            break;
                        }
                }
            }
        }

        // Загрузить
        public void load()
        {
            dataGridView1.Visible = false;
            dataGridView1.Rows.Clear();

            Directory.CreateDirectory("Schedule");
            List<List<string>> data = new List<List<string>>();
            XmlSerializer xs = new XmlSerializer(data.GetType());
            using (TextReader tr = new StreamReader(Data.Value))
                data = (List<List<string>>)xs.Deserialize(tr);

            foreach (List<string> rowData in data)
                dataGridView1.Rows.Add(rowData.ToArray());

            //Скрыть столбцы без значений
            for (int i = 32; i > 25; i--)
            {
                if (Convert.ToString(dataGridView1[i, 0].Value) == "")
                {
                    dataGridView1.Columns[i].Visible = false;
                }
                else dataGridView1.Columns[i].Visible = true;
            }
            dataGridView1.Visible = true;

            //Скрыть средний чек
            switcher3 = true;
            for (byte i = 2; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 1) dataGridView1.Rows[i].Visible = false;
            }

            for (byte i = 1; i < dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1[i, 1].Style.BackColor = Color.FromArgb(45, 45, 45);
                if (Convert.ToString(dataGridView1.Rows[1].Cells[i].Value) == "Вс" || Convert.ToString(dataGridView1.Rows[1].Cells[i].Value) == "Сб")
                    dataGridView1[i, 1].Style.BackColor = Color.FromArgb(255, 208, 201);
            }
        }

        // Сохранить
        public void save()
        {
            changed = false;
            Directory.CreateDirectory("Schedule");
            List<List<string>> data = new List<List<string>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                List<string> rowData = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                    rowData.Add(cell.FormattedValue.ToString());
                data.Add(rowData);
            }

            XmlSerializer xs = new XmlSerializer(data.GetType());
            using (TextWriter tw = new StreamWriter(Data.Value))
            {
                xs.Serialize(tw, data);
                tw.Close();
            }
        }

        //Кнопка сохранить
        private void Button2_Click(object sender, EventArgs e)
        {
            save();
        }

        //Кнопка создать
        private void Button4_Click(object sender, EventArgs e)
        {
            Create();
        }

        bool switcher3 = true;
        //Показать средний чек
        private void Button3_Click(object sender, EventArgs e)
        {
            if (switcher3)
            {
                switcher3 = false;
                for (byte i = 2; i < dataGridView1.Rows.Count; i++)
                {
                    if (i % 2 == 1) dataGridView1.Rows[i].Visible = true;
                }
            }
            else
            {
                switcher3 = true;
                for (byte i = 2; i < dataGridView1.Rows.Count; i++)
                {
                    if (i % 2 == 1) dataGridView1.Rows[i].Visible = false;
                }

            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
        }

        private void CheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (ChangedMod) ChangedMod = false;
            else ChangedMod = true;
        }
    }

}
