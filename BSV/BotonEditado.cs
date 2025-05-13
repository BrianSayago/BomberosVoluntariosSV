using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace BSV
{
    public class BotonEditado : Button
    {
        private int Borde_Tamaño = 0;
        private int Borde_Radio = 40;
        private Color Borde_color = Color.PaleGoldenrod;
        //Constructor 
        public BotonEditado()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.Maroon;
            this.ForeColor = Color.White;

        }
        //metodo privado para ruta de graficos
        private GraphicsPath GetFigurePath(RectangleF rect, float radio)
        {

            GraphicsPath ruta = new GraphicsPath();
            ruta.StartFigure();
            radio = 70f;
            // Esquina superior izquierda
            ruta.AddArc(rect.X, rect.Y, radio, radio, 180, 90);

            // Esquina superior derecha
            ruta.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);

            // Esquina inferior derecha
            ruta.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);

            // Esquina inferior izquierda
            ruta.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);

            ruta.CloseFigure(); // Cierra el camino para completar el rectángulo
            return ruta;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rect_Superficie = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rect_Borde = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (Borde_Radio > 2)
            {
                using (GraphicsPath rutaSurface = GetFigurePath(rect_Superficie, Borde_Radio))
                using (GraphicsPath rutaBorde = GetFigurePath(rect_Borde, Borde_Radio - 1F))
                using (Pen lapiz = new Pen(this.Parent.BackColor, 29))
                using (Pen lapizBorde = new Pen(Borde_color, Borde_Tamaño))
                {
                    lapizBorde.Alignment = PenAlignment.Inset;
                    //para la superfici del boton
                    this.Region = new Region(rect_Superficie);
                    //Dibuja borde
                    pevent.Graphics.DrawPath(lapiz, rutaSurface);
                    //dibujo borde de boton
                    if (Borde_Tamaño >= 1)
                    {
                        pevent.Graphics.DrawPath(lapizBorde, rutaBorde);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

    }
}
