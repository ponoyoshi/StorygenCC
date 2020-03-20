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

namespace StorygenCC.controls
{
    
    public partial class SectionPage : UserControl
    {
        private MainWindow window;
        public Section CurrentSection { get; set; }

        public SectionPage(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        public void LoadPage()
        {
            InputName.Text = CurrentSection.SectionName;
        }

        private void InputName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CurrentSection != null)
            {
                CurrentSection.SectionName = InputName.Text;
                CurrentSection.UIName.Text = InputName.Text;
            }
                
        }
    }
}
