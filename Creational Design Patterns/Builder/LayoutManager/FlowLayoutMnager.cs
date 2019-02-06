namespace Builder.LayoutManager
{
    public class FlowLayoutManager : LayoutManager
    {
        public override void AddWidget(Widget widget)
        {
            HtmlPage.GetWidgets().Add(widget);
        }
        public override void Render()
        {
            HtmlPage.HtmlCode = RenderHtmlFromWidgets();
        }
        private static string RenderHtmlFromWidgets()
        {
            return "HTML Code for FlowLayout.";
        }
    }
}
