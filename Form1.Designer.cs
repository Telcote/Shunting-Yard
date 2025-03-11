namespace model_lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            buttonTick = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            buttonStart = new Button();
            buttonStop = new Button();
            autoMode = new RadioButton();
            manualMode = new RadioButton();
            label3 = new Label();
            button21 = new Button();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button13 = new Button();
            dataGridView1 = new DataGridView();
            dijkstraPostfixBindingSource = new BindingSource(components);
            richTextBox1 = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelArrow = new Label();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button22 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dijkstraPostfixBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 57);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(610, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(696, 57);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(645, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 2;
            label1.Text = "Входная строка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(696, 25);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Выходная строка";
            // 
            // button1
            // 
            button1.Location = new Point(12, 115);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonInputHandler;
            // 
            // button2
            // 
            button2.Location = new Point(135, 115);
            button2.Name = "button2";
            button2.Size = new Size(117, 47);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonInputHandler;
            // 
            // button3
            // 
            button3.Location = new Point(258, 115);
            button3.Name = "button3";
            button3.Size = new Size(117, 47);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonInputHandler;
            // 
            // button4
            // 
            button4.Location = new Point(258, 168);
            button4.Name = "button4";
            button4.Size = new Size(117, 47);
            button4.TabIndex = 9;
            button4.Text = ")";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonInputHandler;
            // 
            // button5
            // 
            button5.Location = new Point(135, 168);
            button5.Name = "button5";
            button5.Size = new Size(117, 47);
            button5.TabIndex = 8;
            button5.Text = "(";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonInputHandler;
            // 
            // button6
            // 
            button6.Location = new Point(12, 168);
            button6.Name = "button6";
            button6.Size = new Size(117, 47);
            button6.TabIndex = 7;
            button6.Text = "^";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonInputHandler;
            // 
            // button7
            // 
            button7.Location = new Point(381, 115);
            button7.Name = "button7";
            button7.Size = new Size(117, 47);
            button7.TabIndex = 10;
            button7.Text = "/";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonInputHandler;
            // 
            // button8
            // 
            button8.Location = new Point(381, 168);
            button8.Name = "button8";
            button8.Size = new Size(117, 47);
            button8.TabIndex = 11;
            button8.Text = "ln";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonInputHandler;
            // 
            // button9
            // 
            button9.Location = new Point(381, 221);
            button9.Name = "button9";
            button9.Size = new Size(117, 47);
            button9.TabIndex = 15;
            button9.Text = "sqrt";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonInputHandler;
            // 
            // button10
            // 
            button10.Location = new Point(258, 221);
            button10.Name = "button10";
            button10.Size = new Size(117, 47);
            button10.TabIndex = 14;
            button10.Text = "tg";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonInputHandler;
            // 
            // button11
            // 
            button11.Location = new Point(135, 221);
            button11.Name = "button11";
            button11.Size = new Size(117, 47);
            button11.TabIndex = 13;
            button11.Text = "cos";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonInputHandler;
            // 
            // button12
            // 
            button12.Location = new Point(12, 221);
            button12.Name = "button12";
            button12.Size = new Size(117, 47);
            button12.TabIndex = 12;
            button12.Text = "sin";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonInputHandler;
            // 
            // buttonTick
            // 
            buttonTick.Enabled = false;
            buttonTick.Location = new Point(12, 515);
            buttonTick.Name = "buttonTick";
            buttonTick.Size = new Size(117, 44);
            buttonTick.TabIndex = 17;
            buttonTick.Text = "Такт";
            buttonTick.UseVisualStyleBackColor = true;
            buttonTick.Click += buttonTickHandler;
            // 
            // button14
            // 
            button14.Location = new Point(381, 274);
            button14.Name = "button14";
            button14.Size = new Size(117, 47);
            button14.TabIndex = 21;
            button14.Text = "d";
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonInputHandler;
            // 
            // button15
            // 
            button15.Location = new Point(258, 274);
            button15.Name = "button15";
            button15.Size = new Size(117, 47);
            button15.TabIndex = 20;
            button15.Text = "c";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonInputHandler;
            // 
            // button16
            // 
            button16.Location = new Point(135, 274);
            button16.Name = "button16";
            button16.Size = new Size(117, 47);
            button16.TabIndex = 19;
            button16.Text = "b";
            button16.UseVisualStyleBackColor = true;
            button16.Click += buttonInputHandler;
            // 
            // button17
            // 
            button17.Location = new Point(12, 274);
            button17.Name = "button17";
            button17.Size = new Size(117, 47);
            button17.TabIndex = 18;
            button17.Text = "a";
            button17.UseVisualStyleBackColor = true;
            button17.Click += buttonInputHandler;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(144, 515);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(117, 44);
            buttonStart.TabIndex = 22;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonTickHandler;
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Location = new Point(280, 515);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(117, 44);
            buttonStop.TabIndex = 23;
            buttonStop.Text = "Стоп";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonTickHandler;
            // 
            // autoMode
            // 
            autoMode.AutoSize = true;
            autoMode.Checked = true;
            autoMode.Location = new Point(12, 619);
            autoMode.Name = "autoMode";
            autoMode.Size = new Size(235, 24);
            autoMode.TabIndex = 24;
            autoMode.TabStop = true;
            autoMode.Text = "Автоматический(по таймеру)";
            autoMode.UseVisualStyleBackColor = true;
            autoMode.CheckedChanged += autoMode_CheckedChanged;
            // 
            // manualMode
            // 
            manualMode.AutoSize = true;
            manualMode.Location = new Point(12, 649);
            manualMode.Name = "manualMode";
            manualMode.Size = new Size(113, 24);
            manualMode.TabIndex = 25;
            manualMode.Text = "Пошаговый";
            manualMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 586);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 26;
            label3.Text = "Выбор режима";
            // 
            // button21
            // 
            button21.Location = new Point(12, 380);
            button21.Name = "button21";
            button21.Size = new Size(240, 47);
            button21.TabIndex = 28;
            button21.Text = "CLR";
            button21.UseVisualStyleBackColor = true;
            button21.Click += buttonInputHandler;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 124);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 30;
            label4.Text = "Стек";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button13
            // 
            button13.Location = new Point(258, 380);
            button13.Name = "button13";
            button13.Size = new Size(240, 47);
            button13.TabIndex = 31;
            button13.Text = "BackSp";
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonInputHandler;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.CausesValidation = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(696, 147);
            dataGridView1.MinimumSize = new Size(16, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(286, 222);
            dataGridView1.TabIndex = 32;
            // 
            // dijkstraPostfixBindingSource
            // 
            dijkstraPostfixBindingSource.DataSource = typeof(DijkstraPostfix);
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(988, 147);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(353, 222);
            richTextBox1.TabIndex = 34;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(617, 147);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(73, 496);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // labelArrow
            // 
            labelArrow.AutoSize = true;
            labelArrow.Location = new Point(589, 150);
            labelArrow.Name = "labelArrow";
            labelArrow.Size = new Size(22, 20);
            labelArrow.TabIndex = 36;
            labelArrow.Text = "→";
            // 
            // button18
            // 
            button18.Location = new Point(381, 327);
            button18.Name = "button18";
            button18.Size = new Size(117, 47);
            button18.TabIndex = 40;
            button18.Text = "i";
            button18.UseVisualStyleBackColor = true;
            button18.Click += buttonInputHandler;
            // 
            // button19
            // 
            button19.Location = new Point(258, 327);
            button19.Name = "button19";
            button19.Size = new Size(117, 47);
            button19.TabIndex = 39;
            button19.Text = "g";
            button19.UseVisualStyleBackColor = true;
            button19.Click += buttonInputHandler;
            // 
            // button20
            // 
            button20.Location = new Point(135, 327);
            button20.Name = "button20";
            button20.Size = new Size(117, 47);
            button20.TabIndex = 38;
            button20.Text = "f";
            button20.UseVisualStyleBackColor = true;
            button20.Click += buttonInputHandler;
            // 
            // button22
            // 
            button22.Location = new Point(12, 327);
            button22.Name = "button22";
            button22.Size = new Size(117, 47);
            button22.TabIndex = 37;
            button22.Text = "e";
            button22.UseVisualStyleBackColor = true;
            button22.Click += buttonInputHandler;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 685);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button22);
            Controls.Add(labelArrow);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button13);
            Controls.Add(label4);
            Controls.Add(button21);
            Controls.Add(label3);
            Controls.Add(manualMode);
            Controls.Add(autoMode);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(buttonTick);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dijkstraPostfixBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button buttonTick;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button buttonStart;
        private Button buttonStop;
        private RadioButton autoMode;
        private RadioButton manualMode;
        private Label label3;
        private Button button21;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button button13;
        private DataGridView dataGridView1;
        private BindingSource dijkstraPostfixBindingSource;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelArrow;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button22;
    }
}