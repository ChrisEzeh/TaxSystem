using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TaxSystems_MyStore.Hooks;

namespace TaxSystems_MyStore.PageObjects
{
    class SummerDressPage
    {

        public IWebDriver driver;

        public SummerDressPage()
        {
            driver = BaseTest.driver;
        }

        private By searchField = By.CssSelector("#search_query_top");
        private By searchButton = By.CssSelector("[name='submit_search']");
        private By printedSummerDress = By.CssSelector("#center_column > ul > li.ajax_block_product.col-xs-12.col-sm-6.col-md-4.first-in-line.last-line.first-item-of-tablet-line.first-item-of-mobile-line.last-mobile-line > div > div.left-block > div > a.product_img_link > img");
        private By blueColour = By.CssSelector("#color_14");
        private By selectSize = By.CssSelector("#group_1");
        private By quantity = By.CssSelector("#quantity_wanted");
        private By addToCartButton = By.CssSelector("#add_to_cart > button > span");
        private By itemsAddedToCart = By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_product.col-xs-12.col-md-6 > h2");
        private By proceedToCheckout = By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a > span");
        private By shoppingCartSummary = By.CssSelector("#cart_title");
        private By plusIcon = By.CssSelector(".icon-plus");
        private By checkOutButton = By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium > span");
        private By authenticationPage = By.CssSelector("#center_column > h1");
        private By quantityField = By.CssSelector("#product_5_24_0_0 > td.cart_quantity.text-center > input.cart_quantity_input.form-control.grey");
        private By description = By.CssSelector("#product_5_24_0_0 > td.cart_description > p > a");
        private By color = By.CssSelector("#product_5_24_0_0 > td.cart_description > small:nth-child(3) > a");
        private By size = By.CssSelector("#product_5_24_0_0 > td.cart_description > small:nth-child(3) > a");
        private By total = By.CssSelector("#total_product_price_5_24_0");
        private By totalProducts = By.CssSelector("#total_product");
        private By totalShipping = By.CssSelector("#total_shipping");
        private By totalBeforeTax = By.CssSelector("#total_price_without_tax");
        private By tax = By.CssSelector("#total_tax");
        private By totalAfterTax = By.CssSelector("#total_price");
        
        public bool CartSummaryItemsDisplayed()
        {
            
            Thread.Sleep(5000);
            return driver.FindElement(description).Displayed;
            return driver.FindElement(color).Displayed;
            return driver.FindElement(size).Displayed;
            return driver.FindElement(total).Displayed;
            return driver.FindElement(totalProducts).Displayed;
            return driver.FindElement(totalShipping).Displayed;
            return driver.FindElement(totalBeforeTax).Displayed;
            return driver.FindElement(tax).Displayed;
            return driver.FindElement(totalAfterTax).Displayed;
        }
        public bool QuantityField(string qty)
        {
            
            Thread.Sleep(5000);
            return driver.FindElement(quantityField).Displayed;
        }
        public bool AuthenticationPageIsDisplayed()
        {
            
            
            return driver.FindElement(authenticationPage).Displayed;
        }
        public void ClickCheckOutButton()
        {
            driver.FindElement(checkOutButton).Click();
        }
        public void ClickProceedToCheckOut()
        {
            driver.FindElement(proceedToCheckout).Click();
        }
        public void ClickPlusIcon()
        {
            driver.FindElement(plusIcon).Click();
        }

        public bool ShoppingCartSummary()
        {
           
            Thread.Sleep(5000);
            return driver.FindElement(shoppingCartSummary).Displayed;
        }
        public bool ItemsAddedToCart()
        {
           
            Thread.Sleep(5000);
            return driver.FindElement(itemsAddedToCart).Displayed;
        }
        public void Navigates(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SearchField(string searchItem)
        {
            
            driver.FindElement(searchField).SendKeys(searchItem);
        }
        public void SearchButton()
        {
            
            driver.FindElement(searchButton).Click();
        }
        public void PrintedSummerDress()
        {
            
            driver.FindElement(printedSummerDress).Click();
        }
        public void BlueColour()
        {

            driver.FindElement(blueColour).Click();
        }
        public void SelectSize()
        {
            SelectElement select = new SelectElement(driver.FindElement(selectSize));
            select.SelectByValue("2");
        }
        public void EnterQuantity(string qty)
        {

            driver.FindElement(quantity).SendKeys(qty);
        }
        public void AddToCart()
        {

            driver.FindElement(addToCartButton).Click();
        }


    }
}
