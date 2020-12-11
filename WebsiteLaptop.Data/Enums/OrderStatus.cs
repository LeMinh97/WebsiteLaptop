using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebsiteLaptop.Data.Enums
{
    public enum OrderStatus
    {
        [Description("New order")]
        New,
        [Description("In Progress")]
        InProgress,
        [Description("Returned")]
        Returned,
        [Description("Cancelled")]
        Cancelled,
        [Description("Completed")]
        Completed
    }
}
