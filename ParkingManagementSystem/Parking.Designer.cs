namespace ParkingManagementSystem
{
    partial class Parking
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
            panel1 = new Panel();
            restore = new Button();
            pcb = new ComboBox();
            ccb = new ComboBox();
            parkingDGV = new DataGridView();
            bpbtn = new Button();
            calendar = new DateTimePicker();
            atbl = new TextBox();
            label5 = new Label();
            dtbl = new TextBox();
            label66 = new Label();
            label100 = new Label();
            panel2 = new Panel();
            l1 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            l2 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            l3 = new Label();
            label11 = new Label();
            panel7 = new Panel();
            panel10 = new Panel();
            l4 = new Label();
            label7 = new Label();
            panel11 = new Panel();
            panel14 = new Panel();
            l6 = new Label();
            label12 = new Label();
            panel15 = new Panel();
            panel16 = new Panel();
            l9 = new Label();
            label15 = new Label();
            panel17 = new Panel();
            panel18 = new Panel();
            l8 = new Label();
            label14 = new Label();
            panel19 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            l5 = new Label();
            label13 = new Label();
            panel12 = new Panel();
            l7 = new Label();
            label8 = new Label();
            panel13 = new Panel();
            panel20 = new Panel();
            l10 = new Label();
            label9 = new Label();
            panel21 = new Panel();
            panel22 = new Panel();
            l11 = new Label();
            label16 = new Label();
            panel23 = new Panel();
            panel24 = new Panel();
            l12 = new Label();
            label17 = new Label();
            panel25 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parkingDGV).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            panel18.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel20.SuspendLayout();
            panel22.SuspendLayout();
            panel24.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(restore);
            panel1.Controls.Add(pcb);
            panel1.Controls.Add(ccb);
            panel1.Controls.Add(parkingDGV);
            panel1.Controls.Add(bpbtn);
            panel1.Controls.Add(calendar);
            panel1.Controls.Add(atbl);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtbl);
            panel1.Controls.Add(label66);
            panel1.Controls.Add(label100);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(566, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 656);
            panel1.TabIndex = 0;
            // 
            // restore
            // 
            restore.FlatAppearance.BorderSize = 0;
            restore.FlatAppearance.MouseDownBackColor = Color.Cyan;
            restore.FlatAppearance.MouseOverBackColor = Color.Cyan;
            restore.Location = new Point(296, 259);
            restore.Name = "restore";
            restore.Size = new Size(145, 41);
            restore.TabIndex = 15;
            restore.Text = "Restore";
            restore.UseVisualStyleBackColor = true;
            restore.Click += restore_Click;
            // 
            // pcb
            // 
            pcb.FormattingEnabled = true;
            pcb.Location = new Point(60, 50);
            pcb.Name = "pcb";
            pcb.Size = new Size(451, 33);
            pcb.TabIndex = 14;
            pcb.Text = "Select Place";
            // 
            // ccb
            // 
            ccb.FormattingEnabled = true;
            ccb.Location = new Point(60, 102);
            ccb.Name = "ccb";
            ccb.Size = new Size(215, 33);
            ccb.TabIndex = 13;
            ccb.Text = "Select Car";
            // 
            // parkingDGV
            // 
            parkingDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parkingDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            parkingDGV.BorderStyle = BorderStyle.Fixed3D;
            parkingDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parkingDGV.Location = new Point(13, 306);
            parkingDGV.Name = "parkingDGV";
            parkingDGV.RowHeadersWidth = 51;
            parkingDGV.Size = new Size(547, 338);
            parkingDGV.TabIndex = 12;
            parkingDGV.CellContentClick += parkingDGV_CellContentClick;
            // 
            // bpbtn
            // 
            bpbtn.FlatAppearance.BorderSize = 0;
            bpbtn.FlatAppearance.MouseDownBackColor = Color.Lime;
            bpbtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            bpbtn.Location = new Point(106, 259);
            bpbtn.Name = "bpbtn";
            bpbtn.Size = new Size(145, 41);
            bpbtn.TabIndex = 10;
            bpbtn.Text = "Book Place";
            bpbtn.UseVisualStyleBackColor = true;
            bpbtn.Click += bpbtn_Click;
            // 
            // calendar
            // 
            calendar.Location = new Point(296, 102);
            calendar.Name = "calendar";
            calendar.Size = new Size(215, 31);
            calendar.TabIndex = 9;
            // 
            // atbl
            // 
            atbl.Location = new Point(191, 195);
            atbl.Name = "atbl";
            atbl.Size = new Size(236, 31);
            atbl.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 198);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 7;
            label5.Text = "Amount";
            // 
            // dtbl
            // 
            dtbl.Location = new Point(191, 150);
            dtbl.Name = "dtbl";
            dtbl.Size = new Size(236, 31);
            dtbl.TabIndex = 6;
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new Point(100, 153);
            label66.Name = "label66";
            label66.Size = new Size(81, 25);
            label66.TabIndex = 5;
            label66.Text = "Duration";
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label100.ForeColor = Color.Black;
            label100.Location = new Point(202, 11);
            label100.Name = "label100";
            label100.Size = new Size(167, 25);
            label100.TabIndex = 0;
            label100.Text = "Book a Parking Lot";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(72, 219, 251);
            panel2.Controls.Add(l1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(8, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 125);
            panel2.TabIndex = 1;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l1.ForeColor = Color.Black;
            l1.Location = new Point(59, 58);
            l1.Name = "l1";
            l1.Size = new Size(79, 25);
            l1.TabIndex = 4;
            l1.Text = "L1Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(37, 14);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 3;
            label6.Text = "Place C1R1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(10, 189, 227);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 125);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(10, 189, 227);
            panel4.Location = new Point(2, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(19, 125);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(72, 219, 251);
            panel5.Controls.Add(l2);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(panel4);
            panel5.Location = new Point(193, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 125);
            panel5.TabIndex = 3;
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l2.ForeColor = Color.Black;
            l2.Location = new Point(63, 58);
            l2.Name = "l2";
            l2.Size = new Size(79, 25);
            l2.TabIndex = 5;
            l2.Text = "L1Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(39, 14);
            label10.Name = "label10";
            label10.Size = new Size(99, 25);
            label10.TabIndex = 4;
            label10.Text = "Place C1R2";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(72, 219, 251);
            panel6.Controls.Add(l3);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(378, 36);
            panel6.Name = "panel6";
            panel6.Size = new Size(179, 125);
            panel6.TabIndex = 4;
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l3.ForeColor = Color.Black;
            l3.Location = new Point(68, 58);
            l3.Name = "l3";
            l3.Size = new Size(79, 25);
            l3.TabIndex = 6;
            l3.Text = "L1Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(38, 14);
            label11.Name = "label11";
            label11.Size = new Size(99, 25);
            label11.TabIndex = 5;
            label11.Text = "Place C1R3";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(10, 189, 227);
            panel7.Location = new Point(1, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(19, 125);
            panel7.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(199, 236, 238);
            panel10.Controls.Add(l4);
            panel10.Controls.Add(label7);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(9, 194);
            panel10.Name = "panel10";
            panel10.Size = new Size(179, 125);
            panel10.TabIndex = 3;
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l4.ForeColor = Color.Black;
            l4.Location = new Point(59, 57);
            l4.Name = "l4";
            l4.Size = new Size(79, 25);
            l4.TabIndex = 5;
            l4.Text = "L1Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(37, 17);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 4;
            label7.Text = "Place C2R1";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(126, 214, 223);
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(19, 125);
            panel11.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(199, 236, 238);
            panel14.Controls.Add(l6);
            panel14.Controls.Add(label12);
            panel14.Controls.Add(panel15);
            panel14.Location = new Point(379, 194);
            panel14.Name = "panel14";
            panel14.Size = new Size(179, 125);
            panel14.TabIndex = 4;
            // 
            // l6
            // 
            l6.AutoSize = true;
            l6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l6.ForeColor = Color.Black;
            l6.Location = new Point(68, 57);
            l6.Name = "l6";
            l6.Size = new Size(79, 25);
            l6.TabIndex = 8;
            l6.Text = "L1Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(38, 17);
            label12.Name = "label12";
            label12.Size = new Size(102, 25);
            label12.TabIndex = 6;
            label12.Text = "Place C2R3";
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(126, 214, 223);
            panel15.Location = new Point(1, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(19, 125);
            panel15.TabIndex = 2;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(72, 219, 251);
            panel16.Controls.Add(l9);
            panel16.Controls.Add(label15);
            panel16.Controls.Add(panel17);
            panel16.Location = new Point(380, 347);
            panel16.Name = "panel16";
            panel16.Size = new Size(179, 125);
            panel16.TabIndex = 4;
            // 
            // l9
            // 
            l9.AutoSize = true;
            l9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l9.ForeColor = Color.Black;
            l9.Location = new Point(68, 60);
            l9.Name = "l9";
            l9.Size = new Size(79, 25);
            l9.TabIndex = 11;
            l9.Text = "L1Status";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.ForeColor = Color.Blue;
            label15.Location = new Point(38, 19);
            label15.Name = "label15";
            label15.Size = new Size(102, 25);
            label15.TabIndex = 9;
            label15.Text = "Place C3R3";
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(10, 189, 227);
            panel17.Location = new Point(1, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(19, 125);
            panel17.TabIndex = 2;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(72, 219, 251);
            panel18.Controls.Add(l8);
            panel18.Controls.Add(label14);
            panel18.Controls.Add(panel19);
            panel18.Location = new Point(196, 347);
            panel18.Name = "panel18";
            panel18.Size = new Size(179, 125);
            panel18.TabIndex = 4;
            // 
            // l8
            // 
            l8.AutoSize = true;
            l8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l8.ForeColor = Color.Black;
            l8.Location = new Point(62, 60);
            l8.Name = "l8";
            l8.Size = new Size(79, 25);
            l8.TabIndex = 10;
            l8.Text = "L1Status";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.ForeColor = Color.Blue;
            label14.Location = new Point(38, 19);
            label14.Name = "label14";
            label14.Size = new Size(102, 25);
            label14.TabIndex = 8;
            label14.Text = "Place C3R2";
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(10, 189, 227);
            panel19.Location = new Point(1, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(19, 125);
            panel19.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(126, 214, 223);
            panel8.Location = new Point(1, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(19, 125);
            panel8.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(199, 236, 238);
            panel9.Controls.Add(l5);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(panel8);
            panel9.Location = new Point(195, 194);
            panel9.Name = "panel9";
            panel9.Size = new Size(179, 125);
            panel9.TabIndex = 3;
            // 
            // l5
            // 
            l5.AutoSize = true;
            l5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l5.ForeColor = Color.Black;
            l5.Location = new Point(62, 57);
            l5.Name = "l5";
            l5.Size = new Size(79, 25);
            l5.TabIndex = 6;
            l5.Text = "L1Status";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(38, 17);
            label13.Name = "label13";
            label13.Size = new Size(102, 25);
            label13.TabIndex = 7;
            label13.Text = "Place C2R2";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(72, 219, 251);
            panel12.Controls.Add(l7);
            panel12.Controls.Add(label8);
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(10, 347);
            panel12.Name = "panel12";
            panel12.Size = new Size(179, 125);
            panel12.TabIndex = 5;
            // 
            // l7
            // 
            l7.AutoSize = true;
            l7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l7.ForeColor = Color.Black;
            l7.Location = new Point(59, 60);
            l7.Name = "l7";
            l7.Size = new Size(79, 25);
            l7.TabIndex = 9;
            l7.Text = "L1Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(37, 19);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 7;
            label8.Text = "Place C3R1";
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(10, 189, 227);
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(19, 125);
            panel13.TabIndex = 2;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(199, 236, 238);
            panel20.Controls.Add(l10);
            panel20.Controls.Add(label9);
            panel20.Controls.Add(panel21);
            panel20.Location = new Point(11, 501);
            panel20.Name = "panel20";
            panel20.Size = new Size(179, 125);
            panel20.TabIndex = 6;
            // 
            // l10
            // 
            l10.AutoSize = true;
            l10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l10.ForeColor = Color.Black;
            l10.Location = new Point(59, 59);
            l10.Name = "l10";
            l10.Size = new Size(79, 25);
            l10.TabIndex = 12;
            l10.Text = "L1Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(37, 20);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 8;
            label9.Text = "Place C4R1";
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(126, 214, 223);
            panel21.Location = new Point(0, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(19, 125);
            panel21.TabIndex = 2;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(199, 236, 238);
            panel22.Controls.Add(l11);
            panel22.Controls.Add(label16);
            panel22.Controls.Add(panel23);
            panel22.Location = new Point(197, 501);
            panel22.Name = "panel22";
            panel22.Size = new Size(179, 125);
            panel22.TabIndex = 4;
            // 
            // l11
            // 
            l11.AutoSize = true;
            l11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l11.ForeColor = Color.Black;
            l11.Location = new Point(62, 59);
            l11.Name = "l11";
            l11.Size = new Size(79, 25);
            l11.TabIndex = 13;
            l11.Text = "L1Status";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(38, 20);
            label16.Name = "label16";
            label16.Size = new Size(102, 25);
            label16.TabIndex = 10;
            label16.Text = "Place C4R2";
            // 
            // panel23
            // 
            panel23.BackColor = Color.FromArgb(126, 214, 223);
            panel23.Location = new Point(1, 0);
            panel23.Name = "panel23";
            panel23.Size = new Size(19, 125);
            panel23.TabIndex = 2;
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(199, 236, 238);
            panel24.Controls.Add(l12);
            panel24.Controls.Add(label17);
            panel24.Controls.Add(panel25);
            panel24.Location = new Point(381, 501);
            panel24.Name = "panel24";
            panel24.Size = new Size(179, 125);
            panel24.TabIndex = 5;
            // 
            // l12
            // 
            l12.AutoSize = true;
            l12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            l12.ForeColor = Color.Black;
            l12.Location = new Point(68, 59);
            l12.Name = "l12";
            l12.Size = new Size(79, 25);
            l12.TabIndex = 14;
            l12.Text = "L1Status";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.ForeColor = Color.Blue;
            label17.Location = new Point(38, 20);
            label17.Name = "label17";
            label17.Size = new Size(102, 25);
            label17.TabIndex = 11;
            label17.Text = "Place C4R3";
            // 
            // panel25
            // 
            panel25.BackColor = Color.FromArgb(126, 214, 223);
            panel25.Location = new Point(1, 0);
            panel25.Name = "panel25";
            panel25.Size = new Size(19, 125);
            panel25.TabIndex = 2;
            // 
            // Parking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 656);
            ControlBox = false;
            Controls.Add(panel24);
            Controls.Add(panel22);
            Controls.Add(panel20);
            Controls.Add(panel12);
            Controls.Add(panel18);
            Controls.Add(panel16);
            Controls.Add(panel14);
            Controls.Add(panel9);
            Controls.Add(panel10);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Parking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parkingDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label100;
        private DateTimePicker calendar;
        private DataGridView parkingDGV;
        private Button bpbtn;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private Panel panel10;
        private Panel panel11;
        private Panel panel14;
        private Panel panel16;
        private Panel panel17;
        private Panel panel15;
        private Panel panel18;
        private Panel panel19;
        private Panel panel8;
        private Panel panel9;
        private Panel panel12;
        private Panel panel13;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Panel panel25;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label16;
        private Label label17;
        private ComboBox pcb;
        private ComboBox ccb;
        private TextBox atbl;
        private Label label5;
        private TextBox dtbl;
        private Label label66;
        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Label l6;
        private Label l9;
        private Label l8;
        private Label l5;
        private Label l7;
        private Label l10;
        private Label l11;
        private Label l12;
        private Button restore;
    }
}