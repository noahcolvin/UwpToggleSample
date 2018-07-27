using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TestUwp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static DependencyProperty DisplayMaskProperty = DependencyProperty.Register("DisplayMask", typeof(bool), typeof(MainPage), new PropertyMetadata(true));
        public static DependencyProperty DisplaySsnProperty = DependencyProperty.Register("DisplaySsn", typeof(bool), typeof(MainPage), new PropertyMetadata(false));

        public bool DisplayToggle { set { SetValue(DisplayMaskProperty, value); SetValue(DisplaySsnProperty, !value); } }
    }
}
