namespace MyWindowsFomApp
{
    partial class DataUI
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
            this.Firstnum = new System.Windows.Forms.Label();
            this.SecondNum = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.FirstNumTextbox = new System.Windows.Forms.TextBox();
            this.SecondNumTextbox = new System.Windows.Forms.TextBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Firstnum
            // 
            this.Firstnum.AutoSize = true;
            this.Firstnum.Location = new System.Drawing.Point(53, 52);
            this.Firstnum.Name = "Firstnum";
            this.Firstnum.Size = new System.Drawing.Size(66, 13);
            this.Firstnum.TabIndex = 0;
            this.Firstnum.Text = "First Number";
            // 
            // SecondNum
            // 
            this.SecondNum.AutoSize = true;
            this.SecondNum.Location = new System.Drawing.Point(56, 91);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(84, 13);
            this.SecondNum.TabIndex = 1;
            this.SecondNum.Text = "Second Number";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(56, 127);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 13);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result";
            // 
            // FirstNumTextbox
            // 
            this.FirstNumTextbox.Location = new System.Drawing.Point(184, 52);
            this.FirstNumTextbox.Name = "FirstNumTextbox";
            this.FirstNumTextbox.Size = new System.Drawing.Size(100, 20);
            this.FirstNumTextbox.TabIndex = 3;
            // 
            // SecondNumTextbox
            // 
            this.SecondNumTextbox.Location = new System.Drawing.Point(184, 88);
            this.SecondNumTextbox.Name = "SecondNumTextbox";
            this.SecondNumTextbox.Size = new System.Drawing.Size(100, 20);
            this.SecondNumTextbox.TabIndex = 3;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(184, 124);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextbox.TabIndex = 3;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(209, 181);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DataUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.SecondNumTextbox);
            this.Controls.Add(this.FirstNumTextbox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.Firstnum);
            this.Name = "DataUI";
            this.Text = "DataUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Firstnum;
        private System.Windows.Forms.Label SecondNum;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox FirstNumTextbox;
        private System.Windows.Forms.TextBox SecondNumTextbox;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.Button ShowButton;
    }
}