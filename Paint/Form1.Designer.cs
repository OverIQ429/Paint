namespace Paint
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            button15 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            создатьПалатноToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // button1
            // 
            button1.Location = new Point(7, 213);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(7, 248);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 2;
            button2.Text = "Save As...";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(8, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 73);
            panel1.TabIndex = 3;
            // 
            // button14
            // 
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(102, 36);
            button14.Name = "button14";
            button14.Size = new Size(27, 27);
            button14.TabIndex = 7;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(69, 36);
            button13.Name = "button13";
            button13.Size = new Size(27, 27);
            button13.TabIndex = 6;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(36, 36);
            button12.Name = "button12";
            button12.Size = new Size(27, 27);
            button12.TabIndex = 5;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(3, 36);
            button11.Name = "button11";
            button11.Size = new Size(27, 27);
            button11.TabIndex = 4;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(102, 3);
            button10.Name = "button10";
            button10.Size = new Size(27, 27);
            button10.TabIndex = 3;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(69, 3);
            button9.Name = "button9";
            button9.Size = new Size(27, 27);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(36, 3);
            button4.Name = "button4";
            button4.Size = new Size(27, 27);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(27, 27);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(11, 180);
            button5.Name = "button5";
            button5.Size = new Size(27, 27);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(44, 180);
            button6.Name = "button6";
            button6.Size = new Size(27, 27);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(77, 180);
            button7.Name = "button7";
            button7.Size = new Size(27, 27);
            button7.TabIndex = 4;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(110, 180);
            button8.Name = "button8";
            button8.Size = new Size(27, 27);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.ControlLight;
            trackBar1.Location = new Point(3, 118);
            trackBar1.Maximum = 25;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(134, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 95);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Толщина";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button15);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 41);
            panel2.TabIndex = 7;
            // 
            // button15
            // 
            button15.Location = new Point(3, 3);
            button15.Name = "button15";
            button15.Size = new Size(94, 29);
            button15.TabIndex = 0;
            button15.Text = "Файл";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { создатьПалатноToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, оПрограммеToolStripMenuItem, загрузитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(195, 124);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // создатьПалатноToolStripMenuItem
            // 
            создатьПалатноToolStripMenuItem.Name = "создатьПалатноToolStripMenuItem";
            создатьПалатноToolStripMenuItem.Size = new Size(194, 24);
            создатьПалатноToolStripMenuItem.Text = "Создать палатно";
            создатьПалатноToolStripMenuItem.Click += создатьПалатноToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(194, 24);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(194, 24);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как..";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(194, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(194, 24);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(trackBar1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(659, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 450);
            panel3.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TrackBar trackBar1;
        private Label label1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
        private Button button15;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem создатьПалатноToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Panel panel3;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
    }
}
