using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;        // krävs för StreamReader
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tips_o_Trix {
	public partial class Form1 : Form {


        List<int> xList = new List<int>();
        List<int> yList = new List<int>();
        public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {

            xList.Clear();
            yList.Clear();

            string sökväg = @"data.txt"; // Filen ligger i mappen  \bin\Debug
            if (File.Exists(sökväg)) {
                StreamReader sr = new StreamReader(sökväg);
               
                while (!sr.EndOfStream) {
                    string[] enRad = sr.ReadLine().Split(',');
                    // göra något med raden
                    xList.Add(int.Parse(enRad[0]));
                    yList.Add(int.Parse(enRad[1]));
                }
                lbl_message.Text = " Filen inläst.";
                sr.Close();
            } else lbl_message.Text = " Filen finns inte!";

            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            SolidBrush tegel = new SolidBrush(Color.DarkRed);

            for(int i = 0; i < xList.Count;i++){
                g.FillRectangle(tegel, xList[i], yList[i], 50, 50);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e) {

            xList.Add(e.X - 25);
            yList.Add(e.Y - 25);

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e) {

            string sökväg = @"data.txt"; // Filen ligger i mappen  \bin\Debug
            if (File.Exists(sökväg)) {
                StreamWriter sr = new StreamWriter(sökväg,false);

                for (int i = 0; i < xList.Count; i++) {
                    string s = xList[i] + "," + yList[i];
                    sr.WriteLine(s);
                }
                sr.Close();
            }
        }
    }
}
