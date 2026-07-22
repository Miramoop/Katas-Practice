public class VendingMachine
{
    public decimal changeEntered { get; set; }
    public string selectedProduct { get; set; }
    public string Output { get; set; }
    public decimal returnedChange { get; set; }

    public string SelectProduct(string code)
    {
        if (code == "A01")
        {
            selectedProduct = "Soda";
            return "Soda";
        }

        if (code == "A02")
        {
            selectedProduct = "Chips";
            return "Chips";
        }
        
        if (code == "A03")
        {
            selectedProduct = "Candy";
            return "Candy";
        }
        
        if (code == "A04")
        {
            selectedProduct = "Gum";
            return "Gum";
        }

        return "Invalid Code";
    }

    public string AcceptChange(int change)
    {
        changeEntered += change;
    
        if (selectedProduct == "Soda" && changeEntered >= 100)
        {
            returnedChange = (changeEntered - 100) / 100;
            Output = "Vending Soda";
            if (returnedChange > 0)
            {
                Output = $"Vending Soda: Change {returnedChange:C2}";
            }
            return Output;
        }
        
        if (selectedProduct == "Chips" && changeEntered >= 65)
        {
            Output = "Vending Chips";
            return Output;   
        }
        
        if (selectedProduct == "Candy" && changeEntered >= 85)
        {
            Output = "Vending Candy";
            return Output;   
        }
        
        if (selectedProduct == "Gum" && changeEntered >= 40)
        {
            Output = "Vending Gum";
            return Output;   
        }
        
        return changeEntered.ToString();
    }
} 
