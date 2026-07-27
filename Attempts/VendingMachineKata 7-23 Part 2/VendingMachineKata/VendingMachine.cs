using System.Runtime.InteropServices.ComTypes;

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
    public decimal ChangeEntered { get; set; }
    
    public string Output { get; set; } = "Welcome";
    public string SelectedItem { get; set; } = "Invalid Code";
    public List<Item> Items { get; set; } = new List<Item>();

    public VendingMachine()
    {
        var soda = new Item
        {
            ItemName = "Soda",
            Price = (decimal)1.00,
            Code = "A01",
            Quantity = 10
        };
        Items.Add(soda);

        var chips = new Item
        {
            ItemName = "Chips",
            Price = (decimal)0.65,
            Code = "A02",
            Quantity = 12
        };
        Items.Add(chips);

        var candy = new Item
        {
            ItemName = "Candy",
            Price = (decimal)0.85,
            Code = "A03",
            Quantity = 8,
        };
        Items.Add(candy);

        var gum = new Item
        {
            ItemName = "Gum",
            Price = (decimal)0.40,
            Code = "A04",
            Quantity = 3
        };
        Items.Add(gum);
    }
    public void Vend(string code)
    {
        SelectedItem = code switch
        {
            "A01" => "Soda",
            "A02" => "Chips",
            "A03" => "Candy",
            "A04" => "Gum",
            _ => $"Invalid Selection: {code}"
        };
    }

    public void EnterChange(int change)
    {
        ChangeEntered += change;
        decimal extraChange;
        decimal insufficientChange;
        
        if (SelectedItem == "Soda" && ChangeEntered >= 100)
        {
            var item = Items.FirstOrDefault(x => x.Code == "A01");
            if (item.Quantity > 0)
            {
                Output = "Vending Soda";
                extraChange = (ChangeEntered - 100) / 100;
                if (extraChange > 0)
                {
                    Output = $"Vending Soda: Change {extraChange:C2}";
                }
                item.Quantity--;
            }
            else
            {
                Output = "Sold Out: Soda";
            }
        }
        if (SelectedItem == "Soda" && ChangeEntered < 100)
        {
            insufficientChange = (100 - ChangeEntered) / 100;
            Output = $"Feed me {insufficientChange:C2} more";
        }
        if (SelectedItem == "Chips" && ChangeEntered >= 65)
        {
            var item = Items.FirstOrDefault(x => x.Code == "A02");
            if (item.Quantity > 0)
            {
                Output = "Vending Chips";
                extraChange = (ChangeEntered - 65) / 100;
                if (extraChange > 0)
                {
                    Output = $"Vending Chips: Change {extraChange:C2}";
                }
                item.Quantity--;
            }
            else
            {
                Output = "Sold Out: Chips";
            }
        }
        if (SelectedItem == "Chips" && ChangeEntered < 65)
        {
            insufficientChange = (65 - ChangeEntered) / 100;
            Output = $"Feed me {insufficientChange:C2} more";
        }
        if (SelectedItem == "Candy" && ChangeEntered >= 85)
        {
            var item = Items.FirstOrDefault(x => x.Code == "A03");
            if (item.Quantity > 0)
            {
                Output = "Vending Candy";
                extraChange = (ChangeEntered - 85) / 100;
                if (extraChange > 0)
                {
                    Output = $"Vending Candy: Change {extraChange:C2}";
                }
                item.Quantity--;
            }
            else
            {
                Output = "Sold Out: Candy";
            }
        }
        if (SelectedItem == "Candy" && ChangeEntered < 85)
        {
            insufficientChange = (85 - ChangeEntered) / 100;
            Output = $"Feed me {insufficientChange:C2} more";
        }
        if (SelectedItem == "Gum" && ChangeEntered >= 40)
        {
            var item = Items.FirstOrDefault(x => x.Code == "A04");
            if (item.Quantity > 0)
            {
                Output = "Vending Gum";
                extraChange = (ChangeEntered - 40) / 100;
                if (extraChange > 0)
                {
                    Output = $"Vending Gum: Change {extraChange:C2}";
                }
                item.Quantity--;
            }
            else
            {
                Output = "Sold Out: Gum";
            }
        }
        if (SelectedItem == "Gum" && ChangeEntered < 40)
        {
            insufficientChange = (40 - ChangeEntered) / 100;
            Output = $"Feed me {insufficientChange:C2} more";
        }
    }

   
}