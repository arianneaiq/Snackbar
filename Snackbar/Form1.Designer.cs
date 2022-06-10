namespace Snackbar
{
    partial class Form1
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
            this.btnSnackInfo = new System.Windows.Forms.Button();
            this.lbSnack1Info = new System.Windows.Forms.Label();
            this.lbSnack2Info = new System.Windows.Forms.Label();
            this.lbSnack3Info = new System.Windows.Forms.Label();
            this.nSnack1 = new System.Windows.Forms.NumericUpDown();
            this.nSnack2 = new System.Windows.Forms.NumericUpDown();
            this.nSnack3 = new System.Windows.Forms.NumericUpDown();
            this.btnAddToShoppingCar = new System.Windows.Forms.Button();
            this.lbSnack1Cal = new System.Windows.Forms.Label();
            this.lbSnack2Cal = new System.Windows.Forms.Label();
            this.lbSnack3Cal = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSnack3Amount = new System.Windows.Forms.Label();
            this.lbSnack2Amount = new System.Windows.Forms.Label();
            this.lbSnack1Amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nSnack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSnack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSnack3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSnackInfo
            // 
            this.btnSnackInfo.Location = new System.Drawing.Point(306, 34);
            this.btnSnackInfo.Name = "btnSnackInfo";
            this.btnSnackInfo.Size = new System.Drawing.Size(162, 37);
            this.btnSnackInfo.TabIndex = 0;
            this.btnSnackInfo.Text = "Snack Information ";
            this.btnSnackInfo.UseVisualStyleBackColor = true;
            this.btnSnackInfo.Click += new System.EventHandler(this.btnSnackInfo_Click);
            // 
            // lbSnack1Info
            // 
            this.lbSnack1Info.AutoSize = true;
            this.lbSnack1Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbSnack1Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack1Info.Location = new System.Drawing.Point(72, 29);
            this.lbSnack1Info.Name = "lbSnack1Info";
            this.lbSnack1Info.Size = new System.Drawing.Size(99, 21);
            this.lbSnack1Info.TabIndex = 1;
            this.lbSnack1Info.Text = "Snack 1 Info ";
            // 
            // lbSnack2Info
            // 
            this.lbSnack2Info.AutoSize = true;
            this.lbSnack2Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbSnack2Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack2Info.Location = new System.Drawing.Point(72, 68);
            this.lbSnack2Info.Name = "lbSnack2Info";
            this.lbSnack2Info.Size = new System.Drawing.Size(95, 21);
            this.lbSnack2Info.TabIndex = 2;
            this.lbSnack2Info.Text = "Snack 2 Info";
            // 
            // lbSnack3Info
            // 
            this.lbSnack3Info.AutoSize = true;
            this.lbSnack3Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbSnack3Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack3Info.Location = new System.Drawing.Point(72, 108);
            this.lbSnack3Info.Name = "lbSnack3Info";
            this.lbSnack3Info.Size = new System.Drawing.Size(95, 21);
            this.lbSnack3Info.TabIndex = 3;
            this.lbSnack3Info.Text = "Snack 3 Info";
            // 
            // nSnack1
            // 
            this.nSnack1.Location = new System.Drawing.Point(13, 32);
            this.nSnack1.Name = "nSnack1";
            this.nSnack1.Size = new System.Drawing.Size(51, 23);
            this.nSnack1.TabIndex = 0;
            // 
            // nSnack2
            // 
            this.nSnack2.Location = new System.Drawing.Point(13, 68);
            this.nSnack2.Name = "nSnack2";
            this.nSnack2.Size = new System.Drawing.Size(51, 23);
            this.nSnack2.TabIndex = 14;
            // 
            // nSnack3
            // 
            this.nSnack3.Location = new System.Drawing.Point(13, 111);
            this.nSnack3.Name = "nSnack3";
            this.nSnack3.Size = new System.Drawing.Size(51, 23);
            this.nSnack3.TabIndex = 13;
            // 
            // btnAddToShoppingCar
            // 
            this.btnAddToShoppingCar.Location = new System.Drawing.Point(61, 238);
            this.btnAddToShoppingCar.Name = "btnAddToShoppingCar";
            this.btnAddToShoppingCar.Size = new System.Drawing.Size(147, 32);
            this.btnAddToShoppingCar.TabIndex = 7;
            this.btnAddToShoppingCar.Text = "Add to Shopping Car ";
            this.btnAddToShoppingCar.UseVisualStyleBackColor = true;
            this.btnAddToShoppingCar.Click += new System.EventHandler(this.btnAddToShoppingCar_Click);
            // 
            // lbSnack1Cal
            // 
            this.lbSnack1Cal.AutoSize = true;
            this.lbSnack1Cal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack1Cal.Location = new System.Drawing.Point(510, 19);
            this.lbSnack1Cal.Name = "lbSnack1Cal";
            this.lbSnack1Cal.Size = new System.Drawing.Size(67, 21);
            this.lbSnack1Cal.TabIndex = 8;
            this.lbSnack1Cal.Text = "Euro ...,...";
            // 
            // lbSnack2Cal
            // 
            this.lbSnack2Cal.AutoSize = true;
            this.lbSnack2Cal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack2Cal.Location = new System.Drawing.Point(510, 50);
            this.lbSnack2Cal.Name = "lbSnack2Cal";
            this.lbSnack2Cal.Size = new System.Drawing.Size(67, 21);
            this.lbSnack2Cal.TabIndex = 9;
            this.lbSnack2Cal.Text = "Euro ...,...";
            // 
            // lbSnack3Cal
            // 
            this.lbSnack3Cal.AutoSize = true;
            this.lbSnack3Cal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack3Cal.Location = new System.Drawing.Point(510, 82);
            this.lbSnack3Cal.Name = "lbSnack3Cal";
            this.lbSnack3Cal.Size = new System.Drawing.Size(67, 21);
            this.lbSnack3Cal.TabIndex = 10;
            this.lbSnack3Cal.Text = "Euro ...,...";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPrice.Location = new System.Drawing.Point(510, 127);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(67, 21);
            this.lbTotalPrice.TabIndex = 11;
            this.lbTotalPrice.Text = "Euro ...,...";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 501);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.nSnack1);
            this.groupBox1.Controls.Add(this.lbSnack1Info);
            this.groupBox1.Controls.Add(this.nSnack2);
            this.groupBox1.Controls.Add(this.nSnack3);
            this.groupBox1.Controls.Add(this.lbSnack2Info);
            this.groupBox1.Controls.Add(this.lbSnack3Info);
            this.groupBox1.Location = new System.Drawing.Point(48, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 196);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Snack Information ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbSnack3Amount);
            this.groupBox2.Controls.Add(this.lbSnack2Amount);
            this.groupBox2.Controls.Add(this.lbSnack1Amount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbTotalPrice);
            this.groupBox2.Controls.Add(this.lbSnack1Cal);
            this.groupBox2.Controls.Add(this.lbSnack3Cal);
            this.groupBox2.Controls.Add(this.lbSnack2Cal);
            this.groupBox2.Location = new System.Drawing.Point(48, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 162);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shopping Car";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Price: ";
            // 
            // lbSnack3Amount
            // 
            this.lbSnack3Amount.AutoSize = true;
            this.lbSnack3Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack3Amount.Location = new System.Drawing.Point(13, 82);
            this.lbSnack3Amount.Name = "lbSnack3Amount";
            this.lbSnack3Amount.Size = new System.Drawing.Size(99, 21);
            this.lbSnack3Amount.TabIndex = 14;
            this.lbSnack3Amount.Text = ".... Snack 3 = ";
            // 
            // lbSnack2Amount
            // 
            this.lbSnack2Amount.AutoSize = true;
            this.lbSnack2Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack2Amount.Location = new System.Drawing.Point(13, 50);
            this.lbSnack2Amount.Name = "lbSnack2Amount";
            this.lbSnack2Amount.Size = new System.Drawing.Size(99, 21);
            this.lbSnack2Amount.TabIndex = 13;
            this.lbSnack2Amount.Text = ".... Snack 2 = ";
            // 
            // lbSnack1Amount
            // 
            this.lbSnack1Amount.AutoSize = true;
            this.lbSnack1Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSnack1Amount.Location = new System.Drawing.Point(13, 19);
            this.lbSnack1Amount.Name = "lbSnack1Amount";
            this.lbSnack1Amount.Size = new System.Drawing.Size(99, 21);
            this.lbSnack1Amount.TabIndex = 12;
            this.lbSnack1Amount.Text = ".... Snack 1 = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "-------------------------  +";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnAddToShoppingCar);
            this.Controls.Add(this.btnSnackInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "MacSnacks";
            ((System.ComponentModel.ISupportInitialize)(this.nSnack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSnack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSnack3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnackInfo;
        private System.Windows.Forms.Label lbSnack1Info;
        private System.Windows.Forms.Label lbSnack2Info;
        private System.Windows.Forms.Label lbSnack3Info;
        private System.Windows.Forms.NumericUpDown nSnack1;
        private System.Windows.Forms.NumericUpDown nSnack2;
        private System.Windows.Forms.NumericUpDown nSnack3;
        private System.Windows.Forms.Button btnAddToShoppingCar;
        private System.Windows.Forms.Label lbSnack1Cal;
        private System.Windows.Forms.Label lbSnack2Cal;
        private System.Windows.Forms.Label lbSnack3Cal;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSnack3Amount;
        private System.Windows.Forms.Label lbSnack2Amount;
        private System.Windows.Forms.Label lbSnack1Amount;
        private System.Windows.Forms.Label label1;
    }
}
