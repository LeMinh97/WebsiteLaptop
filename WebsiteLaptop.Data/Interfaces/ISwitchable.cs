using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Enums;

namespace WebsiteLaptop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
