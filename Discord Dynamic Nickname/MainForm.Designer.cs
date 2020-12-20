partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert the token of the user here:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(20, 41);
            this.textBox1.MaxLength = 88;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect To Discord";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert the id of the guild here:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(20, 138);
            this.textBox2.MaxLength = 88;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(314, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert the dynamic nickname here:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(20, 197);
            this.textBox3.MaxLength = 88;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(314, 25);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(20, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start Changing";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(182, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Stop Changing";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOTE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 72);
            this.label5.TabIndex = 10;
            this.label5.Text = "Do not abuse of this program\r\nor your will Discord account will\r\nbe disabled for " +
    "self-botting.\r\nMade by ZioEren#1337.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Dynamic Nickname";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
}