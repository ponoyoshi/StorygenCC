using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StorygenCC.controls.buttons
{
    
    public partial class Section : UserControl
    {
        public string SectionName { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        private MainWindow window;
        public Section(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        public void SelectSection(object sender, RoutedEventArgs e) => window.LoadSection(this);
    }
}
