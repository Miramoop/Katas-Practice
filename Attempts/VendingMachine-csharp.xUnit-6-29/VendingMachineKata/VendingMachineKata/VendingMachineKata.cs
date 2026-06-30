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
    public string Output { get; set; }
    public decimal ChangeEntered { get; set; }
    public decimal ExtraChange { get; set; }
    public decimal RequiredChange { get; set; }
    public List<Item> items { get; set; } = new List<Item>();

    public VendingMachine()
    {
        var Soda = new Item();
        Soda.ItemName = "Soda";
        Soda.Price = (decimal)1.00;
        Soda.Code = "A01";
        Soda.Quantity = 10;
        items.Add(Soda);

        var Chips = new Item();
        Chips.ItemName = "Chips";
        Chips.Price = (decimal)0.65;
        Chips.Code = "A02";
        Chips.Quantity = 12;
        items.Add(Chips);

        var Candy = new Item();
        Candy.ItemName = "Candy";
        Candy.Price = (decimal)0.85;
        Candy.Code = "A03";
        Candy.Quantity = 8;
        items.Add(Candy);
            
        var Gum = new Item();
        Gum.ItemName = "Gum";
        Gum.Price = (decimal)0.40;
        Gum.Code = "A04";
        Gum.Quantity = 3;
        items.Add(Gum);
    }
    public string Vend(string code)
    {
        if (code == "A01")
        {
            if (ChangeEntered >= 100)
            {
                Output = "Vending Soda";
            }
            return "Soda";
        }

        if (code == "A02")
        {
            if (ChangeEntered >= 65)
            {
                Output = "Vending Chips";
            }
            return "Chips";
        }

        if (code == "A03")
        {
            if (ChangeEntered >= 85)
            {
                Output = "Vending Candy";
            }
            return "Candy";
        }

        if (code == "A04")
        {
            var item = items.FirstOrDefault(x => x.Code == "A04");
            
            if (ChangeEntered >= 40 && item.Quantity != 0)
            {

                Output = "Vending Gum";
                ExtraChange = (ChangeEntered - 40) / 100;
                if (ExtraChange > 0)
                {
                    Output = $"Vending Gum: Change {ExtraChange:C2}";
                }

                //var item = items.FirstOrDefault(x => x.Code == "A04");
                item.Quantity--;
            }
            else if (item.Quantity == 0)
            {
                Output = $"Sold Out: Gum";
            }
            else 
            {
                RequiredChange = (40 - ChangeEntered) / 100;
                Output = $"Feed me {RequiredChange:C2} more";
            } 
            return "Gum"; 
        }
        
        return $"Invalid Selection: {code}";
    }

    public void InputChange(int change)
    {
        ChangeEntered += change;
    }
}