using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Serialization; 
using System.IO;
using static p.Form1;




namespace p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

       
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;

        }
     
        Bitmap bm;
        Graphics g;
        bool paint =false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 1);
        int index;
        int x, y, sX, sY, cX, cY;
        int dx = 7, dy = 7;
        private bool drawTree = false;
        private bool isSelecting = false; 
        private Rectangle selectionRect;  
        private Bitmap copiedImage;

        ColorDialog cd = new ColorDialog();
          Color new_color;

        private int offsetX = 0;
        private int offsetY = 0;
        private Bitmap previousState;
        private bool isFilling = false;
        private TextBox txtInput = new TextBox();

        public class Shape
        {
            [XmlAttribute("Type")]
            public string Type { get; set; }

            [XmlIgnore] 
            public Color Color { get; set; }

            [XmlElement("Color")] 
            public string XmlColor
            {
                get { return ColorTranslator.ToHtml(Color); }
                set { Color = ColorTranslator.FromHtml(value); }
            }

            [XmlAttribute("Thickness")]
            public int Thickness { get; set; }

            [XmlIgnore] 
            public Rectangle Bounds { get; set; }

            [XmlElement("Bounds")] 
            public SerializableRectangle XmlBounds
            {
                get { return new SerializableRectangle(Bounds); }
                set { Bounds = value.ToRectangle(); }
            }

            [XmlIgnore] 
            public Point Start { get; set; }

            [XmlElement("Start")] 
            public SerializablePoint XmlStart
            {
                get { return new SerializablePoint(Start); }
                set { Start = value.ToPoint(); }
            }

            [XmlIgnore]
            public Point End { get; set; }

            [XmlElement("End")] 
            public SerializablePoint XmlEnd
            {
                get { return new SerializablePoint(End); }
                set { End = value.ToPoint(); }
            }
        }
        public class SerializableRectangle
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public SerializableRectangle() { }

            public SerializableRectangle(Rectangle rectangle)
            {
                X = rectangle.X;
                Y = rectangle.Y;
                Width = rectangle.Width;
                Height = rectangle.Height;
            }

            public Rectangle ToRectangle()
            {
                return new Rectangle(X, Y, Width, Height);
            }
        }

        public class SerializablePoint
        {
            public int X { get; set; }
            public int Y { get; set; }

            public SerializablePoint() { }

            public SerializablePoint(Point point)
            {
                X = point.X;
                Y = point.Y;
            }

            public Point ToPoint()
            {
                return new Point(X, Y);
            }
        }



        private void btnRect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            

            Graphics g = e.Graphics;

            if (paint) 
            {
                int tempX = Math.Min(cX, x);
                int tempY = Math.Min(cY, y);
                int tempWidth = Math.Abs(x - cX);
                int tempHeight = Math.Abs(y - cY);

                if (index == 3) 
                {
                    e.Graphics.DrawEllipse(p, tempX, tempY, tempWidth, tempHeight);
                }
                else if (index == 4) 
                {
                    e.Graphics.DrawRectangle(p, tempX, tempY, tempWidth, tempHeight);
                }
                else if (index == 5) 
                {
                    e.Graphics.DrawLine(p, cX, cY, x, y);
                }
            }

            if (drawTree)
            {
                SolidBrush greenBrush = new SolidBrush(Color.Green);

                
                PointF[] topTriangle = {
                new PointF(17 * dx + offsetX, 5 * dy + offsetY),
                new PointF(10 * dx + offsetX, 15 * dy + offsetY),
                new PointF(24 * dx + offsetX, 15 * dy + offsetY)
                };
                g.FillPolygon(greenBrush, topTriangle);

                
                PointF[] middleTriangle = {
                new PointF(17 * dx + offsetX, 10 * dy + offsetY),
                new PointF(8 * dx + offsetX, 20 * dy + offsetY),
                new PointF(26 * dx + offsetX, 20 * dy + offsetY)
                };
                g.FillPolygon(greenBrush, middleTriangle);

                

                PointF[] bottomTriangle = {
                new PointF(17 * dx + offsetX, 15 * dy + offsetY),
                new PointF(6 * dx + offsetX, 25 * dy + offsetY),
                new PointF(28 * dx + offsetX, 25 * dy + offsetY)
                };
                g.FillPolygon(greenBrush, bottomTriangle);

                
                g.FillRectangle(new SolidBrush(Color.Brown), 15 * dx + offsetX, 25 * dy + offsetY, 4 * dx, 4 * dy);

                
                Draw(g, Color.Fuchsia, 10 * dx + offsetX, 14 * dy + offsetY, 2 * dx, 2 * dy);
                Draw(g, Color.Purple, 22 * dx + offsetX, 14 * dy + offsetY, 2 * dx, 2 * dy);
                Draw(g, Color.Maroon, 8 * dx + offsetX, 19 * dy + offsetY, 2 * dx, 2 * dy);
                Draw(g, Color.Red, 25 * dx + offsetX, 19 * dy + offsetY, 2 * dx, 2 * dy);
                Draw(g, Color.Yellow, 6 * dx + offsetX, 24 * dy + offsetY, 2 * dx, 2 * dy);
                Draw(g, Color.Purple, 26 * dx + offsetX, 24 * dy + offsetY, 2 * dx, 2 * dy);
            }

            if (isSelecting)
            {
                using (Pen selectionPen = new Pen(Color.Black, 1))
                {
                    selectionPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawRectangle(selectionPen, selectionRect);
                }
            }
            /*if (bm != null)
            {
                e.Graphics.DrawImage(bm, Point.Empty); 
            }*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 0;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;

        }
      
        private void btnBrush_Click(object sender, EventArgs e)
        {
            /*cd.ShowDialog(); 
            new_color = cd.Color; 
            brush_color.BackColor = new_color; 
            p.Color = new_color; 

            isFilling = true;
            paint = false;*/
        }

       
//-------------------------------------------------------
 
      private void btnPic_Click(object sender, EventArgs e)
        {
            drawTree = true;
            pictureBox1.Invalidate();
        }

     private void Draw(Graphics g, Color color, float x, float y, float width, float height)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x, y, width, height);
        }


        private void btnScalePlus_Click(object sender, EventArgs e)
        {
            dx *= 2; 
            dy *= 2;

        }

        private void btnScaleM_Click(object sender, EventArgs e)
        {
            if (dx > 5 && dy > 5) 
            {
                dx /= 2; 
                dy /= 2; 
            }
        } 
        //------------------------------------
        private void trackBar1_Scroll(object sender, EventArgs e)//товщина лінії
        {
            int thickness = trackBar1.Value; 
            p.Width = thickness; 
            erase.Width = thickness;
        }

        private void pic_color_Click(object sender, EventArgs e)
        {

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)  //зберегти файл
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg|PNG(*.PNG)|*.png|BMP(*.BMP)|*.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (pictureBox1.Image != null)
                    {

                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //піпетка
        {
            this.Cursor = Cursors.Cross; 
            paint = false; 
        }
//--------------
        private void btnTop_Click(object sender, EventArgs e)
        {
            offsetY -= 10; 
            pictureBox1.Invalidate();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            offsetX -= 10; 
            pictureBox1.Invalidate();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            offsetX += 10; 
            pictureBox1.Invalidate();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            offsetY += 10;
            pictureBox1.Invalidate();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveCurrentState()
        {
            if (pictureBox1.Image != null)
            {
                previousState = new Bitmap(pictureBox1.Image);
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previousState != null)
            {
                pictureBox1.Image = new Bitmap(previousState);
                pictureBox1.Refresh();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)    //відкрити файл
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap loadedImage = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = loadedImage;

                    bm = new Bitmap(loadedImage);
                    g = Graphics.FromImage(bm);

                    pictureBox1.Width = loadedImage.Width;
                    pictureBox1.Height = loadedImage.Height;
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)//copy
        {
            if (selectionRect.Width > 0 && selectionRect.Height > 0 && pictureBox1.Image != null)
            {
               
                copiedImage = new Bitmap(selectionRect.Width, selectionRect.Height);
                using (Graphics g = Graphics.FromImage(copiedImage))
                {
                    g.DrawImage(pictureBox1.Image, new Rectangle(0, 0, selectionRect.Width, selectionRect.Height), selectionRect, GraphicsUnit.Pixel);
                }
            }
         
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)//paste
        {
          
               using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawImage(copiedImage, 100, 100); 
                }

                pictureBox1.Invalidate();
            
       
        }
        
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*isSelecting = true;
            this.Invalidate();*/
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        //---------------------
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Cursor == Cursors.Cross)  //піпетка
            {
                if (bm != null && e.X >= 0 && e.X < bm.Width && e.Y >= 0 && e.Y < bm.Height)
                {
                    new_color = bm.GetPixel(e.X, e.Y);
                    brush_color.BackColor = new_color;
                    this.Cursor = Cursors.Default;
                }
            }

            /*if (isFilling) //колір 
            {
                Point clickPoint = e.Location; 
                Color targetColor = bm.GetPixel(clickPoint.X, clickPoint.Y);

                if (targetColor.ToArgb() != new_color.ToArgb()) 
                {
                    FloodFill(bm, clickPoint, targetColor, new_color);
                    pictureBox1.Invalidate(); 
                }
            }*/

        }
       
        private void saveVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Vector File (*.xml)|*.xml"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>));
                    using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, shapes);
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void openVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Vector File (*.xml)|*.xml"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>));
                    using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                    {
                        shapes = (List<Shape>)serializer.Deserialize(fs);
                    }

                    g.Clear(Color.White);


                    foreach (var shape in shapes)
                    {
                        Pen pen = new Pen(shape.Color, shape.Thickness);

                        if (shape.Type == "Rectangle")
                        {
                            g.DrawRectangle(pen, shape.Bounds);
                        }
                        else if (shape.Type == "Ellipse")
                        {
                            g.DrawEllipse(pen, shape.Bounds);
                        }
                        else if (shape.Type == "Line")
                        {
                            g.DrawLine(pen, shape.Start, shape.End);
                        }
                    }

                    pictureBox1.Invalidate();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Файл має неправильний формат або пошкоджений.\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при відкритті файлу: " + ex.Message);
                }
            }

        }

        private void btnText_Click(object sender, EventArgs e) //текст
        {
            txtInput.Visible = true;
            txtInput.Text = "";  
            txtInput.Focus();
        }

        /*private void FloodFill(Bitmap bitmap, Point pt, Color targetColor, Color replacementColor)
        {
            if (targetColor.ToArgb() == replacementColor.ToArgb()) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point current = pixels.Pop();
                if (current.X < 0 || current.Y < 0 || current.X >= bitmap.Width || current.Y >= bitmap.Height)
                    continue;

                Color currentColor = bitmap.GetPixel(current.X, current.Y);
                if (currentColor.ToArgb() == targetColor.ToArgb())
                {
                    bitmap.SetPixel(current.X, current.Y, replacementColor);       
                    pixels.Push(new Point(current.X + 1, current.Y));
                    pixels.Push(new Point(current.X - 1, current.Y));
                    pixels.Push(new Point(current.X, current.Y + 1));
                    pixels.Push(new Point(current.X, current.Y - 1));
                }
            }
        }*/
        private void btnEll_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnLastic_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        List<Shape> shapes = new List<Shape>();
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            // Визначення параметрів фігури
            int startX = Math.Min(cX, e.X);
            int startY = Math.Min(cY, e.Y);
            int width = Math.Abs(e.X - cX);
            int height = Math.Abs(e.Y - cY);

            Shape shape = new Shape
            {
                Color = p.Color,
                Thickness = (int)p.Width
            };

            // Збереження фігури залежно від типу
            if (index == 3) // Еліпс
            {
                shape.Type = "Ellipse";
                shape.Bounds = new Rectangle(startX, startY, width, height);
            }
            else if (index == 4) // Прямокутник
            {
                shape.Type = "Rectangle";
                shape.Bounds = new Rectangle(startX, startY, width, height);
            }
            else if (index == 5) // Лінія
            {
                shape.Type = "Line";
                shape.Start = new Point(cX, cY);
                shape.End = new Point(e.X, e.Y);
            }

            // Додавання фігури до списку
            shapes.Add(shape);

            // Малювання фігури на графіку
            if (index == 3)
            {
                g.DrawEllipse(p, startX, startY, width, height);
            }
            else if (index == 4)
            {
                g.DrawRectangle(p, startX, startY, width, height);
            }
            else if (index == 5)
            {
                g.DrawLine(p, cX, cY, e.X, e.Y);
            }

            pictureBox1.Invalidate();
        }
   
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint && !isFilling)
            {
                sX = e.X - cX; 
                sY = e.Y - cY; 

                pictureBox1.Invalidate(); 
            }


            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();

            x = e.X;
            y= e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

            if (isSelecting && e.Button == MouseButtons.Left)
            {
                int x = Math.Min(selectionRect.Left, e.X);
                int y = Math.Min(selectionRect.Top, e.Y);
                int width = Math.Abs(e.X - selectionRect.Left);
                int height = Math.Abs(e.Y - selectionRect.Top);

                selectionRect = new Rectangle(x, y, width, height);
                pictureBox1.Invalidate();
            }
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            px = py = e.Location; 
            cX = e.X; 
            cY = e.Y;

            if (isSelecting)
            {
                selectionRect = new Rectangle(e.Location, new Size(0, 0));
            }
            listBox1.Items.Add($"MoveTo,{e.X},{e.Y}");

        }
    }
}
