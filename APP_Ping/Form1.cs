using System;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace APP_Ping
{
    public partial class Form1 : Form
    {
        private Thread th;                  // Поток для пинговки и отправки в рич бокс
        private DateTime TimeStart;         // Время начала пинговки
        private int TimeWork = 0;           // Время выполнения пинговки
        private int[] PackageOUT;           // Пакетов отправленно
        private int[] PackageIN;            // Пакетов Полученно
        private Boolean Hide = false;       // Скрыть показать груп бокс с настройками
        public  int countURL = 0;

        private String[] SaveHistoryPing;   // Для хранения пинга

        public Form1()
        {
            PackageOUT = new int[5] { 0, 0, 0, 0, 0 };
            PackageIN = new int[5] { 0, 0, 0, 0, 0 };
            SaveHistoryPing = new String[5];

            Program.mainForm = this;
            InitializeComponent();
            VisiblePanel();

            // ЗАГРУЗКА НАСТРОЕК
            try
            {
                var sr = new StreamReader(@"C:\Settings_pingator\user_settings.txt");
                String buffer = sr.ReadToEnd();
                sr.Close();
                String [] settings_info = buffer.Split(':');

                String Tema = settings_info[0];
                int SizeFont = int.Parse(settings_info[1]);
                String ScaleUI = settings_info[2];
                String Language = settings_info[3];
                String ColorLine = settings_info[4];
                int SizeLine = int.Parse(settings_info[5]);
                String Graphics = settings_info[6];


                switch (Tema)
                {
                    case "Классическая":
                       chart1.BackColor = Color.FromArgb(255, 245, 238);
                       groupBox1.BackColor = Color.FromArgb(255, 245, 238);
                        break;
                    case "Серая":
                       chart1.BackColor = Color.FromArgb(179, 179, 179);
                       groupBox1.BackColor = Color.FromArgb(179, 179, 179);
                        break;
                    case "Тёмная":
                       chart1.BackColor = Color.FromArgb(28, 28, 28);
                       groupBox1.BackColor = Color.FromArgb(28, 28, 28);
                        break;
                    case "Цветная":
                       chart1.BackColor = Color.FromArgb(0, 255, 0);
                       groupBox1.BackColor = Color.FromArgb(0, 255, 0);
                        break;
                    case "Белая":
                       chart1.BackColor = Color.FromArgb(255, 255, 255);
                       groupBox1.BackColor = Color.FromArgb(255, 255, 255);
                        break;
                }       // Загрузка темы

                switch (SizeFont)
                {
                    case 8:
                        label1.Font = new Font("Microsoft Sans Serif", 8);
                        label2.Font = new Font("Microsoft Sans Serif", 8);
                        label3.Font = new Font("Microsoft Sans Serif", 8);
                        label4.Font = new Font("Microsoft Sans Serif", 8);
                        label5.Font = new Font("Microsoft Sans Serif", 8);
                        label8.Font = new Font("Microsoft Sans Serif", 8);

                        менюToolStripMenuItem.Text = "Адрес";
                        инструкцияToolStripMenuItem.Text = "Адрес";
                        авторToolStripMenuItem.Text = "Адрес";

                        richTextBox1.Text = "Адрес";

                        break;
                    case 9:
                        label1.Font = new Font("Microsoft Sans Serif", 9);
                        label2.Font = new Font("Microsoft Sans Serif", 9);
                        label3.Font = new Font("Microsoft Sans Serif", 9);
                        label4.Font = new Font("Microsoft Sans Serif", 9);
                        label5.Font = new Font("Microsoft Sans Serif", 9);
                        label8.Font = new Font("Microsoft Sans Serif", 9);

                        менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9);
                        инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9);
                        авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9);

                        richTextBox1.Font = new Font("Microsoft Sans Serif", 9);
                        break;
                    case 10:
                        label1.Font = new Font("Microsoft Sans Serif", 10);
                        label2.Font = new Font("Microsoft Sans Serif", 10);
                        label3.Font = new Font("Microsoft Sans Serif", 10);
                        label4.Font = new Font("Microsoft Sans Serif", 10);
                        label5.Font = new Font("Microsoft Sans Serif", 10);
                        label8.Font = new Font("Microsoft Sans Serif", 10);

                        менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10);
                        инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10);
                        авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 10);

                        richTextBox1.Font = new Font("Microsoft Sans Serif", 10);
                        break;
                    case 11:
                        label1.Font = new Font("Microsoft Sans Serif", 11);
                        label2.Font = new Font("Microsoft Sans Serif", 11);
                        label3.Font = new Font("Microsoft Sans Serif", 11);
                        label4.Font = new Font("Microsoft Sans Serif", 11);
                        label5.Font = new Font("Microsoft Sans Serif", 11);
                        label8.Font = new Font("Microsoft Sans Serif", 11);

                        менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11);
                        инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11);
                        авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11);

                        richTextBox1.Font = new Font("Microsoft Sans Serif", 11);
                        break;
                    case 12:
                        label1.Font = new Font("Microsoft Sans Serif", 12);
                        label2.Font = new Font("Microsoft Sans Serif", 12);
                        label3.Font = new Font("Microsoft Sans Serif", 12);
                        label4.Font = new Font("Microsoft Sans Serif", 12);
                        label5.Font = new Font("Microsoft Sans Serif", 12);
                        label8.Font = new Font("Microsoft Sans Serif", 12);

                        менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12);
                        инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12);
                        авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12);

                        richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
                        break;
                    case 13:
                        label1.Font = new Font("Microsoft Sans Serif", 13);
                        label2.Font = new Font("Microsoft Sans Serif", 13);
                        label3.Font = new Font("Microsoft Sans Serif", 13);
                        label4.Font = new Font("Microsoft Sans Serif", 13);
                        label5.Font = new Font("Microsoft Sans Serif", 13);
                        label8.Font = new Font("Microsoft Sans Serif", 13);

                        менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13);
                        инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13);
                        авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13);

                        richTextBox1.Font = new Font("Microsoft Sans Serif", 13);
                        break;
                    case 14:
                        label1.Font = new Font("Microsoft Sans Serif", 14);
                        label2.Font = new Font("Microsoft Sans Serif", 14);
                        label3.Font = new Font("Microsoft Sans Serif", 14);
                        label4.Font = new Font("Microsoft Sans Serif", 14);
                        label5.Font = new Font("Microsoft Sans Serif", 14);
                        label8.Font = new Font("Microsoft Sans Serif", 14);

                        менюToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14);
                        инструкцияToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14);
                        авторToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14);

                        richTextBox1.Font = new Font("Microsoft Sans Serif", 14);
                        break;
                }   // Загрузка шрифта в программе

                //switch (ScaleUI)        
                //{ }    // Размер интерфейса

                switch (Language)
                {
                    case "Русский":
                       label1.Text = "Адресса";
                       label2.Text = "Время сеанса";
                       label3.Text = "Сохранить";
                       label4.Text = "Время запуска:";
                       label5.Text = "Время работы:";
                       label8.Text = "Завершение:";

                       менюToolStripMenuItem.Text = "Меню";
                       инструкцияToolStripMenuItem.Text = "Инструкция";
                       авторToolStripMenuItem.Text = "Автор";
                        break;
                    case "Английский":
                       label1.Text = "URL";
                       label2.Text = "Session time";
                       label3.Text = "Save";
                       label4.Text = "Start time:";
                       label5.Text = "Working time:";
                       label8.Text = "Finishing:";

                       менюToolStripMenuItem.Text = "Menu";
                       инструкцияToolStripMenuItem.Text = "Manual";
                       авторToolStripMenuItem.Text = "Author";
                        break;
                }   // Язык приложения

                /*
                switch (ColorLine)
                {
                    case "Жёлтый":
                        chart1.Series[0].Color = Color.FromArgb(255,255,0);
                        break;
                    case "Красный":
                        chart1.Series[0].Color = Color.FromArgb(255, 0, 0);
                        break;
                    case "Серый":
                        chart1.Series[0].Color = Color.FromArgb(128, 128, 0);
                        break;
                    case "Синий":
                        chart1.Series[0].Color = Color.FromArgb(0, 0, 255);
                        break;
                    case "Чёрный":
                        chart1.Series[0].Color = Color.FromArgb(0,0,0);
                        break;
                }  // Цвет линии графика
                */

                switch(SizeLine)
                {
                    case 1:
                        chart1.Series[0].BorderWidth = 1;
                        break;
                    case 2:
                        chart1.Series[0].BorderWidth = 2;
                        break;
                    case 3:
                        chart1.Series[0].BorderWidth = 3;
                        break;
                    case 4:
                        chart1.Series[0].BorderWidth = 4;
                        break;
                    case 5:
                        chart1.Series[0].BorderWidth = 5;
                        break;
                    case 6:
                        chart1.Series[0].BorderWidth = 6;
                        break;
                }    // Толщина линии

                switch(Graphics)
                {
                    case "Точка":
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        break;
                    case "Линия":
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        break;
                    case "Гладкий":
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                        break;
                    case "Колонны":
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        break;
                    case "Боковые колонны":
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                        break;
                    case "Пузырьковый":
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                        break;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("К сожалению нам не удалось получить настройки, все настройки выставлены ПО УМОЛЧАНИЮ!");
            }

            comboBox1.SelectedIndex = 0;

            chart1.Series[0].Points.Clear();            // Чистим график
            
            chart1.ChartAreas[0].AxisY.Minimum = 0;     // Минимум по Y
            chart1.ChartAreas[0].AxisY.Maximum = 5;     // Максимум по Y

        }

        void VisiblePanel()
        {
            if(Hide == false)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
                textBox1.Visible = false;
                comboBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
                Hide = true;
            }else
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label8.Visible = true;
                textBox1.Visible = true;
                comboBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = true;
                Hide = false;
            }
        }

        void Ping(string ip, int index)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните поле IP");
            }
            else
            {
               
                Ping ping = new Ping();
                PingOptions options = new PingOptions();
                PingReply reply = ping.Send(ip);
                string output = "\n";
                DateTime today = DateTime.Now;

                output += today.ToLongTimeString();                     // Текущая дата
                output += " PING: ";
                output += reply.RoundtripTime.ToString();               // Отклик в мс
                output += " мс\n";
                
                SaveHistoryPing[index] += output;

                PackageOUT[index]++;                                           // Пакетов отправленно
                if (reply.Status == IPStatus.Success) { PackageIN[index]++; }  // Пакетов полученно

                this.Invoke((MethodInvoker)delegate ()                  // Выполнения действие с формой в потоке
                {
                    richTextBox1.AppendText(output);                    // Вывести текст в блок 
                    
                    if (reply.RoundtripTime > 0 && reply.RoundtripTime > chart1.ChartAreas[0].AxisY.Maximum) // Если по Y полученный пинг больше 0 и больше предыдущего максимального
                    { 
                        chart1.ChartAreas[0].AxisY.Maximum = reply.RoundtripTime;   
                    }

                    chart1.Series[index].Points.AddXY(today.ToLongTimeString(), reply.RoundtripTime);       // Добавляем время и пинг
                });
               
                
            }
        }

        int GetSecondWork()                 // Возврщает заданное время выполнения программы * 2
        {
            int count = 0;

            int index = comboBox1.SelectedIndex;

            switch (index)
            {
                case 0:                         // 5 секунд
                    count = 10;
                    break;
                case 1:                         // 10 минут
                    count = 1200;
                    break;
                case 2:                         // 30 минут
                    count = 3600;
                    break;
                case 3:                         // 1 час
                    count = 7200;
                    break;
                case 4:                         // 4 часа
                    count = 28800;
                    break;
                case 5:                         // 8 часов
                    count = 57600;
                    break;
                case 6:                         // 24 часа
                    count = 86400;
                    break;
                case 7:                         // Бесконечно
                    count = 18000000;
                    break;
                default:
                    MessageBox.Show("Время не выбрано!");
                    break;
            }

            return count;
        }

        void StartPing()
        {
            int count = 0;
            String[] urls = textBox1.Text.Split('|');
            String first = "127.0.0.1", second = "127.0.0.1", third = "127.0.0.1", fourth = "127.0.0.1", fifth = "127.0.0.1";   // Для защиты и хранения IP введёных юзером
            switch (countURL)
            {
                case 1:
                    first = urls[0];

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        chart1.Series[0].LegendText = urls[0];

                        chart1.Series[1].LegendText = "-";
                        chart1.Series[2].LegendText = "-";
                        chart1.Series[3].LegendText = "-";
                        chart1.Series[4].LegendText = "-";
                    });
                    break;
                case 2:
                    first = urls[0];
                    second = urls[1];

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        chart1.Series[0].LegendText = urls[0];
                        chart1.Series[1].LegendText = urls[1];

                        chart1.Series[2].LegendText = "-";
                        chart1.Series[3].LegendText = "-";
                        chart1.Series[4].LegendText = "-";
                    });
                    break;
                case 3:
                    first = urls[0];
                    second = urls[1];
                    third = urls[2];

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        chart1.Series[0].LegendText = urls[0];
                        chart1.Series[1].LegendText = urls[1];
                        chart1.Series[2].LegendText = urls[2];

                        chart1.Series[3].LegendText = "-";
                        chart1.Series[4].LegendText = "-";
                    });
                    break;
                case 4:
                    first = urls[0];
                    second = urls[1];
                    third = urls[2];
                    fourth = urls[3];

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        chart1.Series[0].LegendText = urls[0];
                        chart1.Series[1].LegendText = urls[1];
                        chart1.Series[2].LegendText = urls[2];
                        chart1.Series[3].LegendText = urls[3];

                        chart1.Series[4].LegendText = "-";
                    });
                    break;
                case 5:
                    first = urls[0];
                    second = urls[1];
                    third = urls[2];
                    fourth = urls[3];
                    fifth = urls[4];

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        chart1.Series[0].LegendText = urls[0];
                        chart1.Series[1].LegendText = urls[1];
                        chart1.Series[2].LegendText = urls[2];
                        chart1.Series[3].LegendText = urls[3];
                        chart1.Series[4].LegendText = urls[4];
                    });
                    break;
                default:
                    first = urls[0];
                    break;
            }

            this.Invoke((MethodInvoker)delegate ()
            {
                count = GetSecondWork();
            });

            for (int i = 0; i < count; i++)
            {
                switch(countURL)
                {
                    case 1:
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            Ping(first, 0);
                        });
                        break;
                    case 2:
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            Ping(first, 0);
                            Ping(second, 1);
                        });
                        break;
                    case 3:
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            Ping(first, 0);
                            Ping(second, 1);
                            Ping(third, 2);
                        });
                        break;
                    case 4:
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            Ping(first, 0);
                            Ping(second, 1);
                            Ping(third, 2);
                            Ping(fourth, 3);
                        });
                        break;
                    case 5:
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            Ping(first, 0);
                            Ping(second, 1);
                            Ping(third, 2);
                            Ping(fourth, 3);
                            Ping(fifth, 4);
                        });
                        break;

                }
                if (i % 2 == 0) 
                {
                    TimeWork++;             // Считаем время выполнения 
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        label5.Text = "Время работы: " + ConvertSecToTime(TimeWork);
                    });
                }     
                Thread.Sleep(500);
            }
            this.Invoke((MethodInvoker)delegate ()
            {
                button1.BackColor = Color.FromArgb(128, 255, 128);
                button1.Text = "Старт";
                // Обнуляем значения
                switch (countURL)
                {
                    case 1:
                        OutputInFile(first, 0);
                        break;
                    case 2:
                        OutputInFile(first, 0);
                        OutputInFile(second, 1);
                        break;
                    case 3:
                        OutputInFile(first, 0);
                        OutputInFile(second, 1);
                        OutputInFile(third, 2);
                        break;
                    case 4:
                        OutputInFile(first, 0);
                        OutputInFile(second, 1);
                        OutputInFile(third, 2);
                        OutputInFile(fourth, 3);
                        break;
                    case 5:
                        OutputInFile(first, 0);
                        OutputInFile(second, 1);
                        OutputInFile(third, 2);
                        OutputInFile(fourth, 3);
                        OutputInFile(fifth, 4);
                        break;
                }
                for(int i = 0; i < 5; i++)
                {
                    PackageIN[i] = 0;
                    PackageOUT[i] = 0;
                }
                TimeWork = 0;
            });
            th.Abort();
        }

        String ConvertSecToTime(int second)
        {
            int time = second;
            int h, m, s;
            h = time / 3600;
            int tmp = h;
            h = h - (24 * (h / 24));
            tmp = tmp - h;
            time = time - tmp * 3600;
            m = (time - (h * 3600)) / 60;
            s = (time - (h * 3600) - (m * 60)) % 60;
            if(time < 3600)
            {
                return (m / 10) + (m % 10) + (":") + (s / 10) + (s % 10);
            }
            return  (h) + (":") + (m / 10) + (m % 10) + (":") + (s / 10) + (s % 10);
        }

        public void OutputInFile(string nameFile, int index)
        {
            String path = textBox2.Text;

            DirectoryInfo data = new DirectoryInfo(@path);
            data.Create();

            var sw = new StreamWriter(textBox2.Text + "\\" + nameFile + ".txt",true);
            sw.WriteLine("Отчёт\n");
            sw.WriteLine("Начало работы: " + TimeStart);
            sw.WriteLine("\nАдрес: " + nameFile);
            sw.WriteLine("\nЗаданное время: " + comboBox1.Text);
            sw.WriteLine("\nПрошло: " + ConvertSecToTime(TimeWork));
            sw.WriteLine("\nПакеты: " + PackageOUT[index].ToString() + " / " + PackageIN[index].ToString() + "\n");
            sw.WriteLine(SaveHistoryPing[index]);
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == String.Empty)
            {
                MessageBox.Show("Введите IP");
                return;
            }
            if (button1.Text == "Старт")
            {
                TimeStart = DateTime.Now;
                th = new Thread(delegate () { StartPing(); });
                button1.BackColor = Color.FromArgb(255, 91, 64);
                button1.Text = "Стоп";
                label4.Text = "Время запуска: " + TimeStart.ToLongTimeString();
                richTextBox1.Clear();
                richTextBox1.Text = "Log";
                DateTime TimeEnd = TimeStart.AddSeconds(GetSecondWork() / 2);
                label8.Text = "Завершение: " + TimeEnd.ToLongTimeString();
                th.Start();
            }else
            {
                if (button1.Text == "Стоп")
                {
                    button1.BackColor = Color.FromArgb(128, 255, 128);
                    button1.Text = "Старт";
                    th.Abort();         // Выключаем поток

                    String[] urls = textBox1.Text.Split('|');
                    String first = "127.0.0.1", second = "127.0.0.1", third = "127.0.0.1", fourth = "127.0.0.1", fifth = "127.0.0.1";

                    switch (countURL)
                    {
                        case 1:
                            first = urls[0];

                            OutputInFile(first, 0);
                            break;
                        case 2:
                            first = urls[0];
                            second = urls[1];

                            OutputInFile(first, 0);
                            OutputInFile(second, 1);
                            break;
                        case 3:
                            first = urls[0];
                            second = urls[1];
                            third = urls[2];

                            OutputInFile(first, 0);
                            OutputInFile(second, 1);
                            OutputInFile(third, 2);
                            break;
                        case 4:
                            first = urls[0];
                            second = urls[1];
                            third = urls[2];
                            fourth = urls[3];

                            OutputInFile(first, 0);
                            OutputInFile(second, 1);
                            OutputInFile(third, 2);
                            OutputInFile(fourth, 3);
                            break;
                        case 5:
                            first = urls[0];
                            second = urls[1];
                            third = urls[2];
                            fourth = urls[3];
                            fifth = urls[4];

                            OutputInFile(first, 0);
                            OutputInFile(second, 1);
                            OutputInFile(third, 2);
                            OutputInFile(fourth, 3);
                            OutputInFile(fifth, 4);
                            break;
                        default:
                            first = urls[0];
                            MessageBox.Show("К сожалению не удалось записать данные пинговки в файл.");
                            break;
                    }

                    //OutputInFile();

                    for (int i = 0; i < 5; i++)
                    {
                        PackageIN[i] = 0;
                        PackageOUT[i] = 0;
                    }
                    TimeWork = 0;
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (th != null) 
            {
                th.Abort();
            }
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author formAuthor = new Author();
            formAuthor.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Сделать зум
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingsPing SP = new SettingsPing();
            SP.ShowDialog();
            VisiblePanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SettingsPing SP = new SettingsPing();
            SP.ShowDialog();
        }
    }
}
