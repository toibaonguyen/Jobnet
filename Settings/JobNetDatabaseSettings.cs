namespace JobNet.Settings;
public class JobNetDatabaseSettings
{
    public string ConnectionString { get; set; } = string.Empty;

    public string UsersTableName { get; set; } = string.Empty;
    public string PostsTableName { get; set; } = string.Empty;
    public string MessagesTableName { get; set; } = string.Empty;
    public string JobPostsTableName { get; set; } = string.Empty;
    public string IndustriesTableName { get; set; } = string.Empty;
    public string GroupsTableName { get; set; } = string.Empty;
    public string ExperiencesTableName { get; set; } = string.Empty;
    public string EducationsTableName { get; set; } = string.Empty;
    public string CompanyPostsTableName { get; set; } = string.Empty;
    public string CompaniesTableName { get; set; } = string.Empty;
    public string CommentsTableName { get; set; } = string.Empty;
    public string CertificationsTableName { get; set; } = string.Empty;
    public string AdminAccountsTableName { get; set; } = string.Empty;
    public string CompanyPostComment { get; set; } = string.Empty;
}