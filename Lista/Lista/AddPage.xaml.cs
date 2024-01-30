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
        List<TaskClass> list;
        TaskClass model;
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

        private void AddBtnClicked(object sender, EventArgs e)
        {

        }
        private void EditBtnClicked(object sender, EventArgs e)
        {

        }
    }
}