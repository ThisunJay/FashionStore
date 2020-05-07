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
            this.dBoard = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.getImgs = new System.Windows.Forms.Button();
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
            // dBoard
            // 
            this.dBoard.Location = new System.Drawing.Point(12, 503);
            this.dBoard.Name = "dBoard";
            this.dBoard.Size = new System.Drawing.Size(98, 39);
            this.dBoard.TabIndex = 2;
            this.dBoard.Text = "Dashboard";
            this.dBoard.UseVisualStyleBackColor = true;
            this.dBoard.Click += new System.EventHandler(this.dBoard_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(235, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(804, 458);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // getImgs
            // 
            this.getImgs.Location = new System.Drawing.Point(122, 71);
            this.getImgs.Name = "getImgs";
            this.getImgs.Size = new System.Drawing.Size(89, 39);
            this.getImgs.TabIndex = 4;
            this.getImgs.Text = "Get Images";
            this.getImgs.UseVisualStyleBackColor = true;
            this.getImgs.Click += new System.EventHandler(this.getImgs_Click);
            // 
            // Patterns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.getImgs);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dBoard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ptnBtn);
            this.Name = "Patterns";
            this.Text = "Patterns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ptnBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dBoard;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button getImgs;
    }
}