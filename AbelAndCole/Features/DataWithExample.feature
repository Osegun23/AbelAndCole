Feature: DataWithExample

As A user, i will like to add some product and 
confirm total amount in my cart

@tag1
Scenario Outline: Validate Amount of Product
	Given I Navigate to "https://www.abelandcole.co.uk/"
    And  i click on start shopping
    And  i add product "<product1>"
    And i add second product "<product2>"
    And i add third product "<product3>"
    When i grab the Cart text
    Then i should see the total number of products in my basket


    Examples: 
    | product1                               | product2                              | product3                                 |
    | Brownie Tray organic Daylesford (570g) | Hummus chips organic, Eat Real (100g) | Simply salted popcorn organic, Nom (20g) |

