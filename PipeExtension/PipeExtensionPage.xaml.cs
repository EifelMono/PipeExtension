using EifelMono.Extensions;
using Xamarin.Forms;

namespace PipeExtension
{
    public partial class PipeExtensionPage : ContentPage
    {
        public PipeExtensionPage()
        {
            InitializeComponent();
            #region StackLayout
            Content = new StackLayout
            {
                Children =
                {
                    #region Button
                    new Button
                    {
                        Text= "ButtonX",
                        Margin= new Thickness(5, 10, 5, 5),
                    }.Pipe((b)=>
                    {
                        b.Clicked+= (sender, e) =>
                        {
                            DisplayAlert("Button.Text",b.Text, "Ok");
                        };
                    }),
                    #endregion
                    #region StackLayout
                    new StackLayout {
                        Orientation= StackOrientation.Horizontal,
                        Margin= new Thickness(10)
                    }.Pipe((s)=> {
                        #region Buttons
                        for(var i= 0;i< 5; i++)
                        {
                            s.Children.Add(new Button {
                                Text=$"b{i}",
                                Margin= new Thickness(5)
                            }.Pipe((b)=> {
                                b.Clicked+= (sender, e) =>
                                {
                                    DisplayAlert("Button.Text",b.Text, "Ok");
                                };
                            }));
                        }
                        #endregion
                    })
                    #endregion
                }
            };
            #endregion
        }
    }
}
