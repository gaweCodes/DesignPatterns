using System;
using System.Collections.Generic;
using Builder.LayoutManager;

namespace Builder
{
    public class Layouter
    {
        private readonly List<Widget> _widgets;
        private HtmlPage _htmlPage;
        public Layouter(List<Widget> widgets)
        {
            _widgets = widgets;
        }
        public void DoLayout(LayoutManager.LayoutManager layoutManager)
        {
            _widgets.ForEach(layoutManager.AddWidget);
            layoutManager.Render();
            _htmlPage = layoutManager.HtmlPage;
        }
        public void PrintHtmlLayoutCode()
        {
            Console.WriteLine("HTML: " + _htmlPage.HtmlCode);
        }
    }
}
