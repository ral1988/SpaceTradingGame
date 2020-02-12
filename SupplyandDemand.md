#Supply and Demand fomulas

Price = BasePrice * (LocalDemand+DemandFactor*UnitsDemanded) / (LocalSupply+SupplyFactor*UnitsSupplied)

(In particular, note that, for all the calculations below, adding a constant value to P(x) doesn't actually change the results. Thus if, say, buying the last few units would be disproportionately expensive, it might be numerically more convenient to replace P(x) with the function Q(x) = P(x) - P(c), where c is e.g. the "typical" amount of the product available. Essentially, Q(x) then gives the cost/profit of bringing the local supply from x to c units.)



problems 
- Users being able to buy one unit and sell it at a profit right after. Will need to decide if the price will be based on the after buying the unit price (making the item more expensive for buying one unit)
-could design an way to show the "spot price" (end user to pick amount and the merchant can tell them how much that would be)
P(x) - P(x -y)
-Preventing the last units being extremly expensive (make max and mins for the market prices).