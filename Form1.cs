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

namespace ChemicalСompoundRecognition
{
    public partial class Form1 : Form
    {
        private static Bitmap? ActiveGraph = null;
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += form_DragEnter;
            this.DragDrop += form_DragDrop;

        }

        private void form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void form_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files?.Length <= 0 || new[] { files[0].Split('.').Last() }.Any(end =>
            {
                var validFormats = new[] { "png", "jpg", "jpeg", "gif", "bmp" };
                if (validFormats.Where(f => f.ToLower().Equals(end.ToLower())).FirstOrDefault() == null)
                    return false;
                return true;
            }) == false) return;

            var firstFile = files[0];
            Bitmap fileBitmap = new Bitmap(firstFile);
            pictureBox1.Image = fileBitmap;
            ActiveGraph = fileBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for(var y = 0; y < ActiveGraph.Height; y++)
            //{
            //    var p = ActiveGraph.GetPixel(250, y);
            //    if(p.ToArgb() == Color.Black.ToArgb())
            //        MessageBox.Show("Черный тут: " + y);
            //}

            //return;
            if (ActiveGraph == null || !int.TryParse(textBox3.Text, out int step) || step <= 0) return;

            GetCoordinates(step);
            GetMatrix();
        }

        private void GetCoordinates(int step)
        {
            var coordinates = new List<Point>();
            var width = ActiveGraph.Width;
            var height = ActiveGraph.Height;

            for (var x = 0; x < width; x += step)
            {
                for (var y = 0; y < height; y++)
                {
                    var pixel = ActiveGraph.GetPixel(x, y);
                    if (pixel.R <= 120 && pixel.G <= 120 && pixel.B <= 120) { coordinates.Add(new Point(x, y)); break; }
                }
            }

            textBox1.Clear();
            coordinates.ForEach(point => textBox1.AppendText($"[{point.X},{point.Y}]" + Environment.NewLine));
        }

        private void GetMatrix()
        {
            var matrix = new List<PixelColor>();
            var width = ActiveGraph.Width;
            var height = ActiveGraph.Height;

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    var pixel = ActiveGraph.GetPixel(x, y);
                    if (pixel.R <= 120 && pixel.G <= 120 && pixel.B <= 120)
                        matrix.Add(new PixelColor(x, y, 1));
                    else matrix.Add(new PixelColor(x, y, 0));
                }
            }

            PixelColor.SavePixelColorsIntoFile(matrix);
        }
    }

    struct PixelColor
    {
        public int X;
        public int Y;
        public int Color;
        public PixelColor(int x, int y, int c)
        {
            X = x;
            Y = y;
            Color = c;
        }

        public static void SavePixelColorsIntoFile(List<PixelColor> collection)
        {
            if (collection?.Count == 0) return;

            string fileText = string.Empty;

            var currentLine = collection[0].Y;
            collection.ForEach(pixel => {
                if (currentLine != pixel.Y)
                {
                    fileText += Environment.NewLine;
                    currentLine++;
                }

                fileText += pixel.Color;
            });

            File.WriteAllText("graphMatrix.txt", fileText);  
        }
    }
}
