namespace BlockBusted
{
    partial class Lenguajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lenguajes));
            System.Windows.Forms.Label cODIGO_LENGUAJELabel;
            System.Windows.Forms.Label nOMBRE_LENGUAJELabel;
            this.lenguajeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lenguajeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lenguajeDataGridView = new System.Windows.Forms.DataGridView();
            this.cODIGO_LENGUAJETextBox = new System.Windows.Forms.TextBox();
            this.nOMBRE_LENGUAJETextBox = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.lenguajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODIGOLENGUAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRELENGUAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODIGO_LENGUAJELabel = new System.Windows.Forms.Label();
            nOMBRE_LENGUAJELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajeBindingNavigator)).BeginInit();
            this.lenguajeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lenguajeBindingNavigator
            // 
            this.lenguajeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lenguajeBindingNavigator.BindingSource = this.lenguajeBindingSource;
            this.lenguajeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lenguajeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lenguajeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lenguajeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lenguajeBindingNavigatorSaveItem});
            this.lenguajeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lenguajeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lenguajeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lenguajeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lenguajeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lenguajeBindingNavigator.Name = "lenguajeBindingNavigator";
            this.lenguajeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lenguajeBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.lenguajeBindingNavigator.TabIndex = 0;
            this.lenguajeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // lenguajeBindingNavigatorSaveItem
            // 
            this.lenguajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lenguajeBindingNavigatorSaveItem.Enabled = false;
            this.lenguajeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lenguajeBindingNavigatorSaveItem.Image")));
            this.lenguajeBindingNavigatorSaveItem.Name = "lenguajeBindingNavigatorSaveItem";
            this.lenguajeBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.lenguajeBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // lenguajeDataGridView
            // 
            this.lenguajeDataGridView.AutoGenerateColumns = false;
            this.lenguajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lenguajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGOLENGUAJEDataGridViewTextBoxColumn,
            this.nOMBRELENGUAJEDataGridViewTextBoxColumn});
            this.lenguajeDataGridView.DataSource = this.lenguajeBindingSource;
            this.lenguajeDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lenguajeDataGridView.Location = new System.Drawing.Point(0, 27);
            this.lenguajeDataGridView.Name = "lenguajeDataGridView";
            this.lenguajeDataGridView.RowTemplate.Height = 24;
            this.lenguajeDataGridView.Size = new System.Drawing.Size(800, 220);
            this.lenguajeDataGridView.TabIndex = 1;
            // 
            // cODIGO_LENGUAJELabel
            // 
            cODIGO_LENGUAJELabel.AutoSize = true;
            cODIGO_LENGUAJELabel.Location = new System.Drawing.Point(12, 287);
            cODIGO_LENGUAJELabel.Name = "cODIGO_LENGUAJELabel";
            cODIGO_LENGUAJELabel.Size = new System.Drawing.Size(144, 17);
            cODIGO_LENGUAJELabel.TabIndex = 2;
            cODIGO_LENGUAJELabel.Text = "CODIGO LENGUAJE:";
            // 
            // cODIGO_LENGUAJETextBox
            // 
            this.cODIGO_LENGUAJETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lenguajeBindingSource, "CODIGO_LENGUAJE", true));
            this.cODIGO_LENGUAJETextBox.Enabled = false;
            this.cODIGO_LENGUAJETextBox.Location = new System.Drawing.Point(162, 284);
            this.cODIGO_LENGUAJETextBox.Name = "cODIGO_LENGUAJETextBox";
            this.cODIGO_LENGUAJETextBox.Size = new System.Drawing.Size(298, 22);
            this.cODIGO_LENGUAJETextBox.TabIndex = 3;
            // 
            // nOMBRE_LENGUAJELabel
            // 
            nOMBRE_LENGUAJELabel.AutoSize = true;
            nOMBRE_LENGUAJELabel.Location = new System.Drawing.Point(7, 320);
            nOMBRE_LENGUAJELabel.Name = "nOMBRE_LENGUAJELabel";
            nOMBRE_LENGUAJELabel.Size = new System.Drawing.Size(149, 17);
            nOMBRE_LENGUAJELabel.TabIndex = 4;
            nOMBRE_LENGUAJELabel.Text = "NOMBRE LENGUAJE:";
            // 
            // nOMBRE_LENGUAJETextBox
            // 
            this.nOMBRE_LENGUAJETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lenguajeBindingSource, "NOMBRE_LENGUAJE", true));
            this.nOMBRE_LENGUAJETextBox.Location = new System.Drawing.Point(162, 317);
            this.nOMBRE_LENGUAJETextBox.Name = "nOMBRE_LENGUAJETextBox";
            this.nOMBRE_LENGUAJETextBox.Size = new System.Drawing.Size(298, 22);
            this.nOMBRE_LENGUAJETextBox.TabIndex = 5;
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(508, 284);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(225, 38);
            this.limpiar.TabIndex = 22;
            this.limpiar.Text = "Limpiar y agregar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click_1);
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(508, 329);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(225, 38);
            this.guardar.TabIndex = 21;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // lenguajeBindingSource
            // 
            this.lenguajeBindingSource.DataSource = typeof(BlockBusted.Models.lenguaje);
            // 
            // cODIGOLENGUAJEDataGridViewTextBoxColumn
            // 
            this.cODIGOLENGUAJEDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_LENGUAJE";
            this.cODIGOLENGUAJEDataGridViewTextBoxColumn.HeaderText = "CODIGO_LENGUAJE";
            this.cODIGOLENGUAJEDataGridViewTextBoxColumn.Name = "cODIGOLENGUAJEDataGridViewTextBoxColumn";
            // 
            // nOMBRELENGUAJEDataGridViewTextBoxColumn
            // 
            this.nOMBRELENGUAJEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_LENGUAJE";
            this.nOMBRELENGUAJEDataGridViewTextBoxColumn.HeaderText = "NOMBRE_LENGUAJE";
            this.nOMBRELENGUAJEDataGridViewTextBoxColumn.Name = "nOMBRELENGUAJEDataGridViewTextBoxColumn";
            // 
            // Lenguajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(nOMBRE_LENGUAJELabel);
            this.Controls.Add(this.nOMBRE_LENGUAJETextBox);
            this.Controls.Add(cODIGO_LENGUAJELabel);
            this.Controls.Add(this.cODIGO_LENGUAJETextBox);
            this.Controls.Add(this.lenguajeDataGridView);
            this.Controls.Add(this.lenguajeBindingNavigator);
            this.Name = "Lenguajes";
            this.Text = "Lenguajes";
            this.Load += new System.EventHandler(this.Lenguajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lenguajeBindingNavigator)).EndInit();
            this.lenguajeBindingNavigator.ResumeLayout(false);
            this.lenguajeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenguajeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lenguajeBindingSource;
        private System.Windows.Forms.BindingNavigator lenguajeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lenguajeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lenguajeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOLENGUAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRELENGUAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cODIGO_LENGUAJETextBox;
        private System.Windows.Forms.TextBox nOMBRE_LENGUAJETextBox;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button guardar;
    }
}