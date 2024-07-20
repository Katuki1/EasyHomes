using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LykEasy.Domain.Entities.Housing
{
    public class BaseHousing
    {
        
        public string? CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }

        public string? ModifiedBy { get; set; }
        public char ModifiedFlag { get; set; } = 'N';
        public DateTime ModifiedTime { get; set; }

        public string? DeletedBy { get; set; }
        public char DeletedFlag { get; set; } = 'N';
        public DateTime DeletedTime { get; set; }
    }
}
