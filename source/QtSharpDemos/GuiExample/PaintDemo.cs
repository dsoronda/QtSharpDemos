using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    using QtCore.Qt;

    public class PaintDemo : QtWidgets.QWidget
    {

        public PaintDemo()
        {
            WindowTitle = "Paint Demo";

            var paintEvent = new QPaintEvent(this.Rect);
            // HOW TO ADD ACTION TO PAINT EVENT ????
            this.OnPaintEvent(paintEvent);
            //this.OnPaintEvent += MyPaintEvent; // we need something like this ?

            Resize(250, 150);
            Move(300, 300);
            Show();
        }

        protected void MyPaintEvent(QPaintEvent e)
        {
            base.OnPaintEvent(e);
            var painter = new QPainter();

            DrawPatterns(painter);
            painter.End();
        }

        protected override void OnPaintEvent(QPaintEvent e)
        {
            base.OnPaintEvent(e);

            var painter = new QPainter();

            // this is example from Qt site, http://doc.qt.io/qt-5/qtwidgets-widgets-scribble-example.html
            // throws Access Violation exception, "Attempted to read or write protected memory. This is often an indication that other memory is corrupt."}
            //var painter2 = new QPainter(this);// throws Access Violation exception

            // this.InitPainter(painter);    // throws Access Violation exception , same as abowe, if commented nothing is drawn on widget

            DrawPatterns(painter);

            painter.End();
        }

        void DrawPatterns(QPainter ptr)
        {
            ptr.SetPen(PenStyle.NoPen);

            ptr.SetBrush(BrushStyle.HorPattern);
            ptr.DrawRect(10, 15, 90, 60);

            ptr.SetBrush(BrushStyle.VerPattern);
            ptr.DrawRect(130, 15, 90, 60);

            ptr.SetBrush(BrushStyle.CrossPattern);
            ptr.DrawRect(250, 15, 90, 60);

            ptr.SetBrush(BrushStyle.Dense7Pattern);
            ptr.DrawRect(10, 105, 90, 60);

            ptr.SetBrush(BrushStyle.Dense6Pattern);
            ptr.DrawRect(130, 105, 90, 60);

            ptr.SetBrush(BrushStyle.Dense5Pattern);
            ptr.DrawRect(250, 105, 90, 60);

            ptr.SetBrush(BrushStyle.BDiagPattern);
            ptr.DrawRect(10, 195, 90, 60);

            ptr.SetBrush(BrushStyle.FDiagPattern);
            ptr.DrawRect(130, 195, 90, 60);

            ptr.SetBrush(BrushStyle.DiagCrossPattern);
            ptr.DrawRect(250, 195, 90, 60);
        }

    }
}
