namespace VendingMachineKata;

 public class Item
 {
     public string ItemName { get; set; }
     public decimal Price { get; set; }
     public string Code { get; set; }
     public int Quantity { get; set; }
 }

public class VendingMachine
{
    public decimal changeEntered { get; set; }
    public decimal extraChange { get; set; }
    public string selectedProduct { get; set; }
    public string Output { get; set; }

    public List<Item> items { get; set; } = new List<Item>();

    public VendingMachine()
    {
        var soda = new Item();
        soda.ItemName = "Soda";
        soda.Price = (decimal)1.00;
        soda.Code = "A01";
        soda.Quantity = 10;
        items.Add(soda);
    }
    public string SelectProduct(string code)
    {
        if (code == "A01")
        {
            selectedProduct = "Soda";
        }

        if (code == "A02")
        {
            selectedProduct = "Chips";
        }

        if (code == "A03")
        {
            selectedProduct = "Candy";
        }

        if (code == "A04")
        {
            selectedProduct = "Gum";
        }

        Output = $"Invalid Selection: {code}";
        return Output;
    }

    public string AcceptChange(decimal change)
    {
        changeEntered += change;
        if (selectedProduct == "Soda" && changeEntered >= 100)
        {
            var item = items.FirstOrDefault(x => x.Code == "A01");
            extraChange = (changeEntered - 100) / 100;
            Output = "Vending Soda";
            if (extraChange > 0 && item.Quantity != 0)
            {
                Output = $"Vending Soda: Change {extraChange:C2}";
            }

            if (item.Quantity == 0)
            {
                Output = "Sold Out: Soda";
            }
            item.Quantity--;
            return Output;
        }
        if (selectedProduct == "Soda" && changeEntered < 100)
        {
            extraChange = (changeEntered - 100) / 100;
            Output = "Vending Soda";
            if (extraChange < 0)
            {
                Output = $"Feed me {-extraChange:C2} more";
            }
            return Output;
        }
        if (selectedProduct == "Chips" && changeEntered >= 65)
        {
            extraChange = (change - 65) / 100;
            Output = "Vending Chips";
            if (extraChange > 0)
            {
                Output = $"Vending Soda: Change {extraChange:C2}";
            }
            return Output;
        }
        if (selectedProduct == "Chips" && changeEntered < 65)
        {
            extraChange = (change - 65) / 100;
            Output = "Vending Chips";
            if (extraChange > 0)
            {
                Output = $"Feed me {-extraChange:C2} more";
            }
            return Output;
        }
        if (selectedProduct == "Candy" && changeEntered >= 85)
        {
            extraChange = (change - 85) / 100;
            Output = "Vending Candy";
            if (extraChange > 0)
            {
                Output = $"Vending Soda: Change {extraChange:C2}";
            }
            return Output;
        }
        if (selectedProduct == "Candy" && changeEntered < 85)
        {
            extraChange = (change - 85) / 100;
            Output = "Vending Candy";
            if (extraChange < 0)
            {
                Output = $"Feed me {-extraChange:C2} more";
            }
            return Output;
        }
        if (selectedProduct == "Gum" && changeEntered >= 40)
        {
            extraChange = (change - 40) / 100;
            Output = "Vending Gum";
            if (extraChange > 0)
            {
                Output = $"Vending Soda: Change {extraChange:C2}";
            }
            return Output;
        }
        if (selectedProduct == "Gum" && changeEntered < 40)
        {
            extraChange = (change - 40) / 100;
            Output = "Vending Gum";
            if (extraChange < 0)
            {
                Output = $"Feed me {extraChange:C2} more";
            }
            return Output;
        }
        return change.ToString();
    }
}