namespace OneHandBandit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_start = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.dvig1 = new System.Windows.Forms.Timer(this.components);
            this.dvig2 = new System.Windows.Forms.Timer(this.components);
            this.dvig3 = new System.Windows.Forms.Timer(this.components);
            this.stop1 = new System.Windows.Forms.Timer(this.components);
            this.stop2 = new System.Windows.Forms.Timer(this.components);
            this.stop3 = new System.Windows.Forms.Timer(this.components);
            this.lcash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_start
            // 
            this.Button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_start.Location = new System.Drawing.Point(74, 69);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(137, 60);
            this.Button_start.TabIndex = 0;
            this.Button_start.Text = "START";
            this.Button_start.UseVisualStyleBackColor = true;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Gold;
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.Location = new System.Drawing.Point(35, 146);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(54, 57);
            this.l1.TabIndex = 1;
            this.l1.Text = "0";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Gold;
            this.l2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.Location = new System.Drawing.Point(117, 146);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(54, 57);
            this.l2.TabIndex = 2;
            this.l2.Text = "0";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Gold;
            this.l3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l3.Location = new System.Drawing.Point(202, 146);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(54, 57);
            this.l3.TabIndex = 3;
            this.l3.Text = "0";
            // 
            // dvig1
            // 
            this.dvig1.Interval = 10;
            this.dvig1.Tick += new System.EventHandler(this.Dvig1_Tick);
            // 
            // dvig2
            // 
            this.dvig2.Interval = 10;
            this.dvig2.Tick += new System.EventHandler(this.Dvig2_Tick);
            // 
            // dvig3
            // 
            this.dvig3.Interval = 10;
            this.dvig3.Tick += new System.EventHandler(this.Dvig3_Tick);
            // 
            // stop1
            // 
            this.stop1.Interval = 1500;
            this.stop1.Tick += new System.EventHandler(this.Stop1_Tick);
            // 
            // stop2
            // 
            this.stop2.Interval = 2500;
            this.stop2.Tick += new System.EventHandler(this.Stop2_Tick);
            // 
            // stop3
            // 
            this.stop3.Interval = 3000;
            this.stop3.Tick += new System.EventHandler(this.Stop3_Tick);
            // 
            // lcash
            // 
            this.lcash.AutoSize = true;
            this.lcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcash.Location = new System.Drawing.Point(12, 9);
            this.lcash.Name = "lcash";
            this.lcash.Size = new System.Drawing.Size(112, 25);
            this.lcash.TabIndex = 4;
            this.lcash.Text = "You have";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lcash);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.Button_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "OneHandBandit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_start;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Timer dvig1;
        private System.Windows.Forms.Timer dvig2;
        private System.Windows.Forms.Timer dvig3;
        private System.Windows.Forms.Timer stop1;
        private System.Windows.Forms.Timer stop2;
        private System.Windows.Forms.Timer stop3;
        private System.Windows.Forms.Label lcash;
    }
}

