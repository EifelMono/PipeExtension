# EifelMono.Extensions (Pipe)

## THE PIPE Extension or write your code where you need it!

Get the Extension from EifelMono.Extensions 

* [NuGet](https://www.nuget.org/packages/EifelMono.Extensions)

* [GitHub](https://github.com/EifelMono/EifelMono.Extensions)

or add this to your code!
```c#
namespace EifelMono.Extensions
{
    public static class GenericExtensions
    {
        public static T Pipe<T>(this T pipe, Action<T> action)
        {
            action(pipe);
            return pipe;
        }
    }
}
```

## Samples

### Pipeping with void functions
```c#
List<string> list1 = new List<string>
                            {
                                "list1.1",
                                "list1.2"
                            }
                            .Pipe(p => p.Add("list1.3"))
                            .Pipe(p => p.RemoveAt(0));

List<string> list2 = new List<string>
                            {
                                "Hello World",
                            }
                            .Pipe((p) =>
                            {
                                for (var i = 0; i < 10; i++)
                                    p.Add($"list2.{i} {DateTime.Now}");
                            }); 
```

### Pipeping with Xamarin.Forms
```c#
Content = new StackLayout
{
    Children =
    {
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
        })
    }
}
```

### For more see Sample's on Unit Test on [GitHub](https://github.com/EifelMono/EifelMono.Extensions)

