﻿namespace FashionStoreWF
{
    partial class Warehouse
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rawBtn = new System.Windows.Forms.Button();
            this.finBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FashionStoreWF.Properties.Resources.loginBack;
            this.pictureBox1.Location = new System.Drawing.Point(224, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rawBtn
            // 
            this.rawBtn.Location = new System.Drawing.Point(12, 208);
            this.rawBtn.Name = "rawBtn";
            this.rawBtn.Size = new System.Drawing.Size(206, 39);
            this.rawBtn.TabIndex = 1;
            this.rawBtn.Text = "Raw";
            this.rawBtn.UseVisualStyleBackColor = true;
            this.rawBtn.Click += new System.EventHandler(this.rawBtn_Click);
            // 
            // finBtn
            // 
            this.finBtn.Location = new System.Drawing.Point(12, 273);
            this.finBtn.Name = "finBtn";
            this.finBtn.Size = new System.Drawing.Size(206, 39);
            this.finBtn.TabIndex = 2;
            this.finBtn.Text = "Finish";
            this.finBtn.UseVisualStyleBackColor = true;
            this.finBtn.Click += new System.EventHandler(this.finBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(247, 45);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(109, 33);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Item";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 389);
            this.dataGridView1.TabIndex = 4;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.finBtn);
            this.Controls.Add(this.rawBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rawBtn;
        private System.Windows.Forms.Button finBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}