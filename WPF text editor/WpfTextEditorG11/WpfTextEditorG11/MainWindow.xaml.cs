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

namespace WpfTextEditorG11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Undo(object sender, RoutedEventArgs e)
        {
            RTBeditor.Undo();
        }

        private void Redo(object sender, RoutedEventArgs e)
        {
            RTBeditor.Redo();
        }

        private void Cut(object sender, RoutedEventArgs e)
        {
            RTBeditor.Cut();
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            RTBeditor.Copy();
        }

        private void Paste(object sender, RoutedEventArgs e)
        {
            RTBeditor.Paste();
        }


        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Group11 Naresuan University\nComputer Engineering", "About");
            MessageBox.Show("Contact mail: Nutdanaij59@email.nu.ac.th", "Contact");
        }

       

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)25);
            
            
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RTBeditor.SelectAll();
            RTBeditor.Selection.Text = "";
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            var size = (double)allTextRange.GetPropertyValue(FontSizeProperty);

            allTextRange.ApplyPropertyValue(RichTextBox.FontSizeProperty, size + 5);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            var size = (double)allTextRange.GetPropertyValue(FontSizeProperty);

            allTextRange.ApplyPropertyValue(RichTextBox.FontSizeProperty, size - 5);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(RichTextBox.FontWeightProperty, FontWeights.Bold);

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange1 = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange1.ApplyPropertyValue(RichTextBox.FontWeightProperty, FontWeights.Normal);
        }

       



        

        private void TextSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = 0;
            if (Int32.TryParse(TextSize.Text, out value))
            {
                value = int.Parse(TextSize.Text);
                TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
                tr.ApplyPropertyValue(FontSizeProperty, (double)value);
            }
        }

        
        private void MenuItem_Click_19(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)5);
        }

        private void MenuItem_Click_20(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)8);
        }

        private void MenuItem_Click_21(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)11);
        }

        private void MenuItem_Click_22(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)12);
        }

        private void MenuItem_Click_23(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)14);
        }

        private void MenuItem_Click_24(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)16);
        }

        private void MenuItem_Click_25(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)18);
        }

        private void MenuItem_Click_26(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)20);
        }

        private void MenuItem_Click_27(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)25);
        }

        private void MenuItem_Click_28(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)30);
        }

        private void MenuItem_Click_29(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)36);
        }

        private void MenuItem_Click_30(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)56);
        }

        private void MenuItem_Click_31(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)72);
        }

        private void MenuItem_Click_32(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
            tr.ApplyPropertyValue(FontSizeProperty, (double)120);
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
        }


        private void MenuItem_Click_16(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Purple);
        }

        private void MenuItem_Click_33(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Yellow);
        }

        private void MenuItem_Click_34(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Green);
        }

        private void MenuItem_Click_35(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Pink);
        }

        private void MenuItem_Click_36(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Brown);
        }

        private void MenuItem_Click_37(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Orange);
        }

        private void MenuItem_Click_38(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.White);
        }

        private void MenuItem_Click_39(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);
        }

        private void MenuItem_Click_40(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Red);
        }

        private void MenuItem_Click_41(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.White);
        }

        private void MenuItem_Click_42(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Yellow);
        }

        private void MenuItem_Click_43(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Green);
        }

        private void MenuItem_Click_44(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Pink);
        }

        private void MenuItem_Click_45(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Brown);
        }

        private void MenuItem_Click_46(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Purple);
        }

        private void MenuItem_Click_47(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Orange);
        }

        private void MenuItem_Click_48(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);

            allTextRange.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Black);
        }

       

        private void MenuItem_Click_50(object sender, RoutedEventArgs e)
        {
            RTBeditor.FontFamily = new FontFamily("Superspace Bold");
        }

        private void MenuItem_Click_51(object sender, RoutedEventArgs e)
        {
            RTBeditor.FontFamily = new FontFamily("TH SarabunPSK");
        }

        private void MenuItem_Click_52(object sender, RoutedEventArgs e)
        {
           

            RTBeditor.FontFamily = new FontFamily("Arial");

        }

        private void NewFile(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Would you like to save ?", "Warning", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var dialog = new Microsoft.Win32.SaveFileDialog();
                dialog.Filter = "Text File(*txt)|*.txt|Allfile(*.*)|*.*";
                dialog.FileName = "File.txt";
                if (dialog.ShowDialog() == true)
                {
                    using (var stream = dialog.OpenFile())
                    {
                        var range = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
                        range.Save(stream, DataFormats.Text);
                    }
                }


            }
            else
            {
                RTBeditor.SelectAll();
                RTBeditor.Selection.Text = "";
            }
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Text file(*txt)|*.txt|Allfile(*.*)|*.*";
            dialog.FileName = "*.txt";
            if (dialog.ShowDialog() == true)
            {
                using (var stream = dialog.OpenFile())
                {
                    var range = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
                    range.Load(stream, DataFormats.Text);
                }
            }
        }

        private void SaveFile(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.Filter = "Text File(*txt)|*.txt|Allfile(*.*)|*.*";
            dialog.FileName = "File.txt";
            if (dialog.ShowDialog() == true)
            {
                using (var stream = dialog.OpenFile())
                {
                    var range = new TextRange(RTBeditor.Document.ContentStart, RTBeditor.Document.ContentEnd);
                    range.Save(stream, DataFormats.Text);
                }
            }
        }
    }
}
