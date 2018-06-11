using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample {
    public class SpliterWithPanelsDemo : QtWidgets.QWidget {
        public SpliterWithPanelsDemo ( ) {
            WindowTitle = "Spliter with Panels Demo";

            this.Layout = GenerateLayout ( );
            //this.ShowMaximized();
            Resize ( 800, 600 );
            Show ( );
        }

        QLayout GenerateLayout ( ) {
            var layoutMain = new QVBoxLayout();

            layoutMain.AddWidget ( InitSpliter ( ) );
            layoutMain.AddStretch ( );

            return layoutMain;
        }

        QWidget InitSpliter ( ) {
            var spliter = new QSplitter(QtCore.Qt.Orientation.Horizontal, this);
            spliter.SetStretchFactor ( 0, 1 );
            spliter.SetStretchFactor ( 1, 1 );
            spliter.HandleWidth = 5;

            spliter.AddWidget ( GetLeftContainer ( ) );
            spliter.AddWidget ( GetRightContainer ( ) );

            return spliter;
        }

        private QWidget GetLeftContainer ( ) {
            var vbox = new QVBoxLayout();

            string text = @"To be or not to be, is that a question ?";
            vbox.AddWidget ( new QLabel ( text, this ) { Font = new QFont ( "Purisa", 15 ) } );
            vbox.AddWidget ( new QCheckBox ( "Show Title", this ) { Checked = true } );

            var container = new QWidget() { Layout = vbox };
            return container;
        }

        private QWidget GetRightContainer ( ) {
            var container = new QWidget();
            container.Layout = FormDemo.GenerateLayout ( );
            return container;
        }
    }
}
