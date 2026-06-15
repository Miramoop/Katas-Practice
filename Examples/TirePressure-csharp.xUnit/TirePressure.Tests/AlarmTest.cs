using TirePressure_csharp.xUnit;

namespace TirePressure.Tests
{
    public class AlarmTest
    {
        [Fact]
        public void AlarmIsOffByDefault()
        {
            Alarm alarm = new Alarm();
            Assert.False(alarm.AlarmOn);
        }
    }
}