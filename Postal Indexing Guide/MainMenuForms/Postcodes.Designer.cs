namespace Postal_Indexing_Guide.MainMenuForms
{
    partial class Postcodes
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
            System.Windows.Forms.Label postcodeIDLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postcodes));
            this.postalIndexingGuide_DataSet = new Postal_Indexing_Guide.PostalIndexingGuideDS();
            this.postalCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postalCodesTableAdapter = new Postal_Indexing_Guide.PostalIndexingGuideDSTableAdapters.PostalCodesTableAdapter();
            this.tableAdapterManager = new Postal_Indexing_Guide.PostalIndexingGuideDSTableAdapters.TableAdapterManager();
            this.postalCodesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.postalCodesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.postcodeIDTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            postcodeIDLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postalIndexingGuide_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postalCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postalCodesBindingNavigator)).BeginInit();
            this.postalCodesBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // postcodeIDLabel
            // 
            postcodeIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            postcodeIDLabel.AutoSize = true;
            postcodeIDLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postcodeIDLabel.Location = new System.Drawing.Point(76, 36);
            postcodeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            postcodeIDLabel.Name = "postcodeIDLabel";
            postcodeIDLabel.Size = new System.Drawing.Size(281, 53);
            postcodeIDLabel.TabIndex = 1;
            postcodeIDLabel.Text = "Postcode ID:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            postcodeLabel.AutoSize = true;
            postcodeLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postcodeLabel.Location = new System.Drawing.Point(141, 105);
            postcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(217, 53);
            postcodeLabel.TabIndex = 3;
            postcodeLabel.Text = "Postcode:";
            // 
            // postalIndexingGuide_DataSet
            // 
            this.postalIndexingGuide_DataSet.DataSetName = "PostalIndexingGuide_DataSet";
            this.postalIndexingGuide_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postalCodesBindingSource
            // 
            this.postalCodesBindingSource.DataMember = "PostalCodes";
            this.postalCodesBindingSource.DataSource = this.postalIndexingGuide_DataSet;
            // 
            // postalCodesTableAdapter
            // 
            this.postalCodesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DistrictsTableAdapter = null;
            this.tableAdapterManager.PostalCodesTableAdapter = this.postalCodesTableAdapter;
            this.tableAdapterManager.RegionsTableAdapter = null;
            this.tableAdapterManager.RepublicsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Postal_Indexing_Guide.PostalIndexingGuideDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VillagesTableAdapter = null;
            // 
            // postalCodesBindingNavigator
            // 
            this.postalCodesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postalCodesBindingNavigator.BindingSource = this.postalCodesBindingSource;
            this.postalCodesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postalCodesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postalCodesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.postalCodesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.postalCodesBindingNavigatorSaveItem});
            this.postalCodesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postalCodesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postalCodesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postalCodesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postalCodesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postalCodesBindingNavigator.Name = "postalCodesBindingNavigator";
            this.postalCodesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postalCodesBindingNavigator.Size = new System.Drawing.Size(1067, 42);
            this.postalCodesBindingNavigator.TabIndex = 0;
            this.postalCodesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 39);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(110, 39);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 39);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 39);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 39);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 42);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 39);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 39);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // postalCodesBindingNavigatorSaveItem
            // 
            this.postalCodesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postalCodesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postalCodesBindingNavigatorSaveItem.Image")));
            this.postalCodesBindingNavigatorSaveItem.Name = "postalCodesBindingNavigatorSaveItem";
            this.postalCodesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 39);
            this.postalCodesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postalCodesBindingNavigatorSaveItem.Click += new System.EventHandler(this.postalCodesBindingNavigatorSaveItem_Click);
            // 
            // postcodeIDTextBox
            // 
            this.postcodeIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postcodeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postcodeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postalCodesBindingSource, "PostcodeID", true));
            this.postcodeIDTextBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postcodeIDTextBox.Location = new System.Drawing.Point(373, 26);
            this.postcodeIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postcodeIDTextBox.Name = "postcodeIDTextBox";
            this.postcodeIDTextBox.Size = new System.Drawing.Size(413, 61);
            this.postcodeIDTextBox.TabIndex = 2;
            this.postcodeIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postalCodesBindingSource, "Postcode", true));
            this.postcodeTextBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postcodeTextBox.Location = new System.Drawing.Point(373, 95);
            this.postcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(413, 61);
            this.postcodeTextBox.TabIndex = 4;
            this.postcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.Color.DarkGreen;
            this.Back.Location = new System.Drawing.Point(85, 188);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(319, 49);
            this.Back.TabIndex = 20;
            this.Back.Text = "Back to the menu";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit.ForeColor = System.Drawing.Color.Red;
            this.Quit.Location = new System.Drawing.Point(468, 188);
            this.Quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(319, 49);
            this.Quit.TabIndex = 21;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(postcodeIDLabel);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.postcodeTextBox);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(postcodeLabel);
            this.panel1.Controls.Add(this.postcodeIDTextBox);
            this.panel1.Location = new System.Drawing.Point(119, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 292);
            this.panel1.TabIndex = 22;
            // 
            // Postcodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.postalCodesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Postcodes";
            this.Text = "Postcodes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Postcodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postalIndexingGuide_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postalCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postalCodesBindingNavigator)).EndInit();
            this.postalCodesBindingNavigator.ResumeLayout(false);
            this.postalCodesBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PostalIndexingGuideDS postalIndexingGuide_DataSet;
        private System.Windows.Forms.BindingSource postalCodesBindingSource;
        private PostalIndexingGuideDSTableAdapters.PostalCodesTableAdapter postalCodesTableAdapter;
        private PostalIndexingGuideDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postalCodesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton postalCodesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox postcodeIDTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Panel panel1;
    }
}