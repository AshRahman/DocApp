namespace Gui
{
    partial class ManagerForm
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
            this.ManageDocButton = new System.Windows.Forms.Button();
            this.ShwoAppButton = new System.Windows.Forms.Button();
            this.ManageAdButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageDocButton
            // 
            this.ManageDocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageDocButton.Location = new System.Drawing.Point(174, 160);
            this.ManageDocButton.Name = "ManageDocButton";
            this.ManageDocButton.Size = new System.Drawing.Size(130, 55);
            this.ManageDocButton.TabIndex = 3;
            this.ManageDocButton.Text = "   Manage     Doctor";
            this.ManageDocButton.UseVisualStyleBackColor = true;
            this.ManageDocButton.Click += new System.EventHandler(this.ManageDocButton_Click);
            // 
            // ShwoAppButton
            // 
            this.ShwoAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShwoAppButton.Location = new System.Drawing.Point(174, 253);
            this.ShwoAppButton.Name = "ShwoAppButton";
            this.ShwoAppButton.Size = new System.Drawing.Size(130, 54);
            this.ShwoAppButton.TabIndex = 4;
            this.ShwoAppButton.Text = "Show Appointments";
            this.ShwoAppButton.UseVisualStyleBackColor = true;
            this.ShwoAppButton.Click += new System.EventHandler(this.ShowApButton_Click);
            // 
            // ManageAdButton
            // 
            this.ManageAdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAdButton.Location = new System.Drawing.Point(174, 357);
            this.ManageAdButton.Name = "ManageAdButton";
            this.ManageAdButton.Size = new System.Drawing.Size(130, 48);
            this.ManageAdButton.TabIndex = 5;
            this.ManageAdButton.Text = "Manage Admins";
            this.ManageAdButton.UseVisualStyleBackColor = true;
            this.ManageAdButton.Click += new System.EventHandler(this.ManageAdButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gui.Properties.Resources.download11;
            this.pictureBox4.Location = new System.Drawing.Point(80, 345);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gui.Properties.Resources.images__staff_;
            this.pictureBox3.Location = new System.Drawing.Point(80, 253);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gui.Properties.Resources.clinician_icon_8;
            this.pictureBox2.Location = new System.Drawing.Point(80, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gui.Properties.Resources.a5f02e8cfdfffd141528ffd4b64dcf5b;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 548);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ManageAdButton);
            this.Controls.Add(this.ShwoAppButton);
            this.Controls.Add(this.ManageDocButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ManageDocButton;
        private System.Windows.Forms.Button ShwoAppButton;
        private System.Windows.Forms.Button ManageAdButton;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}