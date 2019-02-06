using System.Diagnostics;
using System.Net.Mail;

namespace Composite
{
    public class BpmMailNotification : BpmComponent
    {
        private string _to;
        private string _from;
        private string _subject;
        private string _text;
        public BpmMailNotification(int id, string to, string from, string subject, string text) : base(id)
        {
            _to = to;
            _from = from;
            _subject = subject;
            _text = text;
        }
        public override void Draw()
        {
            Debug.Print("Draw the control");
        }
        public override void Start()
        {
            var client = new SmtpClient("localhost");
            client.Send(_from, _to, _subject, _text);
        }
    }
}
