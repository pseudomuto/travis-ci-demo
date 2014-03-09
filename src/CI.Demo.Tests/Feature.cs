using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;
using Should.Core;
using Should.Fluent;

namespace CI.Demo.Tests
{
    public class Feature
    {
        public class Constructor
        {
            [Fact]
            public void ValidatesNameIsNotNull()
            {
                Assert.Throws<ArgumentNullException>(() =>
                {
                    new Demo.Feature(null);
                });
            }

            [Fact]
            public void ValidatesNameIsNotEmpty()
            {
                Assert.Throws<ArgumentNullException>(() =>
                {
                    new Demo.Feature("");
                });
            }

            [Fact]
            public void StoreTheNameInLowercase()
            {
                var subject = new Demo.Feature("My UPPERcase Feature");
                subject.Name.Should().Equal("my uppercase feature");
            }

            [Fact]
            public void ABrokenTestWillNotCommit()
            {
                "Broken".Should().Not.Equal("Committed");
            }
        }
    }
}
