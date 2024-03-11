using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrack
{
    public interface ISenderServices
    {
         Task SenderEmail(string nameandsurname, string email, string subject, string message);
       
    }
}
