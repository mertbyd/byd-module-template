using Byd.ModuleTemplate.Constants;

namespace Byd.ModuleTemplate;

public static class ModuleTemplateDbProperties
{
    public static string DbTablePrefix { get; set; } = "ModuleTemplate";

    public static string? DbSchema { get; set; } = ModuleTemplateDatabaseConstants.SchemaName;

    public const string ConnectionStringName = "ModuleTemplate";
}
