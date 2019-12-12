namespace DZ
{
    partial class Form1
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
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxLevenTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLeven = new System.Windows.Forms.Button();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(19, 14);
            this.buttonReadFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(157, 28);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Чтение из файла";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время чтения из файла:";
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(19, 119);
            this.textBoxFileReadTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.ReadOnly = true;
            this.textBoxFileReadTime.Size = new System.Drawing.Size(157, 22);
            this.textBoxFileReadTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово для поиска:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(442, 17);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(173, 22);
            this.textBoxFind.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(387, 93);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(157, 28);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск слова";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchTime
            // 
            this.textBoxSearchTime.Location = new System.Drawing.Point(442, 54);
            this.textBoxSearchTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchTime.Name = "textBoxSearchTime";
            this.textBoxSearchTime.ReadOnly = true;
            this.textBoxSearchTime.Size = new System.Drawing.Size(173, 22);
            this.textBoxSearchTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска:";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(16, 264);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(675, 356);
            this.listBoxResult.TabIndex = 8;
            // 
            // textBoxLevenTime
            // 
            this.textBoxLevenTime.Location = new System.Drawing.Point(387, 234);
            this.textBoxLevenTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLevenTime.Name = "textBoxLevenTime";
            this.textBoxLevenTime.ReadOnly = true;
            this.textBoxLevenTime.Size = new System.Drawing.Size(301, 22);
            this.textBoxLevenTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Время поиска Левенштейна:";
            // 
            // buttonLeven
            // 
            this.buttonLeven.Location = new System.Drawing.Point(16, 201);
            this.buttonLeven.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLeven.Name = "buttonLeven";
            this.buttonLeven.Size = new System.Drawing.Size(157, 55);
            this.buttonLeven.TabIndex = 9;
            this.buttonLeven.Text = "Поиск алгоритмом Левенштейна";
            this.buttonLeven.UseVisualStyleBackColor = true;
            this.buttonLeven.Click += new System.EventHandler(this.buttonLeven_Click);
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(310, 155);
            this.textBoxMaxDist.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(381, 22);
            this.textBoxMaxDist.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Максимальное расстояние Левенштейна:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(531, 688);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(159, 28);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(19, 688);
            this.buttonSaveReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(187, 28);
            this.buttonSaveReport.TabIndex = 15;
            this.buttonSaveReport.Text = "Сохранение отчета";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(19, 67);
            this.textBoxFileReadCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.ReadOnly = true;
            this.textBoxFileReadCount.Size = new System.Drawing.Size(157, 22);
            this.textBoxFileReadCount.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Количество слов:";
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(346, 192);
            this.textBoxThreadCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(89, 22);
            this.textBoxThreadCount.TabIndex = 19;
            this.textBoxThreadCount.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество потоков:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 731);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLevenTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLeven);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxSearchTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReadFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Поиск в файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxLevenTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLeven;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.Label label7;
    }
}

