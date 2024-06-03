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
using static Integral.IntegralMethods;

namespace Fourier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SelectedFunction.Items.AddRange(Functions.Keys.ToArray());
        }

        private void FurierBtn_Click(object sender, EventArgs e)
        {
            DrawGraph(Functions[SelectedFunction.Text], Periods[SelectedFunction.Text]);
            Furier(Functions[SelectedFunction.Text], Periods[SelectedFunction.Text],Convert.ToInt32(NCount.Text),1000);
            chart1.Legends.Clear();
            var legend = new Legend
            {
                Docking = Docking.Top,
                Alignment = StringAlignment.Center
            };
            chart1.Legends.Add(legend);
            chart1.Series["OriginalFunction"].LegendText = "Изначальная функция";
            chart1.Series["FourierSeries"].LegendText = "Ряд Фурье";
        }
        public void Furier(Func<double, double> func, double period, int nTerms, int points)
        {
            int N = points; // Количество точек для построения графика
            double dt = period / N;
            double[] a = new double[nTerms];
            double[] b = new double[nTerms];
            int numPeriods = Convert.ToInt32(periodCount.Text); // количество отображаемых периодов

            // Вычисление коэффициентов Фурье с использованием метода Симпсона
            for (int n = 0; n < nTerms; n++)
            {
                // Вычисление коэффициентов a_n
                Func<double, double> anFunction = x => func(x) * Math.Cos(2 * Math.PI * n * x / period);
                a[n] = -Simpson(anFunction, 0, period, N) * 2 / period;

                // Вычисление коэффициентов b_n
                Func<double, double> bnFunction = x => func(x) * Math.Sin(2 * Math.PI * n * x / period);
                b[n] = -Simpson(bnFunction, 0, period, N) * 2 / period;
            }

            // Построение графика ряда Фурье
            var fourierSeries = new Series
            {
                Name = "FourierSeries",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Line,
                BorderWidth = 3
            };

            for (int k = 0; k <= N * numPeriods; k++)
            {
                double t = k * dt;
                double sum = a[0] / 2.0; // первый член (a0 / 2)
                for (int n = 1; n < nTerms; n++)
                {
                    sum += a[n] * Math.Cos(2 * Math.PI * n * t / period) + b[n] * Math.Sin(2 * Math.PI * n * t / period);
                }
                fourierSeries.Points.AddXY(t, sum);
            }

            chart1.Series.Add(fourierSeries);
            chart1.ChartAreas[0].RecalculateAxesScale();
        }





        private void DrawGraph(Func<double, double> func, double period)
        {
            chart1.Series.Clear();

            var series = new Series
            {
                Name = "OriginalFunction",
                Color = System.Drawing.Color.Red,
                ChartType = SeriesChartType.Line,
                BorderWidth = 10
            };

            double step = period / 100; // шаг для построения графика
            int numPeriods = Convert.ToInt32(periodCount.Text); // количество отображаемых периодов

            for (double x = 0; x <= period * numPeriods; x += step)
            {
                series.Points.AddXY(x, func(x));
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].RecalculateAxesScale();
        }


        public static Dictionary<string, Func<double, double>> Functions = new Dictionary<string, Func<double, double>>
        {
            {"sin(x)",(x)=>Math.Sin(x) },
            {"cos(x)",(x)=>Math.Cos(x) },
            {"sin(x)+cos(3x)", (x) => Math.Sin(x) + Math.Cos(3*x) },
            {"sin(x)*sin(x/2)",(x) => Math.Sin(x) + Math.Sin(x/2) },
            {"alternating", (x) => (Math.Floor(x) % 2 == 0) ? 1 : -1 }, // Функция чередования
            {"square wave", (x) => (Math.Floor(2 * x / Math.PI) % 2 == 0) ? 1 : -1 }, // Квадратная волна
            {"sawtooth wave", (x) => 2 * (x / Math.PI - Math.Floor(x / Math.PI + 0.5)) }, // Пилообразная волна
            {"triangle wave", (x) => Math.Abs(2 * (x / Math.PI - Math.Floor(x / Math.PI + 0.5))) * 2 - 1 }, // Треугольная волна
            {"sin(x) + cos(2x) + sin(3x)", (x) => Math.Sin(x) + Math.Cos(2 * x) + Math.Sin(3 * x) },
            {"sin(x) + cos(5x) + sin(7x)", (x) => Math.Sin(x) + Math.Cos(5 * x) + Math.Sin(7 * x) }
        };
        public static Dictionary<string, double> Periods = new Dictionary<string, double>
        {
            { "sin(x)", 2 * Math.PI },
            { "cos(x)", 2 * Math.PI },
            {"sin(x)+cos(3x)",2*Math.PI },
            {"sin(x)*sin(x/2)",Math.PI*4 },
            { "alternating", 2 }, // Период функции чередования
            { "square wave", Math.PI }, // Период квадратной волны
            { "sawtooth wave", Math.PI }, // Период пилообразной волны
            { "triangle wave", Math.PI }, // Период треугольной волны
            { "sin(x) + cos(2x) + sin(3x)", 2 * Math.PI },
            { "sin(x) + cos(5x) + sin(7x)", 2 * Math.PI }
        };
        
    }
}
