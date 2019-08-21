using System;
using ByteBee;
using NUnit.Framework;

namespace ByteBeeTests.GuardClause
{
    [TestFixture]
    public class TestAgainstNull
    {
        private class AnyGenericObjectStub { }

        [Test]
        public void When_UseGenericNullObject_Then_ThrowAnException()
        {
            object sut = null;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "object is null");
            Assert.Throws<ArgumentNullException>(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_UseCustomNullObject_Then_ThrowAnException()
        {
            System.Text.StringBuilder sut = null;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "string builder is null");
            Assert.Throws<ArgumentNullException>(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_UseEmptyString_Then_ShouldPass()
        {
            string sut = string.Empty;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "string is empty");
            Assert.DoesNotThrow(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_UseNonEmptyString_Then_ShouldPass()
        {
            string sut = "foobar";
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "string is null");
            Assert.DoesNotThrow(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_UseNullString_Then_ThrowAnException()
        {
            string sut = null;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "string is nul");
            Assert.Throws<ArgumentNullException>(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_UseNullableValueWithNull_Then_ThrowAnException()
        {
            int? sut = null;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "int is null");
            Assert.Throws<ArgumentNullException>(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_UseInitializedObject_Then_ShouldPass()
        {
            var sut = new AnyGenericObjectStub();
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "my stub is null");
            Assert.DoesNotThrow(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_PassingValueType_Then_ShouldPass()
        {
            int sut = 1;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "int is null");
            Assert.DoesNotThrow(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_PassingEmptyGuid_Then_ShouldPass()
        {
            Guid sut = Guid.Empty;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "guid is null");
            Assert.DoesNotThrow(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_PassingDateTime_Then_ShouldPass()
        {
            DateTime sut = DateTime.Now;
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "datetime is null");
            Assert.DoesNotThrow(ExecuteSystemUnderTest);
        }

        [Test]
        public void When_PassingNewObject_Then_ShouldPass()
        {
            object sut = new object();
            void ExecuteSystemUnderTest() => Guard.AgainstNull(sut, "object is null");
            Assert.DoesNotThrow(ExecuteSystemUnderTest);
        }
    }
}