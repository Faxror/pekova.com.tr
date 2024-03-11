using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Abstrack
{
    public interface IMailRepository
    {
        List<Mail> getMailList();

        Mail Createmail(Mail mail);
        
    }
}
