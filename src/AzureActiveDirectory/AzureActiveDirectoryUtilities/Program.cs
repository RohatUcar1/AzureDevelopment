using AzureAdGroupReader;
using System;

namespace AzureActiveDirectoryUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupReader = new AADGroupReader();

            var groupName = "testaddgroup";
            var groupTransitiveMembers = groupReader.GetGroupMembers(groupName);
        }

    }


}
