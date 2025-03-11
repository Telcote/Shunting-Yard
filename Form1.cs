using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace model_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Инициализация модельного слоя
        private DijkstraPostfix dijkstraPostfix = new DijkstraPostfix();

        private void Form1_Load(object sender, EventArgs e)
        {
            char[,] array = dijkstraPostfix.decisionMatrix;
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            this.dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = array[r, c];
                }

                this.dataGridView1.Rows.Add(row);
            }
        }

        //Ассоциативная таблица для математических символов
        private static Dictionary<byte, string> dictionary = new Dictionary<byte, string>()
        {
            { 0, "(" }, { 1, ")" }, { 2, "-" }, { 3, "+" },
            { 4, "/" }, { 5,  "*" }, { 6, "^" }, { 7, "ln"},
            { 8, "sin" }, { 9, "cos" }, { 10,  "tg" }, { 11, "sqrt"},
            { 12, "a" }, { 13, "b" }, { 14, "c" }, { 15, "d" }, 
            { 16, "e" }, { 17, "f" }, { 18, "g" }, { 19, "i" }

        };

        //Обработчик кнопок ввода
        private void buttonInputHandler(object sender, EventArgs e)
        {
            string label = (sender as Button).Text;

            switch (label)
            {
                case "CLR":
                    {
                        dijkstraPostfix.ClearAll();
                        UpdateTextBoxes();
                        break;
                    }
                case "BackSp":
                    {
                        dijkstraPostfix.RemoveLastItem();
                        UpdateTextBoxes();
                        break;
                    }
                default:
                    {
                        dijkstraPostfix.AddToList(GetByteByString(label));
                        this.textBox1.Text = ByteListToString(dijkstraPostfix.GetInputString());
                        break;
                    }
            }
        }

        //Обработчик кнопок управления модельным слоем
        private void buttonTickHandler(object sender, EventArgs e)
        {
            string label = (sender as Button).Text;
            switch (label)
            {
                case "Такт":
                    {
                        this.dijkstraPostfix.state = 1;

                        dijkstraPostfix.Tick();
                        UpdateTextBoxes();

                        break;
                    }
                case "Старт":
                    {
                        // Если выбран автоматический режим
                        if (this.autoMode.Checked)
                        {
                            // Запускаем таймер (см. функцию timer1_Tick)
                            timer1.Enabled = true;
                        }
                        // Если выбран пошаговый режим
                        else
                        {
                            dijkstraPostfix.Tick();
                            UpdateTextBoxes();
                        }

                        break;
                    }
                case "Стоп":
                    {
                        if (this.autoMode.Checked && this.buttonStart.Enabled == false)
                        {
                            this.buttonStart.Enabled = true;
                            this.timer1.Stop();
                        }
                        this.buttonStop.Enabled = false;
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.buttonStop.Enabled = true;
            this.buttonStart.Enabled = false;

            dijkstraPostfix.state = 1;

            dijkstraPostfix.Tick();
            UpdateTextBoxes();

            // Если дошли до конца массива или остановили выполнение вручную
            if (dijkstraPostfix.state == 0 || !this.buttonStop.Enabled)
            {
                timer1.Enabled = false;
                this.buttonStart.Enabled = true;
                this.buttonStop.Enabled = false;
            }
        }

        // Обновление текстовых полей
        private void UpdateTextBoxes()
        {
            this.textBox1.Text = ByteListToString(dijkstraPostfix.GetInputString());
            this.textBox2.Text = ByteListToString(dijkstraPostfix.GetOutputString());
            //this.listBox1.Items.AddRange(ByteListToStringList(dijkstraPostfix.GetStack()));
            var flowPanel = this.flowLayoutPanel1;
            int count = dijkstraPostfix.GetStack().Count;

            if (flowPanel.Controls.Count != count) {
                flowPanel.Controls.Clear();
                foreach (byte b in dijkstraPostfix.GetStack())
                {
                    flowPanel.Controls.Add(new TextBox()
                    {
                        Text = dictionary[b],
                        Size = new Size(flowPanel.Size.Width / 2, 16)
                    });

                }

                if (dijkstraPostfix.stackPointer > 0 && dijkstraPostfix.stackPointer <= flowPanel.Controls.Count)
                {
                    int y = flowPanel.Controls[dijkstraPostfix.stackPointer - 1].Location.Y;
                    var pt = new Point()
                    {
                        X = this.labelArrow.Location.X,
                        Y = y + flowPanel.Size.Height / 4 + 24
                    };
                    this.labelArrow.Location = pt;
                } 
                else
                {
                    var pt = new Point()
                    {
                        X = this.labelArrow.Location.X,
                        Y = flowPanel.PointToScreen(new Point()).Y + flowPanel.Size.Height / 2
                    };
                    this.labelArrow.Location = pt;
                }
            }
        }

        // Преобразование массива байтов в строку
        private string ByteListToString(List<byte> list)
        {
            string result = "";
            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                result += dictionary[enumerator.Current];
            }
            return result;
        }

        // Преобразование байта в строку
        private byte GetByteByString(string value)
        {
            foreach (var kvp in dictionary)
            {
                if (kvp.Value == value)
                {
                    return kvp.Key;
                }
            }
            return default;
        }

        private void autoMode_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonTick.Enabled = this.autoMode.Checked ? false : true;
        }
    }
}