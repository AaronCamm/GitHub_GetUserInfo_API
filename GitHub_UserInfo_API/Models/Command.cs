using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHub_UserInfo_API.Models
{
    public class Command
    {
        public string UserName { get; set; }
        public string FollowerCount { get; set; }
        public string AvatarLink { get; set; }
        public string ReposCount { get; set; }
    }
}
