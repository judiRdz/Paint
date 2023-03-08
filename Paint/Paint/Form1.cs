using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int sx, sy, cx, cy;//NUEVAS VARIABLES
        int index;
        int tamanioPincel = 3;
        bool moviendo = false;
        Pen pen;
         
        Point px, py;

        public Form1()
        {
            InitializeComponent();
            bm=new Bitmap(picBoxPapel.Width,picBoxPapel.Height);
            //Asignamos nuestra propiedad graphics a nuestro pictureBox
            papel = picBoxPapel.CreateGraphics();
            picBoxPapel.BackColor = Color.White;
            //Para que los trazos sea mas suave
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //inicializamos nuestra variable con los valores del trackbar
            tamanioPincel = trackBarTamanioPincel.Value;
            //Inicializamos RGB con los valores de los textBox
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            //Inicializamos un pincel conlos colores y el tamano del pincel
            pen = new Pen(Color.FromArgb(R, G, B), tamanioPincel);
            //Los trazos inicien y terminen de forma ovalada
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            picBoxPapel.Image = bm;
            papel = Graphics.FromImage(bm);
            picBoxPapel.BackgroundImage = bm;
            picBoxPapel.BackgroundImageLayout = ImageLayout.None;
        }

        //Evento que se dispara al hacer clic y sostenerlo en le papel
        private void picBoxPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            py=e.Location;
            cx = e.X;
            cy = e.Y;
            //Cambiar cursor a una cruz
            picBoxPapel.Cursor= Cursors.Cross;
        }

        //Evento que se dispara al dejar de hacer clic sobre el picBox
        private void picBoxPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
            sx = x - cx;
            sy = y - cy;

            if(index==1)
            {
                papel.DrawEllipse(pen, cx, cy, sx, sy);
            }
            if (index == 2)
            {
                papel.DrawRectangle(pen, cx, cy, sx, sy);
            }
            if (index == 3)
            {
                papel.DrawLine(pen, cx, cy, x, y);
            }
            
        }

        private void btnPincel_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            index= 5;
        }
        //Evento que ocurre cuando movemos nuestro cursor sobre el papel
        private void picBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo)
            {
                if (index==4)
                {
                    //llamar funcion para cambiar las propiedades del pincel
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                    //Dibujamos una  linea desde la posicion actual hacia donde nos movemos
                    px = e.Location;
                    papel.DrawLine(pen, px, py);
                    py = px;
                    
                }
                if ( index==5)
                {
                    cambiarPincel(255,255,255);
                    px = e.Location;
                    papel.DrawLine(pen, px, py);
                    py = px;
                }

                picBoxPapel.Refresh();
            }



            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy; 
            
        }
        private void picBoxPapel_Paint(object sender, PaintEventArgs e)
        {
            Graphics papel = e.Graphics;
            if (moviendo)
            {
                if (index == 1)
                {   
                    papel.DrawEllipse(pen, cx, cy, sx, sy);
                   
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
                if (index == 2)
                {                   
                    papel.DrawRectangle(pen, cx, cy, sx, sy);
                    
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
                if (index == 3)
                {
                    papel.DrawLine(pen, cx, cy, x, y);
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
            }

        }
        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R,G,B), trackBarTamanioPincel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        //Evento que ocurre al dezplazar el trackbar
        private void trackBarTamanioPincel_Scroll(object sender, EventArgs e)
        {
            tamanioPincel = trackBarTamanioPincel.Value;
            lblTamanioPincel.Text = trackBarTamanioPincel.Value.ToString();
        }
        //PicBox muestra el colorDialog
        private void picBoxColores_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK) //Mostramos el colorDialog
            {
                //Asignar a los textbox el color asignado
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
                
            }
        }
        //Pasar a color negro nuestra brocha
        private void picBoxNegro_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            papel.Clear(Color.White);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "png IMAGE|*.png";
            guardar.RestoreDirectory= true;
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                Guardar();
                bitmap.Save(guardar.FileName,System.Drawing.Imaging.ImageFormat.Png);
            }*/

            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                Bitmap btm = bm.Clone(new Rectangle(0, 0, picBoxPapel.Width, picBoxPapel.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }

        }

        //dibujar elipse
        private void btnElipse_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        //cuadrado
        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        //dibujar una linea
        private void btnLinea_Click(object sender, EventArgs e)
        {
            index = 3;
        }
    }

    //TODO: Pasar lo de las figuras a este programa
    //  * Plus: Dibujar figuras con dos puntos
    //  *Plus plus: Dibujar figuras en tiempo real
}