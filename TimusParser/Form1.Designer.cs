namespace TimusParser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelJudgeId = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxJUDGE = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textTaskCount = new System.Windows.Forms.TextBox();
            this.labelTaskCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(824, 197);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(480, 286);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // labelJudgeId
            // 
            this.labelJudgeId.AutoSize = true;
            this.labelJudgeId.Location = new System.Drawing.Point(31, 33);
            this.labelJudgeId.Name = "labelJudgeId";
            this.labelJudgeId.Size = new System.Drawing.Size(63, 13);
            this.labelJudgeId.TabIndex = 1;
            this.labelJudgeId.Text = "JUDGE_ID:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(33, 68);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(48, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Пароль:";
            // 
            // textBoxJUDGE
            // 
            this.textBoxJUDGE.Location = new System.Drawing.Point(100, 30);
            this.textBoxJUDGE.Name = "textBoxJUDGE";
            this.textBoxJUDGE.Size = new System.Drawing.Size(89, 20);
            this.textBoxJUDGE.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(100, 65);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(89, 20);
            this.textBoxPass.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(435, 65);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 24);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Lets\' Go";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textTaskCount
            // 
            this.textTaskCount.Location = new System.Drawing.Point(395, 30);
            this.textTaskCount.Name = "textTaskCount";
            this.textTaskCount.Size = new System.Drawing.Size(136, 20);
            this.textTaskCount.TabIndex = 6;
            this.textTaskCount.Text = "2173";
            // 
            // labelTaskCount
            // 
            this.labelTaskCount.AutoSize = true;
            this.labelTaskCount.Location = new System.Drawing.Point(233, 33);
            this.labelTaskCount.Name = "labelTaskCount";
            this.labelTaskCount.Size = new System.Drawing.Size(156, 13);
            this.labelTaskCount.TabIndex = 7;
            this.labelTaskCount.Text = "Количество задач в системе:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 206);
            this.Controls.Add(this.labelTaskCount);
            this.Controls.Add(this.textTaskCount);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxJUDGE);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelJudgeId);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelJudgeId;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxJUDGE;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textTaskCount;
        private System.Windows.Forms.Label labelTaskCount;
    }
}

