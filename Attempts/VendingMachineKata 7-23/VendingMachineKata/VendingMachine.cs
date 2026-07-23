namespace VendingMachineKata;

public class VendingMachine
{
    public decimal ChangeEntered { get; set; }
    
    public string Output { get; set; } = "Welcome";
    public string SelectedItem { get; set; } = "Invalid Code";
    
    public void Vend(string code)
    {
        SelectedItem = code switch
        {
            "A01" => "Soda",
            "A02" => "Chips",
            "A03" => "Candy",
            "A04" => "Gum",
            _ => "Invalid Code"
        };
    }

    public void EnterChange(int change)
    {
        ChangeEntered += change;
        if (SelectedItem == "Soda" && ChangeEntered >= 100)
        {
            Output = "Vending Soda";
        }
    }

   
}