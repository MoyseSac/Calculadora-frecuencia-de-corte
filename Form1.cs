using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CalculadoraElectricidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtResultado.Visible = false;
            chartDiagramaFasorial.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double resistencia = Convert.ToDouble(txtResistencia.Text);
            double inductancia = Convert.ToDouble(txtInductancia.Text);
            double capacitancia = Convert.ToDouble(txtCapacitancia.Text);


            // Calcular la respuesta del filtro
            CalcularRespuestaFiltro(resistencia, inductancia, capacitancia);

            // Calcular e mostrar la impedancia y el diagrama fasorial
            CalcularImpedancia(resistencia, inductancia, capacitancia);

        }

        private void CalcularRespuestaFiltro(double resistencia, double inductancia, double capacitancia)
        {
            // Calcular la frecuencia de corte
            double frecuenciaCorte = 1 / (2 * Math.PI * Math.Sqrt(inductancia * capacitancia));

            // Mostrar la frecuencia de corte
            txtResultado.Text = $"Frecuencia de corte: {frecuenciaCorte} Hz";
            txtResultado.Visible = true;

            // Limpiar elementos anteriores
            listBoxResultado.Items.Clear();
            chartDiagramaFasorial.Series.Clear();

            // Mostrar la respuesta en frecuencia para diferentes frecuencias
            listBoxResultado.Items.Add("Respuesta frecuencias:");

            // Configurar la serie del gráfico para la magnitud
            Series magnitudSerie = new Series("Magnitud");
            magnitudSerie.ChartType = SeriesChartType.Line;
            chartDiagramaFasorial.Series.Add(magnitudSerie);

            // Configurar la serie del gráfico para la fase
            Series faseSerie = new Series("Fase");
            faseSerie.ChartType = SeriesChartType.Line;
            chartDiagramaFasorial.Series.Add(faseSerie);
            chartDiagramaFasorial.Visible = true;

            for (double frecuencia = 0.1; frecuencia <= 15.0; frecuencia += 0.1)
            {
                // Calcular la magnitud y fase
                double magnitud = 1 / Math.Sqrt(1 + Math.Pow(frecuencia / frecuenciaCorte, 2));
                double fase = -Math.Atan(frecuencia / frecuenciaCorte) * (180 / Math.PI);

                if (frecuencia <= 10.0)
                {
                    listBoxResultado.Items.Add($"Frecuencia: {frecuencia:F2z} Hz, Magnitud: {magnitud:F4}, Fase: {fase:F4}°");
                }

                // Agregar puntos al gráfico
                magnitudSerie.Points.AddXY(frecuencia, Math.Round(magnitud, 4));
                faseSerie.Points.AddXY(frecuencia, Math.Round(fase, 4));
            }
        }

        private void CalcularImpedancia(double resistencia, double inductancia, double capacitancia)
        {
            listBoxInduct.Items.Add("Impedancia:");
            double sumatoriaImpedanciaImaginariaSerie = 0.0;
            double sumatoriaImpedanciaImaginariaParalelo = 0.0;

            for (double frecuencia = 0.1; frecuencia <= 10.0; frecuencia += 0.1)
            {
                double omega = 2 * Math.PI * frecuencia;
                double impedanciaReal = resistencia;
                double impedanciaImaginaria = omega * inductancia - 1 / (omega * capacitancia);
                sumatoriaImpedanciaImaginariaSerie += impedanciaImaginaria;

                // Calcular la impedancia en paralelo
                double impedanciaEnParalelo = 1 / impedanciaImaginaria;
                sumatoriaImpedanciaImaginariaParalelo += impedanciaEnParalelo;

                // Mostrar los resultados en el ListBox
                listBoxInduct.Items.Add($"Frecuencia: {frecuencia:F2} Hz, Impedancia: {impedanciaReal:F4} + j{impedanciaImaginaria:F4}");
            }

            // Mostrar la impedancia en serie 
            label6.Text = $"Impedancia Total en Serie: {sumatoriaImpedanciaImaginariaSerie:F4}";

            // Mostrar la impedancia en paralelo 
            label7.Text = $"Impedancia Total en Paralelo: {1 / sumatoriaImpedanciaImaginariaParalelo:F4}";
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCapacitancia.Text = "";
            txtInductancia.Text = "";
            txtResistencia.Text = "";
            txtResultado.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canva.com/design/DAFwuzSwrXE/0JJNvD_vfXuYHT34lZF7YQ/view?utm_content=DAFwuzSwrXE&utm_campaign=designshare&utm_medium=link&utm_source=publishsharelink");
        }
    }  
}
