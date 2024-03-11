Feature: Amazon Cart Validation

    Scenario: Add item to cart and validate cart content
        Given I navigate to Amazon as an unregistered user
        When I search for TP-Link N450 WiFi Router
        And I add the corresponding item to the cart
        Then I validate the correct item and amount is displayed
