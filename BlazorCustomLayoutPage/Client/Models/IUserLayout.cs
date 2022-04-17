using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomLayoutPage.Client.Models
{
    public interface IUserLayout
    {
        Type GetLayoutType();
    }
}
