using IOC.Attribute;

namespace IOC.Editor.Tests.Examples
{
    public class MyTestClass
    {
        [Inject] public MyTestDependency Dependency { get; set; } = null;
    }
}