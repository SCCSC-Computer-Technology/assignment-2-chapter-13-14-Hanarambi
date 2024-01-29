
namespace John_Russo_linq_database_209
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.productDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchProNo = new System.Windows.Forms.Button();
            this.searchProductDesc = new System.Windows.Forms.Button();
            this.textBoxProductNo = new System.Windows.Forms.TextBox();
            this.textBoxProductDesc = new System.Windows.Forms.TextBox();
            this.searchMoreUnitsButton = new System.Windows.Forms.Button();
            this.searchLessUnitsButton = new System.Windows.Forms.Button();
            this.textBoxLessUnits = new System.Windows.Forms.TextBox();
            this.textBoxMoreUnits = new System.Windows.Forms.TextBox();
            this.newFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingNavigator)).BeginInit();
            this.productDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productDataBindingNavigator
            // 
            this.productDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productDataBindingNavigator.BindingSource = this.productDataBindingSource;
            this.productDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productDataBindingNavigatorSaveItem});
            this.productDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productDataBindingNavigator.Name = "productDataBindingNavigator";
            this.productDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productDataBindingNavigator.Size = new System.Drawing.Size(999, 25);
            this.productDataBindingNavigator.TabIndex = 0;
            this.productDataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // productDataBindingSource
            // 
            this.productDataBindingSource.DataSource = typeof(John_Russo_linq_database_209.productData);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productDataBindingNavigatorSaveItem
            // 
            this.productDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productDataBindingNavigatorSaveItem.Enabled = false;
            this.productDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productDataBindingNavigatorSaveItem.Image")));
            this.productDataBindingNavigatorSaveItem.Name = "productDataBindingNavigatorSaveItem";
            this.productDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productDataBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(45, 70);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(476, 220);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(John_Russo_linq_database_209.Product);
            // 
            // searchProNo
            // 
            this.searchProNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchProNo.BackgroundImage")));
            this.searchProNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchProNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProNo.ForeColor = System.Drawing.SystemColors.Control;
            this.searchProNo.Location = new System.Drawing.Point(45, 296);
            this.searchProNo.Name = "searchProNo";
            this.searchProNo.Size = new System.Drawing.Size(98, 73);
            this.searchProNo.TabIndex = 2;
            this.searchProNo.Text = "Search &Product No";
            this.searchProNo.UseVisualStyleBackColor = true;
            this.searchProNo.Click += new System.EventHandler(this.searchProNo_Click);
            // 
            // searchProductDesc
            // 
            this.searchProductDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchProductDesc.BackgroundImage")));
            this.searchProductDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchProductDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchProductDesc.Location = new System.Drawing.Point(149, 296);
            this.searchProductDesc.Name = "searchProductDesc";
            this.searchProductDesc.Size = new System.Drawing.Size(102, 73);
            this.searchProductDesc.TabIndex = 3;
            this.searchProductDesc.Text = "Search Product &Description";
            this.searchProductDesc.UseVisualStyleBackColor = true;
            // 
            // textBoxProductNo
            // 
            this.textBoxProductNo.Location = new System.Drawing.Point(45, 375);
            this.textBoxProductNo.Name = "textBoxProductNo";
            this.textBoxProductNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductNo.TabIndex = 4;
            // 
            // textBoxProductDesc
            // 
            this.textBoxProductDesc.Location = new System.Drawing.Point(149, 375);
            this.textBoxProductDesc.Name = "textBoxProductDesc";
            this.textBoxProductDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductDesc.TabIndex = 5;
            // 
            // searchMoreUnitsButton
            // 
            this.searchMoreUnitsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchMoreUnitsButton.BackgroundImage")));
            this.searchMoreUnitsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchMoreUnitsButton.ForeColor = System.Drawing.Color.Maroon;
            this.searchMoreUnitsButton.Location = new System.Drawing.Point(257, 296);
            this.searchMoreUnitsButton.Name = "searchMoreUnitsButton";
            this.searchMoreUnitsButton.Size = new System.Drawing.Size(129, 73);
            this.searchMoreUnitsButton.TabIndex = 6;
            this.searchMoreUnitsButton.Text = "Search units &greater than";
            this.searchMoreUnitsButton.UseVisualStyleBackColor = true;
            // 
            // searchLessUnitsButton
            // 
            this.searchLessUnitsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchLessUnitsButton.BackgroundImage")));
            this.searchLessUnitsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchLessUnitsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchLessUnitsButton.Location = new System.Drawing.Point(392, 296);
            this.searchLessUnitsButton.Name = "searchLessUnitsButton";
            this.searchLessUnitsButton.Size = new System.Drawing.Size(129, 73);
            this.searchLessUnitsButton.TabIndex = 7;
            this.searchLessUnitsButton.Text = "Search units &Less than";
            this.searchLessUnitsButton.UseVisualStyleBackColor = true;
            // 
            // textBoxLessUnits
            // 
            this.textBoxLessUnits.Location = new System.Drawing.Point(392, 375);
            this.textBoxLessUnits.Name = "textBoxLessUnits";
            this.textBoxLessUnits.Size = new System.Drawing.Size(129, 20);
            this.textBoxLessUnits.TabIndex = 8;
            // 
            // textBoxMoreUnits
            // 
            this.textBoxMoreUnits.Location = new System.Drawing.Point(257, 375);
            this.textBoxMoreUnits.Name = "textBoxMoreUnits";
            this.textBoxMoreUnits.Size = new System.Drawing.Size(129, 20);
            this.textBoxMoreUnits.TabIndex = 9;
            // 
            // newFormButton
            // 
            this.newFormButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newFormButton.BackgroundImage")));
            this.newFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newFormButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newFormButton.Location = new System.Drawing.Point(578, 70);
            this.newFormButton.Name = "newFormButton";
            this.newFormButton.Size = new System.Drawing.Size(287, 220);
            this.newFormButton.TabIndex = 10;
            this.newFormButton.Text = "14.6 Price button";
            this.newFormButton.UseVisualStyleBackColor = true;
            this.newFormButton.Click += new System.EventHandler(this.newFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 508);
            this.Controls.Add(this.newFormButton);
            this.Controls.Add(this.textBoxMoreUnits);
            this.Controls.Add(this.textBoxLessUnits);
            this.Controls.Add(this.searchLessUnitsButton);
            this.Controls.Add(this.searchMoreUnitsButton);
            this.Controls.Add(this.textBoxProductDesc);
            this.Controls.Add(this.textBoxProductNo);
            this.Controls.Add(this.searchProductDesc);
            this.Controls.Add(this.searchProNo);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productDataBindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "John Russo,  linq Matrix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingNavigator)).EndInit();
            this.productDataBindingNavigator.ResumeLayout(false);
            this.productDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productDataBindingSource;
        private System.Windows.Forms.BindingNavigator productDataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productDataBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button searchProNo;
        private System.Windows.Forms.Button searchProductDesc;
        private System.Windows.Forms.TextBox textBoxProductNo;
        private System.Windows.Forms.TextBox textBoxProductDesc;
        private System.Windows.Forms.Button searchMoreUnitsButton;
        private System.Windows.Forms.Button searchLessUnitsButton;
        private System.Windows.Forms.TextBox textBoxLessUnits;
        private System.Windows.Forms.TextBox textBoxMoreUnits;
        private System.Windows.Forms.Button newFormButton;
    }
}

