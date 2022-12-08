﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TestProject;

[Dependency(ReplaceServices = true)]
public class TestProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestProject";
}
