using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CustomControls.ADControls
{
    public class ADToogleButton: CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToogleColor= Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToogleColor = Color.Gainsboro;
        private bool solidStyle = true;

        [ DefaultValue(true)]
        public bool SolidStyle 
        { 
            get 
            { 
                return (solidStyle == true);
            }
            set 
            { 
                solidStyle = value;
                this.Invalidate();
            }
        }

        public Color OnBackColor 
        {
            get
            {
                return onBackColor;
            }
            set 
            { 
                onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnToogleColor 
        {
            get
            {
                return onToogleColor;
            }
            set
            {
                onToogleColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor 
        {
            get
            {
                return offBackColor;
            }
            set
            {

                offBackColor = value;
                this.Invalidate();
            }

        }
        public Color OffToogleColor 
        {
            get 
            { 
                return offToogleColor; 
            } 
            set 
            { 
                offToogleColor = value; 
                this.Invalidate(); 
            }
        }

        //Constructor
        public ADToogleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0,0,arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width-arcSize-2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toogleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode=SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked )// Estado ON
            {
                //Draw the control surface
                if(solidStyle)
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(onBackColor,2),GetFigurePath());
                //Draw the toogle
                pevent.Graphics.FillEllipse(new SolidBrush(onToogleColor), 
                    new Rectangle(this.Width-this.Height+1,2,toogleSize,toogleSize));
            }
            else// Estado OFF
            {
                //Draw the control surface
                if (solidStyle)
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(offBackColor,2),GetFigurePath());
                //Draw the toogle
                pevent.Graphics.FillEllipse(new SolidBrush(offToogleColor),
                    new Rectangle(2, 2, toogleSize, toogleSize));
            }
        }
        
    }
}
