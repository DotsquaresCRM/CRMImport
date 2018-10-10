namespace DSTools.SqlToCRMImport
{
    partial class CRMImport
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRMImport));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLoadSql = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbEntity = new System.Windows.Forms.ComboBox();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.lstTablesColumn = new System.Windows.Forms.ListBox();
            this.lstEntityColumn = new System.Windows.Forms.ListBox();
            this.lstSortedTablesColumn = new System.Windows.Forms.ListBox();
            this.lstSortedEntityColumn = new System.Windows.Forms.ListBox();
            this.btnMoveRTable = new System.Windows.Forms.Button();
            this.btnMoveLTable = new System.Windows.Forms.Button();
            this.btnMoveLEntity = new System.Windows.Forms.Button();
            this.btnMoveREntity = new System.Windows.Forms.Button();
            this.btnUpTable = new System.Windows.Forms.Button();
            this.btnDownTable = new System.Windows.Forms.Button();
            this.btnDownEntity = new System.Windows.Forms.Button();
            this.btnUpEntity = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.toolStripSeparator2,
            this.btnLoadSql,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.tsbCancel,
            this.toolStripSeparator3});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1179, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Visible = false;
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLoadSql
            // 
            this.btnLoadSql.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadSql.Image")));
            this.btnLoadSql.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadSql.Name = "btnLoadSql";
            this.btnLoadSql.Size = new System.Drawing.Size(108, 22);
            this.btnLoadSql.Text = "Load Sql Tables";
            this.btnLoadSql.ToolTipText = "Perfomrs a Who I Am request";
            this.btnLoadSql.Click += new System.EventHandler(this.btnLoadSql_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(94, 22);
            this.toolStripButton2.Text = "Load Entities";
            this.toolStripButton2.ToolTipText = "Perfomrs a Who I Am request";
            this.toolStripButton2.Click += new System.EventHandler(this.tsbWhoAmI_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(63, 22);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.ToolTipText = "Cancel the current request";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbEntity
            // 
            this.cmbEntity.FormattingEnabled = true;
            this.cmbEntity.Location = new System.Drawing.Point(767, 59);
            this.cmbEntity.Name = "cmbEntity";
            this.cmbEntity.Size = new System.Drawing.Size(243, 21);
            this.cmbEntity.TabIndex = 5;
            this.cmbEntity.SelectedIndexChanged += new System.EventHandler(this.cmbEntity_SelectedIndexChanged);
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(154, 59);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(243, 21);
            this.cmbTables.TabIndex = 6;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // lstTablesColumn
            // 
            this.lstTablesColumn.FormattingEnabled = true;
            this.lstTablesColumn.Location = new System.Drawing.Point(17, 165);
            this.lstTablesColumn.Name = "lstTablesColumn";
            this.lstTablesColumn.Size = new System.Drawing.Size(180, 251);
            this.lstTablesColumn.TabIndex = 7;
            // 
            // lstEntityColumn
            // 
            this.lstEntityColumn.FormattingEnabled = true;
            this.lstEntityColumn.Location = new System.Drawing.Point(939, 165);
            this.lstEntityColumn.Name = "lstEntityColumn";
            this.lstEntityColumn.Size = new System.Drawing.Size(222, 251);
            this.lstEntityColumn.TabIndex = 8;
            // 
            // lstSortedTablesColumn
            // 
            this.lstSortedTablesColumn.FormattingEnabled = true;
            this.lstSortedTablesColumn.Location = new System.Drawing.Point(285, 165);
            this.lstSortedTablesColumn.Name = "lstSortedTablesColumn";
            this.lstSortedTablesColumn.Size = new System.Drawing.Size(238, 251);
            this.lstSortedTablesColumn.TabIndex = 9;
            // 
            // lstSortedEntityColumn
            // 
            this.lstSortedEntityColumn.FormattingEnabled = true;
            this.lstSortedEntityColumn.Location = new System.Drawing.Point(592, 165);
            this.lstSortedEntityColumn.Name = "lstSortedEntityColumn";
            this.lstSortedEntityColumn.Size = new System.Drawing.Size(240, 251);
            this.lstSortedEntityColumn.TabIndex = 10;
            // 
            // btnMoveRTable
            // 
            this.btnMoveRTable.Location = new System.Drawing.Point(204, 234);
            this.btnMoveRTable.Name = "btnMoveRTable";
            this.btnMoveRTable.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRTable.TabIndex = 11;
            this.btnMoveRTable.Text = "->";
            this.btnMoveRTable.UseVisualStyleBackColor = true;
            this.btnMoveRTable.Click += new System.EventHandler(this.btnMoveRTable_Click);
            // 
            // btnMoveLTable
            // 
            this.btnMoveLTable.Location = new System.Drawing.Point(204, 302);
            this.btnMoveLTable.Name = "btnMoveLTable";
            this.btnMoveLTable.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLTable.TabIndex = 12;
            this.btnMoveLTable.Text = "<-";
            this.btnMoveLTable.UseVisualStyleBackColor = true;
            this.btnMoveLTable.Click += new System.EventHandler(this.btnMoveLTable_Click);
            // 
            // btnMoveLEntity
            // 
            this.btnMoveLEntity.Location = new System.Drawing.Point(849, 234);
            this.btnMoveLEntity.Name = "btnMoveLEntity";
            this.btnMoveLEntity.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLEntity.TabIndex = 14;
            this.btnMoveLEntity.Text = "<-";
            this.btnMoveLEntity.UseVisualStyleBackColor = true;
            this.btnMoveLEntity.Click += new System.EventHandler(this.btnMoveLEntity_Click);
            // 
            // btnMoveREntity
            // 
            this.btnMoveREntity.Location = new System.Drawing.Point(849, 302);
            this.btnMoveREntity.Name = "btnMoveREntity";
            this.btnMoveREntity.Size = new System.Drawing.Size(75, 23);
            this.btnMoveREntity.TabIndex = 13;
            this.btnMoveREntity.Text = "->";
            this.btnMoveREntity.UseVisualStyleBackColor = true;
            this.btnMoveREntity.Click += new System.EventHandler(this.btnMoveREntity_Click);
            // 
            // btnUpTable
            // 
            this.btnUpTable.Image = ((System.Drawing.Image)(resources.GetObject("btnUpTable.Image")));
            this.btnUpTable.Location = new System.Drawing.Point(360, 116);
            this.btnUpTable.Name = "btnUpTable";
            this.btnUpTable.Size = new System.Drawing.Size(37, 43);
            this.btnUpTable.TabIndex = 15;
            this.btnUpTable.UseVisualStyleBackColor = true;
            this.btnUpTable.Click += new System.EventHandler(this.btnUpTable_Click);
            // 
            // btnDownTable
            // 
            this.btnDownTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDownTable.Image")));
            this.btnDownTable.Location = new System.Drawing.Point(403, 116);
            this.btnDownTable.Name = "btnDownTable";
            this.btnDownTable.Size = new System.Drawing.Size(37, 43);
            this.btnDownTable.TabIndex = 16;
            this.btnDownTable.UseVisualStyleBackColor = true;
            this.btnDownTable.Click += new System.EventHandler(this.btnDownTable_Click);
            // 
            // btnDownEntity
            // 
            this.btnDownEntity.Image = ((System.Drawing.Image)(resources.GetObject("btnDownEntity.Image")));
            this.btnDownEntity.Location = new System.Drawing.Point(707, 116);
            this.btnDownEntity.Name = "btnDownEntity";
            this.btnDownEntity.Size = new System.Drawing.Size(37, 43);
            this.btnDownEntity.TabIndex = 18;
            this.btnDownEntity.UseVisualStyleBackColor = true;
            this.btnDownEntity.Click += new System.EventHandler(this.btnDownEntity_Click);
            // 
            // btnUpEntity
            // 
            this.btnUpEntity.Image = ((System.Drawing.Image)(resources.GetObject("btnUpEntity.Image")));
            this.btnUpEntity.Location = new System.Drawing.Point(664, 116);
            this.btnUpEntity.Name = "btnUpEntity";
            this.btnUpEntity.Size = new System.Drawing.Size(37, 43);
            this.btnUpEntity.TabIndex = 17;
            this.btnUpEntity.UseVisualStyleBackColor = true;
            this.btnUpEntity.Click += new System.EventHandler(this.btnUpEntity_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(487, 422);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(154, 36);
            this.btnImport.TabIndex = 19;
            this.btnImport.Text = "Start Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tables Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Entities";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(860, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Entity Fields";
            // 
            // CRMImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDownEntity);
            this.Controls.Add(this.btnUpEntity);
            this.Controls.Add(this.btnDownTable);
            this.Controls.Add(this.btnUpTable);
            this.Controls.Add(this.btnMoveLEntity);
            this.Controls.Add(this.btnMoveREntity);
            this.Controls.Add(this.btnMoveLTable);
            this.Controls.Add(this.btnMoveRTable);
            this.Controls.Add(this.lstSortedEntityColumn);
            this.Controls.Add(this.lstSortedTablesColumn);
            this.Controls.Add(this.lstEntityColumn);
            this.Controls.Add(this.lstTablesColumn);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.cmbEntity);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "CRMImport";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1179, 505);
            this.Load += new System.EventHandler(this.SampleTool_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnLoadSql;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox cmbEntity;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.ListBox lstTablesColumn;
        private System.Windows.Forms.ListBox lstEntityColumn;
        private System.Windows.Forms.ListBox lstSortedTablesColumn;
        private System.Windows.Forms.ListBox lstSortedEntityColumn;
        private System.Windows.Forms.Button btnMoveRTable;
        private System.Windows.Forms.Button btnMoveLTable;
        private System.Windows.Forms.Button btnMoveLEntity;
        private System.Windows.Forms.Button btnMoveREntity;
        private System.Windows.Forms.Button btnUpTable;
        private System.Windows.Forms.Button btnDownTable;
        private System.Windows.Forms.Button btnDownEntity;
        private System.Windows.Forms.Button btnUpEntity;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
