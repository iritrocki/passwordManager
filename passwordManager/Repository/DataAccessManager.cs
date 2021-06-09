using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessManager
    {
        private DataAccessManager(){}

        private static IDataAccess<Category> _dac = null;
        private static IDataAccess<Account> _daa = null;
        private static IDataAccess<CreditCard> _dacc = null;

        public static IDataAccess<Category> GetDataAccessCategory()
        {
            if(_dac == null)
            {
                _dac = new DataAccessCategory();
            }
            return _dac;
        }

        public static IDataAccess<Account> GetDataAccessAccount()
        {
            if (_daa == null)
            {
                _daa = new DataAccessAccount();
            }
            return _daa;
        }

        public static IDataAccess<CreditCard> GetDataAccessCreditCard()
        {
            if (_dacc == null)
            {
                _dacc = new DataAccessCreditCard();
            }
            return _dacc;
        }
    }
}
