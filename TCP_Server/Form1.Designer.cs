namespace TCP_Server
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
            this.comment_box = new System.Windows.Forms.TextBox();
            this.port_box = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.ip_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.port_box)).BeginInit();
            this.SuspendLayout();
            // 
            // comment_box
            // 
            this.comment_box.Location = new System.Drawing.Point(25, 88);
            this.comment_box.Name = "comment_box";
            this.comment_box.Size = new System.Drawing.Size(243, 22);
            this.comment_box.TabIndex = 0;
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(335, 23);
            this.port_box.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(95, 22);
            this.port_box.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 116);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(463, 23);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(99, 23);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_ClickAsync);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(463, 64);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(99, 23);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // ip_box
            // 
            this.ip_box.Location = new System.Drawing.Point(42, 23);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(243, 22);
            this.ip_box.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 253);
            this.Controls.Add(this.ip_box);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.comment_box);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

