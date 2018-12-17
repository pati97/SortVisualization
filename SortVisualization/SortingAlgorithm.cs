using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualization
{
    public class SortingAlgorithm
    {
        ArrayList arrayToSort;
        Graphics g;
        Bitmap bmpsave;
        PictureBox pcbSamples;
        bool savePicture;
        int imgCount;

        public SortingAlgorithm(ArrayList list, PictureBox pic, bool sp)
        {
            imgCount = 0;
            arrayToSort = list;
            pcbSamples = pic;
            savePicture = sp;

            bmpsave = new Bitmap(pcbSamples.Width, pcbSamples.Height);
            g = Graphics.FromImage(bmpsave);
            pcbSamples.Image = bmpsave;
            DrawSamples();
        }

        private void DrawSamples()
        {
            g.Clear(Color.White);


            for (int i = 0; i < arrayToSort.Count; i++)
            {
                int x = (int)(((double)pcbSamples.Width / arrayToSort.Count) * i);

                Pen pen = new Pen(Color.Black);
                g.DrawLine(pen, new Point(x, pcbSamples.Height), new Point(x, (pcbSamples.Height - (int)arrayToSort[i])));
            }

        }

        private static void QuickSort<T>(IList<T> input, int left, int right)
            where T : IComparable<T>
        {
            int pivot = 0;

            if (left < right)
            {
                pivot = Partition(input, left, right);
                QuickSort(input, left, pivot - 1);
                QuickSort(input, pivot + 1, right);
            }
        }

        private static int Partition<T>(IList<T> input, int left, int right)
            where T : IComparable<T>
        {
            var pivot = input[right];
            int i = 0;
            if (left >= 0)
            {
                i = left - 1;
            }

            for (int j = left; j <= right - 1; j++)
            {
                if (input[j].CompareTo(pivot) <= 0)
                {
                    i = i + 1;
                    Swap(input, i, j);
                }
            }

            Swap(input, i + 1, right);
            return i + 1;
        }

        private static void Swap<T>(IList<T> list, int low, int high)
        {
            var temp = list[low];
            list[low] = list[high];
            list[high] = temp;
        }
    }
}
