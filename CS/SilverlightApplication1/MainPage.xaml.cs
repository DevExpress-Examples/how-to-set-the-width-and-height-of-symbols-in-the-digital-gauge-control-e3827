using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Gauges;


namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            #region #SetSymbolSize
            // Specify fixed values for symbol height and width.
            SymbolLength newWidth = new SymbolLength(SymbolLengthType.Fixed, 44);
            matrixView.Width = newWidth;
            SymbolLength newHeight = new SymbolLength(SymbolLengthType.Fixed, 50);
            matrixView.Height = newHeight;
            #endregion #SetSymbolSize
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            #region #SetSymbolSize
            // Specify proportional values for symbol height and width.
            SymbolLength newWidth = new SymbolLength(SymbolLengthType.Proportional, 2);
            matrixView.Width = newWidth;
            SymbolLength newHeight = new SymbolLength(SymbolLengthType.Proportional, 5);
            matrixView.Height = newHeight;
            #endregion #SetSymbolSize
        }

    }
}
