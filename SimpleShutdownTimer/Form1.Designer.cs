namespace SimpleShutdownTimer
{
    partial class simpleShutDownTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simpleShutDownTimer));
            this.help_button = new System.Windows.Forms.Button();
            this.Button30m = new System.Windows.Forms.Button();
            this.Button_45m = new System.Windows.Forms.Button();
            this.button_4hrs = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button2hr = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.buttonCustom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help_button
            // 
            this.help_button.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.help_button, "help_button");
            this.help_button.Name = "help_button";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // Button30m
            // 
            resources.ApplyResources(this.Button30m, "Button30m");
            this.Button30m.Name = "Button30m";
            this.Button30m.UseVisualStyleBackColor = true;
            this.Button30m.Click += new System.EventHandler(this.Button30m_Click);
            // 
            // Button_45m
            // 
            resources.ApplyResources(this.Button_45m, "Button_45m");
            this.Button_45m.Name = "Button_45m";
            this.Button_45m.UseVisualStyleBackColor = true;
            this.Button_45m.Click += new System.EventHandler(this.Button_45m_Click);
            // 
            // button_4hrs
            // 
            resources.ApplyResources(this.button_4hrs, "button_4hrs");
            this.button_4hrs.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_4hrs.Name = "button_4hrs";
            this.button_4hrs.UseVisualStyleBackColor = true;
            this.button_4hrs.Click += new System.EventHandler(this.button_4hrs_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button2hr
            // 
            this.button2hr.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button2hr, "button2hr");
            this.button2hr.Name = "button2hr";
            this.button2hr.UseVisualStyleBackColor = false;
            this.button2hr.Click += new System.EventHandler(this.button2hr_Click);
            // 
            // Stop
            // 
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.Name = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // buttonCustom
            // 
            resources.ApplyResources(this.buttonCustom, "buttonCustom");
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.UseVisualStyleBackColor = true;
            this.buttonCustom.Click += new System.EventHandler(this.button_Custom);
            // 
            // simpleShutDownTimer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCustom);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.button2hr);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button_4hrs);
            this.Controls.Add(this.Button_45m);
            this.Controls.Add(this.Button30m);
            this.Controls.Add(this.help_button);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "simpleShutDownTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button30m;
        private System.Windows.Forms.Button Button_45m;
        private System.Windows.Forms.Button button_4hrs;
        private System.Windows.Forms.Button Button_2h;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button2hr;
        private System.Windows.Forms.Button Stop;
        public System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button buttonCustom;
    }
}

