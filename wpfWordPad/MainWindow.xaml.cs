using System;
using System.Collections.Generic;
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

namespace wpfWordPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            rtfNote.TextChanged += RtfNote_TextChanged;
            cbColorText.SelectionChanged += CbColorText_SelectionChanged;
            cbColorBack.SelectionChanged += CbColorBack_SelectionChanged;

        }

        private void CbColorBack_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox c)
            {
                switch (c.SelectedIndex)
                {
                    case 0:
                        rtfNote.Background = Brushes.White;
                        break;
                    case 1:
                        rtfNote.Background = Brushes.Black;
                        break;
                    case 2:
                        rtfNote.Background = Brushes.Red;
                        break;
                    case 3:
                        rtfNote.Background = Brushes.Yellow;
                        break;
                    case 4:
                        rtfNote.Background = Brushes.Green;
                        break;
                    case 5:
                        rtfNote.Background = Brushes.Blue;
                        break;
                    case 6:
                        rtfNote.Background = Brushes.Orange;
                        break;
                    default:
                        break;
                }
            }
        }

        private void CbColorText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox c)
            {
                switch (c.SelectedIndex)
                {
                    case 0:
                        rtfNote.Foreground = Brushes.Black;
                        break;
                    case 1:
                        rtfNote.Foreground = Brushes.White;
                        break;
                    case 2:
                        rtfNote.Foreground = Brushes.Red;
                        break;
                    case 3:
                        rtfNote.Foreground = Brushes.Yellow;
                        break;
                    case 4:
                        rtfNote.Foreground = Brushes.Green;
                        break;
                    case 5:
                        rtfNote.Foreground = Brushes.Blue;
                        break;
                    case 6:
                        rtfNote.Foreground = Brushes.Orange;
                        break;
                    default:
                        break;
                }
            }
        }

        private void RtfNote_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRange MyText = new TextRange(rtfNote.Document.ContentStart, rtfNote.Document.ContentEnd);
            var t = MyText.Text.Trim().Count();
            tbNotes.Text = "Кол-во символов: " + t.ToString();
        }

        private void cmdDateTime_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            rtfNote.AppendText(DateTime.Now.ToString());
        }

    }

    public class MyCommands
    {
        public static RoutedCommand cmdDateTime { get; set; } = new("cmdDateTime", typeof(MainWindow));
    }
}
