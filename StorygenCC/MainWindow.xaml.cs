using StorygenCC.controls;
using StorygenCC.controls.buttons;
using StorygenCC.controls.selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StorygenCC
{
    
    public partial class MainWindow : Window
    {
        private bool menuVisibility = false;
        private GridLength gridLengthZero = new GridLength(0);
        private Welcome welcome = new Welcome();

        public ProjectManager projectManagerUI;
        public SectionPage sectionPage;

        public MainWindow()
        {
            InitializeComponent();
            SelectorBox.Width = gridLengthZero;       
            Container.Child = welcome;
            this.projectManagerUI = new ProjectManager(this);
            this.sectionPage = new SectionPage(this);
        }

        private void Window_Drag(object sender, MouseButtonEventArgs e) => this.DragMove();
        private void Window_Close(object sender, RoutedEventArgs e) => this.Close();
        private void Select_Compilation(object sender, RoutedEventArgs e) => MenuClickEvent();

        private void MenuClickEvent()
        {
            if (!menuVisibility)
            {
                SelectorBox.Width = new GridLength(150);
                SelectorContainer.Child = projectManagerUI;
                menuVisibility = true;
            }
            else
            {
                SelectorBox.Width = gridLengthZero;
                SelectorContainer.Child = null;
                menuVisibility = false;
            }
        }

        public void LoadSection(Section section)
        {
            if (Container.Child == welcome)
                Container.Child = sectionPage;

            sectionPage.CurrentSection = section;
            sectionPage.LoadPage();
        }
    }
}
