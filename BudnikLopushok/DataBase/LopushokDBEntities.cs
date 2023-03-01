using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudnikLopushok.DataBase
{
    public partial class LopushokDBEntities
    {
        private static LopushokDBEntities context;
        public static LopushokDBEntities GetContext()
        {
            if (context == null)
                context = new LopushokDBEntities();
            return context;
        }
    }
}
