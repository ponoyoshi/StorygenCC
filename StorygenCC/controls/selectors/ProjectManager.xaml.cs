using StorygenCC.controls.buttons;
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

namespace StorygenCC.controls.selectors
{
    
    public partial class ProjectManager : UserControl
    {
        private MainWindow window;
        public ProjectManager(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void AddSection(object sender, RoutedEventArgs e)
        {
            Section section = new Section(window)
            {
                SectionName = "New Section",
                StartTime = 0,
                EndTime = 0
            };
            SectionList.Children.Add(section);
        }

        public void RemoveSection(int index) => SectionList.Children.Remove(window.sectionPage.CurrentSection);

        public Section GetSection(int index)
        {
            return (Section)SectionList.Children[index];
        }
    }
}