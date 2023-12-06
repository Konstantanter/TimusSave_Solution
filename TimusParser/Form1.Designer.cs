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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelJudgeId = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxJUDGE = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textTaskCount = new System.Windows.Forms.TextBox();
            this.labelTaskCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.labelJudgeId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJudgeId.Location = new System.Drawing.Point(149, 68);
            this.labelJudgeId.Name = "labelJudgeId";
            this.labelJudgeId.Size = new System.Drawing.Size(84, 19);
            this.labelJudgeId.TabIndex = 1;
            this.labelJudgeId.Text = "JUDGE_ID:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(171, 106);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(61, 19);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Пароль:";
            // 
            // textBoxJUDGE
            // 
            this.textBoxJUDGE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxJUDGE.Location = new System.Drawing.Point(239, 65);
            this.textBoxJUDGE.Name = "textBoxJUDGE";
            this.textBoxJUDGE.Size = new System.Drawing.Size(119, 26);
            this.textBoxJUDGE.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(239, 103);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(119, 26);
            this.textBoxPass.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(574, 106);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(86, 32);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Lets\' Go";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textTaskCount
            // 
            this.textTaskCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTaskCount.Location = new System.Drawing.Point(585, 65);
            this.textTaskCount.Name = "textTaskCount";
            this.textTaskCount.Size = new System.Drawing.Size(75, 26);
            this.textTaskCount.TabIndex = 6;
            this.textTaskCount.Text = "2173";
            this.textTaskCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTaskCount
            // 
            this.labelTaskCount.AutoSize = true;
            this.labelTaskCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskCount.Location = new System.Drawing.Point(378, 68);
            this.labelTaskCount.Name = "labelTaskCount";
            this.labelTaskCount.Size = new System.Drawing.Size(201, 19);
            this.labelTaskCount.TabIndex = 7;
            this.labelTaskCount.Text = "Количество задач в системе:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 147);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(120, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Добро пожаловать в Timus Solutions Saver,\r\nпрограмма автоматической загрузки реше" +
    "ний";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
            this.Text = "Timus Solutions Saver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

