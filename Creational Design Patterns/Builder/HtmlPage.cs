using System.Collections.Generic;
using Builder.LayoutManager;

namespace Builder
{
    public class HtmlPage
    {
        private readonly List<Widget> _widgets = new List<Widget>();
        public string HtmlCode { get; set; }
        public List<Widget> GetWidgets()
        {
            return _widgets;
        }
    }
}
