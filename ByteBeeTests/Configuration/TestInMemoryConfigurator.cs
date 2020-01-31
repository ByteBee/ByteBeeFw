using System;
using System.IO;
using ByteBee.Configuration;
using ByteBee.Configuration.Impl;
using NUnit.Framework;

namespace ByteBeeTests.Configuration
{
    [TestFixture]
    public class TestInMemoryConfigurator
    {
        [Test]
        public void TestSettingStringValueIntoTheConfig()
        {
            IConfigurationStore store = new InMemoryConfigurationStore();
            IConfigurationManager config = new ConfigurationManager(store);
            config.Set("global", "foo", "bar");
        }


        [Test]
        public void TestGettingKnownValueFromConfig()
        {
            IConfigurationStore store = new InMemoryConfigurationStore();
            IConfigurationManager config = new ConfigurationManager(store);

            config.Set("global", "foo", "bar");

            var bar = config.Get<string>("global", "foo");

            Assert.AreEqual("bar", bar);
        }

        [Test]
        public void ReloadConfigShouldRemainTheSame()
        {
            IConfigurationStore store = new InMemoryConfigurationStore();
            IConfigurationManager config = new ConfigurationManager(store);

            config.Set("global", "foo", "bar");

            config.Save();
            config.Load();

            var bar = config.Get<string>("global", "foo");

            Assert.AreEqual("bar", bar);
        }

        [Test]
        public void LoadTheConfigShouldRestoreLastSavedState()
        {
            IConfigurationStore store = new InMemoryConfigurationStore();
            IConfigurationManager config = new ConfigurationManager(store);

            config.Set("global", "foo", "bar");

            config.Save();

            config.Set("global", "foo", "foobar");

            config.Load();

            var bar = config.Get<string>("global", "foo");

            Assert.AreEqual("bar", bar);
        }

        [Test]
        public void SaveOptionsToFileShouldBeWrittenInExpectedFormat()
        {
            string pathToConfig = "test.ini";
            IConfigurationStore store = new StandardConfigurationStore(pathToConfig);
            IConfigurationManager config = new ConfigurationManager(store);
            config.Set("global", "foo", "bar");

            config.Save();

            string configContent = File.ReadAllText(pathToConfig);
            File.Delete(pathToConfig);

            Assert.AreEqual("[global]\r\nfoo = bar\r\n\r\n", configContent);
        }

        [Test]
        public void TestLoadConfigurationShouldProvideGoodValues()
        {
            string fileContent =
                @"[global]
                foo = bar

                ; this is a comment
                [test2]
                item1 = 'value1'
                item2 = value2
                ; this is a comment
                item3 = value3      ; this is a comment
                item4 = value4      # this is a comment
                number = 42";

            string pathToConfig = "test.ini";
            File.WriteAllText(pathToConfig, fileContent);

            IConfigurationStore store = new StandardConfigurationStore(pathToConfig);
            IConfigurationManager config = new ConfigurationManager(store);

            config.Load();
            File.Delete(pathToConfig);

            Assert.AreEqual("bar", config.Get<string>("global", "foo"));
            Assert.AreEqual("value1", config.Get<string>("test2", "item1"));
            Assert.AreEqual("value2", config.Get<string>("test2", "item2"));
            Assert.AreEqual("value3", config.Get<string>("test2", "item3"));
            Assert.AreEqual("value4", config.Get<string>("test2", "item4"));
            Assert.AreEqual(42, config.Get<int>("test2", "number"));
        }

        [Test]
        public void TestWithMyOwnConfig()
        {
            string fileContent =
                @"[MyConfig]
                Name = TestCase
                Treshold = 42
                Expires = 2020-06-04";

            string pathToConfig = "test.ini";
            File.WriteAllText(pathToConfig, fileContent);

            IConfigurationStore store = new StandardConfigurationStore(pathToConfig);
            IConfigurationManager config = new ConfigurationManager(store);
            config.Load();

            var cfg = config.GetConfig<MyConfig>();

            File.Delete(pathToConfig);

            Assert.AreEqual("TestCase", cfg.Name);
            Assert.AreEqual(42, cfg.Treshold);
            Assert.AreEqual(new DateTime(2020, 06, 04), cfg.Expires);
        }
    }
}