namespace Gui
{
    partial class AppForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.TimeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DocNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmAppButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DocIdTB = new System.Windows.Forms.TextBox();
            this.PidTB = new System.Windows.Forms.TextBox();
            this.DoctorTable = new System.Windows.Forms.DataGridView();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowAppButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.AppTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.RefreshButton);
            this.groupBox1.Controls.Add(this.HelpButton);
            this.groupBox1.Controls.Add(this.TimeTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DocNameTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ConfirmAppButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DocIdTB);
            this.groupBox1.Controls.Add(this.PidTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Form";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshButton.Location = new System.Drawing.Point(817, 149);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 20;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HelpButton.Location = new System.Drawing.Point(823, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 23);
            this.HelpButton.TabIndex = 19;
            this.HelpButton.Text = "Help?";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // TimeTB
            // 
            this.TimeTB.BackColor = System.Drawing.Color.LightCyan;
            this.TimeTB.Location = new System.Drawing.Point(599, 100);
            this.TimeTB.Name = "TimeTB";
            this.TimeTB.Size = new System.Drawing.Size(219, 22);
            this.TimeTB.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Doctor Name";
            // 
            // DocNameTB
            // 
            this.DocNameTB.BackColor = System.Drawing.Color.LightCyan;
            this.DocNameTB.Location = new System.Drawing.Point(599, 47);
            this.DocNameTB.Name = "DocNameTB";
            this.DocNameTB.Size = new System.Drawing.Size(219, 22);
            this.DocNameTB.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Patient ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 10;
            // 
            // ConfirmAppButton
            // 
            this.ConfirmAppButton.BackColor = System.Drawing.Color.LightGreen;
            this.ConfirmAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmAppButton.Location = new System.Drawing.Point(599, 149);
            this.ConfirmAppButton.Name = "ConfirmAppButton";
            this.ConfirmAppButton.Size = new System.Drawing.Size(184, 23);
            this.ConfirmAppButton.TabIndex = 5;
            this.ConfirmAppButton.Text = "Confirm Appointment";
            this.ConfirmAppButton.UseVisualStyleBackColor = false;
            this.ConfirmAppButton.Click += new System.EventHandler(this.ConfirmAppButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doctor  ID";
            // 
            // DocIdTB
            // 
            this.DocIdTB.BackColor = System.Drawing.Color.LightCyan;
            this.DocIdTB.Location = new System.Drawing.Point(168, 102);
            this.DocIdTB.Name = "DocIdTB";
            this.DocIdTB.Size = new System.Drawing.Size(219, 22);
            this.DocIdTB.TabIndex = 3;
            // 
            // PidTB
            // 
            this.PidTB.BackColor = System.Drawing.Color.LightCyan;
            this.PidTB.Location = new System.Drawing.Point(168, 58);
            this.PidTB.Name = "PidTB";
            this.PidTB.Size = new System.Drawing.Size(219, 22);
            this.PidTB.TabIndex = 0;
            // 
            // DoctorTable
            // 
            this.DoctorTable.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DoctorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorTable.Location = new System.Drawing.Point(12, 274);
            this.DoctorTable.Name = "DoctorTable";
            this.DoctorTable.Size = new System.Drawing.Size(409, 192);
            this.DoctorTable.TabIndex = 3;
            this.DoctorTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorTable_CellContentClick);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(149, 482);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 23);
            this.ShowButton.TabIndex = 8;
            this.ShowButton.Text = "SHOW ALL";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowAppButton
            // 
            this.ShowAppButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ShowAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAppButton.Location = new System.Drawing.Point(600, 485);
            this.ShowAppButton.Name = "ShowAppButton";
            this.ShowAppButton.Size = new System.Drawing.Size(162, 23);
            this.ShowAppButton.TabIndex = 9;
            this.ShowAppButton.Text = "Show Appointments";
            this.ShowAppButton.UseVisualStyleBackColor = false;
            this.ShowAppButton.Click += new System.EventHandler(this.ShowAppButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Menu;
            this.button6.Location = new System.Drawing.Point(819, 481);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 10;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AppTable
            // 
            this.AppTable.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.AppTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTable.Location = new System.Drawing.Point(461, 274);
            this.AppTable.Name = "AppTable";
            this.AppTable.Size = new System.Drawing.Size(433, 192);
            this.AppTable.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(151, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doctors List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Appointments";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui.Properties.Resources._13971;
            this.ClientSize = new System.Drawing.Size(906, 523);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowAppButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.AppTable);
            this.Controls.Add(this.DoctorTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShowButton);
            this.Name = "AppForm";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocIdTB;
        private System.Windows.Forms.TextBox PidTB;
        private System.Windows.Forms.DataGridView DoctorTable;
        private System.Windows.Forms.Button ConfirmAppButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button ShowAppButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView AppTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocNameTB;
        private System.Windows.Forms.TextBox TimeTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}