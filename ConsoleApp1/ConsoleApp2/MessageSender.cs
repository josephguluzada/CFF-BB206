using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MessageSender
    {
        Email _email;
        Sms _sms;

        public MessageSender(Email email, Sms sms)
        {
            _email = email;
            _sms = sms;
        }

        public void Send()
        {
            _email.Send();
            _sms.Send();
        }
    }
}
