using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomLayoutPage.Client.Models
{
    public class UserLayout : IUserLayout
    {
        private StartupLayout option;
        public UserLayout(IOptions<StartupLayout> option)
        {
            this.option = option.Value;
        }

        public Type GetLayoutType()
        {
            return Type.GetType(option.Layout);
        }
    }
}
