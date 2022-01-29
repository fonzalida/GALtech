﻿using CoolSoft.VISTA;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Vista
{
    public partial class FormPresentacion : Form
    {

        int i = 0;

        public FormPresentacion()
        {
            InitializeComponent();

            Shown += new EventHandler(FormPresentacion_Shown);

            // To report progress from the background worker we need to set this property
            backgroundWorker1.WorkerReportsProgress = true;
 
            // This event will be raised on the worker thread when the worker starts
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            // This event will be raised when we call ReportProgress
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

        }

        private async void FormPresentacion_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

            //await Cargar();

        }

        private async Task<int> Cargar()
        {
            while (progressBar1.Value < progressBar1.Maximum)
            {

                progressBar1.Value++;
                Thread.Sleep(10);
                this.Refresh();
            }

            FormularioPrincipal f = new FormularioPrincipal();
            f.Show();
            this.Hide();
            return 1;
        }

        private string Texto(string s)
        {
            return "Cargando " + s;
        }

        private void FormPresentacion_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Your background task goes here
            for (int i = 0; i <= 100; i++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(i);
                // Simulate long task
                Thread.Sleep(30);
            }

          
        }
        // Back on the 'UI' thread so we can update the progress bar
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }

        private void FormPresentacion_Shown(object sender, EventArgs e)
        {

        }

        private void cargarPrincipal(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormularioPrincipal f = new FormularioPrincipal();
            f.Show();
            this.Hide();
        }
    }
}
