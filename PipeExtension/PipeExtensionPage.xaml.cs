using System.Collections.Generic;
using EifelMono.Extensions;
using Xamarin.Forms;

namespace PipeExtension
{
    public partial class PipeExtensionPage : ContentPage
    {
        List<string> List1 { get; set; } = new List<string>() {
            "List1"
        };
        List<string> List2 = new List<string>().Pipe((l) =>
        {
            for (int i = 1; i <= 2; i++)
                l.Add(new string('2', i));
        });
        List<string> List3 = new List<string>().Pipe((l) =>
        {
            for (int i = 1; i <= 3; i++)
                l.Add(new string('3', i));
        });

        public PipeExtensionPage()
        {
            InitializeComponent();
            #region Vertical StackLayout
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
                    #region Horizontal StackLayout
                    new ScrollView
                    {
                        Orientation= ScrollOrientation.Horizontal,
                        #region Horizontal StackLayout
                        Content=  new StackLayout
                        {
                            Orientation= StackOrientation.Horizontal,
                            Margin= new Thickness(10)
                        }.Pipe((s)=>
                        {
                            #region Buttons
                            for(var i= 0;i< 10; i++)
                            {
                                s.Children.Add(new Button
                                {
                                    Text=$"b{i}",
                                    Margin= new Thickness(5)
                                }.Pipe((b)=>
                                {
                                    b.Clicked+= (sender, e) =>
                                    {
                                        DisplayAlert("Button.Text",b.Text, "Ok");
                                    };
                                }));
                            }
                            #endregion
                        })
                        #endregion
                    },
                    #endregion
                    #region Grid
                    new Grid {
                        ColumnDefinitions= new ColumnDefinitionCollection {
                            new ColumnDefinition {Width= new GridLength(1, GridUnitType.Star)},
                            new ColumnDefinition {Width= new GridLength(1, GridUnitType.Star)},
                            new ColumnDefinition {Width= new GridLength(1, GridUnitType.Star)}
                        },
                        RowDefinitions= new RowDefinitionCollection {
                            new RowDefinition {Height= new GridLength(1, GridUnitType.Star)},
                            new RowDefinition {Height= new GridLength(1, GridUnitType.Star)},
                            new RowDefinition {Height= new GridLength(1, GridUnitType.Star)}
                        },
                        Children= {
                            new Label {
                                Text= "Grid 0.0",
                                HorizontalTextAlignment= TextAlignment.Center,
                                VerticalTextAlignment= TextAlignment.Center
                            }.Pipe((l)=> {
                                Grid.SetRow(l, 0);
                                Grid.SetColumn(l, 0);
                            }),
                            new Label {
                                Text= "Grid 0.1",
                                HorizontalTextAlignment= TextAlignment.Center,
                                VerticalTextAlignment= TextAlignment.Center
                            }.Pipe((l)=> {
                                Grid.SetRow(l, 0);
                                Grid.SetColumn(l, 1);
                            }),
                            new Label {
                                Text= "Grid 0.2",
                                HorizontalTextAlignment= TextAlignment.Center,
                                VerticalTextAlignment= TextAlignment.Center
                            }.Pipe((l)=> {
                                Grid.SetRow(l, 0);
                                Grid.SetColumn(l, 2);
                            }),
                            new Label {
                                Text= "Grid 1.0",
                                HorizontalTextAlignment= TextAlignment.Center,
                                VerticalTextAlignment= TextAlignment.Center
                            }.Pipe((l)=> {
                                Grid.SetRow(l, 1);
                                Grid.SetColumn(l, 0);
                            }),
                            new Label {
                                Text= "Grid 1.1",
                                HorizontalTextAlignment= TextAlignment.Center,
                                VerticalTextAlignment= TextAlignment.Center
                            }.Pipe((l)=> {
                                Grid.SetRow(l, 1);
                                Grid.SetColumn(l, 1);
                            }),
                            new Label {
                                Text= "Grid 1.2",
                                HorizontalTextAlignment= TextAlignment.Center,
                                VerticalTextAlignment= TextAlignment.Center
                            }.Pipe((l)=> {
                                Grid.SetRow(l, 1);
                                Grid.SetColumn(l, 2);
                            })
                        }
                    },
                    #endregion
                    #region ListView
                    new ListView {
                        HeightRequest=50
                    }.Pipe((lv)=> {
                        lv.ItemsSource= new List<string>().Pipe((l)=> {
                            l.AddRange(List1);
                            l.AddRange(List2);
                            l.AddRange(List3);
                        });
                    })
                    #endregion
                }
            };
            #endregion
        }
    }
}
