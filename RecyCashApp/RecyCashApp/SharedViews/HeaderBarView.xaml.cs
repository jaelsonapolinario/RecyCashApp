using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecyCashApp.SharedViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderBarView : Grid
    {
        public HeaderBarView()
        {
            InitializeComponent();
        }
    }
}