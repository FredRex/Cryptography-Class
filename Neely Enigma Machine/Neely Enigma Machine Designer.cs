namespace Neely_Enigma_Machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.ECheck = new System.Windows.Forms.CheckBox();
            this.DCheck = new System.Windows.Forms.CheckBox();
            this.CaesarText = new System.Windows.Forms.TextBox();
            this.SlopeText = new System.Windows.Forms.TextBox();
            this.CodewordText = new System.Windows.Forms.TextBox();
            this.PlayfairText = new System.Windows.Forms.TextBox();
            this.Mat100 = new System.Windows.Forms.NumericUpDown();
            this.Mat101 = new System.Windows.Forms.NumericUpDown();
            this.Mat111 = new System.Windows.Forms.NumericUpDown();
            this.Mat110 = new System.Windows.Forms.NumericUpDown();
            this.Mat200 = new System.Windows.Forms.NumericUpDown();
            this.Mat201 = new System.Windows.Forms.NumericUpDown();
            this.Mat210 = new System.Windows.Forms.NumericUpDown();
            this.Mat220 = new System.Windows.Forms.NumericUpDown();
            this.Mat211 = new System.Windows.Forms.NumericUpDown();
            this.Mat221 = new System.Windows.Forms.NumericUpDown();
            this.Mat202 = new System.Windows.Forms.NumericUpDown();
            this.Mat212 = new System.Windows.Forms.NumericUpDown();
            this.Mat222 = new System.Windows.Forms.NumericUpDown();
            this.CaesarButton = new System.Windows.Forms.Button();
            this.MultiplicativeButton = new System.Windows.Forms.Button();
            this.AffineButton = new System.Windows.Forms.Button();
            this.CodeButton = new System.Windows.Forms.Button();
            this.VigButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.Mat2Button = new System.Windows.Forms.Button();
            this.Mat3Button = new System.Windows.Forms.Button();
            this.CodeKey = new System.Windows.Forms.TextBox();
            this.HCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mat100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat201)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat210)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat220)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat211)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat221)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat202)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat212)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat222)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(31, 188);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(349, 291);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(31, 679);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(349, 291);
            this.Output.TabIndex = 1;
            // 
            // ECheck
            // 
            this.ECheck.AutoSize = true;
            this.ECheck.Location = new System.Drawing.Point(1524, 767);
            this.ECheck.Name = "ECheck";
            this.ECheck.Size = new System.Drawing.Size(62, 17);
            this.ECheck.TabIndex = 2;
            this.ECheck.Text = "Encrypt";
            this.ECheck.UseVisualStyleBackColor = true;
            this.ECheck.CheckedChanged += new System.EventHandler(this.ECheck_CheckedChanged);
            // 
            // DCheck
            // 
            this.DCheck.AutoSize = true;
            this.DCheck.Location = new System.Drawing.Point(1779, 767);
            this.DCheck.Name = "DCheck";
            this.DCheck.Size = new System.Drawing.Size(63, 17);
            this.DCheck.TabIndex = 3;
            this.DCheck.Text = "Decrypt";
            this.DCheck.UseVisualStyleBackColor = true;
            this.DCheck.CheckedChanged += new System.EventHandler(this.DCheck_CheckedChanged);
            // 
            // CaesarText
            // 
            this.CaesarText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaesarText.Location = new System.Drawing.Point(1117, 148);
            this.CaesarText.Name = "CaesarText";
            this.CaesarText.Size = new System.Drawing.Size(84, 26);
            this.CaesarText.TabIndex = 4;
            // 
            // SlopeText
            // 
            this.SlopeText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlopeText.Location = new System.Drawing.Point(1326, 148);
            this.SlopeText.Name = "SlopeText";
            this.SlopeText.Size = new System.Drawing.Size(84, 26);
            this.SlopeText.TabIndex = 5;
            // 
            // CodewordText
            // 
            this.CodewordText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodewordText.Location = new System.Drawing.Point(1594, 148);
            this.CodewordText.Name = "CodewordText";
            this.CodewordText.Size = new System.Drawing.Size(302, 26);
            this.CodewordText.TabIndex = 6;
            // 
            // PlayfairText
            // 
            this.PlayfairText.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayfairText.Location = new System.Drawing.Point(1007, 294);
            this.PlayfairText.Name = "PlayfairText";
            this.PlayfairText.Size = new System.Drawing.Size(889, 82);
            this.PlayfairText.TabIndex = 7;
            // 
            // Mat100
            // 
            this.Mat100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat100.Location = new System.Drawing.Point(1285, 523);
            this.Mat100.Name = "Mat100";
            this.Mat100.Size = new System.Drawing.Size(65, 26);
            this.Mat100.TabIndex = 8;
            // 
            // Mat101
            // 
            this.Mat101.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat101.Location = new System.Drawing.Point(1285, 566);
            this.Mat101.Name = "Mat101";
            this.Mat101.Size = new System.Drawing.Size(65, 26);
            this.Mat101.TabIndex = 9;
            // 
            // Mat111
            // 
            this.Mat111.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat111.Location = new System.Drawing.Point(1356, 566);
            this.Mat111.Name = "Mat111";
            this.Mat111.Size = new System.Drawing.Size(65, 26);
            this.Mat111.TabIndex = 10;
            // 
            // Mat110
            // 
            this.Mat110.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat110.Location = new System.Drawing.Point(1356, 523);
            this.Mat110.Name = "Mat110";
            this.Mat110.Size = new System.Drawing.Size(65, 26);
            this.Mat110.TabIndex = 11;
            // 
            // Mat200
            // 
            this.Mat200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat200.Location = new System.Drawing.Point(1524, 523);
            this.Mat200.Name = "Mat200";
            this.Mat200.Size = new System.Drawing.Size(65, 26);
            this.Mat200.TabIndex = 12;
            // 
            // Mat201
            // 
            this.Mat201.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat201.Location = new System.Drawing.Point(1524, 566);
            this.Mat201.Name = "Mat201";
            this.Mat201.Size = new System.Drawing.Size(65, 26);
            this.Mat201.TabIndex = 13;
            // 
            // Mat210
            // 
            this.Mat210.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat210.Location = new System.Drawing.Point(1595, 523);
            this.Mat210.Name = "Mat210";
            this.Mat210.Size = new System.Drawing.Size(65, 26);
            this.Mat210.TabIndex = 14;
            // 
            // Mat220
            // 
            this.Mat220.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat220.Location = new System.Drawing.Point(1666, 523);
            this.Mat220.Name = "Mat220";
            this.Mat220.Size = new System.Drawing.Size(65, 26);
            this.Mat220.TabIndex = 15;
            // 
            // Mat211
            // 
            this.Mat211.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat211.Location = new System.Drawing.Point(1595, 566);
            this.Mat211.Name = "Mat211";
            this.Mat211.Size = new System.Drawing.Size(65, 26);
            this.Mat211.TabIndex = 16;
            // 
            // Mat221
            // 
            this.Mat221.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat221.Location = new System.Drawing.Point(1666, 566);
            this.Mat221.Name = "Mat221";
            this.Mat221.Size = new System.Drawing.Size(65, 26);
            this.Mat221.TabIndex = 17;
            // 
            // Mat202
            // 
            this.Mat202.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat202.Location = new System.Drawing.Point(1524, 610);
            this.Mat202.Name = "Mat202";
            this.Mat202.Size = new System.Drawing.Size(65, 26);
            this.Mat202.TabIndex = 18;
            // 
            // Mat212
            // 
            this.Mat212.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat212.Location = new System.Drawing.Point(1595, 610);
            this.Mat212.Name = "Mat212";
            this.Mat212.Size = new System.Drawing.Size(65, 26);
            this.Mat212.TabIndex = 19;
            // 
            // Mat222
            // 
            this.Mat222.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat222.Location = new System.Drawing.Point(1666, 610);
            this.Mat222.Name = "Mat222";
            this.Mat222.Size = new System.Drawing.Size(65, 26);
            this.Mat222.TabIndex = 20;
            // 
            // CaesarButton
            // 
            this.CaesarButton.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaesarButton.Location = new System.Drawing.Point(1498, 806);
            this.CaesarButton.Name = "CaesarButton";
            this.CaesarButton.Size = new System.Drawing.Size(162, 37);
            this.CaesarButton.TabIndex = 21;
            this.CaesarButton.Text = "Caesar Hack";
            this.CaesarButton.UseVisualStyleBackColor = true;
            this.CaesarButton.Click += new System.EventHandler(this.CaesarButton_Click);
            // 
            // MultiplicativeButton
            // 
            this.MultiplicativeButton.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicativeButton.Location = new System.Drawing.Point(1680, 806);
            this.MultiplicativeButton.Name = "MultiplicativeButton";
            this.MultiplicativeButton.Size = new System.Drawing.Size(162, 37);
            this.MultiplicativeButton.TabIndex = 22;
            this.MultiplicativeButton.Text = "Multi Hack";
            this.MultiplicativeButton.UseVisualStyleBackColor = true;
            this.MultiplicativeButton.Click += new System.EventHandler(this.MultiplicativeButton_Click);
            // 
            // AffineButton
            // 
            this.AffineButton.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AffineButton.Location = new System.Drawing.Point(1498, 849);
            this.AffineButton.Name = "AffineButton";
            this.AffineButton.Size = new System.Drawing.Size(162, 37);
            this.AffineButton.TabIndex = 23;
            this.AffineButton.Text = "Affine Hack";
            this.AffineButton.UseVisualStyleBackColor = true;
            this.AffineButton.Click += new System.EventHandler(this.AffineButton_Click);
            // 
            // CodeButton
            // 
            this.CodeButton.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeButton.Location = new System.Drawing.Point(1680, 849);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(162, 37);
            this.CodeButton.TabIndex = 24;
            this.CodeButton.Text = "Codeword Hack";
            this.CodeButton.UseVisualStyleBackColor = true;
            this.CodeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // VigButton
            // 
            this.VigButton.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VigButton.Location = new System.Drawing.Point(1498, 892);
            this.VigButton.Name = "VigButton";
            this.VigButton.Size = new System.Drawing.Size(162, 37);
            this.VigButton.TabIndex = 25;
            this.VigButton.Text = "Vigenere";
            this.VigButton.UseVisualStyleBackColor = true;
            this.VigButton.Click += new System.EventHandler(this.VigButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(1680, 892);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(162, 37);
            this.PlayButton.TabIndex = 26;
            this.PlayButton.Text = "Playfair";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Mat2Button
            // 
            this.Mat2Button.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat2Button.Location = new System.Drawing.Point(1498, 935);
            this.Mat2Button.Name = "Mat2Button";
            this.Mat2Button.Size = new System.Drawing.Size(162, 37);
            this.Mat2Button.TabIndex = 27;
            this.Mat2Button.Text = "Hill 2x2";
            this.Mat2Button.UseVisualStyleBackColor = true;
            this.Mat2Button.Click += new System.EventHandler(this.Mat2Button_Click);
            // 
            // Mat3Button
            // 
            this.Mat3Button.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mat3Button.Location = new System.Drawing.Point(1680, 935);
            this.Mat3Button.Name = "Mat3Button";
            this.Mat3Button.Size = new System.Drawing.Size(162, 37);
            this.Mat3Button.TabIndex = 28;
            this.Mat3Button.Text = "Hill 3x3";
            this.Mat3Button.UseVisualStyleBackColor = true;
            this.Mat3Button.Click += new System.EventHandler(this.Mat3Button_Click);
            // 
            // CodeKey
            // 
            this.CodeKey.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeKey.Location = new System.Drawing.Point(1595, 180);
            this.CodeKey.Name = "CodeKey";
            this.CodeKey.Size = new System.Drawing.Size(57, 26);
            this.CodeKey.TabIndex = 29;
            // 
            // HCheck
            // 
            this.HCheck.AutoSize = true;
            this.HCheck.Location = new System.Drawing.Point(1651, 767);
            this.HCheck.Name = "HCheck";
            this.HCheck.Size = new System.Drawing.Size(52, 17);
            this.HCheck.TabIndex = 30;
            this.HCheck.Text = "Hack";
            this.HCheck.UseVisualStyleBackColor = true;
            this.HCheck.CheckedChanged += new System.EventHandler(this.HCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1908, 1041);
            this.Controls.Add(this.HCheck);
            this.Controls.Add(this.CodeKey);
            this.Controls.Add(this.Mat3Button);
            this.Controls.Add(this.Mat2Button);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.VigButton);
            this.Controls.Add(this.CodeButton);
            this.Controls.Add(this.AffineButton);
            this.Controls.Add(this.MultiplicativeButton);
            this.Controls.Add(this.CaesarButton);
            this.Controls.Add(this.Mat222);
            this.Controls.Add(this.Mat212);
            this.Controls.Add(this.Mat202);
            this.Controls.Add(this.Mat221);
            this.Controls.Add(this.Mat211);
            this.Controls.Add(this.Mat220);
            this.Controls.Add(this.Mat210);
            this.Controls.Add(this.Mat201);
            this.Controls.Add(this.Mat200);
            this.Controls.Add(this.Mat110);
            this.Controls.Add(this.Mat111);
            this.Controls.Add(this.Mat101);
            this.Controls.Add(this.Mat100);
            this.Controls.Add(this.PlayfairText);
            this.Controls.Add(this.CodewordText);
            this.Controls.Add(this.SlopeText);
            this.Controls.Add(this.CaesarText);
            this.Controls.Add(this.DCheck);
            this.Controls.Add(this.ECheck);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mat100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat201)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat210)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat220)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat211)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat221)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat202)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat212)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mat222)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.CheckBox ECheck;
        private System.Windows.Forms.CheckBox DCheck;
        private System.Windows.Forms.TextBox CaesarText;
        private System.Windows.Forms.TextBox SlopeText;
        private System.Windows.Forms.TextBox CodewordText;
        private System.Windows.Forms.TextBox PlayfairText;
        private System.Windows.Forms.NumericUpDown Mat100;
        private System.Windows.Forms.NumericUpDown Mat101;
        private System.Windows.Forms.NumericUpDown Mat111;
        private System.Windows.Forms.NumericUpDown Mat110;
        private System.Windows.Forms.NumericUpDown Mat200;
        private System.Windows.Forms.NumericUpDown Mat201;
        private System.Windows.Forms.NumericUpDown Mat210;
        private System.Windows.Forms.NumericUpDown Mat220;
        private System.Windows.Forms.NumericUpDown Mat211;
        private System.Windows.Forms.NumericUpDown Mat221;
        private System.Windows.Forms.NumericUpDown Mat202;
        private System.Windows.Forms.NumericUpDown Mat212;
        private System.Windows.Forms.NumericUpDown Mat222;
        private System.Windows.Forms.Button CaesarButton;
        private System.Windows.Forms.Button MultiplicativeButton;
        private System.Windows.Forms.Button AffineButton;
        private System.Windows.Forms.Button CodeButton;
        private System.Windows.Forms.Button VigButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button Mat2Button;
        private System.Windows.Forms.Button Mat3Button;
        private System.Windows.Forms.TextBox CodeKey;
        private System.Windows.Forms.CheckBox HCheck;
    }
}
