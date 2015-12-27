namespace GlobalVariables
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Code = new System.Windows.Forms.RichTextBox();
            this.AboutMetrics = new System.Windows.Forms.RichTextBox();
            this.ResultAnalys = new System.Windows.Forms.RichTextBox();
            this.LoadTxtFile = new System.Windows.Forms.Button();
            this.DeleteComment = new System.Windows.Forms.Button();
            this.Analys = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(2, 75);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(349, 349);
            this.Code.TabIndex = 0;
            this.Code.Text = "";
            // 
            // AboutMetrics
            // 
            this.AboutMetrics.Location = new System.Drawing.Point(373, 75);
            this.AboutMetrics.Name = "AboutMetrics";
            this.AboutMetrics.Size = new System.Drawing.Size(335, 349);
            this.AboutMetrics.TabIndex = 1;
            this.AboutMetrics.Text = resources.GetString("AboutMetrics.Text");
            // 
            // ResultAnalys
            // 
            this.ResultAnalys.Location = new System.Drawing.Point(745, 75);
            this.ResultAnalys.Name = "ResultAnalys";
            this.ResultAnalys.Size = new System.Drawing.Size(239, 140);
            this.ResultAnalys.TabIndex = 2;
            this.ResultAnalys.Text = "";
            // 
            // LoadTxtFile
            // 
            this.LoadTxtFile.Location = new System.Drawing.Point(2, 24);
            this.LoadTxtFile.Name = "LoadTxtFile";
            this.LoadTxtFile.Size = new System.Drawing.Size(138, 25);
            this.LoadTxtFile.TabIndex = 3;
            this.LoadTxtFile.Text = "Загрузить файл";
            this.LoadTxtFile.UseVisualStyleBackColor = true;
            this.LoadTxtFile.Click += new System.EventHandler(this.Load_Click);
            // 
            // DeleteComment
            // 
            this.DeleteComment.Location = new System.Drawing.Point(161, 26);
            this.DeleteComment.Name = "DeleteComment";
            this.DeleteComment.Size = new System.Drawing.Size(190, 23);
            this.DeleteComment.TabIndex = 4;
            this.DeleteComment.Text = "Удаление комментариев";
            this.DeleteComment.UseVisualStyleBackColor = true;
            this.DeleteComment.Click += new System.EventHandler(this.DeleteComment_Click);
            // 
            // Analys
            // 
            this.Analys.Location = new System.Drawing.Point(745, 26);
            this.Analys.Name = "Analys";
            this.Analys.Size = new System.Drawing.Size(117, 23);
            this.Analys.TabIndex = 5;
            this.Analys.Text = "Анализ";
            this.Analys.UseVisualStyleBackColor = true;
            this.Analys.Click += new System.EventHandler(this.Analys_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.FileName = "FileName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 455);
            this.Controls.Add(this.Analys);
            this.Controls.Add(this.DeleteComment);
            this.Controls.Add(this.LoadTxtFile);
            this.Controls.Add(this.ResultAnalys);
            this.Controls.Add(this.AboutMetrics);
            this.Controls.Add(this.Code);
            this.Name = "Form1";
            this.Text = "Global Variables";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Code;
        private System.Windows.Forms.RichTextBox AboutMetrics;
        private System.Windows.Forms.RichTextBox ResultAnalys;
        private System.Windows.Forms.Button LoadTxtFile;
        private System.Windows.Forms.Button DeleteComment;
        private System.Windows.Forms.Button Analys;
        private System.Windows.Forms.OpenFileDialog LoadFile;
    }
}

