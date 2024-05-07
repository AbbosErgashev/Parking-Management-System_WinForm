namespace ParkingManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            utbl = new TextBox();
            ptbl = new TextBox();
            lbtn = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 392);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(62, 178);
            label8.Name = "label8";
            label8.Size = new Size(74, 28);
            label8.TabIndex = 4;
            label8.Text = "System";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 135);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 3;
            label7.Text = "Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(56, 94);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 2;
            label6.Text = "Parking";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 48);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 1;
            label5.Text = "Professinal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 160);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 211);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(348, 29);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 3;
            label3.Text = "Parking Lot 1.0";
            // 
            // utbl
            // 
            utbl.Location = new Point(340, 157);
            utbl.Name = "utbl";
            utbl.Size = new Size(268, 31);
            utbl.TabIndex = 4;
            // 
            // ptbl
            // 
            ptbl.Location = new Point(340, 208);
            ptbl.Name = "ptbl";
            ptbl.PasswordChar = '*';
            ptbl.Size = new Size(268, 31);
            ptbl.TabIndex = 5;
            // 
            // lbtn
            // 
            lbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbtn.ForeColor = Color.FromArgb(0, 64, 0);
            lbtn.Location = new Point(348, 295);
            lbtn.Name = "lbtn";
            lbtn.Size = new Size(153, 47);
            lbtn.TabIndex = 6;
            lbtn.Text = "Login";
            lbtn.UseVisualStyleBackColor = true;
            lbtn.Click += lbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.parking;
            pictureBox1.Location = new Point(373, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 392);
            Controls.Add(pictureBox1);
            Controls.Add(lbtn);
            Controls.Add(ptbl);
            Controls.Add(utbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox utbl;
        private TextBox ptbl;
        private Button lbtn;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
