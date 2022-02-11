using IOC.Interface;
using NUnit.Framework;

namespace IOC.Editor.Tests
{
    public class IOCContainerRegisterTests
    {
        [Test]
        public void Register_RegisterSameType_True()
        {
            var iocContainer = new IOCContainer() as IIOCContainer;
            iocContainer.Register<IOCContainer>();
            iocContainer.Register<IOCContainer>();

            Assert.IsTrue(true);
        }
    }
}