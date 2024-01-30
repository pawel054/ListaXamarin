using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        private List<TaskClass> list;
        private TaskClass model;
        public AddPage(List<TaskClass> list)
        {
            InitializeComponent();
            this.list = list;
            addButton.IsVisible = true;
            editButton.IsVisible = false;
        }

        public AddPage(List<TaskClass> list, TaskClass model)
        {
            InitializeComponent();
            this.list = list;
            this.model = model;
            entryTitle.Text = model.Title;
            chckImportant.IsChecked = model.Priority == "" ? false : true;

            addButton.IsVisible = false;
            editButton.IsVisible = true;
        }

        private async void AddBtnClicked(object sender, EventArgs e)
        {
            TaskClass task = new TaskClass();
            task.Id = Guid.NewGuid();
            task.Title = entryTitle.Text;
            if (chckImportant.IsChecked)
                task.Priority = "Ważne";
            else
                task.Priority = "";

            list.Add(task);
            JSON.WriteToFile(list);
            await Navigation.PopAsync();
        }
        private async void EditBtnClicked(object sender, EventArgs e)
        {
            model.Title = entryTitle.Text;
            if (chckImportant.IsChecked)
                model.Priority = "Ważne";
            else
                model.Priority = "";

            JSON.WriteToFile(list);
            await Navigation.PopToRootAsync();
        }
    }
}