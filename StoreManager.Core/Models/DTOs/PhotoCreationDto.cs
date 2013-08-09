using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.Models.DTOs
{
    public class PhotoCreationDto : BaseEntity
    {
        public byte[] Avatar { get; set; }
        public byte[] MainPhoto { get; set; }
    }
}
