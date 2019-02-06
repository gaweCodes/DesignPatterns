namespace Builder.LayoutManager
{
    public abstract class LayoutManager
    {
        public HtmlPage HtmlPage { get; }
        protected LayoutManager()
        {
            HtmlPage = new HtmlPage();
        }
        public abstract void AddWidget(Widget widget);
        public abstract void Render();
    }
}
