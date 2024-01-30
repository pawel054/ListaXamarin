using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lista
{
    public partial class MainPage : ContentPage
    {
        List<TaskClass> tasks = new List<TaskClass>();
        protected override void OnAppearing()
        {
            base.OnAppearing();
            UpdateList();
        }

        public MainPage()
        {
            InitializeComponent();
            UpdateList();
        }

        private void AddBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage(tasks));
        }

        private void EditBtnClicked(object sender, EventArgs e)
        {
            if(lista.SelectedItem != null)
            {
                if (lista.SelectedItem is TaskClass model)
                    Navigation.PushAsync(new AddPage(tasks, model));

                lista.SelectedItem = null;
            }
            else
            {
                DisplayAlert("Alert", "Nie wybrano elementu!", "OK");
            }
        }

        private void DeleteBtnClicked(object sender, EventArgs e)
        {
            if(lista.SelectedItem != null)
            {
                if (lista.SelectedItem is TaskClass model)
                {
                    tasks.Remove(model);
                    JSON.WriteToFile(tasks);
                    UpdateList();
                }
                lista.SelectedItem = null;
            }
            else
            {
                DisplayAlert("Alert", "Nie wybrano elementu!", "OK");
            }

        }

        private void UpdateList()
        {
            tasks = JSON.GetFromFile();
            lista.ItemsSource = tasks;
        }
    }
}
