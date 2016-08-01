using QtCore;
using QtQml;
using QtQuick;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    /// <summary>
    /// Load and show Window defined in QML file
    /// </summary>
    public class QuickViewDemo
    {
        const string RectQml = @"media\QML\Rectangle.qml";
        const string AppQml = @"media\QML\App.qml";

        public QuickViewDemo()
        {
            //var desktopWidget = new QDesktopWidget();

            //var window = new QtGui.QWindow();
            //window.Resize(800, 600);

            //var appEng = new QQmlApplicationEngine();
            //var view = new QQuickView(appEng, window);

            // I'm not sure how to do this anymore, to much different examples :(
            var view = new QQuickView();
            view.Source = QUrl.FromLocalFile(AppQml);
            
            view.Resize(400, 300);
            
            view.Show();
        }
    }
}
