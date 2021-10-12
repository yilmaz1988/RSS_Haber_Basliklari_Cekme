using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Haber_Basliklari_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader("http://www.turkiyegazetesi.com.tr/rss/rss.xml");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku2 = new XmlTextReader("http://www.cumhuriyet.com.tr/rss/son_dakika.xml");
            while (xmloku2.Read())
            {
                if (xmloku2.Name == "title")
                {
                    listBox1.Items.Add(xmloku2.ReadString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku3 = new XmlTextReader("http://www.oncevatan.com.tr/rss.php");
            while (xmloku3.Read())
            {
                if (xmloku3.Name=="title")
                {
                    listBox1.Items.Add(xmloku3.ReadString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku4 = new XmlTextReader("https://www.yurtgazetesi.com.tr/service/rss.php");
            while (xmloku4.Read())
            {
                if (xmloku4.Name=="title")
                {
                    listBox1.Items.Add(xmloku4.ReadString());
                }
            }
        }
    }
}
