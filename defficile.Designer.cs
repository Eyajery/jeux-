namespace menu
{
    partial class defficile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defficile));
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatues = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(735, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Debut";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblStatues
            // 
            this.lblStatues.BackColor = System.Drawing.Color.Transparent;
            this.lblStatues.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatues.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatues.Location = new System.Drawing.Point(760, 126);
            this.lblStatues.Name = "lblStatues";
            this.lblStatues.Size = new System.Drawing.Size(263, 38);
            this.lblStatues.TabIndex = 4;
            this.lblStatues.Text = "Match or MisMatch";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimeLeft.Location = new System.Drawing.Point(770, 175);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(263, 54);
            this.lblTimeLeft.TabIndex = 5;
            this.lblTimeLeft.Text = "Temps rester :100";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10000;
            this.GameTimer.Tick += new System.EventHandler(this.TamerEvent);
            // 
            // defficile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 820);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblStatues);
            this.Controls.Add(this.button1);
            this.Name = "defficile";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label lblStatues;
        private Label lblTimeLeft;
        private System.Windows.Forms.Timer GameTimer;
    }
}