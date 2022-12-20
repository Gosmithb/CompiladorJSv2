namespace CompiladorJSv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.dataGridTokens = new System.Windows.Forms.DataGridView();
            this.dataGridErrores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.compiladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridErroresSemantico = new System.Windows.Forms.DataGridView();
            this.dataGridClases = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridParametros = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridMetodos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridErrores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridErroresSemantico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMetodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 63);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(348, 483);
            this.txtBox.TabIndex = 0;
            this.txtBox.Text = "";
            // 
            // dataGridTokens
            // 
            this.dataGridTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTokens.Location = new System.Drawing.Point(383, 63);
            this.dataGridTokens.Name = "dataGridTokens";
            this.dataGridTokens.RowTemplate.Height = 25;
            this.dataGridTokens.Size = new System.Drawing.Size(421, 177);
            this.dataGridTokens.TabIndex = 1;
            // 
            // dataGridErrores
            // 
            this.dataGridErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridErrores.Location = new System.Drawing.Point(383, 277);
            this.dataGridErrores.Name = "dataGridErrores";
            this.dataGridErrores.RowTemplate.Height = 25;
            this.dataGridErrores.Size = new System.Drawing.Size(421, 174);
            this.dataGridErrores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sintactico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Errores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compiladorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compiladorToolStripMenuItem
            // 
            this.compiladorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem});
            this.compiladorToolStripMenuItem.Name = "compiladorToolStripMenuItem";
            this.compiladorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.compiladorToolStripMenuItem.Text = "Compilador";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutarToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(858, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Errores semantico";
            // 
            // dataGridErroresSemantico
            // 
            this.dataGridErroresSemantico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridErroresSemantico.Location = new System.Drawing.Point(858, 63);
            this.dataGridErroresSemantico.Name = "dataGridErroresSemantico";
            this.dataGridErroresSemantico.RowTemplate.Height = 25;
            this.dataGridErroresSemantico.Size = new System.Drawing.Size(421, 177);
            this.dataGridErroresSemantico.TabIndex = 6;
            // 
            // dataGridClases
            // 
            this.dataGridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClases.Location = new System.Drawing.Point(858, 274);
            this.dataGridClases.Name = "dataGridClases";
            this.dataGridClases.RowTemplate.Height = 25;
            this.dataGridClases.Size = new System.Drawing.Size(421, 177);
            this.dataGridClases.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clases";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Atributos";
            // 
            // dataGridParametros
            // 
            this.dataGridParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParametros.Location = new System.Drawing.Point(383, 518);
            this.dataGridParametros.Name = "dataGridParametros";
            this.dataGridParametros.RowTemplate.Height = 25;
            this.dataGridParametros.Size = new System.Drawing.Size(421, 174);
            this.dataGridParametros.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(863, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Metodos";
            // 
            // dataGridMetodos
            // 
            this.dataGridMetodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMetodos.Location = new System.Drawing.Point(863, 518);
            this.dataGridMetodos.Name = "dataGridMetodos";
            this.dataGridMetodos.RowTemplate.Height = 25;
            this.dataGridMetodos.Size = new System.Drawing.Size(421, 177);
            this.dataGridMetodos.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 704);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridMetodos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridParametros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridClases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridErroresSemantico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridErrores);
            this.Controls.Add(this.dataGridTokens);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridErrores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridErroresSemantico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMetodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtBox;
        private DataGridView dataGridTokens;
        private DataGridView dataGridErrores;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem compiladorToolStripMenuItem;
        private ToolStripMenuItem ejecutarToolStripMenuItem;
        private Label label3;
        private DataGridView dataGridErroresSemantico;
        private DataGridView dataGridClases;
        private Label label4;
        private Label label5;
        private DataGridView dataGridParametros;
        private Label label6;
        private DataGridView dataGridMetodos;
    }
}