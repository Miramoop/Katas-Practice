namespace VendingMachineKata;

public class VendingMachine
{
    public int changeEntered { get; set; }
    public string selectedItem { get; set; }
    public string output { get; set; }
    public int returnedChange { get; set; }
    
    public string SelectItem(string code)
    {
        if (code == "A01")
        {
            selectedItem = "Soda";
            return "Soda";
        }
        
        if (code == "A02")
        {
            selectedItem = "Chips";
            return "Chips";
        }
        
        if (code == "A03")
        {
            selectedItem = "Candy";
            return "Candy";
        }
        
        if (code == "A04")
        {
            selectedItem = "Gum";
            return "Gum";
        }

        return "Invalid Code Entered";
    }

    public string InputChange(int change)
    {
        changeEntered += change;

        if (selectedItem == "Gum" && changeEntered >= 40)
        {
            output = "Vending Gum";
            returnedChange = changeEntered - 40;
        }
        
        if (selectedItem == "Candy" && changeEntered >= 85)
        {
            output = "Vending Candy";
            returnedChange = changeEntered - 85;
        }
        
        if (selectedItem == "Chips" && changeEntered >= 65)
        {
            output = "Vending Chips";
            returnedChange = changeEntered - 65;
        }
        
        if (selectedItem == "Soda" && changeEntered >= 100)
        {
            output = "Vending Soda";
            returnedChange = changeEntered - 100;
            if (changeEntered > 100)
            {
                output = "Vending Soda: Change $0.25";
            }
        }
        
        return changeEntered.ToString();
        
    }
}