namespace yatzheeProjectME
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
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblDice3 = new System.Windows.Forms.Label();
            this.lblDice4 = new System.Windows.Forms.Label();
            this.lblDice5 = new System.Windows.Forms.Label();
            this.btnReroll = new System.Windows.Forms.Button();
            this.tbxRerollValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Location = new System.Drawing.Point(120, 70);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(35, 13);
            this.lblDice1.TabIndex = 0;
            this.lblDice1.Text = "label1";
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Location = new System.Drawing.Point(161, 70);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(35, 13);
            this.lblDice2.TabIndex = 1;
            this.lblDice2.Text = "label2";
            // 
            // lblDice3
            // 
            this.lblDice3.AutoSize = true;
            this.lblDice3.Location = new System.Drawing.Point(202, 70);
            this.lblDice3.Name = "lblDice3";
            this.lblDice3.Size = new System.Drawing.Size(35, 13);
            this.lblDice3.TabIndex = 2;
            this.lblDice3.Text = "label3";
            // 
            // lblDice4
            // 
            this.lblDice4.AutoSize = true;
            this.lblDice4.Location = new System.Drawing.Point(243, 70);
            this.lblDice4.Name = "lblDice4";
            this.lblDice4.Size = new System.Drawing.Size(35, 13);
            this.lblDice4.TabIndex = 3;
            this.lblDice4.Text = "label4";
            // 
            // lblDice5
            // 
            this.lblDice5.AutoSize = true;
            this.lblDice5.Location = new System.Drawing.Point(284, 70);
            this.lblDice5.Name = "lblDice5";
            this.lblDice5.Size = new System.Drawing.Size(35, 13);
            this.lblDice5.TabIndex = 4;
            this.lblDice5.Text = "label5";
            // 
            // btnReroll
            // 
            this.btnReroll.Location = new System.Drawing.Point(123, 152);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(75, 23);
            this.btnReroll.TabIndex = 5;
            this.btnReroll.Text = "btnReroll";
            this.btnReroll.UseVisualStyleBackColor = true;
            // 
            // tbxRerollValue
            // 
            this.tbxRerollValue.Location = new System.Drawing.Point(204, 155);
            this.tbxRerollValue.Name = "tbxRerollValue";
            this.tbxRerollValue.Size = new System.Drawing.Size(33, 20);
            this.tbxRerollValue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxRerollValue);
            this.Controls.Add(this.btnReroll);
            this.Controls.Add(this.lblDice5);
            this.Controls.Add(this.lblDice4);
            this.Controls.Add(this.lblDice3);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblDice3;
        private System.Windows.Forms.Label lblDice4;
        private System.Windows.Forms.Label lblDice5;
        private System.Windows.Forms.Button btnReroll;
        private System.Windows.Forms.TextBox tbxRerollValue;
    }
}

