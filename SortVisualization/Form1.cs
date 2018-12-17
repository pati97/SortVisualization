using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualization
{
    public partial class Form1 : Form
    {
        Graphics graphic1;
        ArrayList arrayChooseAlgorithms;
        Bitmap bmpsave1;

        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Randomize(IList list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                int swapIndex = rand.Next(list.Count - i);
                if(swapIndex != i)
                {
                    object temp = list[swapIndex];
                    list[swapIndex] = list[i];
                    list[i] = temp;
                }
            }
        }

        private void DrawSample()
        {
            graphic1.Clear(Color.White);

            for(int i = 0; i < arrayChooseAlgorithms.Count; i++)
            {
                int x = (int)(((double)pcbSort1.Width / arrayChooseAlgorithms.Count) * i) ;

                Pen pen = new Pen(Color.DarkBlue);
                graphic1.DrawLine(pen, new Point(x, pcbSort1.Height), new Point(x, (pcbSort1.Height - (int)arrayChooseAlgorithms[i])));
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            bmpsave1 = new Bitmap(pcbSort1.Width, pcbSort1.Height);
            graphic1 = Graphics.FromImage(bmpsave1);
            pcbSort1.Image = bmpsave1;

            arrayChooseAlgorithms = new ArrayList(20);

            for(int i = 0; i < arrayChooseAlgorithms.Capacity; i++ )
            {
                int ElementValue = (int)((double)i / arrayChooseAlgorithms.Capacity * pcbSort1.Height);
                arrayChooseAlgorithms.Add(ElementValue);
            }
            Randomize(arrayChooseAlgorithms);
            DrawSample();
        }

        private void RedrawItem(int index, Graphics g, IList SortingElementsList)
        {
            int x = (int)(((double)pcbSort1.Width / arrayChooseAlgorithms.Count) * index);
            g.DrawLine(new Pen(Color.Green), new Point(x, 0), new Point(x, pcbSort1.Height));
            g.DrawLine(new Pen(Color.Black), new Point(x, 0), new Point(x, pcbSort1.Height - (int)SortingElementsList[index]));
        }
    }
}
