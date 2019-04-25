using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaPeriodo : Form
    {
        public TelaPeriodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}";
            string ini = string.Format(dateTimeFormat,dtp_inicio.Value.Year,dtp_inicio.Value.Month,dtp_inicio.Value.Day,dtp_inicio.Value.Hour,dtp_inicio.Value.Minute,dtp_inicio.Value.Second);
            string fi = string.Format(dateTimeFormat, dtp_fim.Value.Year, dtp_fim.Value.Month, dtp_fim.Value.Day, dtp_fim.Value.Hour, dtp_fim.Value.Minute, dtp_fim.Value.Second);
            TelaRelatorio relatorio = new TelaRelatorio(ini,fi);
            relatorio.ShowDialog();
        }
    }
}
