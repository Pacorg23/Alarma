
namespace alarma
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.TiempoTotal = new System.Windows.Forms.Label();
            this.deficitDeTiempo = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.lap = new System.Windows.Forms.Button();
            this.lapList = new System.Windows.Forms.ListBox();
            this.currentLap = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(28, 26);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Iniciar";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // TiempoTotal
            // 
            this.TiempoTotal.AutoSize = true;
            this.TiempoTotal.Location = new System.Drawing.Point(157, 26);
            this.TiempoTotal.Name = "TiempoTotal";
            this.TiempoTotal.Size = new System.Drawing.Size(49, 15);
            this.TiempoTotal.TabIndex = 1;
            this.TiempoTotal.Text = "00:00:00";
            this.TiempoTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // deficitDeTiempo
            // 
            this.deficitDeTiempo.AutoSize = true;
            this.deficitDeTiempo.Location = new System.Drawing.Point(157, 148);
            this.deficitDeTiempo.Name = "deficitDeTiempo";
            this.deficitDeTiempo.Size = new System.Drawing.Size(49, 15);
            this.deficitDeTiempo.TabIndex = 2;
            this.deficitDeTiempo.Text = "00:00:00";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(28, 85);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "Parar";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // lap
            // 
            this.lap.Location = new System.Drawing.Point(28, 140);
            this.lap.Name = "lap";
            this.lap.Size = new System.Drawing.Size(75, 23);
            this.lap.TabIndex = 4;
            this.lap.Text = "Vuelta";
            this.lap.UseVisualStyleBackColor = true;
            this.lap.Click += new System.EventHandler(this.button3_Click);
            // 
            // lapList
            // 
            this.lapList.AllowDrop = true;
            this.lapList.FormattingEnabled = true;
            this.lapList.ItemHeight = 15;
            this.lapList.Location = new System.Drawing.Point(262, 6);
            this.lapList.Name = "lapList";
            this.lapList.Size = new System.Drawing.Size(161, 199);
            this.lapList.TabIndex = 5;
            // 
            // currentLap
            // 
            this.currentLap.AutoSize = true;
            this.currentLap.Location = new System.Drawing.Point(157, 85);
            this.currentLap.Name = "currentLap";
            this.currentLap.Size = new System.Drawing.Size(49, 15);
            this.currentLap.TabIndex = 6;
            this.currentLap.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 211);
            this.Controls.Add(this.currentLap);
            this.Controls.Add(this.lapList);
            this.Controls.Add(this.lap);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.deficitDeTiempo);
            this.Controls.Add(this.TiempoTotal);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label TiempoTotal;
        private System.Windows.Forms.Label deficitDeTiempo;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button lap;
        private System.Windows.Forms.ListBox lapList;
        private System.Windows.Forms.Label currentLap;
        private System.Windows.Forms.Timer timer;
    }
}

