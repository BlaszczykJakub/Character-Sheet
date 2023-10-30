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
using CharacterSheet_Rework.ViewModels;
using Microsoft.Win32;

namespace CharacterSheet_Rework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // File Dialogs
        SaveFileDialog saveFileDialog = new();
        OpenFileDialog openFileDialog = new();


        // View Model
        private CharacterViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new CharacterViewModel();
            _viewModel.ArmorProf.Add("Light");
            _viewModel.ArmorProf.Add("Heavy");
            _viewModel.ArmorProf.Add("Cloth");
            this.DataContext = _viewModel;
        }

        private void SaveCharacter(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == true)
            {
                _viewModel.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void LoadCharacter(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    this.DataContext = null;
                    var temp = CharacterViewModel.LoadFromFile(openFileDialog.FileName);

                    if (temp != null)
                        _viewModel = temp;

                    this.DataContext = _viewModel;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }

            saveFileDialog.FileName = openFileDialog.FileName;
        }
    }
}
