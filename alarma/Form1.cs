using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarma
{
    public partial class Form1 : Form
    {
        
        public int tiempoTotal=0;
        public int vueltaActual=0;
        public int adeudoDeTiempo { get; set; }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\okey-\source\repos\alarma\alarma\sonidos\mixkit-digital-clock-digital-alarm-buzzer-992.wav");

        public Form1()
        {

            InitializeComponent();
            timer.Interval = 1000;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();

            }
            
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tiempoTotal++;
            vueltaActual++;
            if (vueltaActual>=2700)
            {
                if (vueltaActual%60==0)
                {
                    player.Play();
                }
                if (vueltaActual>27600)
                {
                    currentLap.BackColor = Color.IndianRed;

                }
            }
            TiempoTotal.Text = deIntATiempo(tiempoTotal);
            currentLap.Text = deIntATiempo(vueltaActual);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (vueltaActual>27600)
            {
                adeudoDeTiempo = adeudoDeTiempo + (vueltaActual - 27000);
                deficitDeTiempo.Text = deIntATiempo(adeudoDeTiempo);
            }
            lapList.Items.Add(deIntATiempo(vueltaActual));
            vueltaActual = 0;
            currentLap.Text = deIntATiempo(0);
            timer.Start();
        }
        private string deIntATiempo(int tiempo)
        {
            
            
            int segundos, minutos, horas;
            segundos = tiempo % 60;
            tiempo = tiempo - segundos;
            minutos = tiempo / 60;
            horas = minutos / 60;
            minutos = minutos - (horas * 60);
            TimeSpan time = new TimeSpan(0, horas, minutos, segundos);
            string output=time.ToString(@"dd\.hh\:mm\:ss");
            
            return output.Remove(0, 3);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (!timer.Enabled)
            {
                
                
                if (vueltaActual==0)
                {
                    tiempoTotal = 0;
                }
                vueltaActual = 0;
            }

        }
    }
}
