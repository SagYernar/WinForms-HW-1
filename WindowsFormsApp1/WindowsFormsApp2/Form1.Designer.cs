namespace WindowsFormsApp2
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.buttonBigger = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(38, 21);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(211, 34);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Новая Игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.ButtonNewGame_Click);
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Location = new System.Drawing.Point(105, 172);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(75, 23);
            this.buttonEndGame.TabIndex = 1;
            this.buttonEndGame.Text = "Мое Число!";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Visible = false;
            this.buttonEndGame.Click += new System.EventHandler(this.ButtonEndGame_Click);
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(38, 143);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(75, 23);
            this.buttonLower.TabIndex = 2;
            this.buttonLower.Text = "Меньше";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Visible = false;
            this.buttonLower.Click += new System.EventHandler(this.ButtonLower_Click);
            // 
            // buttonBigger
            // 
            this.buttonBigger.Location = new System.Drawing.Point(173, 143);
            this.buttonBigger.Name = "buttonBigger";
            this.buttonBigger.Size = new System.Drawing.Size(75, 23);
            this.buttonBigger.TabIndex = 3;
            this.buttonBigger.Text = "Больше";
            this.buttonBigger.UseVisualStyleBackColor = true;
            this.buttonBigger.Visible = false;
            this.buttonBigger.Click += new System.EventHandler(this.ButtonBigger_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(124, 114);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(35, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "label1";
            this.labelNumber.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 257);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonBigger);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "Form1";
            this.Text = "Игра - угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Button buttonBigger;
        private System.Windows.Forms.Label labelNumber;
    }
}

