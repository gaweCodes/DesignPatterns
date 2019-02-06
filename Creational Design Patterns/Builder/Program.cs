using System;
using System.Collections.Generic;
using Builder.LayoutManager;

namespace Builder
{
    internal class Program
    {
        private static void Main()
        {
            const string widgetHtmlCode = "Widget HTML Code";
            var widgets = new List<Widget>();
            for (var index = 0; index < 5; index++)
                widgets.Add(new Widget(widgetHtmlCode));
            var layouter = new Layouter(widgets);
            layouter.DoLayout(new BorderLayoutManager());
            layouter.PrintHtmlLayoutCode();
            layouter.DoLayout(new BoxLayoutManager());
            layouter.PrintHtmlLayoutCode();
            layouter.DoLayout(new FlowLayoutManager());
            layouter.PrintHtmlLayoutCode();
            Console.ReadLine();
        }
    }
}
