using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.TruniControls
{
    public class CustomPanel: Panel
    {
        private int borderSize = 0;
        private Color borderColor = Color.Black;
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //Constructor
        public CustomPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }

        [Category("Advance")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Advance")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width-radius, rectangle.Height-radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode= SmoothingMode.AntiAlias;

            LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottomColor, this.gradientAngle);
            Graphics graphicsArtan = e.Graphics;
            graphicsArtan.FillRectangle(brushArtan, ClientRectangle);

            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, borderRadius))
                using (GraphicsPath pathBorder = GetArtanPath(rectBorder, borderRadius - 1F))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                    if (borderSize >= 1)
                    {
                        //Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectangleF);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
    }

}
