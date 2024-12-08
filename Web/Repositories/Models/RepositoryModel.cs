namespace Repositories.Models;

public class RepositoryModel
{
    public Guid Id { get; set; }

    public IndexJsonModel Index { get; set; }

    public string IndexMd { get; set; }

    public dynamic Instructions { get; set; }

    public string License { get; set; }

    public string CodeOfConduct { get; set; }
}