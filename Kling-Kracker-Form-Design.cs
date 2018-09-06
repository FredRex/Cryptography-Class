namespace Cipher_Cracker_V2
{
    partial class KlingKracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlingKracker));
            this.Caesar = new System.Windows.Forms.Button();
            this.Multiplicative = new System.Windows.Forms.Button();
            this.Affine = new System.Windows.Forms.Button();
            this.Title_Label = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Caesar
            // 
            this.Caesar.AccessibleName = "Caesar";
            this.Caesar.Location = new System.Drawing.Point(620, 36);
            this.Caesar.Name = "Caesar";
            this.Caesar.Size = new System.Drawing.Size(104, 23);
            this.Caesar.TabIndex = 1;
            this.Caesar.Text = "Caesar";
            this.Caesar.UseVisualStyleBackColor = true;
            this.Caesar.Click += new System.EventHandler(this.Caesar_Click);
            // 
            // Multiplicative
            // 
            this.Multiplicative.AccessibleName = "Multiplicative";
            this.Multiplicative.Location = new System.Drawing.Point(620, 63);
            this.Multiplicative.Name = "Multiplicative";
            this.Multiplicative.Size = new System.Drawing.Size(104, 23);
            this.Multiplicative.TabIndex = 2;
            this.Multiplicative.Text = "Multiplicative";
            this.Multiplicative.UseVisualStyleBackColor = true;
            this.Multiplicative.Click += new System.EventHandler(this.Multiplicative_Click);
            // 
            // Affine
            // 
            this.Affine.AccessibleName = "Affine";
            this.Affine.Location = new System.Drawing.Point(620, 92);
            this.Affine.Name = "Affine";
            this.Affine.Size = new System.Drawing.Size(104, 23);
            this.Affine.TabIndex = 3;
            this.Affine.Text = "Affine";
            this.Affine.UseVisualStyleBackColor = true;
            this.Affine.Click += new System.EventHandler(this.Affine_Click);
            // 
            // Title_Label
            // 
            this.Title_Label.AccessibleName = "Title_Label";
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Title_Label.Location = new System.Drawing.Point(3, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(342, 50);
            this.Title_Label.TabIndex = 4;
            this.Title_Label.Text = "Welcome to the Kling Kracker(TM)\r\n           Made By Dirty Dave";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InputLabel.Location = new System.Drawing.Point(119, 93);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(63, 22);
            this.InputLabel.TabIndex = 5;
            this.InputLabel.Text = "Input:";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(8, 130);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(337, 93);
            this.InputText.TabIndex = 6;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OutputLabel.Location = new System.Drawing.Point(103, 235);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(79, 22);
            this.OutputLabel.TabIndex = 7;
            this.OutputLabel.Text = "Output:";
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(8, 268);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(337, 239);
            this.OutputText.TabIndex = 8;
            // 
            // KlingKracker
            // 
            this.AccessibleName = "Kling Kracker";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Cipher_Cracker_V2.Properties.Resources.You_Know_I_Had_To_Kling_It_To_Em;
            this.ClientSize = new System.Drawing.Size(727, 519);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Affine);
            this.Controls.Add(this.Multiplicative);
            this.Controls.Add(this.Caesar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlingKracker";
            this.Text = "Kling Kracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Caesar;
        private System.Windows.Forms.Button Multiplicative;
        private System.Windows.Forms.Button Affine;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputText;
    }
}

