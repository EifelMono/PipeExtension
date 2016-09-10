<H1>EifelMono.Extensions</H1>

<H2>Sample Pipe Extension</H2>

Pipe Pipeping of void functions
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

    List<string> list3 = new List<string>
                    {   
                        "list3.1",
                        "list3.2",
                    }
                    .Pipe(p => p.AddRange(list1));                   

```


<h3>For more see Sample's and Unit Test</h3>

