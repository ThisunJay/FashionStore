namespace FashionStoreWF
{
    partial class MarkAttendance
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectEmp = new System.Windows.Forms.ComboBox();
            this.markBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FashionStoreWF.Properties.Resources.loginBack;
            this.pictureBox1.Location = new System.Drawing.Point(267, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.label1.Location = new System.Drawing.Point(437, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mark Attendance";
            // 
            // SelectEmp
            // 
            this.SelectEmp.FormattingEnabled = true;
            this.SelectEmp.Location = new System.Drawing.Point(385, 259);
            this.SelectEmp.Name = "SelectEmp";
            this.SelectEmp.Size = new System.Drawing.Size(292, 24);
            this.SelectEmp.TabIndex = 2;
            // 
            // markBtn
            // 
            this.markBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.markBtn.Image = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.markBtn.Location = new System.Drawing.Point(670, 337);
            this.markBtn.Name = "markBtn";
            this.markBtn.Size = new System.Drawing.Size(102, 36);
            this.markBtn.TabIndex = 3;
            this.markBtn.Text = "Submit";
            this.markBtn.UseVisualStyleBackColor = true;
            this.markBtn.Click += new System.EventHandler(this.markBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.markBtn);
            this.Controls.Add(this.SelectEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MarkAttendance";
            this.Text = "Mark Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectEmp;
        private System.Windows.Forms.Button markBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}