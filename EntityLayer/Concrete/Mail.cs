using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mail
    {
        [Key]
        public int İd { get; set; }

        public string NameandSurname { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }

    }
}
