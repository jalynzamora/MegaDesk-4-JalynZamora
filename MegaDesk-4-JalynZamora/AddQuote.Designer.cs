namespace MegaDesk_3_JalynZamora
{
    partial class AddQuote
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.numOfDrawers = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.quoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(22, 388);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(133, 35);
            this.MainMenuButton.TabIndex = 0;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(146, 121);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(168, 20);
            this.widthInput.TabIndex = 1;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            this.widthInput.Validated += new System.EventHandler(this.widthInput_Validated);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(102, 124);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(102, 183);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(39, 13);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth:";
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(146, 176);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(166, 20);
            this.depthInput.TabIndex = 4;
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthInput_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 5;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(229, 72);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(85, 13);
            this.customerName.TabIndex = 6;
            this.customerName.Text = "Customer Name:";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.AutoSize = true;
            this.numOfDrawers.Location = new System.Drawing.Point(392, 124);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(71, 13);
            this.numOfDrawers.TabIndex = 7;
            this.numOfDrawers.Text = "# of Drawers:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(469, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 8;
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Location = new System.Drawing.Point(392, 179);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(87, 13);
            this.surfaceMaterial.TabIndex = 10;
            this.surfaceMaterial.Text = "Surface Material:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(485, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // quoteButton
            // 
            this.quoteButton.Location = new System.Drawing.Point(310, 294);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(109, 26);
            this.quoteButton.TabIndex = 12;
            this.quoteButton.Text = "Quote";
            this.quoteButton.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 435);
            this.Controls.Add(this.quoteButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label numOfDrawers;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button quoteButton;
    }
}