namespace FashionStoreWF
{
    partial class AddWarehouseItem
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
            this.ItemCode = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemDes = new System.Windows.Forms.TextBox();
            this.ItemType = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FashionStoreWF.Properties.Resources.loginBack;
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 530);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.label1.Location = new System.Drawing.Point(458, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Item";
            // 
            // ItemCode
            // 
            this.ItemCode.Location = new System.Drawing.Point(443, 95);
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Size = new System.Drawing.Size(281, 22);
            this.ItemCode.TabIndex = 2;
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(443, 161);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(281, 22);
            this.ItemName.TabIndex = 3;
            // 
            // ItemDes
            // 
            this.ItemDes.Location = new System.Drawing.Point(443, 308);
            this.ItemDes.Multiline = true;
            this.ItemDes.Name = "ItemDes";
            this.ItemDes.Size = new System.Drawing.Size(281, 95);
            this.ItemDes.TabIndex = 4;
            // 
            // ItemType
            // 
            this.ItemType.FormattingEnabled = true;
            this.ItemType.Location = new System.Drawing.Point(443, 231);
            this.ItemType.Name = "ItemType";
            this.ItemType.Size = new System.Drawing.Size(281, 24);
            this.ItemType.TabIndex = 5;
            this.ItemType.SelectedIndexChanged += new System.EventHandler(this.ItemType_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::FashionStoreWF.Properties.Resources.loginBack;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Image = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.addBtn.Location = new System.Drawing.Point(623, 456);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 36);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Item";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.BackgroundImage = global::FashionStoreWF.Properties.Resources.loginBack;
            this.clrBtn.ForeColor = System.Drawing.Color.White;
            this.clrBtn.Image = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.clrBtn.Location = new System.Drawing.Point(443, 456);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(101, 36);
            this.clrBtn.TabIndex = 7;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.label2.Location = new System.Drawing.Point(313, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.label3.Location = new System.Drawing.Point(313, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.label4.Location = new System.Drawing.Point(317, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::FashionStoreWF.Properties.Resources.loginBack;
            this.label5.Location = new System.Drawing.Point(313, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item Description";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddWarehouseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionStoreWF.Properties.Resources.backgroundSingleColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ItemType);
            this.Controls.Add(this.ItemDes);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddWarehouseItem";
            this.Text = "AddWarehouseItem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemCode;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox ItemDes;
        private System.Windows.Forms.ComboBox ItemType;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}