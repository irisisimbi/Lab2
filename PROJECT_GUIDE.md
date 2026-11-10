# Project Guide

## Project title
Bicycle, Meal and Mushroom Management System

## Development environment
- Language: C#
- IDE: Visual Studio 2022
- Application type: Windows Forms
- Framework: .NET 8

## Application flow
1. Launch the application and enter login details.
2. After successful login, choose Bicycle, Meal, or Mushroom.
3. Bicycle: select bicycle type and rental hours; the system calculates the rental total.
4. Meal: select a meal and quantity; the system calculates the order total.
5. Mushroom: select a mushroom product and quantity; the system calculates the order total.
6. A message box displays the selected item, quantity/duration, and total in RWF.
7. Return to the service menu or log out.

## Demo login
Username: admin
Password: 1234

## Test cases
| Test | Action | Expected result |
|---|---|---|
| Login success | Enter admin / 1234 | Service menu opens |
| Login failure | Enter incorrect details | Warning message appears |
| Bicycle | Standard bicycle for 2 hours | Total is 2,000 RWF |
| Meal | Rice and beans, quantity 2 | Total is 5,000 RWF |
| Mushroom | Oyster mushrooms, quantity 2 | Total is 6,000 RWF |
| Back | Click Back | Returns to service menu |
| Logout | Click Logout | Ends the current menu session |

## Sample values to confirm
Bicycle: Standard 1,000 RWF/hour; Mountain 1,500 RWF/hour; Electric 2,500 RWF/hour.
Meal: Rice and beans 2,500 RWF; Chicken and chips 3,500 RWF; Beef with rice 5,000 RWF.
Mushroom: Oyster pack 3,000 RWF; Button pack 5,000 RWF; Shiitake pack 8,000 RWF.

All prices and product choices are illustrative placeholders and should be confirmed with the lecturer.
