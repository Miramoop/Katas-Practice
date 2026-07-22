namespace VendingMachineKata;

public class VendingMachine
{
    public int inputtedChange { get; set; }
    public int extraChange { get; set; }
    public string selectedItem { get; set; }
    public string output { get; set; }
    
    public string Vend(string code)
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
        
        return "Invalid Code";   
    }

    public string CountChange(int change)
    {
        inputtedChange += change;

        if (selectedItem == "Soda" && inputtedChange >= 100)
        {
            extraChange = (inputtedChange - 100) / 100;
            output = "Vending Soda";
            if (extraChange > 0)
            {
                output = $"Vending Soda: Change {extraChange:C2}";
            }
            return output;
        }
        
        if (selectedItem == "Chips" && inputtedChange >= 65)
        {
            output = "Vending Chips";
            return output;
        }
        
        if (selectedItem == "Candy" && inputtedChange >= 85)
        {
            output = "Vending Candy";
            return output;
        }
        
        if (selectedItem == "Gum" && inputtedChange >= 40)
        {
            output = "Vending Gum";
            return output;
        }
        return inputtedChange.ToString();
    }
}