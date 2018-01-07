namespace TCP_Server
{
    partial class TCP_Server
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
            this.comment_box = new System.Windows.Forms.TextBox();
            this.port_box = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.port_box)).BeginInit();
            this.SuspendLayout();
            // 
            // comment_box
            // 
            this.comment_box.Location = new System.Drawing.Point(67, 63);
            this.comment_box.Margin = new System.Windows.Forms.Padding(2);
            this.comment_box.Name = "comment_box";
            this.comment_box.Size = new System.Drawing.Size(255, 20);
            this.comment_box.TabIndex = 0;
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(251, 19);
            this.port_box.Margin = new System.Windows.Forms.Padding(2);
            this.port_box.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(71, 20);
            this.port_box.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 102);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 95);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(347, 19);
            this.start_button.Margin = new System.Windows.Forms.Padding(2);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(74, 19);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_ClickAsync);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(347, 52);
            this.stop_button.Margin = new System.Windows.Forms.Padding(2);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(74, 19);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // ip_box
            // 
            this.ip_box.Location = new System.Drawing.Point(32, 19);
            this.ip_box.Margin = new System.Windows.Forms.Padding(2);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(183, 20);
            this.ip_box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 206);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ip_box);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.comment_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TCP_Server";
            this.Text = "TCP_Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.port_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comment_box;
        private System.Windows.Forms.NumericUpDown port_box;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Label label3;
    }
}

