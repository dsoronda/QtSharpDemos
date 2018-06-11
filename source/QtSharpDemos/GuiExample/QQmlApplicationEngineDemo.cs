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

namespace QtSharpDemos.GuiExample {
	// Load QML file as Application window
	public class QQmlApplicationEngineDemo {
		public static readonly string Description = "QML demo";
		const string MainQml = @"media\QML\main.qml";
		public QQmlApplicationEngineDemo() {
			var QmlEngine = new QQmlApplicationEngine( MainQml );
		}
	}
}
