namespace SecondModule;

public static class SecondModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "SecondModule";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "SecondModule";
}
