using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;
using QtQml;
using QtWidgets;
using QtQuick;
using QtGui;

namespace QtSharpDemos.GuiExample
{
    public class QmlDemo : QtWidgets.QWidget
    {
        const string RectQml = @"media\QML\Rectangle.qml";
        public QmlDemo()
        {

            WindowTitle = "Qml Demo";

            //QQmlEngine engine = new QQmlEngine(this);
            //var component = new QQmlComponent(engine, @"media\QML\App.qml");
            //var obj = component.Create();


            QQmlEngine engine = new QQmlEngine(this);
            var component = new QQmlComponent(engine, @"media\QML\Rectangle.qml");
            //QQmlContext context = new QQmlContext();
            var obj = component.Create();

            //var view = new QDeclarativeView();
            //view.setSource(QUrl::fromLocalFile("MyItem.qml"));
            //view.show();
            //QObject  obj  = view.rootObject();

            Resize(400, 300);
            Move(100, 100);
            Show();
        }
    }
}
