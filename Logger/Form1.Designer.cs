
namespace Logger
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
            this.debugButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.debugEButton = new System.Windows.Forms.Button();
            this.debugFormatButton = new System.Windows.Forms.Button();
            this.ErrorButton = new System.Windows.Forms.Button();
            this.errorEButton = new System.Windows.Forms.Button();
            this.errorEOnlyButoon = new System.Windows.Forms.Button();
            this.fatalButton = new System.Windows.Forms.Button();
            this.fatalEButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(12, 33);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 23);
            this.debugButton.TabIndex = 0;
            this.debugButton.Text = "debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(670, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Location = new System.Drawing.Point(12, 389);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(46, 17);
            this.CheckLabel.TabIndex = 2;
            this.CheckLabel.Text = "label1";
            // 
            // debugEButton
            // 
            this.debugEButton.Location = new System.Drawing.Point(12, 78);
            this.debugEButton.Name = "debugEButton";
            this.debugEButton.Size = new System.Drawing.Size(75, 23);
            this.debugEButton.TabIndex = 3;
            this.debugEButton.Text = "debugE";
            this.debugEButton.UseVisualStyleBackColor = true;
            this.debugEButton.Click += new System.EventHandler(this.debugEButton_Click);
            // 
            // debugFormatButton
            // 
            this.debugFormatButton.Location = new System.Drawing.Point(12, 128);
            this.debugFormatButton.Name = "debugFormatButton";
            this.debugFormatButton.Size = new System.Drawing.Size(129, 23);
            this.debugFormatButton.TabIndex = 4;
            this.debugFormatButton.Text = "debugFormat";
            this.debugFormatButton.UseVisualStyleBackColor = true;
            this.debugFormatButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(176, 33);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(75, 23);
            this.ErrorButton.TabIndex = 5;
            this.ErrorButton.Text = "Error";
            this.ErrorButton.UseVisualStyleBackColor = true;
            this.ErrorButton.Click += new System.EventHandler(this.ErrorButton_Click);
            // 
            // errorEButton
            // 
            this.errorEButton.Location = new System.Drawing.Point(176, 78);
            this.errorEButton.Name = "errorEButton";
            this.errorEButton.Size = new System.Drawing.Size(75, 23);
            this.errorEButton.TabIndex = 6;
            this.errorEButton.Text = "ErrorE";
            this.errorEButton.UseVisualStyleBackColor = true;
            this.errorEButton.Click += new System.EventHandler(this.errorEButton_Click);
            // 
            // errorEOnlyButoon
            // 
            this.errorEOnlyButoon.Location = new System.Drawing.Point(176, 128);
            this.errorEOnlyButoon.Name = "errorEOnlyButoon";
            this.errorEOnlyButoon.Size = new System.Drawing.Size(89, 23);
            this.errorEOnlyButoon.TabIndex = 7;
            this.errorEOnlyButoon.Text = "ErrorEOnly";
            this.errorEOnlyButoon.UseVisualStyleBackColor = true;
            this.errorEOnlyButoon.Click += new System.EventHandler(this.errorEOnlyButoon_Click);
            // 
            // fatalButton
            // 
            this.fatalButton.Location = new System.Drawing.Point(296, 33);
            this.fatalButton.Name = "fatalButton";
            this.fatalButton.Size = new System.Drawing.Size(75, 23);
            this.fatalButton.TabIndex = 8;
            this.fatalButton.Text = "Fatal";
            this.fatalButton.UseVisualStyleBackColor = true;
            this.fatalButton.Click += new System.EventHandler(this.fatalButton_Click);
            // 
            // fatalEButton
            // 
            this.fatalEButton.Location = new System.Drawing.Point(296, 78);
            this.fatalEButton.Name = "fatalEButton";
            this.fatalEButton.Size = new System.Drawing.Size(75, 23);
            this.fatalEButton.TabIndex = 9;
            this.fatalEButton.Text = "fatalE";
            this.fatalEButton.UseVisualStyleBackColor = true;
            this.fatalEButton.Click += new System.EventHandler(this.fatalEButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fatalEButton);
            this.Controls.Add(this.fatalButton);
            this.Controls.Add(this.errorEOnlyButoon);
            this.Controls.Add(this.errorEButton);
            this.Controls.Add(this.ErrorButton);
            this.Controls.Add(this.debugFormatButton);
            this.Controls.Add(this.debugEButton);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.debugButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Button debugEButton;
        private System.Windows.Forms.Button debugFormatButton;
        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.Button errorEButton;
        private System.Windows.Forms.Button errorEOnlyButoon;
        private System.Windows.Forms.Button fatalButton;
        private System.Windows.Forms.Button fatalEButton;
    }
}

