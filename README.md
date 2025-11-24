# CodeKata-Checkout

This kata explores building a checkout system that calculates total prices for items, including special offers. The focus is on practicing TDD, incremental design, and refactoring.

**Problem Statement**

In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our shop, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually. In addition, some items are multi-priced: buy n of them, and they’ll cost you y pounds. For example, item ‘A’ might cost 50 pounds individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130. The current pricing and offers are as follows:

<img width="307" height="290" alt="image" src="https://github.com/user-attachments/assets/df997edf-a8b2-4d66-bd5a-9ebf816b7a39" />



Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95). Because the pricing changes frequently, we need to be able to pass in a set of pricing rules each time we start handling a checkout transaction.

Here's a suggested interface for the checkout...

 

interface ICheckout

{

    void Scan(string item);

    int GetTotalPrice();

}


**Instructions**

Implement a class library that satisfies the problem described above. The solution should be test driven.

We're as interested in the process that you go through to develop the code as the end result, so commit early and often so we can see the steps that you go through to arrive at your solution. We want to see a git repository containing your solution, ideally uploaded to your own github account.




**My Approach**

* I started with creating a skeleton for this c# class lib project
* Created a first basic Red testcase and added a given suggested interface
* Fixed the testcase with minimal required code and refactored the code if required.
* Reiterated the process for adding validation/support for other required items.
* Introduced pricing rules as I reached a stage where basic functionality was ready and multibuy features work started.
* Implemented DefaultRule and MultiBuyRule to cater multibuy offers features.
* Refactored the code whenever I felt necessary.

To keep the checkout logic flexible and maintainable, I applied the Strategy pattern to encapsulate different pricing rules as required based on item. Each strategy unit tested independently to make sure the pricing rule works even if not in use, the pricing provider is also injected into Checkout system to change it dynamically to support the requirement of frequent price changes.# CodeKata-Checkout

This kata explores building a checkout system that calculates total prices for items, including special offers. The focus is on practicing TDD, incremental design, and refactoring.

**Problem Statement**

In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our shop, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually. In addition, some items are multi-priced: buy n of them, and they’ll cost you y pounds. For example, item ‘A’ might cost 50 pounds individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130. The current pricing and offers are as follows:

<img width="307" height="290" alt="image" src="https://github.com/user-attachments/assets/df997edf-a8b2-4d66-bd5a-9ebf816b7a39" />



Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95). Because the pricing changes frequently, we need to be able to pass in a set of pricing rules each time we start handling a checkout transaction.

Here's a suggested interface for the checkout...

 

interface ICheckout

{

    void Scan(string item);

    int GetTotalPrice();

}


**Instructions**

Implement a class library that satisfies the problem described above. The solution should be test driven.

We're as interested in the process that you go through to develop the code as the end result, so commit early and often so we can see the steps that you go through to arrive at your solution. We want to see a git repository containing your solution, ideally uploaded to your own github account.




**My Approach**

* I started with creating a skeleton for this c# class lib project
* Created a first basic Red testcase and added a given suggested interface
* Fixed the testcase with minimal required code and refactored the code if required.
* Reiterated the process for adding validation/support for other required items.
* Introduced pricing rules as I reached a stage where basic functionality was ready and multibuy features work started.
* Implemented DefaultRule and MultiBuyRule to cater multibuy offers features.
* Refactored the code whenever I felt necessary.

To keep the checkout logic flexible and maintainable, I applied the Strategy pattern to encapsulate different pricing rules as required based on item. Each strategy unit tested independently to make sure the pricing rule works even if not in use, the pricing provider is also injected into Checkout system to change it dynamically to support the requirement of frequent price changes.
