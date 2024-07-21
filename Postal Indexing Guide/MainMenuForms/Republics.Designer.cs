namespace Postal_Indexing_Guide.MainMenuForms
{
    partial class Republics
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
            System.Windows.Forms.Label republicIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Republics));
            this.postalIndexingGuide_DataSet = new Postal_Indexing_Guide.PostalIndexingGuideDS();
            this.republicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.republicsTableAdapter = new Postal_Indexing_Guide.PostalIndexingGuideDSTableAdapters.RepublicsTableAdapter();
            this.tableAdapterManager = new Postal_Indexing_Guide.PostalIndexingGuideDSTableAdapters.TableAdapterManager();
            this.republicsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.republicsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.republicIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Quit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            republicIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postalIndexingGuide_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.republicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.republicsBindingNavigator)).BeginInit();
            this.republicsBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // republicIDLabel
            // 
            republicIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            republicIDLabel.AutoSize = true;
            republicIDLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            republicIDLabel.Location = new System.Drawing.Point(21, 42);
            republicIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            republicIDLabel.Name = "republicIDLabel";
            republicIDLabel.Size = new System.Drawing.Size(283, 53);
            republicIDLabel.TabIndex = 1;
            republicIDLabel.Text = "Republic ID:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(155, 107);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(157, 53);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // postalIndexingGuide_DataSet
            // 
            this.postalIndexingGuide_DataSet.DataSetName = "PostalIndexingGuide_DataSet";
            this.postalIndexingGuide_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // republicsBindingSource
            // 
            this.republicsBindingSource.DataMember = "Republics";
            this.republicsBindingSource.DataSource = this.postalIndexingGuide_DataSet;
            // 
            // republicsTableAdapter
            // 
            this.republicsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DistrictsTableAdapter = null;
            this.tableAdapterManager.PostalCodesTableAdapter = null;
            this.tableAdapterManager.RegionsTableAdapter = null;
            this.tableAdapterManager.RepublicsTableAdapter = this.republicsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Postal_Indexing_Guide.PostalIndexingGuideDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VillagesTableAdapter = null;
            // 
            // republicsBindingNavigator
            // 
            this.republicsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.republicsBindingNavigator.BindingSource = this.republicsBindingSource;
            this.republicsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.republicsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.republicsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.republicsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.republicsBindingNavigatorSaveItem});
            this.republicsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.republicsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.republicsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.republicsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.republicsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.republicsBindingNavigator.Name = "republicsBindingNavigator";
            this.republicsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.republicsBindingNavigator.Size = new System.Drawing.Size(1067, 42);
            this.republicsBindingNavigator.TabIndex = 0;
            this.republicsBindingNavigator.Text = "bindingNavigator1";
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
            // republicsBindingNavigatorSaveItem
            // 
            this.republicsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.republicsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("republicsBindingNavigatorSaveItem.Image")));
            this.republicsBindingNavigatorSaveItem.Name = "republicsBindingNavigatorSaveItem";
            this.republicsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 39);
            this.republicsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.republicsBindingNavigatorSaveItem.Click += new System.EventHandler(this.republicsBindingNavigatorSaveItem_Click);
            // 
            // republicIDTextBox
            // 
            this.republicIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.republicIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.republicIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.republicsBindingSource, "RepublicID", true));
            this.republicIDTextBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.republicIDTextBox.Location = new System.Drawing.Point(324, 28);
            this.republicIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.republicIDTextBox.Name = "republicIDTextBox";
            this.republicIDTextBox.Size = new System.Drawing.Size(413, 61);
            this.republicIDTextBox.TabIndex = 2;
            this.republicIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.republicsBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(324, 97);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(413, 61);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(republicIDLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.republicIDTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Location = new System.Drawing.Point(179, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 346);
            this.panel1.TabIndex = 5;
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit.ForeColor = System.Drawing.Color.Red;
            this.Quit.Location = new System.Drawing.Point(417, 197);
            this.Quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(319, 49);
            this.Quit.TabIndex = 19;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.Color.DarkGreen;
            this.Back.Location = new System.Drawing.Point(31, 197);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(319, 49);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back to the menu";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Republics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.republicsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Republics";
            this.Text = "Republics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseApplicationButton_Click);
            this.Load += new System.EventHandler(this.Republics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postalIndexingGuide_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.republicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.republicsBindingNavigator)).EndInit();
            this.republicsBindingNavigator.ResumeLayout(false);
            this.republicsBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PostalIndexingGuideDS postalIndexingGuide_DataSet;
        private System.Windows.Forms.BindingSource republicsBindingSource;
        private PostalIndexingGuideDSTableAdapters.RepublicsTableAdapter republicsTableAdapter;
        private PostalIndexingGuideDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator republicsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton republicsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox republicIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Back;
    }
}