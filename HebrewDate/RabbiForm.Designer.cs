namespace HebrewDate
{
    partial class RabbiForm
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
            this.comboBox_dayName = new System.Windows.Forms.ComboBox();
            this.comboBox_dayNum = new System.Windows.Forms.ComboBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.button_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_dayName
            // 
            this.comboBox_dayName.FormattingEnabled = true;
            this.comboBox_dayName.Location = new System.Drawing.Point(652, 174);
            this.comboBox_dayName.Name = "comboBox_dayName";
            this.comboBox_dayName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dayName.TabIndex = 0;
            // 
            // comboBox_dayNum
            // 
            this.comboBox_dayNum.FormattingEnabled = true;
            this.comboBox_dayNum.Location = new System.Drawing.Point(512, 174);
            this.comboBox_dayNum.Name = "comboBox_dayNum";
            this.comboBox_dayNum.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dayNum.TabIndex = 1;
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(369, 174);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(121, 21);
            this.comboBox_month.TabIndex = 2;
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(196, 174);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(121, 21);
            this.comboBox_year.TabIndex = 3;
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(65, 172);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(75, 23);
            this.button_result.TabIndex = 4;
            this.button_result.Text = "הצג";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // RabbiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.comboBox_dayNum);
            this.Controls.Add(this.comboBox_dayName);
            this.Name = "RabbiForm";
            this.Text = "RabbiForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_dayName;
        private System.Windows.Forms.ComboBox comboBox_dayNum;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Button button_result;
    }
}