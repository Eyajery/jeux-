namespace menu
{
    partial class moyen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moyen));
            this.lblStatues = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblStatues
            // 
            this.lblStatues.BackColor = System.Drawing.Color.Transparent;
            this.lblStatues.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatues.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatues.Location = new System.Drawing.Point(805, 140);
            this.lblStatues.Name = "lblStatues";
            this.lblStatues.Size = new System.Drawing.Size(263, 56);
            this.lblStatues.TabIndex = 4;
            this.lblStatues.Text = "Match or MisMatch";
            this.lblStatues.Click += new System.EventHandler(this.lblStatues_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(805, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Debut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeLeft.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTimeLeft.Location = new System.Drawing.Point(823, 196);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(223, 28);
            this.lblTimeLeft.TabIndex = 6;
            this.lblTimeLeft.Text = "Temps rester :100";
            this.lblTimeLeft.Click += new System.EventHandler(this.lblTimeLeft_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10000;
            this.GameTimer.Tick += new System.EventHandler(this.TamerEvent);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            // 
            // moyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 623);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatues);
            this.Name = "moyen";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStatues;
        private Button button1;
        private Label lblTimeLeft;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer timer1;
    }
}