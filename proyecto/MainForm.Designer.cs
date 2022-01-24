/*
 * Creado por SharpDevelop.
 * Usuario: Limber
 * Fecha: 18/12/2020
 * Hora: 14:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label leerDatos;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dATOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label resultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dato1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dato2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dato3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dato4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.leerDatos = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.resultado = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dato4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.dATOSToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dATOSToolStripMenuItem
			// 
			this.dATOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.limpiarToolStripMenuItem});
			this.dATOSToolStripMenuItem.Name = "dATOSToolStripMenuItem";
			this.dATOSToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.dATOSToolStripMenuItem.Text = "DATOS";
			// 
			// limpiarToolStripMenuItem
			// 
			this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
			this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
			this.limpiarToolStripMenuItem.Text = "limpiar";
			// 
			// leerDatos
			// 
			this.leerDatos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.leerDatos.Location = new System.Drawing.Point(14, 101);
			this.leerDatos.Name = "leerDatos";
			this.leerDatos.Size = new System.Drawing.Size(449, 109);
			this.leerDatos.TabIndex = 5;
			this.leerDatos.Text = "leerDatos";
			this.leerDatos.Click += new System.EventHandler(this.Label1Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(512, 50);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 100);
			this.button1.TabIndex = 8;
			this.button1.Text = "LEER";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button2.Location = new System.Drawing.Point(512, 484);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(159, 100);
			this.button2.TabIndex = 7;
			this.button2.Text = "MOSTRAR";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button3.Location = new System.Drawing.Point(512, 271);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(159, 100);
			this.button3.TabIndex = 9;
			this.button3.Text = "LIMPIAR";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// resultado
			// 
			this.resultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.resultado.Location = new System.Drawing.Point(724, 101);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(433, 472);
			this.resultado.TabIndex = 10;
			this.resultado.Text = "mostrarDatos";
			this.resultado.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(14, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(433, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "LEYENDO DATOS";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(738, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(433, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "MOSTRANDO DATOS";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dato1,
			this.dato2,
			this.dato3,
			this.dato4});
			this.dataGridView1.Location = new System.Drawing.Point(13, 253);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(450, 331);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// dato1
			// 
			this.dato1.HeaderText = "Dato 1";
			this.dato1.Name = "dato1";
			// 
			// dato2
			// 
			this.dato2.HeaderText = "Dato 2";
			this.dato2.Name = "dato2";
			// 
			// dato3
			// 
			this.dato3.HeaderText = "Dato 3";
			this.dato3.Name = "dato3";
			// 
			// dato4
			// 
			this.dato4.HeaderText = "Dato 4";
			this.dato4.Name = "dato4";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(1215, 607);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.leerDatos);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "proyecto";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
