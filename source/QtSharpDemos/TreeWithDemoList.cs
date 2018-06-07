using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtSharpDemos.GuiExample;
using QtGui;
using QtCore.Qt;
using System.Reflection;

namespace QtSharpDemos {

	class TreeWithDemoList : QWidget {
		private QTreeWidget _treeView;

		// container for demo widgets
		private QGroupBox demoWidgetContainer;

		/// <summary>
		///  Demo use box layouts  to create a windows example.
		/// </summary>
		public TreeWithDemoList() {
			WindowTitle = "Window demo";
			this._treeView = InitTreeView();

			GetDemoWidgetsList( this._treeView );

			this.Layout = GenerateLayout();

			demoWidgetContainer.Layout.AddWidget( new ButtonsDemo() );

			Resize( 640, 480 );
			Move( 300, 300 );
			//Show();
		}

		void GetDemoWidgetsList( QTreeWidget treeWidget ) {
			var assembly = typeof( Program ).GetTypeInfo().Assembly;
			var demos = assembly.DefinedTypes.Where( x => x.GetTypeInfo().IsSubclassOf( typeof( QWidget ) ) && !x.GetTypeInfo().IsAbstract ).ToList();
			demos.Remove( this.GetType().GetTypeInfo() );

			foreach (var item in demos) {
				treeWidget.AddTopLevelItem( CreateItem( item.Name, item.FullName ) );
			}

			foreach (TypeInfo item in demos.Take( 1 )) {
				//	var bla = item as QWidget;

				//object obj = Activator.CreateInstance( item );
				//var widget = obj as QWidget;
				//widget.Show();
			}

		}

		QTreeWidget InitTreeView() {
			var tree = new QTreeWidget();
			tree.ColumnCount = 2;
			tree.SetColumnWidth( 0, 250 );
			var name = new QtCore.QStringList( "name" );
			tree.SetHeaderLabels( name );
			tree.HeaderItem.SetText( 1, "description" );

			var strings = new QtCore.QStringList( "simple, string" );

			//var topLevelItem = CreateItem( "CheckboxDemo", "This is checkbox demo" );
			//tree.AddTopLevelItem( topLevelItem );

			//QTreeWidgetItem helloItem = new QTreeWidgetItem( strings );
			//tree.AddTopLevelItem( helloItem );
			//var child = CreateItem( "child", "this is child" );
			//helloItem.AddChild( child );

			//tree.ItemSelectionChanged += Tree_ItemSelectionChanged;
			return tree;
		}

		private QTreeWidgetItem CreateItem( string name, string description ) {
			var item = new QTreeWidgetItem();
			item.SetText( 0, name );
			item.SetText( 1, description );

			return item;
		}

		/// <summary>
		/// Generate 
		/// </summary>
		/// <returns></returns>
		QLayout GenerateLayout() {
			//var vbox = new QVBoxLayout(parentWidget);
			var vbox = new QVBoxLayout();

			// demo list
			var splitter = new QSplitter();
			//splitter.Orientation = Orientation.Vertical;
			splitter.AddWidget( this._treeView );
			//var hbox1 = new QHBoxLayout();
			//hbox1.AddWidget( this._treeView );

			var vbox1 = new QVBoxLayout();
			// https://doc.qt.io/qt-5/qgroupbox.html#details

			// demo container
			var demoBox = new QGroupBox( "demos" );
			demoBox.Layout = new QHBoxLayout();
			this.demoWidgetContainer = demoBox;

			//vbox1.AddWidget( demoBox );

			splitter.AddWidget( demoBox );

			//vbox.AddLayout( splitter );
			vbox.AddWidget( splitter );

			var bottomLayout = new QHBoxLayout();
			bottomLayout.AddWidget( new QPushButton( "Help" ) );
			bottomLayout.AddWidget( new QPushButton( "Activate" ) );
			var quitButton = new QPushButton( "Quit" );
			quitButton.Pressed += CloseButton_Pressed;
			bottomLayout.AddWidget( quitButton, 0, AlignmentFlag.AlignTop );

			bottomLayout.AddStretch( 1 );
			bottomLayout.AddWidget( new QPushButton( "OK" ) );

			vbox.AddLayout( bottomLayout, 1 );

			return vbox;
			//parentWidget.Layout = vbox;
		}

		private void CloseButton_Pressed() {
			QGuiApplication.Exit();
		}

	}
}
