namespace Gui
{
    partial class ShowAppForm
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
            this.button6 = new System.Windows.Forms.Button();
            this.ShowApp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AppTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(527, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 25);
            this.button6.TabIndex = 19;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ShowApp
            // 
            this.ShowApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowApp.Location = new System.Drawing.Point(71, 321);
            this.ShowApp.Name = "ShowApp";
            this.ShowApp.Size = new System.Drawing.Size(108, 23);
            this.ShowApp.TabIndex = 17;
            this.ShowApp.Text = "SHOW ALL";
            this.ShowApp.UseVisualStyleBackColor = true;
            this.ShowApp.Click += new System.EventHandler(this.ShowApp_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(305, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AppTable
            // 
            this.AppTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.AppTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTable.Location = new System.Drawing.Point(12, 12);
            this.AppTable.Name = "AppTable";
            this.AppTable.Size = new System.Drawing.Size(670, 299);
            this.AppTable.TabIndex = 13;
            this.AppTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gui.Properties.Resources.banner_medical_indemnity2;
            this.ClientSize = new System.Drawing.Size(691, 349);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ShowApp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AppTable);
            this.Name = "ShowAppForm";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.ManagePatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ShowApp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView AppTable;
    }
}