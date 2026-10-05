using System;

namespace MyCompanyName.MyProjectName.Constants;

public static class MyProjectNameDatabaseConstants
{
    public static string SchemaName { get; } = "MyProjectName".ToSnakeCase();
}
