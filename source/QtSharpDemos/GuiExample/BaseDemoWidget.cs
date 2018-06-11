using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample {
	public abstract class BaseDemoWidget : QtWidgets.QWidget{
		public BaseDemoWidget() : base() {
			InitUI();
		}

		public abstract void InitUI();
	}
}
