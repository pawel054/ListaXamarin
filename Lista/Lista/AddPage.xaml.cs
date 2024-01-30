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
        public AddPage(List<TaskClass> list)
        {
            InitializeComponent();
        }

        public AddPage(List<TaskClass> list, TaskClass model)
        {
            InitializeComponent();
        }
    }
}