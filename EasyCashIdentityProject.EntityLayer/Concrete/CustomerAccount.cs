using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }      /* Müşteri hesap numarası */
        public string CustomerAccountCurrency { get; set; }    /* Hesabın döviz değeri */
        public decimal CustomerAccountBalance { get; set; }    /* Hesabın bakiyesi */
        public string BankBranch { get; set; }                 /* Hesabın bulunduğu banka şubesi */
    }
}
