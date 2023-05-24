using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(string message="No data found in the database"):base(message) { }
    }
}
