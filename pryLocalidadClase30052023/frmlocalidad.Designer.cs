
namespace pryLocalidadClase30052023
{
    partial class frmlocalidad
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbLocalidad = new System.Windows.Forms.ListBox();
            this.cmdGraficar = new System.Windows.Forms.Button();
            this.chtGraficoLocalidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 498);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtToneladas);
            this.tabPage1.Controls.Add(this.lblToneladas);
            this.tabPage1.Controls.Add(this.lstCultivo);
            this.tabPage1.Controls.Add(this.lstLocalidad);
            this.tabPage1.Controls.Add(this.lblCultivo);
            this.tabPage1.Controls.Add(this.lblLocalidad);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADMINISTRAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chtGraficoLocalidad);
            this.tabPage2.Controls.Add(this.cmdGraficar);
            this.tabPage2.Controls.Add(this.lsbLocalidad);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GRÁFICO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtToneladas
            // 
            this.txtToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToneladas.Location = new System.Drawing.Point(11, 160);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(219, 23);
            this.txtToneladas.TabIndex = 12;
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladas.Location = new System.Drawing.Point(8, 140);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(92, 17);
            this.lblToneladas.TabIndex = 11;
            this.lblToneladas.Text = "TONELADAS";
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(11, 94);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(383, 24);
            this.lstCultivo.TabIndex = 10;
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(11, 34);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(383, 24);
            this.lstLocalidad.TabIndex = 9;
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivo.Location = new System.Drawing.Point(8, 74);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(67, 17);
            this.lblCultivo.TabIndex = 8;
            this.lblCultivo.Text = "CULTIVO";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(8, 14);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(85, 17);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "LOCALIDAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOCALIDAD";
            // 
            // lsbLocalidad
            // 
            this.lsbLocalidad.FormattingEnabled = true;
            this.lsbLocalidad.Location = new System.Drawing.Point(11, 36);
            this.lsbLocalidad.Name = "lsbLocalidad";
            this.lsbLocalidad.Size = new System.Drawing.Size(245, 381);
            this.lsbLocalidad.TabIndex = 9;
            // 
            // cmdGraficar
            // 
            this.cmdGraficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGraficar.Location = new System.Drawing.Point(135, 427);
            this.cmdGraficar.Name = "cmdGraficar";
            this.cmdGraficar.Size = new System.Drawing.Size(121, 30);
            this.cmdGraficar.TabIndex = 14;
            this.cmdGraficar.Text = "GRAFICAR";
            this.cmdGraficar.UseVisualStyleBackColor = true;
            this.cmdGraficar.Click += new System.EventHandler(this.cmdGraficar_Click);
            // 
            // chtGraficoLocalidad
            // 
            this.chtGraficoLocalidad.BorderlineColor = System.Drawing.Color.Black;
            this.chtGraficoLocalidad.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chtGraficoLocalidad.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtGraficoLocalidad.Legends.Add(legend2);
            this.chtGraficoLocalidad.Location = new System.Drawing.Point(293, 36);
            this.chtGraficoLocalidad.Name = "chtGraficoLocalidad";
            this.chtGraficoLocalidad.Size = new System.Drawing.Size(581, 421);
            this.chtGraficoLocalidad.TabIndex = 15;
            this.chtGraficoLocalidad.Text = "chart1";
            // 
            // frmlocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmlocalidad";
            this.Text = "PRODUCCION POR LOCALIDAD Y TIPO DE CULTIVO";
            this.Load += new System.EventHandler(this.frmlocalidad_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoLocalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficoLocalidad;
        private System.Windows.Forms.Button cmdGraficar;
        private System.Windows.Forms.ListBox lsbLocalidad;
        private System.Windows.Forms.Label label1;
    }
}

