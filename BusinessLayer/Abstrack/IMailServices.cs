using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrack
{
    public interface IMailServices 
    {
        List<Mail> getMailList();

        Mail Createmail(Mail mail);
    }
}
