namespace Chapter7
{
    partial class Timer_Game
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
            this.lblnum = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtspeed = new System.Windows.Forms.TextBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.lblspeed = new System.Windows.Forms.Label();
            this.lblguesss = new System.Windows.Forms.Label();
            this.txtguess = new System.Windows.Forms.TextBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(330, 85);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(99, 108);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "0";
            this.lblnum.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtspeed
            // 
            this.txtspeed.Location = new System.Drawing.Point(827, 82);
            this.txtspeed.Name = "txtspeed";
            this.txtspeed.Size = new System.Drawing.Size(145, 30);
            this.txtspeed.TabIndex = 2;
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(700, 330);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(101, 43);
            this.btnstop.TabIndex = 3;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblspeed
            // 
            this.lblspeed.AutoSize = true;
            this.lblspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspeed.Location = new System.Drawing.Point(663, 82);
            this.lblspeed.Name = "lblspeed";
            this.lblspeed.Size = new System.Drawing.Size(102, 32);
            this.lblspeed.TabIndex = 0;
            this.lblspeed.Text = "Speed";
            this.lblspeed.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // lblguesss
            // 
            this.lblguesss.AutoSize = true;
            this.lblguesss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguesss.Location = new System.Drawing.Point(663, 147);
            this.lblguesss.Name = "lblguesss";
            this.lblguesss.Size = new System.Drawing.Size(101, 32);
            this.lblguesss.TabIndex = 0;
            this.lblguesss.Text = "Guess";
            this.lblguesss.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // txtguess
            // 
            this.txtguess.Location = new System.Drawing.Point(827, 147);
            this.txtguess.Name = "txtguess";
            this.txtguess.Size = new System.Drawing.Size(145, 30);
            this.txtguess.TabIndex = 2;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.Location = new System.Drawing.Point(704, 230);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(244, 32);
            this.lblshow.TabIndex = 0;
            this.lblshow.Text = "-----------------------";
            this.lblshow.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // Timer_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.txtguess);
            this.Controls.Add(this.txtspeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.lblguesss);
            this.Controls.Add(this.lblspeed);
            this.Controls.Add(this.lblnum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timer_Game";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtspeed;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label lblspeed;
        private System.Windows.Forms.Label lblguesss;
        private System.Windows.Forms.TextBox txtguess;
        private System.Windows.Forms.Label lblshow;
    }
}