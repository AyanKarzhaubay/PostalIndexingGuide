namespace Postal_Indexing_Guide
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.searchFormButton = new System.Windows.Forms.Button();
            this.textBoxMainForm = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.villagesFormButton = new System.Windows.Forms.Button();
            this.districtsFormButton = new System.Windows.Forms.Button();
            this.regionsFormButton = new System.Windows.Forms.Button();
            this.republicsFormButton = new System.Windows.Forms.Button();
            this.postalIndexesFormButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchFormButton
            // 
            this.searchFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFormButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.searchFormButton.Location = new System.Drawing.Point(173, 74);
            this.searchFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchFormButton.Name = "searchFormButton";
            this.searchFormButton.Size = new System.Drawing.Size(319, 49);
            this.searchFormButton.TabIndex = 15;
            this.searchFormButton.Text = "Search";
            this.searchFormButton.UseVisualStyleBackColor = false;
            this.searchFormButton.Click += new System.EventHandler(this.searchFormButton_Click);
            // 
            // textBoxMainForm
            // 
            this.textBoxMainForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMainForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMainForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMainForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMainForm.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainForm.Location = new System.Drawing.Point(44, 27);
            this.textBoxMainForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMainForm.Name = "textBoxMainForm";
            this.textBoxMainForm.ReadOnly = true;
            this.textBoxMainForm.Size = new System.Drawing.Size(583, 39);
            this.textBoxMainForm.TabIndex = 14;
            this.textBoxMainForm.Text = "Postal Indexing Guide";
            this.textBoxMainForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.Color.Red;
            this.quitButton.Location = new System.Drawing.Point(173, 416);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(319, 49);
            this.quitButton.TabIndex = 13;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // villagesFormButton
            // 
            this.villagesFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.villagesFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.villagesFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.villagesFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.villagesFormButton.Location = new System.Drawing.Point(173, 359);
            this.villagesFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.villagesFormButton.Name = "villagesFormButton";
            this.villagesFormButton.Size = new System.Drawing.Size(319, 49);
            this.villagesFormButton.TabIndex = 12;
            this.villagesFormButton.Text = "Villages";
            this.villagesFormButton.UseVisualStyleBackColor = false;
            this.villagesFormButton.Click += new System.EventHandler(this.villagesFormButton_Click);
            // 
            // districtsFormButton
            // 
            this.districtsFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.districtsFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.districtsFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.districtsFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtsFormButton.Location = new System.Drawing.Point(173, 302);
            this.districtsFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.districtsFormButton.Name = "districtsFormButton";
            this.districtsFormButton.Size = new System.Drawing.Size(319, 49);
            this.districtsFormButton.TabIndex = 11;
            this.districtsFormButton.Text = "Districts";
            this.districtsFormButton.UseVisualStyleBackColor = false;
            this.districtsFormButton.Click += new System.EventHandler(this.districtsFormButton_Click);
            // 
            // regionsFormButton
            // 
            this.regionsFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regionsFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regionsFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regionsFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionsFormButton.Location = new System.Drawing.Point(173, 245);
            this.regionsFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regionsFormButton.Name = "regionsFormButton";
            this.regionsFormButton.Size = new System.Drawing.Size(319, 49);
            this.regionsFormButton.TabIndex = 10;
            this.regionsFormButton.Text = "Regions";
            this.regionsFormButton.UseVisualStyleBackColor = false;
            this.regionsFormButton.Click += new System.EventHandler(this.regionsFormButton_Click);
            // 
            // republicsFormButton
            // 
            this.republicsFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.republicsFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.republicsFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.republicsFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.republicsFormButton.Location = new System.Drawing.Point(173, 188);
            this.republicsFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.republicsFormButton.Name = "republicsFormButton";
            this.republicsFormButton.Size = new System.Drawing.Size(319, 49);
            this.republicsFormButton.TabIndex = 9;
            this.republicsFormButton.Text = "Republics";
            this.republicsFormButton.UseVisualStyleBackColor = false;
            this.republicsFormButton.Click += new System.EventHandler(this.republicsFormButton_Click);
            // 
            // postalIndexesFormButton
            // 
            this.postalIndexesFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postalIndexesFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.postalIndexesFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postalIndexesFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postalIndexesFormButton.Location = new System.Drawing.Point(173, 131);
            this.postalIndexesFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postalIndexesFormButton.Name = "postalIndexesFormButton";
            this.postalIndexesFormButton.Size = new System.Drawing.Size(319, 49);
            this.postalIndexesFormButton.TabIndex = 16;
            this.postalIndexesFormButton.Text = "Postal indexes";
            this.postalIndexesFormButton.UseVisualStyleBackColor = false;
            this.postalIndexesFormButton.Click += new System.EventHandler(this.postalIndexesFormButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.villagesFormButton);
            this.panel1.Controls.Add(this.districtsFormButton);
            this.panel1.Controls.Add(this.textBoxMainForm);
            this.panel1.Controls.Add(this.postalIndexesFormButton);
            this.panel1.Controls.Add(this.regionsFormButton);
            this.panel1.Controls.Add(this.republicsFormButton);
            this.panel1.Controls.Add(this.searchFormButton);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Location = new System.Drawing.Point(203, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 486);
            this.panel1.TabIndex = 17;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchFormButton;
        private System.Windows.Forms.TextBox textBoxMainForm;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button villagesFormButton;
        private System.Windows.Forms.Button districtsFormButton;
        private System.Windows.Forms.Button regionsFormButton;
        private System.Windows.Forms.Button republicsFormButton;
        private System.Windows.Forms.Button postalIndexesFormButton;
        private System.Windows.Forms.Panel panel1;
    }
}

