using CarsWebLibrary;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CarDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Car> allCars;
        private Car selectedCar = new Car();
        public MainWindow()
        {
            InitializeComponent();
            GetAllCars();
        }

        private async void GetAllCars()
        {
            allCars = await Services.GetAllCars();
            CarsListView.ItemsSource = allCars;
        }

        private void CarsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count >= 1)
            {
                selectedCar = (Car)e.AddedItems[0];
                CarMake.Text = selectedCar.Make;
                CarModel.Text = selectedCar.Model;
                CarYear.Text = selectedCar.Year.ToString();
                ActionPanel.Visibility = Visibility.Visible;
            }

        }

        private void UpdateActionButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateStackPanel.Visibility = Visibility.Visible;
            UpdateCarMakeTextBox.Text = selectedCar.Make;
            UpdateCarModelTextBox.Text = selectedCar.Model;
            UpdateCarYearTextBox.Text = selectedCar.Year.ToString();
        }

        private void DeleteActionButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteConfirmationStackPanel.Visibility = Visibility.Visible;
        }

        private async void ConfirmDelete_Click(object sender, RoutedEventArgs e)
        {
            var carDeleteResponse = await Services.DeleteCar(selectedCar.ID);
            MessageBox.Show(carDeleteResponse);
            GetAllCars();
            DeleteConfirmationStackPanel.Visibility = Visibility.Hidden;
        }

        private void CancelDeleteAction_Click(object sender, RoutedEventArgs e)
        {
            DeleteConfirmationStackPanel.Visibility = Visibility.Hidden;
        }

        private async void UpdateCarButton_Click(object sender, RoutedEventArgs e)
        {
            var carUpdateModel = new UpdateCar
            {
                Make = UpdateCarMakeTextBox.Text,
                Model = UpdateCarModelTextBox.Text,
                Year = int.Parse(UpdateCarYearTextBox.Text)
            };
            var carUpdateResponse = await Services.UpdateCar(carUpdateModel, selectedCar.ID);
            if (carUpdateResponse != null)
                GetAllCars();
            UpdateStackPanel.Visibility = Visibility.Hidden;
        }

        private void CancelUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateStackPanel.Visibility = Visibility.Hidden;
        }

        private async void AddCarButton_Click(object sender, RoutedEventArgs e)
        {
            var carAddModel = new AddCar
            {
                Make = AddCarMakeTextBox.Text,
                Model = AddCarModelTextBox.Text,
                Year = int.Parse(AddCarYearTextBox.Text)
            };
            var addCarResponse = await Services.AddCar(carAddModel);
            if (addCarResponse != null)
            {
                MessageBox.Show($"{addCarResponse.Make} {addCarResponse.Make} {addCarResponse.Year} has been added.");
                GetAllCars();
            }
        }
    }
}
