using DataAccesss.Abstrack;
using DataAccesss.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Concrete
{
    public class MailRepository : IMailRepository
    {
        private readonly KisiselDBContext _dbContext;

        public MailRepository(KisiselDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Mail Createmail(Mail mail)
        {
            _dbContext.Mail.Add(mail);
           
                _dbContext.SaveChanges();
            
          

           
            return mail;
        }

        public List<Mail> getMailList()
        {
            return _dbContext.Mail.ToList();
        }
    }
}
