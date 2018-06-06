using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QtCore.Qt;
using QtWidgets;
using QtCore;
using QtGui;

namespace QtSharpDemos.GuiExample {
	public class TreeViewDemo : QTreeWidget {
		private QTreeWidgetItem _previousSelectedItem;

		public TreeViewDemo() {
			WindowTitle = "TreeView demo";

			InitUI();

			Resize( 350, 300 );
			Move( 300, 300 );
			Show();
		}

		void InitUI() {
			var strings = new QtCore.QStringList( "simple, string" );

			var tree = this;
			tree.ColumnCount = 2;
			var column = tree.ColumnAt( 0 );

			var topLevelItem = CreateItem( "hello", "this is hello" );
			tree.AddTopLevelItem( topLevelItem );

			QTreeWidgetItem helloItem = new QTreeWidgetItem( strings );
			tree.AddTopLevelItem( helloItem );
			var child = CreateItem( "child", "this is child" );
			helloItem.AddChild( child );

			tree.ItemSelectionChanged += Tree_ItemSelectionChanged;

			this._previousSelectedItem = topLevelItem;
		}

		private void Tree_ItemSelectionChanged() {
			var item = this.CurrentItem;
			item.SetBackground( 0, new QtGui.QBrush( GlobalColor.red ) );
			item.SetBackground( 1, new QtGui.QBrush( GlobalColor.green ) );
			this._previousSelectedItem = item;
		}

		private QTreeWidgetItem CreateItem( string name, string description ) {
			var item = new QTreeWidgetItem();
			item.SetText( 0, name );
			item.SetText( 1, description );

			return item;
		}
	}
}
