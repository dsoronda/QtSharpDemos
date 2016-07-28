using QtCore.Qt;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    /// <summary>
    /// Display QCheckBox  widget to show/hide the title of the window
    /// </summary>
    public class CheckBoxDemo : QtWidgets.QWidget
    {
        public CheckBoxDemo()
        {
            WindowTitle = "CheckBox Demo";

            SetupUI();

            Resize(250, 150);
            Move(300, 300);
            Show();
        }

        public void SetupUI()
        {
            var checkBox = new QCheckBox("Show title", this);
            checkBox.Checked = true;
            checkBox.Move(50, 50);

            checkBox.StateChanged += ShowTitle;
        }

        public void ShowTitle(int state)
        {
            if (state == (int)CheckState.Checked)
            {
                WindowTitle = "checked";
            }
            else
            {
                WindowTitle = "unchecked";
            }
        }
    }
}
