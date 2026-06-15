# Vending Machine Kata

In this simple Kata, your task is to recreate the workings of a vending machine.
This vending machine will have a set of products at varying quantities and prices
that can be chosen and dispensed.

## Features

### Select a Product

There are four products available in this vending machine. Each product is 
able to be selected by sending the appropriate code to the machine.

| Item  | Price  |  Code  | Quantity |
|:-----:|:------:|:------:|:--------:|
| Soda  | $1.00  |  A01   |    10    |
| Chips | $0.65  |  A03   |    12    |
| Candy | $0.85  |  A03   |    8     |
|  Gum  | $0.40  |  A04   |    3     |

#### Exact Change

When the respective vending code is entered and the correct amount of money
is given, the machine prints "Vending Item Name" where `Item Name` is the
name of the item that was selected

Example Output:
Vending Soda

#### Returning Change

When the respective vending code is entered and more money than is needed is
supplied to the machine, the machine prints "Vending Item Name: Change Item
Change" where `Item Name` is the name of the item selected and `Item Change`
being the amount of change to be returned. The item's change should display
two decimal places.

Example Output:
Vending Gum: Change $0.60

#### Insufficient Funds

When the respective vending code is entered and not enough money is supplied
to the machine, the machine prints "Feed me $X.XX more" where `$X.XX` is the 
extra amount needed to purchase the item. The item price should always display
two decimal places.

Example Output:
Feed me $0.30 more

#### Invalid Product

When a vending code is entered that does not exist, the machine prints "Invalid
Selection: Item Code" where `Item Code` is the code that was sent to the machine.

Example Output:
Invalid Selection: A08

#### Manage Quantities 

The vending machine needs to keep track of how many of each item is in the machine.
Whenever an item is vended, it's quantity should be reduced by 1.

#### Out of Stock Items

When a vending code is entered where the quantity of an item is 0, the machine
prints "Sold Out: Item Name" where `Item Name` is the name of the item that is 
sold out.

Example Output:
Sold Out: Candy