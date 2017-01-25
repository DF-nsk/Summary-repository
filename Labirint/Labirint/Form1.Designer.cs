namespace Labirint
{
    partial class Form_Meny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Meny));
            this.checkBox_Sound = new System.Windows.Forms.CheckBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_Sound
            // 
            this.checkBox_Sound.AutoSize = true;
            this.checkBox_Sound.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Sound.Checked = true;
            this.checkBox_Sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Sound.Font = new System.Drawing.Font("Minion Pro", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Sound.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox_Sound.Location = new System.Drawing.Point(116, 120);
            this.checkBox_Sound.Name = "checkBox_Sound";
            this.checkBox_Sound.Size = new System.Drawing.Size(132, 37);
            this.checkBox_Sound.TabIndex = 0;
            this.checkBox_Sound.Text = "Sound Yes";
            this.checkBox_Sound.UseVisualStyleBackColor = false;
            this.checkBox_Sound.CheckedChanged += new System.EventHandler(this.checkBox_Sound_CheckedChanged);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Exit.Location = new System.Drawing.Point(335, 246);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 26);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Start.Location = new System.Drawing.Point(12, 246);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 26);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirint.Properties.Resources._7972;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 284);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.checkBox_Sound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Meny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабиринт 2D";
            this.Load += new System.EventHandler(this.Form_Meny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Sound;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Start;
    }
}

