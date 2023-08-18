using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public int ProcessType { get; set; }      /* İşlem türü */
        public decimal Amount { get; set; }       /* Ne kadar para gönderildi */
        public DateTime ProcessDate { get; set; } /* İşlemin tarihi */
    }
}
