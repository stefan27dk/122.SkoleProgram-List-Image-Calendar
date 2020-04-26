namespace SkoleProgram
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studerendeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underviserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.klasserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studerendeToolStripMenuItem,
            this.underviserToolStripMenuItem,
            this.klasserToolStripMenuItem,
            this.klasserToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studerendeToolStripMenuItem
            // 
            this.studerendeToolStripMenuItem.Name = "studerendeToolStripMenuItem";
            this.studerendeToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.studerendeToolStripMenuItem.Text = "Billeder";
            this.studerendeToolStripMenuItem.Click += new System.EventHandler(this.StuderendeToolStripMenuItem_Click);
            // 
            // underviserToolStripMenuItem
            // 
            this.underviserToolStripMenuItem.Name = "underviserToolStripMenuItem";
            this.underviserToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.underviserToolStripMenuItem.Text = "Studerende";
            this.underviserToolStripMenuItem.Click += new System.EventHandler(this.UnderviserToolStripMenuItem_Click);
            // 
            // klasserToolStripMenuItem
            // 
            this.klasserToolStripMenuItem.Name = "klasserToolStripMenuItem";
            this.klasserToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.klasserToolStripMenuItem.Text = "Underviser";
            this.klasserToolStripMenuItem.Click += new System.EventHandler(this.KlasserToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.richTextBox1.Location = new System.Drawing.Point(42, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(381, 200);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            this.richTextBox1.MouseLeave += new System.EventHandler(this.Savebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(38, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Noteringer";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(307, 168);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 4;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rediger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // klasserToolStripMenuItem1
            // 
            this.klasserToolStripMenuItem1.Name = "klasserToolStripMenuItem1";
            this.klasserToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.klasserToolStripMenuItem1.Text = "Klasser";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem studerendeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underviserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasserToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem klasserToolStripMenuItem1;
    }
}

