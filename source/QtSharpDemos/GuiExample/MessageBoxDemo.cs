using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class MessageBoxDemo : QtWidgets.QWidget
    {
        public MessageBoxDemo()
        {
            WindowTitle = "MessageBox Demo";
            var grid = new QGridLayout(this);

            InitUI(grid);

            Resize(250, 150);
            Move(300, 300);
            Show();
        }

        public void InitUI(QGridLayout grid)
        {
            grid.Spacing = 2;

            var errorButton = new QPushButton("Error");
            var warnimgButton = new QPushButton("Warning");
            var questionButton = new QPushButton("Question");
            var informationButton = new QPushButton("Information");
            var aboutButton = new QPushButton("About");

            grid.AddWidget(errorButton, 0, 0);
            grid.AddWidget(warnimgButton, 0, 1);
            grid.AddWidget(questionButton, 1, 0);
            grid.AddWidget(informationButton, 1, 1);
            grid.AddWidget(aboutButton, 2, 0);

            errorButton.Clicked += ErrorButton_Clicked;
            warnimgButton.Clicked += WarnimgButton_Clicked;
            questionButton.Clicked += QuestionButton_Clicked;
            informationButton.Clicked += InformationButton_Clicked;
            aboutButton.Clicked += AboutButton_Clicked;
        }

        private void AboutButton_Clicked(bool obj)
        {
            QMessageBox.About(this, "About", "QtSharp Message box example.");
        }

        private void InformationButton_Clicked(bool obj)
        {
            QMessageBox.Information(this, "Information", "This Information dialog.");
        }

        private void QuestionButton_Clicked(bool obj)
        {
            QMessageBox.Question(this, "Question", "This is Question dialog. Are you sure ?");
        }

        private void WarnimgButton_Clicked(bool obj)
        {
            QMessageBox.Warning(this, "Warning", "This is Waring dialog!");
        }

        private void ErrorButton_Clicked(bool obj)
        {
            QMessageBox.Critical(this, "Error", "This is Critical dialog!");
        }
    }
}
