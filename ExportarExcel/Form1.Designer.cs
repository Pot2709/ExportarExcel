namespace ExportarExcel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexportarr = new FontAwesome.Sharp.IconButton();
            this.btnimportar = new FontAwesome.Sharp.IconButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTranajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexportarr);
            this.groupBox1.Controls.Add(this.btnimportar);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnexportarr
            // 
            this.btnexportarr.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnexportarr.IconColor = System.Drawing.Color.Black;
            this.btnexportarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexportarr.IconSize = 30;
            this.btnexportarr.Location = new System.Drawing.Point(319, 15);
            this.btnexportarr.Name = "btnexportarr";
            this.btnexportarr.Size = new System.Drawing.Size(105, 58);
            this.btnexportarr.TabIndex = 3;
            this.btnexportarr.Text = "Exportar";
            this.btnexportarr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnexportarr.UseVisualStyleBackColor = true;
            this.btnexportarr.Click += new System.EventHandler(this.btnexportarr_Click);
            // 
            // btnimportar
            // 
            this.btnimportar.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnimportar.IconColor = System.Drawing.Color.Black;
            this.btnimportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnimportar.IconSize = 30;
            this.btnimportar.Location = new System.Drawing.Point(122, 15);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(109, 58);
            this.btnimportar.TabIndex = 1;
            this.btnimportar.Text = "Importa";
            this.btnimportar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnimportar.UseVisualStyleBackColor = true;
            this.btnimportar.Click += new System.EventHandler(this.btnimportarr_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 79);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(600, 279);
            this.dgv.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(734, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impresionToolStripMenuItem,
            this.registroDeTranajadoresToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // impresionToolStripMenuItem
            // 
            this.impresionToolStripMenuItem.Name = "impresionToolStripMenuItem";
            this.impresionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.impresionToolStripMenuItem.Text = "Impresion";
            // 
            // registroDeTranajadoresToolStripMenuItem
            // 
            this.registroDeTranajadoresToolStripMenuItem.Name = "registroDeTranajadoresToolStripMenuItem";
            this.registroDeTranajadoresToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registroDeTranajadoresToolStripMenuItem.Text = "Registro de Tranajadores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(734, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private FontAwesome.Sharp.IconButton btnimportar;
        private FontAwesome.Sharp.IconButton btnexportarr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTranajadoresToolStripMenuItem;
    }
}

