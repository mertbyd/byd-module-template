using MyCompanyName.MyProjectName.Constants;

namespace MyCompanyName.MyProjectName;

public static class MyProjectNameDbProperties
{
    public static string DbTablePrefix { get; set; } = "MyProjectName";

    public static string? DbSchema { get; set; } = MyProjectNameDatabaseConstants.SchemaName;

    public const string ConnectionStringName = "MyProjectName";
}
