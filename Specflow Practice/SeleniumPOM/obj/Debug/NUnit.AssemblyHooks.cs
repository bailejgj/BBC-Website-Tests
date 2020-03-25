using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;

[GeneratedCode("SpecFlow", "3.1.89")]
[SetUpFixture]
public class SeleniumPOM_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(SeleniumPOM_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(SeleniumPOM_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
