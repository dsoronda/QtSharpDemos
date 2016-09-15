using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore.Qt;

namespace QtSharpDemos.GuiExample
{
    public class PaintDemo : QtWidgets.QWidget
    {

        public PaintDemo()
        {
            WindowTitle = "Paint Demo";
 
            Resize(400, 300);
            Show();
        }

    
        protected override void OnPaintEvent(QPaintEvent e)
        {
            base.OnPaintEvent(e);

            // this is example from Qt site, http://doc.qt.io/qt-5/qtwidgets-widgets-scribble-example.html
            var painter = new QPainter(this);// throws Access Violation exception
            painter.SetRenderHint ( QPainter.RenderHint.Antialiasing );

            DrawPatternsEx ( painter );
            painter.End();
        }

        void DrawPatternsEx(QPainter ptr)
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
