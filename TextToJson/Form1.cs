using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TextToJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new
                   System.IO.StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.UTF8);
                sw.Write(tb_output.Text);
                sw.Close();
            }
        }

        private void btn_to_array_Click(object sender, EventArgs e)
        {
            
            using (StringReader reader = new StringReader(tb_input.Text))
            {
                JArray list = new JArray();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Do something with the line
                    list.Add(line);
                }
                tb_output.Text = list.ToString();
            }
        }
    }
}
