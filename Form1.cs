using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GlobalVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadFile = new OpenFileDialog();
            LoadFile.Filter = "Текстовый файл|*.txt";
            if (LoadFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Code.Text = File.ReadAllText(LoadFile.FileName);
            }
        }

        private void DeleteComment_Click(object sender, EventArgs e)
        {
            Regex find = new Regex(@"//.*|{([^}])+}");
            Code.Text = find.Replace(Code.Text, "");
        }

        private void Analys_Click(object sender, EventArgs e)
        {
            Logic metrics = new Logic (Code.Text);
            ResultAnalys.Text = ResultAnalys.Text +"Параметры метрики: " + "\n" + metrics.AnalysMetrix();
        }
    }
}
