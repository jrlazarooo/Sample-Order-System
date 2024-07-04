namespace Sample_Order
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkCreamy = new System.Windows.Forms.CheckBox();
            this.chkSalted = new System.Windows.Forms.CheckBox();
            this.chkVanilla = new System.Windows.Forms.CheckBox();
            this.chkBurnt = new System.Windows.Forms.CheckBox();
            this.chkHot = new System.Windows.Forms.CheckBox();
            this.chkIced = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.nuD1 = new System.Windows.Forms.NumericUpDown();
            this.nuD2 = new System.Windows.Forms.NumericUpDown();
            this.nuD3 = new System.Windows.Forms.NumericUpDown();
            this.nuD4 = new System.Windows.Forms.NumericUpDown();
            this.nuD5 = new System.Windows.Forms.NumericUpDown();
            this.nuD6 = new System.Windows.Forms.NumericUpDown();
            this.nuD7 = new System.Windows.Forms.NumericUpDown();
            this.nuD8 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.chkMember = new System.Windows.Forms.CheckBox();
            this.rdoDine = new System.Windows.Forms.RadioButton();
            this.rdoGO = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nuD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "KiFFee Ordering System\r\n";
            // 
            // chkCreamy
            // 
            this.chkCreamy.AutoSize = true;
            this.chkCreamy.Location = new System.Drawing.Point(85, 78);
            this.chkCreamy.Name = "chkCreamy";
            this.chkCreamy.Size = new System.Drawing.Size(129, 17);
            this.chkCreamy.TabIndex = 1;
            this.chkCreamy.Text = "Creamy Caramel Latte";
            this.chkCreamy.UseVisualStyleBackColor = true;
            this.chkCreamy.CheckedChanged += new System.EventHandler(this.chkCreamy_CheckedChanged);
            // 
            // chkSalted
            // 
            this.chkSalted.AutoSize = true;
            this.chkSalted.Location = new System.Drawing.Point(85, 129);
            this.chkSalted.Name = "chkSalted";
            this.chkSalted.Size = new System.Drawing.Size(124, 17);
            this.chkSalted.TabIndex = 2;
            this.chkSalted.Text = "Salted Caramel Latte";
            this.chkSalted.UseVisualStyleBackColor = true;
            this.chkSalted.CheckedChanged += new System.EventHandler(this.chkSalted_CheckedChanged);
            // 
            // chkVanilla
            // 
            this.chkVanilla.AutoSize = true;
            this.chkVanilla.Location = new System.Drawing.Point(85, 177);
            this.chkVanilla.Name = "chkVanilla";
            this.chkVanilla.Size = new System.Drawing.Size(174, 17);
            this.chkVanilla.TabIndex = 3;
            this.chkVanilla.Text = "Vanilla Sweet Cream Cold Brew";
            this.chkVanilla.UseVisualStyleBackColor = true;
            this.chkVanilla.CheckedChanged += new System.EventHandler(this.chkVanilla_CheckedChanged);
            // 
            // chkBurnt
            // 
            this.chkBurnt.AutoSize = true;
            this.chkBurnt.Location = new System.Drawing.Point(85, 216);
            this.chkBurnt.Name = "chkBurnt";
            this.chkBurnt.Size = new System.Drawing.Size(157, 17);
            this.chkBurnt.TabIndex = 4;
            this.chkBurnt.Text = "Burnt Caramel Oatmilk Latte";
            this.chkBurnt.UseVisualStyleBackColor = true;
            this.chkBurnt.CheckedChanged += new System.EventHandler(this.chkBurnt_CheckedChanged);
            // 
            // chkHot
            // 
            this.chkHot.AutoSize = true;
            this.chkHot.Location = new System.Drawing.Point(318, 78);
            this.chkHot.Name = "chkHot";
            this.chkHot.Size = new System.Drawing.Size(116, 17);
            this.chkHot.TabIndex = 5;
            this.chkHot.Text = "Hot Brewed Coffee";
            this.chkHot.UseVisualStyleBackColor = true;
            this.chkHot.CheckedChanged += new System.EventHandler(this.chkHot_CheckedChanged);
            // 
            // chkIced
            // 
            this.chkIced.AutoSize = true;
            this.chkIced.Location = new System.Drawing.Point(318, 127);
            this.chkIced.Name = "chkIced";
            this.chkIced.Size = new System.Drawing.Size(138, 17);
            this.chkIced.TabIndex = 6;
            this.chkIced.Text = "Iced Caramel Macchiatt";
            this.chkIced.UseVisualStyleBackColor = true;
            this.chkIced.CheckedChanged += new System.EventHandler(this.chkIced_CheckedChanged);
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(318, 216);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(135, 17);
            this.chkJava.TabIndex = 7;
            this.chkJava.Text = "Java Chip Frappuchino";
            this.chkJava.UseVisualStyleBackColor = true;
            this.chkJava.CheckedChanged += new System.EventHandler(this.chkJava_CheckedChanged);
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Location = new System.Drawing.Point(318, 177);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(172, 17);
            this.chkGreen.TabIndex = 8;
            this.chkGreen.Text = "Green Tea Cream Frappuchino";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chkGreen_CheckedChanged);
            // 
            // nuD1
            // 
            this.nuD1.Enabled = false;
            this.nuD1.Location = new System.Drawing.Point(42, 77);
            this.nuD1.Name = "nuD1";
            this.nuD1.Size = new System.Drawing.Size(37, 20);
            this.nuD1.TabIndex = 9;
            // 
            // nuD2
            // 
            this.nuD2.Enabled = false;
            this.nuD2.Location = new System.Drawing.Point(42, 126);
            this.nuD2.Name = "nuD2";
            this.nuD2.Size = new System.Drawing.Size(37, 20);
            this.nuD2.TabIndex = 10;
            // 
            // nuD3
            // 
            this.nuD3.Enabled = false;
            this.nuD3.Location = new System.Drawing.Point(42, 174);
            this.nuD3.Name = "nuD3";
            this.nuD3.Size = new System.Drawing.Size(37, 20);
            this.nuD3.TabIndex = 11;
            // 
            // nuD4
            // 
            this.nuD4.Enabled = false;
            this.nuD4.Location = new System.Drawing.Point(42, 215);
            this.nuD4.Name = "nuD4";
            this.nuD4.Size = new System.Drawing.Size(37, 20);
            this.nuD4.TabIndex = 12;
            // 
            // nuD5
            // 
            this.nuD5.Enabled = false;
            this.nuD5.Location = new System.Drawing.Point(275, 77);
            this.nuD5.Name = "nuD5";
            this.nuD5.Size = new System.Drawing.Size(37, 20);
            this.nuD5.TabIndex = 13;
            // 
            // nuD6
            // 
            this.nuD6.Enabled = false;
            this.nuD6.Location = new System.Drawing.Point(275, 126);
            this.nuD6.Name = "nuD6";
            this.nuD6.Size = new System.Drawing.Size(37, 20);
            this.nuD6.TabIndex = 14;
            // 
            // nuD7
            // 
            this.nuD7.Enabled = false;
            this.nuD7.Location = new System.Drawing.Point(275, 174);
            this.nuD7.Name = "nuD7";
            this.nuD7.Size = new System.Drawing.Size(37, 20);
            this.nuD7.TabIndex = 15;
            // 
            // nuD8
            // 
            this.nuD8.Enabled = false;
            this.nuD8.Location = new System.Drawing.Point(275, 215);
            this.nuD8.Name = "nuD8";
            this.nuD8.Size = new System.Drawing.Size(37, 20);
            this.nuD8.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGO);
            this.groupBox1.Controls.Add(this.chkMember);
            this.groupBox1.Controls.Add(this.rdoDine);
            this.groupBox1.Location = new System.Drawing.Point(42, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 125);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership and Dining";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(275, 262);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(105, 32);
            this.btnComplete.TabIndex = 18;
            this.btnComplete.Text = "Complete Order";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(403, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset Order";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(271, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total :";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(271, 367);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(59, 20);
            this.lblPoints.TabIndex = 21;
            this.lblPoints.Text = "Points :";
            // 
            // chkMember
            // 
            this.chkMember.AutoSize = true;
            this.chkMember.Location = new System.Drawing.Point(17, 29);
            this.chkMember.Name = "chkMember";
            this.chkMember.Size = new System.Drawing.Size(83, 17);
            this.chkMember.TabIndex = 22;
            this.chkMember.Text = "Membership";
            this.chkMember.UseVisualStyleBackColor = true;
            // 
            // rdoDine
            // 
            this.rdoDine.AutoSize = true;
            this.rdoDine.Location = new System.Drawing.Point(6, 64);
            this.rdoDine.Name = "rdoDine";
            this.rdoDine.Size = new System.Drawing.Size(65, 17);
            this.rdoDine.TabIndex = 22;
            this.rdoDine.TabStop = true;
            this.rdoDine.Text = "For Dine";
            this.rdoDine.UseVisualStyleBackColor = true;
            // 
            // rdoGO
            // 
            this.rdoGO.AutoSize = true;
            this.rdoGO.Location = new System.Drawing.Point(6, 87);
            this.rdoGO.Name = "rdoGO";
            this.rdoGO.Size = new System.Drawing.Size(55, 17);
            this.rdoGO.TabIndex = 23;
            this.rdoGO.TabStop = true;
            this.rdoGO.Text = "To Go";
            this.rdoGO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 421);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nuD8);
            this.Controls.Add(this.nuD7);
            this.Controls.Add(this.nuD6);
            this.Controls.Add(this.nuD5);
            this.Controls.Add(this.nuD4);
            this.Controls.Add(this.nuD3);
            this.Controls.Add(this.nuD2);
            this.Controls.Add(this.nuD1);
            this.Controls.Add(this.chkGreen);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.chkIced);
            this.Controls.Add(this.chkHot);
            this.Controls.Add(this.chkBurnt);
            this.Controls.Add(this.chkVanilla);
            this.Controls.Add(this.chkSalted);
            this.Controls.Add(this.chkCreamy);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiFFee Sample Order System";
            ((System.ComponentModel.ISupportInitialize)(this.nuD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuD8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCreamy;
        private System.Windows.Forms.CheckBox chkSalted;
        private System.Windows.Forms.CheckBox chkVanilla;
        private System.Windows.Forms.CheckBox chkBurnt;
        private System.Windows.Forms.CheckBox chkHot;
        private System.Windows.Forms.CheckBox chkIced;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.NumericUpDown nuD1;
        private System.Windows.Forms.NumericUpDown nuD2;
        private System.Windows.Forms.NumericUpDown nuD3;
        private System.Windows.Forms.NumericUpDown nuD4;
        private System.Windows.Forms.NumericUpDown nuD5;
        private System.Windows.Forms.NumericUpDown nuD6;
        private System.Windows.Forms.NumericUpDown nuD7;
        private System.Windows.Forms.NumericUpDown nuD8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.CheckBox chkMember;
        private System.Windows.Forms.RadioButton rdoDine;
        private System.Windows.Forms.RadioButton rdoGO;
    }
}

