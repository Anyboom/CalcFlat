
namespace CalcFlat
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.CalcAction = new System.Windows.Forms.Button();
            this.ProfitBaseResultLabel = new System.Windows.Forms.Label();
            this.ProfitBaseLabel = new System.Windows.Forms.Label();
            this.ProfitPercentResultLabel = new System.Windows.Forms.Label();
            this.ProfitPercentLabel = new System.Windows.Forms.Label();
            this.FlatTextBox = new System.Windows.Forms.TextBox();
            this.FlatLabel = new System.Windows.Forms.Label();
            this.BasePathLabel = new System.Windows.Forms.Label();
            this.BasePathTextBox = new System.Windows.Forms.TextBox();
            this.BankLabel = new System.Windows.Forms.Label();
            this.BankTextBox = new System.Windows.Forms.TextBox();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.CalcAction);
            this.MainGroup.Controls.Add(this.ProfitBaseResultLabel);
            this.MainGroup.Controls.Add(this.ProfitBaseLabel);
            this.MainGroup.Controls.Add(this.ProfitPercentResultLabel);
            this.MainGroup.Controls.Add(this.ProfitPercentLabel);
            this.MainGroup.Controls.Add(this.FlatTextBox);
            this.MainGroup.Controls.Add(this.FlatLabel);
            this.MainGroup.Controls.Add(this.BasePathLabel);
            this.MainGroup.Controls.Add(this.BasePathTextBox);
            this.MainGroup.Controls.Add(this.BankLabel);
            this.MainGroup.Controls.Add(this.BankTextBox);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(360, 158);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // CalcAction
            // 
            this.CalcAction.Location = new System.Drawing.Point(266, 122);
            this.CalcAction.Name = "CalcAction";
            this.CalcAction.Size = new System.Drawing.Size(81, 23);
            this.CalcAction.TabIndex = 10;
            this.CalcAction.Text = "Вычислить";
            this.CalcAction.UseVisualStyleBackColor = true;
            this.CalcAction.Click += new System.EventHandler(this.CalcAction_Click);
            // 
            // ProfitBaseResultLabel
            // 
            this.ProfitBaseResultLabel.Location = new System.Drawing.Point(224, 86);
            this.ProfitBaseResultLabel.Name = "ProfitBaseResultLabel";
            this.ProfitBaseResultLabel.Size = new System.Drawing.Size(123, 15);
            this.ProfitBaseResultLabel.TabIndex = 9;
            this.ProfitBaseResultLabel.Text = "0р";
            this.ProfitBaseResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfitBaseLabel
            // 
            this.ProfitBaseLabel.AutoSize = true;
            this.ProfitBaseLabel.Location = new System.Drawing.Point(155, 86);
            this.ProfitBaseLabel.Name = "ProfitBaseLabel";
            this.ProfitBaseLabel.Size = new System.Drawing.Size(63, 15);
            this.ProfitBaseLabel.TabIndex = 8;
            this.ProfitBaseLabel.Text = "Результат:";
            // 
            // ProfitPercentResultLabel
            // 
            this.ProfitPercentResultLabel.Location = new System.Drawing.Point(111, 86);
            this.ProfitPercentResultLabel.Name = "ProfitPercentResultLabel";
            this.ProfitPercentResultLabel.Size = new System.Drawing.Size(38, 15);
            this.ProfitPercentResultLabel.TabIndex = 7;
            this.ProfitPercentResultLabel.Text = "0%";
            this.ProfitPercentResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfitPercentLabel
            // 
            this.ProfitPercentLabel.AutoSize = true;
            this.ProfitPercentLabel.Location = new System.Drawing.Point(13, 86);
            this.ProfitPercentLabel.Name = "ProfitPercentLabel";
            this.ProfitPercentLabel.Size = new System.Drawing.Size(92, 15);
            this.ProfitPercentLabel.TabIndex = 6;
            this.ProfitPercentLabel.Text = "Проходимость:";
            // 
            // FlatTextBox
            // 
            this.FlatTextBox.Location = new System.Drawing.Point(224, 24);
            this.FlatTextBox.Name = "FlatTextBox";
            this.FlatTextBox.Size = new System.Drawing.Size(123, 23);
            this.FlatTextBox.TabIndex = 5;
            // 
            // FlatLabel
            // 
            this.FlatLabel.AutoSize = true;
            this.FlatLabel.Location = new System.Drawing.Point(181, 27);
            this.FlatLabel.Name = "FlatLabel";
            this.FlatLabel.Size = new System.Drawing.Size(37, 15);
            this.FlatLabel.TabIndex = 4;
            this.FlatLabel.Text = "Флэт:";
            // 
            // BasePathLabel
            // 
            this.BasePathLabel.AutoSize = true;
            this.BasePathLabel.Location = new System.Drawing.Point(13, 56);
            this.BasePathLabel.Name = "BasePathLabel";
            this.BasePathLabel.Size = new System.Drawing.Size(34, 15);
            this.BasePathLabel.TabIndex = 3;
            this.BasePathLabel.Text = "База:";
            // 
            // BasePathTextBox
            // 
            this.BasePathTextBox.Location = new System.Drawing.Point(57, 53);
            this.BasePathTextBox.Name = "BasePathTextBox";
            this.BasePathTextBox.ReadOnly = true;
            this.BasePathTextBox.Size = new System.Drawing.Size(290, 23);
            this.BasePathTextBox.TabIndex = 2;
            this.BasePathTextBox.DoubleClick += new System.EventHandler(this.BasePathTextBox_DoubleClick);
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(13, 27);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(36, 15);
            this.BankLabel.TabIndex = 1;
            this.BankLabel.Text = "Банк:";
            // 
            // BankTextBox
            // 
            this.BankTextBox.Location = new System.Drawing.Point(57, 24);
            this.BankTextBox.Name = "BankTextBox";
            this.BankTextBox.Size = new System.Drawing.Size(118, 23);
            this.BankTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 180);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор по флэту";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label ProfitBaseResultLabel;
        private System.Windows.Forms.Label ProfitBaseLabel;
        private System.Windows.Forms.Label ProfitPercentResultLabel;
        private System.Windows.Forms.Label ProfitPercentLabel;
        private System.Windows.Forms.TextBox FlatTextBox;
        private System.Windows.Forms.Label FlatLabel;
        private System.Windows.Forms.Label BasePathLabel;
        private System.Windows.Forms.TextBox BasePathTextBox;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.TextBox BankTextBox;
        private System.Windows.Forms.Button CalcAction;
    }
}

