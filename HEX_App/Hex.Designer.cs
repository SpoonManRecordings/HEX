namespace HexNameSpace
{
    partial class HexInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexInterface));
            this.hexButton = new System.Windows.Forms.Button();
            this.hexText = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hexButton
            // 
            this.hexButton.AutoSize = true;
            this.hexButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hexButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hexButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexButton.Location = new System.Drawing.Point(12, 226);
            this.hexButton.Name = "hexButton";
            this.hexButton.Size = new System.Drawing.Size(125, 23);
            this.hexButton.TabIndex = 1;
            this.hexButton.Text = "Ask HEX a Question";
            this.hexButton.UseVisualStyleBackColor = false;
            this.hexButton.Visible = false;
            this.hexButton.Click += new System.EventHandler(this.hexButton_Click);
            this.hexButton.Enter += new System.EventHandler(this.hexButton_Enter);
            this.hexButton.Leave += new System.EventHandler(this.hexButton_Leave);
            // 
            // hexText
            // 
            this.hexText.Location = new System.Drawing.Point(12, 12);
            this.hexText.Multiline = true;
            this.hexText.Name = "hexText";
            this.hexText.Size = new System.Drawing.Size(202, 208);
            this.hexText.TabIndex = 0;
            this.hexText.Text = "+++ <Your Question Here> +++";
            this.hexText.Visible = false;
            this.hexText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hexText_MouseClick);
            this.hexText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hexText_KeyDown);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(171, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(43, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.Enter += new System.EventHandler(this.closeButton_Enter);
            this.closeButton.Leave += new System.EventHandler(this.closeButton_Leave);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.Location = new System.Drawing.Point(143, 226);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 23);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Visible = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // HexInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(226, 261);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.hexText);
            this.Controls.Add(this.hexButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HexInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HEX/Roundworld Interface";
            this.Load += new System.EventHandler(this.HexInterface_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInterface_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HexInterface_MouseClick);
            this.MouseHover += new System.EventHandler(this.HexInterface_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hexButton;
        private System.Windows.Forms.TextBox hexText;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button helpButton;
    }
}

