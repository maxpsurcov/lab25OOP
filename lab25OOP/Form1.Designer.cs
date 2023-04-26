namespace lab25OOP
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
            this.connectButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.usageTextBox = new System.Windows.Forms.TextBox();
            this.report1Button = new System.Windows.Forms.Button();
            this.report2Button = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(71, 378);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(161, 56);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "connectButton";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(272, 378);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(172, 56);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "insertButton";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(71, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(225, 29);
            this.nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(71, 112);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(225, 29);
            this.addressTextBox.TabIndex = 3;
            // 
            // usageTextBox
            // 
            this.usageTextBox.Location = new System.Drawing.Point(71, 180);
            this.usageTextBox.Name = "usageTextBox";
            this.usageTextBox.Size = new System.Drawing.Size(225, 29);
            this.usageTextBox.TabIndex = 4;
            // 
            // report1Button
            // 
            this.report1Button.Location = new System.Drawing.Point(71, 461);
            this.report1Button.Name = "report1Button";
            this.report1Button.Size = new System.Drawing.Size(161, 55);
            this.report1Button.TabIndex = 5;
            this.report1Button.Text = "report1Button";
            this.report1Button.UseVisualStyleBackColor = true;
            // 
            // report2Button
            // 
            this.report2Button.Location = new System.Drawing.Point(283, 461);
            this.report2Button.Name = "report2Button";
            this.report2Button.Size = new System.Drawing.Size(161, 55);
            this.report2Button.TabIndex = 6;
            this.report2Button.Text = "report2Button";
            this.report2Button.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(552, 411);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(184, 76);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(552, 319);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(278, 29);
            this.searchTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 643);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.report2Button);
            this.Controls.Add(this.report1Button);
            this.Controls.Add(this.usageTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox usageTextBox;
        private System.Windows.Forms.Button report1Button;
        private System.Windows.Forms.Button report2Button;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

