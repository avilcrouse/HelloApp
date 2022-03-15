using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label1 = new Label()
            {
                Text = "Кофанов Кирилл Алексеевич",
                FontSize = 18,
                TextColor = Color.Black
            };
            Label label2 = new Label()
            {
                Text = "Студент группы ПКС-31",
                FontSize = 18,
                TextColor = Color.Black
            };

            Image1.Source = ImageSource.FromResource("HelloApp.Images.srt.jpg");

            Label label3 = new Label()
            {
                Text = "Люблю играть в волейбол.",
                FontSize = 18,
                TextColor = Color.Black
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2, label3, Image1 }
            };
            stackLayout.Spacing = 8;
            this.Content = stackLayout;
            stackLayout.Orientation = StackOrientation.Horizontal;

        }

    }
}


