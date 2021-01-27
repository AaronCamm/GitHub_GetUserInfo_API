using GitHub_UserInfo_API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;

namespace GitHub_UserInfo_API.Data
{
    public class MockCommanderRepo
    {
        private static string avatarLink = "null";
        private static string followerCount = "0";
        private static string reposCount = "0";

        public Command GetCommandByName(string userName)
        {
            using (var client = new WebClient())
            {
                var gitResponse = client.DownloadString($"https://github.com/{userName}");

                avatarLink = Regex.Match(gitResponse, "itemprop=\"image\" href=\"(.*?)s=400").Groups[1].Value.Replace("?", "");
                followerCount = Regex.Match(gitResponse, "text-bold text-gray-dark\" >(.*?)</span>\n          followers").Groups[1].Value;
                reposCount = Regex.Match(gitResponse, "Repositories\n      <span title=\"(.*?)\" class").Groups[1].Value;
            }


            return new Command { UserName = userName, AvatarLink = avatarLink, FollowerCount = followerCount, ReposCount = reposCount };
        }
    }
}
