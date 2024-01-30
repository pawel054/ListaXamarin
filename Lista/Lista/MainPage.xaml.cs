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
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage(tasks));
        }

        private void EditBtnClicked(object sender, EventArgs e)
        {

        }

        private void DeleteBtnClicked(object sender, EventArgs e)
        {

        }
    }
}
