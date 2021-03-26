using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Ping
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

        }

        ///
        /// Перед закрытием формы посмотреть значения полей в текст боксах 
        /// и применить соответсвующие настройки
        ///
        /// ТЕМЫ: 
        ///  Классическая
        ///  Серая
        ///  Тёмная
        ///  Цветная
        ///  Белая
        ///  
        /// Размер шрифта
        ///  8
        ///  9
        ///  10
        ///  11
        ///  12
        ///  13
        ///  14

        private void SetFontSize(int SizeFont)
        {
            switch (SizeFont)
            {
                case 0:
                    Program.mainForm.label1.Font = new Font("Microsoft Sans Serif", 8);
                    Program.mainForm.label2.Font = new Font("Microsoft Sans Serif", 8);
                    Program.mainForm.label3.Font = new Font("Microsoft Sans Serif", 8);
                    Program.mainForm.label4.Font = new Font("Microsoft Sans Serif", 8);
                    Program.mainForm.label5.Font = new Font("Microsoft Sans Serif", 8);
                    Program.mainForm.label8.Font = new Font("Microsoft Sans Serif", 8);

                    Program.mainForm.менюToolStripMenuItem.Text = "Адресса";
                    Program.mainForm.инструкцияToolStripMenuItem.Text = "Адресса";
                    Program.mainForm.авторToolStripMenuItem.Text = "Адресса";

                    Program.mainForm.richTextBox1.Text = "Адресса";

                    break;
                case 1:
                    Program.mainForm.label1.Font = new Font("Microsoft Sans Serif", 9);
                    Program.mainForm.label2.Font = new Font("Microsoft Sans Serif", 9);
                    Program.mainForm.label3.Font = new Font("Microsoft Sans Serif", 9);
                    Program.mainForm.label4.Font = new Font("Microsoft Sans Serif", 9);
                    Program.mainForm.label5.Font = new Font("Microsoft Sans Serif", 9);
                    Program.mainForm.label8.Font = new Font("Microsoft Sans Serif", 9);

                    Program.mainForm.менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9);
                    Program.mainForm.инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9);
                    Program.mainForm.авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9);

                    Program.mainForm.richTextBox1.Font = new Font("Microsoft Sans Serif", 9);
                    break;
                case 2:
                    Program.mainForm.label1.Font = new Font("Microsoft Sans Serif", 10);
                    Program.mainForm.label2.Font = new Font("Microsoft Sans Serif", 10);
                    Program.mainForm.label3.Font = new Font("Microsoft Sans Serif", 10);
                    Program.mainForm.label4.Font = new Font("Microsoft Sans Serif", 10);
                    Program.mainForm.label5.Font = new Font("Microsoft Sans Serif", 10);
                    Program.mainForm.label8.Font = new Font("Microsoft Sans Serif", 10);

                    Program.mainForm.менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10);
                    Program.mainForm.инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10);
                    Program.mainForm.авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10);

                    Program.mainForm.richTextBox1.Font = new Font("Microsoft Sans Serif", 10);
                    break;
                case 3:
                    Program.mainForm.label1.Font = new Font("Microsoft Sans Serif", 11);
                    Program.mainForm.label2.Font = new Font("Microsoft Sans Serif", 11);
                    Program.mainForm.label3.Font = new Font("Microsoft Sans Serif", 11);
                    Program.mainForm.label4.Font = new Font("Microsoft Sans Serif", 11);
                    Program.mainForm.label5.Font = new Font("Microsoft Sans Serif", 11);
                    Program.mainForm.label8.Font = new Font("Microsoft Sans Serif", 11);

                    Program.mainForm.менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11);
                    Program.mainForm.инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11);
                    Program.mainForm.авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11);

                    Program.mainForm.richTextBox1.Font = new Font("Microsoft Sans Serif", 11);
                    break;
                case 4:
                    Program.mainForm.label1.Font = new Font("Microsoft Sans Serif", 12);
                    Program.mainForm.label2.Font = new Font("Microsoft Sans Serif", 12);
                    Program.mainForm.label3.Font = new Font("Microsoft Sans Serif", 12);
                    Program.mainForm.label4.Font = new Font("Microsoft Sans Serif", 12);
                    Program.mainForm.label5.Font = new Font("Microsoft Sans Serif", 12);
                    Program.mainForm.label8.Font = new Font("Microsoft Sans Serif", 12);

                    Program.mainForm.менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12);
                    Program.mainForm.инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12);
                    Program.mainForm.авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12);

                    Program.mainForm.richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
                    break;
                case 5:
                    Program.mainForm.label1.Font = new Font("Microsoft Sans Serif", 13);
                    Program.mainForm.label2.Font = new Font("Microsoft Sans Serif", 13);
                    Program.mainForm.label3.Font = new Font("Microsoft Sans Serif", 13);
                    Program.mainForm.label4.Font = new Font("Microsoft Sans Serif", 13);
                    Program.mainForm.label5.Font = new Font("Microsoft Sans Serif", 13);
                    Program.mainForm.label8.Font = new Font("Microsoft Sans Serif", 13);

                    Program.mainForm.менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13);
                    Program.mainForm.инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13);
                    Program.mainForm.авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13);

                    Program.mainForm.richTextBox1.Font = new Font("Microsoft Sans Serif", 13);
                    break;
                case 6:
                    Program.mainForm.label1.Font = new Font("Microsoft Sans Serif", 14);
                    Program.mainForm.label2.Font = new Font("Microsoft Sans Serif", 14);
                    Program.mainForm.label3.Font = new Font("Microsoft Sans Serif", 14);
                    Program.mainForm.label4.Font = new Font("Microsoft Sans Serif", 14);
                    Program.mainForm.label5.Font = new Font("Microsoft Sans Serif", 14);
                    Program.mainForm.label8.Font = new Font("Microsoft Sans Serif", 14);

                    Program.mainForm.менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14);
                    Program.mainForm.инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14);
                    Program.mainForm.авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14);

                    Program.mainForm.richTextBox1.Font = new Font("Microsoft Sans Serif", 14);
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            Program.mainForm.chart1.BackColor = Color.FromArgb(128, 255, 128);

            int Tema = comboBox_Tema.SelectedIndex;
            int Font = comboBox_SizeFont.SelectedIndex;
            int Scale = comboBox_ScaleInt.SelectedIndex;
            int Language = comboBox_Language.SelectedIndex;
            int ColorLine = comboBox_ColorLine.SelectedIndex;
            int SizeLine = comboBox_FatLine.SelectedIndex;
            int Graphics = comboBox_Graphik.SelectedIndex;
            int X = comboBox_X.SelectedIndex;
            int Warning = comboBox_Warning.SelectedIndex;

            switch (Tema)
            {
                case 0:
                    Program.mainForm.chart1.BackColor = Color.FromArgb(255, 245, 238);
                    Program.mainForm.groupBox1.BackColor = Color.FromArgb(255, 245, 238);
                    break;
                case 1:
                    Program.mainForm.chart1.BackColor = Color.FromArgb(179, 179, 179);
                    Program.mainForm.groupBox1.BackColor = Color.FromArgb(179, 179, 179);
                    break;
                case 2:
                    Program.mainForm.chart1.BackColor = Color.FromArgb(28,28,28);
                    Program.mainForm.groupBox1.BackColor = Color.FromArgb(28, 28, 28);
                    break;
                case 3:
                    Program.mainForm.chart1.BackColor = Color.FromArgb(0,255,0);
                    Program.mainForm.groupBox1.BackColor = Color.FromArgb(0,255,0);
                    break;
                case 4:
                    Program.mainForm.chart1.BackColor = Color.FromArgb(255,255,255);
                    Program.mainForm.groupBox1.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                default:
                    Program.mainForm.chart1.BackColor = Color.FromArgb(255, 245, 238);
                    Program.mainForm.groupBox1.BackColor = Color.FromArgb(255, 245, 238);
                    break;
            }

            SetFontSize(Font);

            switch (Scale)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }

            switch (Language)
            {
                case 0:
                    Program.mainForm.label1.Text = "Адресса";
                    Program.mainForm.label2.Text = "Время сеанса";
                    Program.mainForm.label3.Text = "Сохранить";
                    Program.mainForm.label4.Text = "Время запуска:";
                    Program.mainForm.label5.Text = "Время работы:";
                    Program.mainForm.label8.Text = "Завершение:";

                    Program.mainForm.менюToolStripMenuItem.Text = "Меню";
                    Program.mainForm.инструкцияToolStripMenuItem.Text = "Инструкция";
                    Program.mainForm.авторToolStripMenuItem.Text = "Автор";

                    SetFontSize(Font);
                    break;
                case 1:
                    Program.mainForm.label1.Text = "URL";
                    Program.mainForm.label2.Text = "Session time";
                    Program.mainForm.label3.Text = "Save";
                    Program.mainForm.label4.Text = "Start time:";
                    Program.mainForm.label5.Text = "Working time:";
                    Program.mainForm.label8.Text = "Finishing:";

                    Program.mainForm.менюToolStripMenuItem.Text = "Menu";
                    Program.mainForm.инструкцияToolStripMenuItem.Text = "Manual";
                    Program.mainForm.авторToolStripMenuItem.Text = "Author";

                    SetFontSize(Font);
                    break;
                default:
                    break;
            }

            switch(ColorLine)
            {
                case 0:
                    Program.mainForm.chart1.Series[0].Color = Color.FromArgb(255, 255, 0);
                    break;
                case 1:
                    Program.mainForm.chart1.Series[0].Color = Color.FromArgb(255, 0, 0);
                    break;
                case 2:
                    Program.mainForm.chart1.Series[0].Color = Color.FromArgb(128, 128, 0);
                    break;
                case 3:
                    Program.mainForm.chart1.Series[0].Color = Color.FromArgb(0, 0, 255);
                    break;
                case 4:
                    Program.mainForm.chart1.Series[0].Color = Color.FromArgb(0, 0, 0);
                    break;
            }

            switch(SizeLine)
            {
                case 0:
                    Program.mainForm.chart1.Series[0].BorderWidth = 1;
                    break;
                case 1:
                    Program.mainForm.chart1.Series[0].BorderWidth = 2;
                    break;
                case 2:
                    Program.mainForm.chart1.Series[0].BorderWidth = 3;
                    break;
                case 3:
                    Program.mainForm.chart1.Series[0].BorderWidth = 4;
                    break;
                case 4:
                    Program.mainForm.chart1.Series[0].BorderWidth = 5;
                    break;
                case 5:
                    Program.mainForm.chart1.Series[0].BorderWidth = 6;
                    break;
            }

            switch (Graphics)
            {
                case 0:
                    Program.mainForm.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case 1:
                    Program.mainForm.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                case 2:
                    Program.mainForm.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    break;
                case 3:
                    Program.mainForm.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 4:
                    Program.mainForm.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    break;
                case 5:
                    Program.mainForm.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                    break;
            }

            /*
             * СОХРАНЕНИЯ НАСТРОЕК В ФАЙЛ
             **/

            DirectoryInfo data = new DirectoryInfo(@"C:\Settings_pingator");
            data.Create();

            var sw = new StreamWriter(@"C:\Settings_pingator\user_settings.txt");
            sw.WriteLine(comboBox_Tema.Text + ":" + comboBox_SizeFont.Text + ":" + comboBox_ScaleInt.Text + ":" + comboBox_Language.Text + ":" + 
               comboBox_ColorLine.Text + ":" + comboBox_FatLine.Text + ":" + comboBox_Graphik.Text + ":" + comboBox_X.Text + ":" + comboBox_Warning.Text);

            /*
             * comboBox_Tema
             * comboBox_SizeFont
             * comboBox_ScaleInt
             * comboBox_Language
             * comboBox_ColorLine
             * comboBox_FatLine
             * comboBox_Graphik
             * comboBox_X
             * comboBox_Warning
             * 
             **/

            sw.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox_Tema.Text = "Классическая";
            comboBox_SizeFont.Text = "12";
            comboBox_ScaleInt.Text = "Средний";
            comboBox_Language.Text = "Русский";
            comboBox5.Text = "";
            comboBox_ColorLine.Text = "Чёрный";
            comboBox_FatLine.Text = "2";
            comboBox_Graphik.Text = "Гладкий";
            comboBox_X.Text = "Время запроса";
            comboBox_Warning.Text = ">100 пинга";
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
