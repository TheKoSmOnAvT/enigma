namespace Enigma
{
    partial class Form1
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
            System.Windows.Forms.Splitter splitter1;
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FirstRoter = new System.Windows.Forms.Label();
            this.ThridRoter = new System.Windows.Forms.Label();
            this.SecondRoter = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.TextBoxOut = new System.Windows.Forms.TextBox();
            this.OUTPUT = new System.Windows.Forms.Label();
            this.INPUT = new System.Windows.Forms.Label();
            this.ComboFirst = new System.Windows.Forms.ComboBox();
            this.ComboThrid = new System.Windows.Forms.ComboBox();
            this.ComboSecond = new System.Windows.Forms.ComboBox();
            splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitter1.CausesValidation = false;
            splitter1.Cursor = System.Windows.Forms.Cursors.Hand;
            splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            splitter1.Enabled = false;
            splitter1.Location = new System.Drawing.Point(0, 314);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            splitter1.MinExtra = 20;
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1067, 240);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.Splitter1_SplitterMoved);
            splitter1.BackColorChanged += new System.EventHandler(this.Splitter1_BackColorChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(551, 28);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 26);
            this.progressBar1.TabIndex = 1;
            // 
            // FirstRoter
            // 
            this.FirstRoter.AutoSize = true;
            this.FirstRoter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstRoter.Location = new System.Drawing.Point(267, 16);
            this.FirstRoter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstRoter.Name = "FirstRoter";
            this.FirstRoter.Size = new System.Drawing.Size(70, 17);
            this.FirstRoter.TabIndex = 2;
            this.FirstRoter.Text = "FirstRoter";
            this.FirstRoter.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ThridRoter
            // 
            this.ThridRoter.AutoSize = true;
            this.ThridRoter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThridRoter.Location = new System.Drawing.Point(20, 16);
            this.ThridRoter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThridRoter.Name = "ThridRoter";
            this.ThridRoter.Size = new System.Drawing.Size(76, 17);
            this.ThridRoter.TabIndex = 3;
            this.ThridRoter.Text = "ThridRoter";
            this.ThridRoter.Click += new System.EventHandler(this.ThridRouter_Click);
            // 
            // SecondRoter
            // 
            this.SecondRoter.AutoSize = true;
            this.SecondRoter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecondRoter.Location = new System.Drawing.Point(128, 16);
            this.SecondRoter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondRoter.Name = "SecondRoter";
            this.SecondRoter.Size = new System.Drawing.Size(91, 17);
            this.SecondRoter.TabIndex = 4;
            this.SecondRoter.Text = "SecondRoter";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(204)), true);
            this.StartButton.Location = new System.Drawing.Point(837, 478);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(172, 44);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "START";
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartButton.UseCompatibleTextRendering = true;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(21, 497);
            this.TextBoxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(784, 22);
            this.TextBoxInput.TabIndex = 6;
            // 
            // TextBoxOut
            // 
            this.TextBoxOut.Location = new System.Drawing.Point(21, 262);
            this.TextBoxOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxOut.Name = "TextBoxOut";
            this.TextBoxOut.Size = new System.Drawing.Size(1028, 22);
            this.TextBoxOut.TabIndex = 7;
            // 
            // OUTPUT
            // 
            this.OUTPUT.AutoSize = true;
            this.OUTPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OUTPUT.Location = new System.Drawing.Point(16, 209);
            this.OUTPUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OUTPUT.Name = "OUTPUT";
            this.OUTPUT.Size = new System.Drawing.Size(158, 39);
            this.OUTPUT.TabIndex = 13;
            this.OUTPUT.Text = "OUTPUT";
            // 
            // INPUT
            // 
            this.INPUT.AutoSize = true;
            this.INPUT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.INPUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INPUT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.INPUT.Location = new System.Drawing.Point(16, 431);
            this.INPUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.INPUT.Name = "INPUT";
            this.INPUT.Size = new System.Drawing.Size(121, 39);
            this.INPUT.TabIndex = 14;
            this.INPUT.Text = "INPUT";
            // 
            // ComboFirst
            // 
            this.ComboFirst.FormattingEnabled = true;
            this.ComboFirst.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.ComboFirst.Location = new System.Drawing.Point(265, 50);
            this.ComboFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboFirst.Name = "ComboFirst";
            this.ComboFirst.Size = new System.Drawing.Size(77, 24);
            this.ComboFirst.TabIndex = 15;
            this.ComboFirst.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ComboThrid
            // 
            this.ComboThrid.FormattingEnabled = true;
            this.ComboThrid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.ComboThrid.Location = new System.Drawing.Point(25, 50);
            this.ComboThrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboThrid.Name = "ComboThrid";
            this.ComboThrid.Size = new System.Drawing.Size(77, 24);
            this.ComboThrid.TabIndex = 16;
            this.ComboThrid.SelectedIndexChanged += new System.EventHandler(this.ComboThrid_SelectedIndexChanged);
            // 
            // ComboSecond
            // 
            this.ComboSecond.FormattingEnabled = true;
            this.ComboSecond.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.ComboSecond.Location = new System.Drawing.Point(151, 50);
            this.ComboSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboSecond.Name = "ComboSecond";
            this.ComboSecond.Size = new System.Drawing.Size(77, 24);
            this.ComboSecond.TabIndex = 17;
            this.ComboSecond.SelectedIndexChanged += new System.EventHandler(this.ComboSecond_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ComboSecond);
            this.Controls.Add(this.ComboThrid);
            this.Controls.Add(this.ComboFirst);
            this.Controls.Add(this.INPUT);
            this.Controls.Add(this.OUTPUT);
            this.Controls.Add(this.TextBoxOut);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SecondRoter);
            this.Controls.Add(this.ThridRoter);
            this.Controls.Add(this.FirstRoter);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ENIGMA!!!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label FirstRoter;
        private System.Windows.Forms.Label ThridRoter;
        private System.Windows.Forms.Label SecondRoter;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.TextBox TextBoxOut;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label OUTPUT;
        private System.Windows.Forms.Label INPUT;
        private System.Windows.Forms.ComboBox ComboFirst;
        private System.Windows.Forms.ComboBox ComboThrid;
        private System.Windows.Forms.ComboBox ComboSecond;
    }
}

