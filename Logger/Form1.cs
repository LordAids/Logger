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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Debug("Была нажата кнопка дебага");
            CheckLabel.Text = "Debug log записан";
        }

        private void debugEButton_Click(object sender, EventArgs e)
        {
            Exception ex = new Exception("Ошибка для показа debugE");
            log.Debug("Была нажата кнопка дебага и вот код ошибки: ", ex);
            CheckLabel.Text = "DebugE log записан";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.DebugFormat("Дебаг формат так сказать: ", sender);
            CheckLabel.Text = "DebugFormat log записан";
        }

        private void ErrorButton_Click(object sender, EventArgs e)
        {
            log.Error("Произошла ошибка");
            Exception ex = new Exception("");
            log.ErrorUnique("Произошла ошибка", ex);
            CheckLabel.Text = "Error log записан";

        }

        private void errorEButton_Click(object sender, EventArgs e)
        {
            Exception ex = new Exception("Ошибка для показа ErrorE");
            log.Error("Произошла ошибка. Код: ", ex);
            log.ErrorUnique("Произошла ошибка.Код: ", ex);
            CheckLabel.Text = "ErrorE log записан";
        }

        private void errorEOnlyButoon_Click(object sender, EventArgs e)
        {
            Exception ex = new Exception("Ошибка для показа ErrorEOnly");
            log.Error(ex);
            log.ErrorUnique("Код ошибки:", ex);
            CheckLabel.Text = "ErrorEOnly log записан";
        }

        private void fatalButton_Click(object sender, EventArgs e)
        {
            log.Fatal("Произошла фатальная ошибка");
            CheckLabel.Text = "Fatal log записан";
        }

        private void fatalEButton_Click(object sender, EventArgs e)
        {
            Exception ex = new Exception("Код фатальной ошибки");
            log.Fatal("Произошла фатальная ошибка. Код:", ex );
        }
    }
}
