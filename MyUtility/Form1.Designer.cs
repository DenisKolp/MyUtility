namespace MyUtility
{
    partial class fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasteTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasteDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasteHello = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tbProgram = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbGenerate = new System.Windows.Forms.Label();
            this.tbGenerate = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tbCopy = new System.Windows.Forms.Button();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tbProgram.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            this.tb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            resources.ApplyResources(this.менюToolStripMenuItem, "менюToolStripMenuItem");
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            resources.ApplyResources(this.tsmiExit, "tsmiExit");
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPasteTime,
            this.tsmiPasteDate,
            this.tsmiPasteHello,
            this.toolStripMenuItem2,
            this.сохранитьToolStripMenuItem1,
            this.загрузитьToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            // 
            // tsmiPasteTime
            // 
            this.tsmiPasteTime.Name = "tsmiPasteTime";
            resources.ApplyResources(this.tsmiPasteTime, "tsmiPasteTime");
            this.tsmiPasteTime.Click += new System.EventHandler(this.tsmiPasteTime_Click);
            // 
            // tsmiPasteDate
            // 
            this.tsmiPasteDate.Name = "tsmiPasteDate";
            resources.ApplyResources(this.tsmiPasteDate, "tsmiPasteDate");
            this.tsmiPasteDate.Click += new System.EventHandler(this.tsmiPasteDate_Click);
            // 
            // tsmiPasteHello
            // 
            this.tsmiPasteHello.Name = "tsmiPasteHello";
            resources.ApplyResources(this.tsmiPasteHello, "tsmiPasteHello");
            this.tsmiPasteHello.Click += new System.EventHandler(this.tsmiPasteHello_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInfo});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            // 
            // tsmiInfo
            // 
            this.tsmiInfo.Name = "tsmiInfo";
            resources.ApplyResources(this.tsmiInfo, "tsmiInfo");
            this.tsmiInfo.Click += new System.EventHandler(this.tsmiInfo_Click);
            // 
            // tbProgram
            // 
            this.tbProgram.Controls.Add(this.tb1);
            this.tbProgram.Controls.Add(this.tb2);
            this.tbProgram.Controls.Add(this.tb3);
            this.tbProgram.Controls.Add(this.tb4);
            resources.ApplyResources(this.tbProgram, "tbProgram");
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.SelectedIndex = 0;
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.DimGray;
            this.tb1.Controls.Add(this.lbCount);
            this.tb1.Controls.Add(this.button3);
            this.tb1.Controls.Add(this.button2);
            this.tb1.Controls.Add(this.button1);
            resources.ApplyResources(this.tb1, "tb1");
            this.tb1.Name = "tb1";
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.DimGray;
            this.tb2.Controls.Add(this.cbRandom);
            this.tb2.Controls.Add(this.tbCopy);
            this.tb2.Controls.Add(this.button5);
            this.tb2.Controls.Add(this.tbGenerate);
            this.tb2.Controls.Add(this.lbGenerate);
            this.tb2.Controls.Add(this.lbTo);
            this.tb2.Controls.Add(this.lbFrom);
            this.tb2.Controls.Add(this.label1);
            this.tb2.Controls.Add(this.numericUpDown2);
            this.tb2.Controls.Add(this.numericUpDown1);
            this.tb2.Controls.Add(this.button4);
            resources.ApplyResources(this.tb2, "tb2");
            this.tb2.Name = "tb2";
            // 
            // tb3
            // 
            this.tb3.BackColor = System.Drawing.Color.DimGray;
            this.tb3.Controls.Add(this.rtbNotepad);
            resources.ApplyResources(this.tb3, "tb3");
            this.tb3.Name = "tb3";
            // 
            // tb4
            // 
            this.tb4.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.tb4, "tb4");
            this.tb4.Name = "tb4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbCount
            // 
            resources.ApplyResources(this.lbCount, "lbCount");
            this.lbCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCount.Name = "lbCount";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // lbFrom
            // 
            resources.ApplyResources(this.lbFrom, "lbFrom");
            this.lbFrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFrom.Name = "lbFrom";
            // 
            // lbTo
            // 
            resources.ApplyResources(this.lbTo, "lbTo");
            this.lbTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTo.Name = "lbTo";
            // 
            // lbGenerate
            // 
            resources.ApplyResources(this.lbGenerate, "lbGenerate");
            this.lbGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGenerate.Name = "lbGenerate";
            // 
            // tbGenerate
            // 
            resources.ApplyResources(this.tbGenerate, "tbGenerate");
            this.tbGenerate.Name = "tbGenerate";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbCopy
            // 
            resources.ApplyResources(this.tbCopy, "tbCopy");
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.UseVisualStyleBackColor = true;
            this.tbCopy.Click += new System.EventHandler(this.tbCopy_Click);
            // 
            // cbRandom
            // 
            resources.ApplyResources(this.cbRandom, "cbRandom");
            this.cbRandom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            resources.ApplyResources(this.rtbNotepad, "rtbNotepad");
            this.rtbNotepad.Name = "rtbNotepad";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            resources.ApplyResources(this.сохранитьToolStripMenuItem1, "сохранитьToolStripMenuItem1");
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            resources.ApplyResources(this.загрузитьToolStripMenuItem, "загрузитьToolStripMenuItem");
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // fm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tbProgram);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tbProgram.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb1.PerformLayout();
            this.tb2.ResumeLayout(false);
            this.tb2.PerformLayout();
            this.tb3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasteTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasteDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasteHello;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tbProgram;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.TabPage tb3;
        private System.Windows.Forms.TabPage tb4;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGenerate;
        private System.Windows.Forms.TextBox tbGenerate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button tbCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    }
}

