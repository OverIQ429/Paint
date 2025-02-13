using System.Drawing;
using System.Reflection;

namespace Paint
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetSize();
            pictureBox1.Visible = true;
        }

        private bool Mouse = true;
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }

            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }

            public void ResetPoint()
            {
                index = 0;
            }

            public int GetCountPoint()
            {
                return index;
            }

            public Point[] GetPoints()
            {
                return points;
            }

        }
        private ArrayPoints arrayPoints = new ArrayPoints(2);

        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;

        Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = false;
            arrayPoints.ResetPoint();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse) { return; }

            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoint() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox1.BackColor;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button15, button15.Width / 2, button15.Height);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    pictureBox1.Image.Save(saveFileDialog1.FileName);

                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg|PNG(*.PNG)|*.png|BMP(*.BMP)|*.bmp|GIF(*.GIF)|*.gif|TIFF(*.TIFF)|*.tiff;*.tif|EMF(*.EMF)|*.emf|WMF(*.WMF)|*.wmf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBox1.Image == null)
                    {
                        string fileExtension = System.IO.Path.GetExtension(saveFileDialog1.FileName).ToUpper(); // Получаем расширение файла и приводим к верхнему регистру
                        System.Drawing.Imaging.ImageFormat imageFormat;

                        switch (fileExtension)
                        {
                            case ".JPG":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case ".PNG":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Png;
                                break;
                            case ".BMP":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case ".GIF":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            case ".TIFF":
                            case ".TIF": // Поддержка обоих расширений TIFF
                                imageFormat = System.Drawing.Imaging.ImageFormat.Tiff;
                                break;
                            case ".EMF":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Emf;
                                break;
                            case ".WMF":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Wmf;
                                break;
                            default:
                                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg; // По умолчанию сохраняем как JPG
                                break;
                        }

                        pictureBox1.Image.Save(saveFileDialog1.FileName, imageFormat);
                    }
                }
            }
        }

        private void создатьПалатноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;
            //pictureBox1.Image = null;
            //pictureBox1.BackColor = Color.White;
            //pictureBox1.Invalidate();

            // Удаляем старый PictureBox
            Controls.Remove(pictureBox1);
            pictureBox1.Dispose(); // Освобождаем ресурсы

            // Создаем новый PictureBox
            pictureBox1 = CreateNewPictureBox();
            Controls.Add(pictureBox1);

        }

        private PictureBox CreateNewPictureBox()
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Name = "pictureBox1"; // Важно:  Дайте ему то же имя, чтобы код работал!
            newPictureBox.BackColor = Color.White;
            newPictureBox.BorderStyle = BorderStyle.FixedSingle;
            newPictureBox.Width = Screen.PrimaryScreen.Bounds.Width;
            newPictureBox.Height = Screen.PrimaryScreen.Bounds.Height;
            newPictureBox.Location = new Point(10, 10);
            newPictureBox.Visible = true; // Убедитесь, что он видим
            newPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            newPictureBox.MouseDown += pictureBox1_MouseDown;
            newPictureBox.MouseMove += pictureBox1_MouseMove;
            newPictureBox.MouseUp += pictureBox1_MouseUp;
            graphics.Clear(pictureBox1.BackColor);
            return newPictureBox;
        }

        private PictureBox LoadPictureBox(Bitmap bmp)
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Name = "pictureBox1"; // Важно:  Дайте ему то же имя, чтобы код работал!
            newPictureBox.BackColor = Color.White;
            newPictureBox.BorderStyle = BorderStyle.FixedSingle;
            newPictureBox.Width = Screen.PrimaryScreen.Bounds.Width;
            newPictureBox.Height = Screen.PrimaryScreen.Bounds.Height;
            newPictureBox.Location = new Point(10, 10);
            newPictureBox.Visible = true; // Убедитесь, что он видим
            newPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            newPictureBox.Image = bmp;
            newPictureBox.MouseDown += pictureBox1_MouseDown;
            newPictureBox.MouseMove += pictureBox1_MouseMove;
            newPictureBox.MouseUp += pictureBox1_MouseUp;
            graphics.Clear(pictureBox1.BackColor);
            return newPictureBox;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Выберите изображение для загрузки";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Bitmap loadedBitmap = new Bitmap(openFileDialog1.FileName);

                    // Освобождаем ресурсы, если они были выделены ранее
                    if (map != null)
                    {
                        map.Dispose();
                    }
                    if (graphics != null)
                    {
                        graphics.Dispose();
                    }

                    // Создаем новый Bitmap с размерами PictureBox
                    map = new Bitmap(pictureBox1.Width, pictureBox1.Height); // Используем размеры PictureBox!

                    // Создаем Graphics из нового Bitmap
                    graphics = Graphics.FromImage(map);

                    // Очищаем фон
                    graphics.Clear(Color.White); // Или другой нужный цвет фона

                    // Рисуем загруженное изображение на новый Bitmap
                    graphics.DrawImage(loadedBitmap, 0, 0, pictureBox1.Width, pictureBox1.Height); // Масштабируем изображение под PictureBox

                    // Устанавливаем изображение в PictureBox
                    pictureBox1.Image = map;

                    // Освобождаем ресурсы загруженного изображения
                    loadedBitmap.Dispose();

                    // Сбрасываем точки
                    arrayPoints.ResetPoint();

                    // Перерисовываем PictureBox
                    pictureBox1.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
