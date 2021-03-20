using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public partial class Form1 : Form
    {
        Logger log = new Logger();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Debug("Была нажата кнопка дебага");
            label1.Text = sender.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void debugEButton_Click(object sender, EventArgs e)
        {
            Exception ex = new Exception("Ошибка для показа debugE");
            log.Debug("Была нажата кнопка дебага и вот код ошибки: ", ex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.DebugFormat("Дебаг формат так сказать: ", sender);
        }
    }
}
