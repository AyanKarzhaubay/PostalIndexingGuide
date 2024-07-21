namespace Postal_Indexing_Guide.MainMenuForms
{
    partial class GuestMainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestMainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMainForm = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBoxMainForm);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Location = new System.Drawing.Point(187, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 281);
            this.panel1.TabIndex = 18;
            // 
            // textBoxMainForm
            // 
            this.textBoxMainForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMainForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMainForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMainForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMainForm.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainForm.Location = new System.Drawing.Point(43, 23);
            this.textBoxMainForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMainForm.Name = "textBoxMainForm";
            this.textBoxMainForm.ReadOnly = true;
            this.textBoxMainForm.Size = new System.Drawing.Size(583, 39);
            this.textBoxMainForm.TabIndex = 14;
            this.textBoxMainForm.Text = "Postal Indexing Guide";
            this.textBoxMainForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.ForestGreen;
            this.Search.Location = new System.Drawing.Point(172, 70);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(319, 49);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit.ForeColor = System.Drawing.Color.Red;
            this.Quit.Location = new System.Drawing.Point(172, 127);
            this.Quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(319, 49);
            this.Quit.TabIndex = 13;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // GuestMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GuestMainMenuForm";
            this.Text = "GuestMainMenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseApplicationButton_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMainForm;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Quit;
    }
}