using AzureAdGroupReader;
using System;

namespace AzureActiveDirectoryUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupReader = new AADGroupReader();

            var groupName = "my-aad-group";
            var groupTransitiveMembers = groupReader.GetGroupMembers(groupName);
        }

    }


}
