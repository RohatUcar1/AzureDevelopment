namespace AzureAdGroupReader
{
    public class AadGroupMember
    {
        public string ObjectId { get; set; }
        public string Name { get; set; }
        public string UserPrincipalName { get; set; }
        public string Email { get; set; } //UserPrincipalName
    }
}