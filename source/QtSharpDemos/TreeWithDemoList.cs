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

		/// <summary>
		///  Demo use box layouts  to create a windows example.
		/// </summary>
		public TreeWithDemoList() {
			WindowTitle = "Window demo";
			this._treeView = InitTreeView();
			GetDemoWidgets();

			this.Layout = GenerateLayout();

			Resize( 640, 480 );
			Move( 300, 300 );
			//Show();
		}

		void GetDemoWidgets() {
			var assembly = typeof( Program ).GetTypeInfo().Assembly;
			var demos = assembly.DefinedTypes.Where( x => x.GetTypeInfo().IsSubclassOf( typeof( QWidget ) ) && !x.GetTypeInfo().IsAbstract ).ToList();
			demos.Remove( this.GetType().GetTypeInfo() );

			foreach (var item in demos) {
				this._treeView.AddTopLevelItem( CreateItem( item.Name, item.FullName ) );
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

			vbox.AddWidget( new QLabel( "Windows" ) );

			var vbox1 = new QVBoxLayout();
			vbox1.AddWidget( new QPushButton( "Activate" ) );
			var quitButton = new QPushButton( "Quit" );
			quitButton.Pressed += CloseButton_Pressed;

			vbox1.AddWidget( quitButton, 0, AlignmentFlag.AlignTop );

			var hbox1 = new QHBoxLayout();
			hbox1.AddWidget( this._treeView );
			hbox1.AddLayout( vbox1 );

			vbox.AddLayout( hbox1 );

			var hbox2 = new QHBoxLayout();
			hbox2.AddWidget( new QPushButton( "Help" ) );
			hbox2.AddStretch( 1 );
			hbox2.AddWidget( new QPushButton( "OK" ) );

			vbox.AddLayout( hbox2, 1 );

			return vbox;
			//parentWidget.Layout = vbox;
		}

		private void CloseButton_Pressed() {
			QGuiApplication.Exit();
		}

	}
}
