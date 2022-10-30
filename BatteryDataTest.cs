using System.Collections.Generic;
using Xunit;

namespace nameSpace
{

        public class BatteryDataTest
        {
            [Fact]
            public void TestGenerateBatteryData()
            {
                var sampleData = new List<int>();
                sampleData = BatteryData.GenerateBatteryData(5, 2, 26);
                Assert.True(sampleData.Count == 5);
            }

            [Fact]
            public void TestFormatData()
            {
                var formatData = BatteryData.FormatData(1, "SOC", 6, "Temperature", 23);
                Assert.True(formatData == "{Sample_no=1, SOC=6, Temperature=23}");
            }

        }
}
