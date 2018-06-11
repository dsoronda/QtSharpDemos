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

namespace QtSharpDemos
{

	class TreeWithDemoList : QWidget
	{
		private QTreeWidget _treeView;

		// container for demo widgets
		private QGroupBox demoWidgetContainer;
		private QWidget demoWidget;
		private readonly Dictionary<string, TypeInfo> demoDictionary = new Dictionary<string, TypeInfo>();

		/// <summary>
		///  Demo use box layouts  to create a windows example.
		/// </summary>
		public TreeWithDemoList()
		{
			WindowTitle = "Window demo";
			this.Layout = GenerateLayout();

			demoWidget = new Paint_GrayscaleImage();
			demoWidgetContainer.Layout.AddWidget(demoWidget);

			Resize(900, 600);
			Move(300, 300);

		}

		void GetDemoWidgetsList(QTreeWidget treeWidget)
		{
			var assembly = typeof(Program).GetTypeInfo().Assembly;
			var demos = assembly.DefinedTypes.Where(x => x.GetTypeInfo().IsSubclassOf(typeof(QWidget)) && !x.GetTypeInfo().IsAbstract).ToList();
			demos.Remove(this.GetType().GetTypeInfo());

			foreach (TypeInfo item in demos)
			{
				var itemDescription = item.GetField("Description", BindingFlags.Public | BindingFlags.Static);
				//var demoObj = Activator.CreateInstance( item );
				string description = null;
				//using (var demoObj = (QWidget) Activator.CreateInstance( item )) {
				if (itemDescription != null)
				{
					description = itemDescription.GetValue(null).ToString();
				}
				//}

				treeWidget.AddTopLevelItem(CreateItem(item.Name, description ?? item.FullName));
				demoDictionary.Add(item.Name, item);
			}

			foreach (TypeInfo item in demos.Take(1))
			{
				//	var bla = item as QWidget;


				//var obj = Activator.CreateInstance( item );
				//obj.GetType().GetProperties();
				//var widget = obj as QWidget;
				//widget.Show();
			}
		}

		void ShowDemo(string name)
		{
			if (demoWidgetContainer.Layout.Count <= 1)
			{
				demoWidgetContainer.Layout.RemoveWidget(demoWidget);
				var demoTypeInfo = demoDictionary[name];
				demoWidget.Dispose();

				demoWidget = (BaseDemoWidget)Activator.CreateInstance(demoTypeInfo);
				demoWidgetContainer.Layout.AddWidget(demoWidget);
				demoWidgetContainer.Repaint();
			}
			else
			{
				var info = new QMessageBox(icon: QMessageBox.Icon.Critical, title: "Error", text: "Invalid number of demo widgets");
				info.Show();
			}
		}

		QTreeWidget InitTreeView(QWidget parent = null)
		{
			var tree = new QTreeWidget(parent);
			tree.ColumnCount = 2;
			tree.SetColumnWidth(0, 160);
			tree.SetColumnWidth(1, 200);
			tree.WordWrap = true;
			tree.Size.Width = 260;
			var name = new QtCore.QStringList("name");
			tree.SetHeaderLabels(name);
			tree.HeaderItem.SetText(1, "description");

			var strings = new QtCore.QStringList("simple, string");

			tree.ItemSelectionChanged += Tree_ItemSelectionChanged;

			//var topLevelItem = CreateItem( "CheckboxDemo", "This is checkbox demo" );
			//tree.AddTopLevelItem( topLevelItem );

			//QTreeWidgetItem helloItem = new QTreeWidgetItem( strings );
			//tree.AddTopLevelItem( helloItem );
			//var child = CreateItem( "child", "this is child" );
			//helloItem.AddChild( child );

			//tree.ItemSelectionChanged += Tree_ItemSelectionChanged;
			return tree;
		}

		private void Tree_ItemSelectionChanged()
		{
			QTreeWidgetItem item = this._treeView.CurrentItem;
			var name = item.Text(0); // QtDisplayRole
#if DEBUG
			//var info = new QMessageBox(icon: QMessageBox.Icon.Information, title: "Info", text: $"Selected demo : {name}");
			//info.Show();
#endif
			ShowDemo(name);
		}

		private QTreeWidgetItem CreateItem(string name, string description)
		{
			var item = new QTreeWidgetItem();
			item.SetText(0, name);
			item.SetText(1, description);

			return item;
		}

		/// <summary>
		/// Generate 
		/// </summary>
		/// <returns></returns>
		QLayout GenerateLayout()
		{
			//var vbox = new QVBoxLayout(parentWidget);
			var vbox = new QVBoxLayout();

			// demo list
			var splitter = new QSplitter();

			var vbox1 = new QVBoxLayout();
			// https://doc.qt.io/qt-5/qgroupbox.html#details

			// demo container
			var demoBox = new QGroupBox("demos");
			demoBox.Layout = new QHBoxLayout();

			this.demoWidgetContainer = demoBox;

			this._treeView = InitTreeView();

			GetDemoWidgetsList(this._treeView);

			splitter.AddWidget(this._treeView);
			splitter.AddWidget(demoBox);

			vbox.AddWidget(splitter);

			var bottomLayout = new QHBoxLayout();
			bottomLayout.AddWidget(new QPushButton("Help"));
			bottomLayout.AddWidget(new QPushButton("Activate"));
			var quitButton = new QPushButton("Quit");
			quitButton.Pressed += CloseButton_Pressed;
			bottomLayout.AddWidget(quitButton, 0, AlignmentFlag.AlignTop);

			bottomLayout.AddStretch(1);
			bottomLayout.AddWidget(new QPushButton("OK"));

			vbox.AddLayout(bottomLayout, 1);

			return vbox;
		}

		private void CloseButton_Pressed()
		{
			QGuiApplication.Exit();
		}

	}
}
