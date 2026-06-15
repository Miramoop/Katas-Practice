namespace _100DoorsKataBase;

public class _100Doors
{
    public List<bool> Doors { get; set; } = new List<bool>(new bool[100]);

    public void ToggleAllDoors()
    {
        for (int i = 0; i < 100; i++)
        {
            Doors[i] = true;
        }
    }
    
    public void ToggleAllDoors(int pass)
    {
        for (int i = 0; i < 100; i += pass)
        {
            Doors[i] = false;
        }
    }
}