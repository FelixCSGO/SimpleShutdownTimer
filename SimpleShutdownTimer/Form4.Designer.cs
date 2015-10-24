namespace SimpleShutdownTimer
{
    partial class customTimer_Form
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
            this.hour_Button = new System.Windows.Forms.Button();
            this.minute_Button = new System.Windows.Forms.Button();
            this.second_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hour_Button
            // 
            this.hour_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hour_Button.Location = new System.Drawing.Point(12, 62);
            this.hour_Button.Name = "hour_Button";
            this.hour_Button.Size = new System.Drawing.Size(92, 48);
            this.hour_Button.TabIndex = 1;
            this.hour_Button.Text = "Hour";
            this.hour_Button.UseVisualStyleBackColor = true;
            this.hour_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // minute_Button
            // 
            this.minute_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minute_Button.Location = new System.Drawing.Point(124, 62);
            this.minute_Button.Name = "minute_Button";
            this.minute_Button.Size = new System.Drawing.Size(92, 48);
            this.minute_Button.TabIndex = 2;
            this.minute_Button.Text = "Minute";
            this.minute_Button.UseVisualStyleBackColor = true;
            this.minute_Button.Click += new System.EventHandler(this.minute_Button_Click);
            // 
            // second_Button
            // 
            this.second_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.second_Button.Location = new System.Drawing.Point(238, 62);
            this.second_Button.Name = "second_Button";
            this.second_Button.Size = new System.Drawing.Size(92, 48);
            this.second_Button.TabIndex = 4;
            this.second_Button.Text = "Second";
            this.second_Button.UseVisualStyleBackColor = true;
            this.second_Button.Click += new System.EventHandler(this.second_Button_Click);
            // 
            // customTimer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 137);
            this.Controls.Add(this.second_Button);
            this.Controls.Add(this.minute_Button);
            this.Controls.Add(this.hour_Button);
            this.Name = "customTimer_Form";
            this.Text = "Custom Timer";
            this.Load += new System.EventHandler(this.customTimer_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hour_Button;
        private System.Windows.Forms.Button minute_Button;
        private System.Windows.Forms.Button second_Button;
    }
}