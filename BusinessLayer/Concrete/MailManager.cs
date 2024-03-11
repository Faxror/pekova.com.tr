using BusinessLayer.Abstrack;
using DataAccesss.Abstrack;
using DataAccesss.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MailManager : IMailServices
    {
        private readonly IMailRepository mailRepository;
        private readonly KisiselDBContext _dbContext;

        public MailManager(IMailRepository mailRepository, KisiselDBContext dbContext)
        {
            this.mailRepository = mailRepository;
            _dbContext = dbContext;
        }

        public Mail Createmail(Mail mail)
        {
            return mailRepository.Createmail(mail);
             
        }

        public List<Mail> getMailList()
        {
            return mailRepository.getMailList();
            
        }
    }
}
