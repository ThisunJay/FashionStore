namespace FashionStoreWF
{
    partial class Patterns
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
            this.ptnBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ptnBtn
            // 
            this.ptnBtn.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.ptnBtn.Location = new System.Drawing.Point(640, 12);
            this.ptnBtn.Name = "ptnBtn";
            this.ptnBtn.Size = new System.Drawing.Size(117, 37);
            this.ptnBtn.TabIndex = 0;
            this.ptnBtn.Text = "Add Pattern";
            this.ptnBtn.UseVisualStyleBackColor = true;
            this.ptnBtn.Click += new System.EventHandler(this.ptnBtn_Click);
            // 
            // button2
            // 
            this.button2.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.button2.Location = new System.Drawing.Point(790, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Finish Good";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Patterns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ptnBtn);
            this.Name = "Patterns";
            this.Text = "Patterns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ptnBtn;
        private System.Windows.Forms.Button button2;
    }
}