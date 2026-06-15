using _100DoorsKataBase;

namespace _100DoorsKataTests;

public class _100DoorsKataTests
{
    [Fact]
    public void Doors_CheckFor100DoorsInList()
    {
        var doors = new _100Doors();
        Assert.Equal(100, doors.Doors.Count);
    }

    [Fact]
    public void Doors_CheckAllDoorsFalse()
    {
        var doors = new _100Doors();
        Assert.Equal(true, doors.Doors.All(x => x == false));
    }

    [Fact]
    public void Doors_ToggleAllDoors()
    {
        var doors = new _100Doors();
        Assert.Equal(true, doors.Doors.All(x => x == false));

        doors.ToggleAllDoors();
        Assert.Equal(true, doors.Doors.All(x=> x == true));
    }

    [Fact]
    public void Doors_GivenPass2_EverySecondDoorShouldBeClosed()
    {
        var doors = new _100Doors();
        doors.ToggleAllDoors(2);
        Assert.Equal(false, doors.Doors[1]);
        Assert.Equal(false, doors.Doors[3]);
    }

    [Fact]
    public void Doors_GivenPass3_EveryThirdDoorShouldBeToggled()
    {
        var doors = new _100Doors();
        doors.ToggleAllDoors(3);
        Assert.Equal(false, doors.Doors[2]);
        Assert.Equal(false, doors.Doors[5]);
    }
}