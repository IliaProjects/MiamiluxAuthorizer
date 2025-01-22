using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher.CustomObjects
{
    public partial class BaseButton : Button
    {
        private bool _isMouseOver;
        private bool _isMouseDown;
        public BaseButton()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Gray;
            this.ForeColor = Color.White;
            this.Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isMouseOver = true;
            this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isMouseOver = false;
            this.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isMouseDown = true;
            this.Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isMouseDown = false;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            Rectangle rect = this.ClientRectangle;

            Color baseColor = this.BackColor;
            Color highlightColor = ControlPaint.Light(baseColor, 0.2f);
            Color shadowColor = ControlPaint.Dark(baseColor, 0.2f);

            if (_isMouseDown)
            {
                g.FillRectangle(new SolidBrush(shadowColor), rect);
                ControlPaint.DrawBorder(g, rect, Color.White, ButtonBorderStyle.Solid);
            }
            else if (_isMouseOver)
            {
                g.FillRectangle(new SolidBrush(highlightColor), rect);
                ControlPaint.DrawBorder(g, rect, Color.White, ButtonBorderStyle.Solid);
            }
            else
            {
                g.FillRectangle(new SolidBrush(baseColor), rect);
                ControlPaint.DrawBorder(g, rect, shadowColor, ButtonBorderStyle.Solid);
            }

            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
