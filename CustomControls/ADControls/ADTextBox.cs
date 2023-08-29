using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.ADControls
{
    public partial class ADTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        public bool underLinedStyle=true;

        //Properties
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
        public bool UnderLinedStyle
        {
            get
            {
                return underLinedStyle;
            }
            set
            {
                underLinedStyle = value; 
                this.Invalidate();
            }
        }

        //Constructor
        public ADTextBox()
        {
            InitializeComponent();
        }

        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            
            //Draw border
            using(Pen penBorder= new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underLinedStyle)//Line Style
                    graph.DrawLine(penBorder, 0, this.Height-1,this.Width,this.Height-1);
                else //Normal Style
                    graph.DrawLine(penBorder, 0,0,this.Width-0.5F,this.Height-0.5F);
                
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //Private Methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize= new Size(0,txtHeight);
                textBox1.Multiline=false;

                this.Height=textBox1.Height+this.Padding.Top+this.Padding.Bottom;
            }
        }
    }
}
