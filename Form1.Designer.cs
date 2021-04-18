namespace Optovik
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonZP = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelJan = new System.Windows.Forms.Label();
            this.labelFeb = new System.Windows.Forms.Label();
            this.labelMar = new System.Windows.Forms.Label();
            this.labelApr = new System.Windows.Forms.Label();
            this.labelMay = new System.Windows.Forms.Label();
            this.labelJune = new System.Windows.Forms.Label();
            this.labelJuly = new System.Windows.Forms.Label();
            this.labelAug = new System.Windows.Forms.Label();
            this.labelSep = new System.Windows.Forms.Label();
            this.labelOct = new System.Windows.Forms.Label();
            this.labelNov = new System.Windows.Forms.Label();
            this.labelDec = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControlZP1 = new Optovik.UserControlZP();
            this.userControlGraph1 = new Optovik.UserControlGraph();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.buttonGraph);
            this.panel1.Controls.Add(this.buttonZP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 550);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUser.BackgroundImage")));
            this.buttonUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Location = new System.Drawing.Point(0, 500);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(50, 50);
            this.buttonUser.TabIndex = 2;
            this.buttonUser.TabStop = false;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.ButtonUser_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGraph.BackgroundImage")));
            this.buttonGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGraph.FlatAppearance.BorderSize = 0;
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph.Location = new System.Drawing.Point(0, 75);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(50, 50);
            this.buttonGraph.TabIndex = 1;
            this.buttonGraph.TabStop = false;
            this.buttonGraph.UseVisualStyleBackColor = false;
            this.buttonGraph.Click += new System.EventHandler(this.ButtonGraph_Click);
            // 
            // buttonZP
            // 
            this.buttonZP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonZP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZP.BackgroundImage")));
            this.buttonZP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonZP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZP.FlatAppearance.BorderSize = 0;
            this.buttonZP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZP.Location = new System.Drawing.Point(0, 25);
            this.buttonZP.Name = "buttonZP";
            this.buttonZP.Size = new System.Drawing.Size(50, 50);
            this.buttonZP.TabIndex = 1;
            this.buttonZP.TabStop = false;
            this.buttonZP.UseVisualStyleBackColor = false;
            this.buttonZP.Click += new System.EventHandler(this.ButtonZP_Click);
            // 
            // labelClose
            // 
            this.labelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Image = ((System.Drawing.Image)(resources.GetObject("labelClose.Image")));
            this.labelClose.Location = new System.Drawing.Point(1255, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 25);
            this.labelClose.TabIndex = 1;
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // labelJan
            // 
            this.labelJan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelJan.Location = new System.Drawing.Point(50, 0);
            this.labelJan.Name = "labelJan";
            this.labelJan.Size = new System.Drawing.Size(100, 25);
            this.labelJan.TabIndex = 5;
            this.labelJan.Text = "Январь";
            this.labelJan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJan.Visible = false;
            this.labelJan.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelFeb
            // 
            this.labelFeb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelFeb.Location = new System.Drawing.Point(150, 0);
            this.labelFeb.Name = "labelFeb";
            this.labelFeb.Size = new System.Drawing.Size(100, 25);
            this.labelFeb.TabIndex = 6;
            this.labelFeb.Text = "Февраль";
            this.labelFeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFeb.Visible = false;
            this.labelFeb.Click += new System.EventHandler(this.Label3_Click);
            // 
            // labelMar
            // 
            this.labelMar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelMar.Location = new System.Drawing.Point(250, 0);
            this.labelMar.Name = "labelMar";
            this.labelMar.Size = new System.Drawing.Size(100, 25);
            this.labelMar.TabIndex = 7;
            this.labelMar.Text = "Март";
            this.labelMar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMar.Visible = false;
            this.labelMar.Click += new System.EventHandler(this.Label4_Click);
            // 
            // labelApr
            // 
            this.labelApr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelApr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelApr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelApr.Location = new System.Drawing.Point(350, 0);
            this.labelApr.Name = "labelApr";
            this.labelApr.Size = new System.Drawing.Size(100, 25);
            this.labelApr.TabIndex = 8;
            this.labelApr.Text = "Апрель";
            this.labelApr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelApr.Visible = false;
            this.labelApr.Click += new System.EventHandler(this.Label5_Click);
            // 
            // labelMay
            // 
            this.labelMay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelMay.Location = new System.Drawing.Point(450, 0);
            this.labelMay.Name = "labelMay";
            this.labelMay.Size = new System.Drawing.Size(100, 25);
            this.labelMay.TabIndex = 9;
            this.labelMay.Text = "Май";
            this.labelMay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMay.Visible = false;
            this.labelMay.Click += new System.EventHandler(this.Label6_Click);
            // 
            // labelJune
            // 
            this.labelJune.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJune.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelJune.Location = new System.Drawing.Point(550, 0);
            this.labelJune.Name = "labelJune";
            this.labelJune.Size = new System.Drawing.Size(100, 25);
            this.labelJune.TabIndex = 10;
            this.labelJune.Text = "Июнь";
            this.labelJune.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJune.Visible = false;
            this.labelJune.Click += new System.EventHandler(this.Label7_Click);
            // 
            // labelJuly
            // 
            this.labelJuly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJuly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJuly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelJuly.Location = new System.Drawing.Point(650, 0);
            this.labelJuly.Name = "labelJuly";
            this.labelJuly.Size = new System.Drawing.Size(100, 25);
            this.labelJuly.TabIndex = 11;
            this.labelJuly.Text = "Июль";
            this.labelJuly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJuly.Visible = false;
            this.labelJuly.Click += new System.EventHandler(this.Label8_Click);
            // 
            // labelAug
            // 
            this.labelAug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelAug.Location = new System.Drawing.Point(750, 0);
            this.labelAug.Name = "labelAug";
            this.labelAug.Size = new System.Drawing.Size(100, 25);
            this.labelAug.TabIndex = 12;
            this.labelAug.Text = "Август";
            this.labelAug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAug.Visible = false;
            this.labelAug.Click += new System.EventHandler(this.Label9_Click);
            // 
            // labelSep
            // 
            this.labelSep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelSep.Location = new System.Drawing.Point(850, 0);
            this.labelSep.Name = "labelSep";
            this.labelSep.Size = new System.Drawing.Size(100, 25);
            this.labelSep.TabIndex = 13;
            this.labelSep.Text = "Сентябрь";
            this.labelSep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSep.Visible = false;
            this.labelSep.Click += new System.EventHandler(this.Label10_Click);
            // 
            // labelOct
            // 
            this.labelOct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelOct.Location = new System.Drawing.Point(950, 0);
            this.labelOct.Name = "labelOct";
            this.labelOct.Size = new System.Drawing.Size(100, 25);
            this.labelOct.TabIndex = 14;
            this.labelOct.Text = "Октябрь";
            this.labelOct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOct.Visible = false;
            this.labelOct.Click += new System.EventHandler(this.Label11_Click);
            // 
            // labelNov
            // 
            this.labelNov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelNov.Location = new System.Drawing.Point(1050, 0);
            this.labelNov.Name = "labelNov";
            this.labelNov.Size = new System.Drawing.Size(100, 25);
            this.labelNov.TabIndex = 15;
            this.labelNov.Text = "Ноябрь";
            this.labelNov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNov.Visible = false;
            this.labelNov.Click += new System.EventHandler(this.Label12_Click);
            // 
            // labelDec
            // 
            this.labelDec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.labelDec.Location = new System.Drawing.Point(1150, 0);
            this.labelDec.Name = "labelDec";
            this.labelDec.Size = new System.Drawing.Size(100, 25);
            this.labelDec.TabIndex = 16;
            this.labelDec.Text = "Декабрь";
            this.labelDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDec.Visible = false;
            this.labelDec.Click += new System.EventHandler(this.Label13_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthLabel.Location = new System.Drawing.Point(50, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(100, 25);
            this.monthLabel.TabIndex = 18;
            this.monthLabel.Text = "Месяц";
            this.monthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monthLabel.Visible = false;
            this.monthLabel.TextChanged += new System.EventHandler(this.Label14_TextChanged);
            this.monthLabel.Click += new System.EventHandler(this.Label14_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(55, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 50);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(5, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 47;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(905, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 81);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Сохранить изменения в графике?";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(228, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(122, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Не сохранять";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(16, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // userControlZP1
            // 
            this.userControlZP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userControlZP1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlZP1.ForeColor = System.Drawing.Color.White;
            this.userControlZP1.Location = new System.Drawing.Point(50, 25);
            this.userControlZP1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlZP1.Name = "userControlZP1";
            this.userControlZP1.Size = new System.Drawing.Size(1230, 525);
            this.userControlZP1.TabIndex = 2;
            // 
            // userControlGraph1
            // 
            this.userControlGraph1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userControlGraph1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlGraph1.ForeColor = System.Drawing.Color.White;
            this.userControlGraph1.Location = new System.Drawing.Point(50, 25);
            this.userControlGraph1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlGraph1.Name = "userControlGraph1";
            this.userControlGraph1.Size = new System.Drawing.Size(1230, 525);
            this.userControlGraph1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1280, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelDec);
            this.Controls.Add(this.labelNov);
            this.Controls.Add(this.labelOct);
            this.Controls.Add(this.labelSep);
            this.Controls.Add(this.labelAug);
            this.Controls.Add(this.labelJuly);
            this.Controls.Add(this.labelJune);
            this.Controls.Add(this.labelMay);
            this.Controls.Add(this.labelApr);
            this.Controls.Add(this.labelMar);
            this.Controls.Add(this.labelFeb);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.userControlZP1);
            this.Controls.Add(this.userControlGraph1);
            this.Controls.Add(this.labelJan);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовик";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormZP_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonZP;
        private System.Windows.Forms.Label labelClose;
        private UserControlZP userControlZP1;
        private UserControlGraph userControlGraph1;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Label labelJan;
        private System.Windows.Forms.Label labelFeb;
        private System.Windows.Forms.Label labelMar;
        private System.Windows.Forms.Label labelApr;
        private System.Windows.Forms.Label labelMay;
        private System.Windows.Forms.Label labelJune;
        private System.Windows.Forms.Label labelJuly;
        private System.Windows.Forms.Label labelAug;
        private System.Windows.Forms.Label labelSep;
        private System.Windows.Forms.Label labelOct;
        private System.Windows.Forms.Label labelNov;
        private System.Windows.Forms.Label labelDec;
        public System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel panel1;
    }
}

