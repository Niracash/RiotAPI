using RiotAPI.Controller;
using RiotAPI.View;
using RiotAPI.View.ViewModel;
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

namespace RiotAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainController controller;
        MainViewModel viewModel;
        public MainWindow()
        {
            controller = new MainController();
            viewModel = new MainViewModel();
            InitializeComponent();

            this.DataContext=viewModel;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Region))
            {
                return;
            }
            if (string.IsNullOrEmpty(viewModel.SummonerName))
            {
                return;
            }

            if(controller.GetSummoner(viewModel.SummonerName))
            {
                ProfileWindow profile = new ProfileWindow();
                profile.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Somethings wrong");
            }


        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
