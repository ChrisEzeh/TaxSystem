using NUnit.Framework;
using System;
using TaxSystems_MyStore.PageObjects;
using TechTalk.SpecFlow;

namespace TaxSystems_MyStore.StepDefinitions
{
    [Binding]
    public class SummerDressSteps
    {
        SummerDressPage summerDressPage = new SummerDressPage();

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            summerDressPage.Navigates(url);
        }
        
        [When(@"I enter ""(.*)"" in the search field")]
        public void WhenIEnterInTheSearchField(string fieldItem)
        {
            summerDressPage.SearchField(fieldItem);
        }
        [When(@"I click on search")]
        public void WhenIClickOnSearch()
        {
            summerDressPage.SearchButton();
        }

        [When(@"I click printed summer dress")]
        public void WhenIClickPrintedSummerDress()
        {
            summerDressPage.PrintedSummerDress();
        }

        [When(@"I click on blue")]
        public void WhenIClickOnBlue()
        {
            summerDressPage.BlueColour();
        }

        [When(@"I select medium from dropdown")]
        public void WhenISelectMediumFromDropdown()
        {
            summerDressPage.SelectSize();
        }

        [When(@"I enter ""(.*)"" in the quantity field")]
        public void WhenIEnterInTheQuantityField(string qty)
        {
            summerDressPage.EnterQuantity(qty);
        }

        [When(@"I click on add to cart button")]
        public void WhenIClickOnAddToCartButton()
        {
            summerDressPage.AddToCart();
        }

        [Then(@"pop up window message ""(.*)""")]
        public void ThenPopUpWindowMessage(string p0)
        {
            
            Assert.IsTrue(summerDressPage.ItemsAddedToCart(), "Product successfully added to your shopping cart");
        }

        [When(@"I click on proceed to checkout")]
        public void WhenIClickOnProceedToCheckout()
        {
            summerDressPage.ClickProceedToCheckOut();
        }
        [Then(@"I can see ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" in cart")]
        public void ThenICanSeeAndAndAndAndAndAndAndAndInCart(string description, string color, string size, string total, string totalproducts, string totalshipping, string totalbeforetax, string tax, string totalaftertax)
        {
            Assert.IsTrue(summerDressPage.CartSummaryItemsDisplayed());
        }
        [Then(@"I can see ""(.*)"" in shopping-cart summary")]
        public void ThenICanSeeInShopping_CartSummary(string qty)
        {
            Assert.IsTrue(summerDressPage.QuantityField(qty));
        }

        [When(@"I click on the plus icon to increase quantity")]
        public void WhenIClickOnThePlusIconToIncreaseQuantity()
        {
            summerDressPage.ClickPlusIcon();
        }
        [Then(@"I can see Shopping-Cart Summary")]
        public void ThenICanSeeShopping_CartSummary()
        {
            Assert.IsTrue(summerDressPage.ShoppingCartSummary());
        }
        [When(@"I click on proceed to checkout button")]
        public void WhenIClickOnProceedToCheckoutButton()
        {
            summerDressPage.ClickCheckOutButton();
        }

        [Then(@"I will see the authentication page")]
        public void ThenIWillSeeTheAuthenticationPage()
        {
            Assert.IsTrue(summerDressPage.AuthenticationPageIsDisplayed());
        }


    }
}
