namespace VendingMachineBase;

public class Item
{
    // Name, Code, Price don't change, but Quantity does
    public string ItemName { get; init; }
    public string Code { get; init; }
    public decimal Price { get; init; }
    public int Quantity { get; set; }
}
public class VendingMachine
{
    public decimal totalChange { get; set; }
    public decimal neededChange { get; set; }
    public decimal extraChange { get; set; }
    public string selectedItem { get; set; }
    public string output { get; set; }
    public List<Item> Items { get; set; }

    public VendingMachine()
    {
        // If wanted to add more items, could connect to database, json, excel, etc
        Items =
        [
            new Item
            {
                ItemName = "Soda",
                Code = "A01",
                Price = 100,
                Quantity = 10
            },
            new Item
            {
                ItemName = "Chips",
                Code = "A02",
                Price = 65,
                Quantity = 12
            },
            new Item
            {
                ItemName = "Candy",
                Code = "A03",
                Price = 85,
                Quantity = 8
            },
            new Item
            {
                ItemName = "Gum",
                Code = "A04",
                Price = 40,
                Quantity = 3
            }
        ];

    }

    public string SelectProduct(string code)
    {
        // If code doesn't exist, then returns null
        // LINQ statement, essentially shortens a query from .Select,
        // .Sum, .Where, etc to one line
        // Could have also used a switch statement
        var item = Items.FirstOrDefault(x => x.Code == code);

        if (item == null)
        {
            return $"Invalid Selection: {code}";
        }

        selectedItem = item.ItemName;
        return selectedItem;
    }

    public void CalculateChange(int change)
    { 
        totalChange += change;
    }

    public string VendProduct()
    {
        var item = GetSelectedItem();

        if (item == null)
        {
            return "No Item Selected";
        }

        VendItem(item);
        return output;
    }

    private void VendItem(Item? item)
    {
        if (item.Quantity <= 0)
        {
            output = $"Sold Out: {item.ItemName}";
        }
        else if (totalChange < item.Price)
        {
            neededChange = (item.Price - totalChange) / 100;
            output = $"Feed me {neededChange:C2} more";
        }
        else
        {
            output = $"Vending {item.ItemName}";
            if (totalChange > item.Price)
            {
                extraChange = (totalChange - item.Price) / 100;
                output = $"Vending {item.ItemName}: Change {extraChange:C2}";
            }

            item.Quantity--;
        }
    }

    private Item? GetSelectedItem()
    {
        return Items.FirstOrDefault(x => x.ItemName == selectedItem);
    }
}
