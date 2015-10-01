using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLMNFCPrototype
{
    class Connection
    {
        public string Connect = @"Data Source=.\SQL2012;Initial Catalog=NFCProject;Persist Security Info=True;MultipleActiveResultSets=True;User ID=sa;Password=admin@sql2012";
        public string ConnectionString
        {
            get
            {
                return Connect;
            }//get
        }//ConnectionString
    }//Connection
}//namespace