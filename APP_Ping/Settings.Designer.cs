namespace APP_Ping
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_SizeFont = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ScaleInt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Tema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_X = new System.Windows.Forms.ComboBox();
            this.comboBox_ColorLine = new System.Windows.Forms.ComboBox();
            this.comboBox_Warning = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_FatLine = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Graphik = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_SizeFont);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_Language);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_ScaleInt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Tema);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Внешний вид приложения";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(32, 357);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(228, 28);
            this.comboBox5.TabIndex = 1;
            this.comboBox5.Text = "Тут что то будет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пока что неизвестно";
            // 
            // comboBox_SizeFont
            // 
            this.comboBox_SizeFont.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_SizeFont.FormattingEnabled = true;
            this.comboBox_SizeFont.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.comboBox_SizeFont.Location = new System.Drawing.Point(32, 129);
            this.comboBox_SizeFont.Name = "comboBox_SizeFont";
            this.comboBox_SizeFont.Size = new System.Drawing.Size(228, 28);
            this.comboBox_SizeFont.TabIndex = 1;
            this.comboBox_SizeFont.Text = global::APP_Ping.Properties.Settings.Default.font;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Размер шрифта";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "Language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBox_Language.Location = new System.Drawing.Point(32, 283);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(228, 28);
            this.comboBox_Language.TabIndex = 1;
            this.comboBox_Language.Text = global::APP_Ping.Properties.Settings.Default.Language;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Язык";
            // 
            // comboBox_ScaleInt
            // 
            this.comboBox_ScaleInt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "ScaleInterface", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_ScaleInt.FormattingEnabled = true;
            this.comboBox_ScaleInt.Items.AddRange(new object[] {
            "Очень маленький",
            "Маленький",
            "Средний",
            "Большой",
            "Очень большой"});
            this.comboBox_ScaleInt.Location = new System.Drawing.Point(32, 205);
            this.comboBox_ScaleInt.Name = "comboBox_ScaleInt";
            this.comboBox_ScaleInt.Size = new System.Drawing.Size(228, 28);
            this.comboBox_ScaleInt.TabIndex = 1;
            this.comboBox_ScaleInt.Text = global::APP_Ping.Properties.Settings.Default.ScaleInterface;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Маштаб интерфейса";
            // 
            // comboBox_Tema
            // 
            this.comboBox_Tema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Tema.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "Tema", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_Tema.FormattingEnabled = true;
            this.comboBox_Tema.Items.AddRange(new object[] {
            "Классическая",
            "Серая",
            "Тёмная",
            "Цветная",
            "Белая"});
            this.comboBox_Tema.Location = new System.Drawing.Point(32, 49);
            this.comboBox_Tema.Name = "comboBox_Tema";
            this.comboBox_Tema.Size = new System.Drawing.Size(228, 28);
            this.comboBox_Tema.TabIndex = 1;
            this.comboBox_Tema.Text = global::APP_Ping.Properties.Settings.Default.Tema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox_X);
            this.groupBox2.Controls.Add(this.comboBox_ColorLine);
            this.groupBox2.Controls.Add(this.comboBox_Warning);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox_FatLine);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox_Graphik);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(316, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Внешний вид графика";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ось X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Цвет линии";
            // 
            // comboBox_X
            // 
            this.comboBox_X.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "X", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_X.FormattingEnabled = true;
            this.comboBox_X.Items.AddRange(new object[] {
            "Время запроса",
            "Нумерация запроса"});
            this.comboBox_X.Location = new System.Drawing.Point(20, 269);
            this.comboBox_X.Name = "comboBox_X";
            this.comboBox_X.Size = new System.Drawing.Size(228, 28);
            this.comboBox_X.TabIndex = 1;
            this.comboBox_X.Text = global::APP_Ping.Properties.Settings.Default.X;
            // 
            // comboBox_ColorLine
            // 
            this.comboBox_ColorLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "ColorLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_ColorLine.FormattingEnabled = true;
            this.comboBox_ColorLine.Items.AddRange(new object[] {
            "Жёлтый",
            "Красный",
            "Серый",
            "Синий",
            "Чёрный"});
            this.comboBox_ColorLine.Location = new System.Drawing.Point(20, 49);
            this.comboBox_ColorLine.Name = "comboBox_ColorLine";
            this.comboBox_ColorLine.Size = new System.Drawing.Size(228, 28);
            this.comboBox_ColorLine.Sorted = true;
            this.comboBox_ColorLine.TabIndex = 1;
            this.comboBox_ColorLine.Text = global::APP_Ping.Properties.Settings.Default.ColorLine;
            // 
            // comboBox_Warning
            // 
            this.comboBox_Warning.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "Warning", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_Warning.FormattingEnabled = true;
            this.comboBox_Warning.Items.AddRange(new object[] {
            ">10 пинга",
            ">30 пинга",
            ">50 пинга",
            ">80 пинга",
            ">100 пинга",
            ">150 пинга",
            ">300 пинга"});
            this.comboBox_Warning.Location = new System.Drawing.Point(20, 349);
            this.comboBox_Warning.Name = "comboBox_Warning";
            this.comboBox_Warning.Size = new System.Drawing.Size(228, 28);
            this.comboBox_Warning.TabIndex = 1;
            this.comboBox_Warning.Text = global::APP_Ping.Properties.Settings.Default.Warning;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Тип графика";
            // 
            // comboBox_FatLine
            // 
            this.comboBox_FatLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "FatLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_FatLine.FormattingEnabled = true;
            this.comboBox_FatLine.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_FatLine.Location = new System.Drawing.Point(20, 129);
            this.comboBox_FatLine.Name = "comboBox_FatLine";
            this.comboBox_FatLine.Size = new System.Drawing.Size(228, 28);
            this.comboBox_FatLine.TabIndex = 1;
            this.comboBox_FatLine.Text = global::APP_Ping.Properties.Settings.Default.FatLine;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Предупреждение";
            // 
            // comboBox_Graphik
            // 
            this.comboBox_Graphik.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::APP_Ping.Properties.Settings.Default, "Graphik", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_Graphik.FormattingEnabled = true;
            this.comboBox_Graphik.Items.AddRange(new object[] {
            "Точка",
            "Линия",
            "Гладкий",
            "Колонны",
            "Боковые колонны"});
            this.comboBox_Graphik.Location = new System.Drawing.Point(20, 205);
            this.comboBox_Graphik.Name = "comboBox_Graphik";
            this.comboBox_Graphik.Size = new System.Drawing.Size(228, 28);
            this.comboBox_Graphik.TabIndex = 1;
            this.comboBox_Graphik.Text = global::APP_Ping.Properties.Settings.Default.Graphik;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Толщина линии";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 428);
            this.button1.MaximumSize = new System.Drawing.Size(1200, 320);
            this.button1.MinimumSize = new System.Drawing.Size(490, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(508, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "По умолчанию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox_Tema;
        public System.Windows.Forms.ComboBox comboBox_SizeFont;
        public System.Windows.Forms.ComboBox comboBox_Language;
        public System.Windows.Forms.ComboBox comboBox_ScaleInt;
        public System.Windows.Forms.ComboBox comboBox_X;
        public System.Windows.Forms.ComboBox comboBox_Warning;
        public System.Windows.Forms.ComboBox comboBox_FatLine;
        public System.Windows.Forms.ComboBox comboBox_Graphik;
        public System.Windows.Forms.ComboBox comboBox_ColorLine;
    }
}