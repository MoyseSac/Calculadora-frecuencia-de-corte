namespace CalculadoraElectricidad
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.txtCapacitancia = new System.Windows.Forms.TextBox();
            this.txtInductancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.Label();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chartDiagramaFasorial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxInduct = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagramaFasorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(364, 177);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResistencia
            // 
            this.txtResistencia.Location = new System.Drawing.Point(187, 96);
            this.txtResistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.Size = new System.Drawing.Size(132, 22);
            this.txtResistencia.TabIndex = 1;
            // 
            // txtCapacitancia
            // 
            this.txtCapacitancia.Location = new System.Drawing.Point(187, 190);
            this.txtCapacitancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacitancia.Name = "txtCapacitancia";
            this.txtCapacitancia.Size = new System.Drawing.Size(132, 22);
            this.txtCapacitancia.TabIndex = 2;
            // 
            // txtInductancia
            // 
            this.txtInductancia.Location = new System.Drawing.Point(187, 283);
            this.txtInductancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtInductancia.Name = "txtInductancia";
            this.txtInductancia.Size = new System.Drawing.Size(132, 22);
            this.txtInductancia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resistencia Ohms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capacitancia faradios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inductancia henrios";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(364, 273);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Frecuencia de Corte";
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(184, 343);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(46, 17);
            this.txtResultado.TabIndex = 9;
            this.txtResultado.Text = "label5";
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(568, 436);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(597, 260);
            this.listBoxResultado.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chartDiagramaFasorial
            // 
            chartArea6.Name = "ChartArea1";
            this.chartDiagramaFasorial.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartDiagramaFasorial.Legends.Add(legend6);
            this.chartDiagramaFasorial.Location = new System.Drawing.Point(568, 28);
            this.chartDiagramaFasorial.Margin = new System.Windows.Forms.Padding(4);
            this.chartDiagramaFasorial.Name = "chartDiagramaFasorial";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartDiagramaFasorial.Series.Add(series6);
            this.chartDiagramaFasorial.Size = new System.Drawing.Size(591, 380);
            this.chartDiagramaFasorial.TabIndex = 11;
            this.chartDiagramaFasorial.Text = "chart1";
            // 
            // listBoxInduct
            // 
            this.listBoxInduct.FormattingEnabled = true;
            this.listBoxInduct.ItemHeight = 16;
            this.listBoxInduct.Location = new System.Drawing.Point(37, 436);
            this.listBoxInduct.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxInduct.Name = "listBoxInduct";
            this.listBoxInduct.Size = new System.Drawing.Size(504, 260);
            this.listBoxInduct.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CalculadoraElectricidad.Properties.Resources.pregunta;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(376, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 124);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Impedancia total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 381);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraElectricidad.Properties.Resources._d593fa93_f1a6_4fa0_8d6a_e2d56e0b3164;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 766);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxInduct);
            this.Controls.Add(this.chartDiagramaFasorial);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInductancia);
            this.Controls.Add(this.txtCapacitancia);
            this.Controls.Add(this.txtResistencia);
            this.Controls.Add(this.btnCalcular);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculos";
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagramaFasorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResistencia;
        private System.Windows.Forms.TextBox txtCapacitancia;
        private System.Windows.Forms.TextBox txtInductancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagramaFasorial;
        private System.Windows.Forms.ListBox listBoxInduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

