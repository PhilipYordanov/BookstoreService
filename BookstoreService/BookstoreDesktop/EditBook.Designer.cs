namespace BookstoreDesktop
{
    partial class EditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label yearLabel;
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            bookIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).BeginInit();
            this.bookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookstoreDesktop.BookstoreService.Book);
            // 
            // bookBindingNavigator
            // 
            this.bookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookBindingNavigator.BindingSource = this.bookBindingSource;
            this.bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookBindingNavigatorSaveItem});
            this.bookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookBindingNavigator.Name = "bookBindingNavigator";
            this.bookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookBindingNavigator.Size = new System.Drawing.Size(865, 27);
            this.bookBindingNavigator.TabIndex = 0;
            this.bookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bookBindingNavigatorSaveItem
            // 
            this.bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookBindingNavigatorSaveItem.Enabled = false;
            this.bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookBindingNavigatorSaveItem.Image")));
            this.bookBindingNavigatorSaveItem.Name = "bookBindingNavigatorSaveItem";
            this.bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.bookBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new System.Drawing.Point(51, 60);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(61, 17);
            bookIDLabel.TabIndex = 1;
            bookIDLabel.Text = "Book ID:";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookID", true));
            this.bookIDTextBox.Location = new System.Drawing.Point(143, 57);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(121, 22);
            this.bookIDTextBox.TabIndex = 2;
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(51, 88);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(86, 17);
            categoryIDLabel.TabIndex = 3;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "CategoryID", true));
            this.categoryIDComboBox.DataSource = this.categoryBindingSource;
            this.categoryIDComboBox.DisplayMember = "Name";
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(143, 85);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.categoryIDComboBox.TabIndex = 4;
            this.categoryIDComboBox.ValueMember = "CategoryID";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(51, 119);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(143, 116);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 22);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(51, 147);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(43, 17);
            iSBNLabel.TabIndex = 7;
            iSBNLabel.Text = "ISBN:";
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(143, 144);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(121, 22);
            this.iSBNTextBox.TabIndex = 8;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(51, 175);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 17);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(143, 172);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(51, 203);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(143, 200);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 22);
            this.titleTextBox.TabIndex = 12;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(51, 231);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(42, 17);
            yearLabel.TabIndex = 13;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(143, 228);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(121, 22);
            this.yearTextBox.TabIndex = 14;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(419, 71);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(333, 221);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 19;
            this.coverPictureBox.TabStop = false;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(BookstoreDesktop.BookstoreService.Category);
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 628);
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(bookIDLabel);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.bookBindingNavigator);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.Load += new System.EventHandler(this.EditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).EndInit();
            this.bookBindingNavigator.ResumeLayout(false);
            this.bookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingNavigator bookBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}