using System;

/*
 * Data that user needs to provide while calling parameterized methods
 */
namespace Freshdirect_iPhone
{
	public class Data
	{
		//Login Data
		//Email id
		public static string ValidUser = "test@1.com";
		public static string InvalidUser = "test@test";
		public static string ExistingUser = "testuser01@igate.com";
		public static string WDCUser = "wdcbulkorder@gmail.com";
		public static string ProdUser = "fdxtester17@gmail.com";

		//Users for Add To cart
		public static string CartUser1 = "testuserA2@test.com";
		public static string CartUser2 = "testuser190@test.com";
		public static string CartUser3 = "ss@capgemini.com";
		public static string CartUser4 = "testuserAB1@test.com";

		//Users for add/Edit address and payment
		public static string AddUser1 ="AddAddressUser@test.com";
		public static string AddUser2 = "testuser1200@test.com";
		public static string AddressUser1 = "testuser0705@test.com";

		//Users for checkout
		public static string CheckoutUser1 = "testuserA1@test.com";
		public static string CheckoutUser2 = "testuser322@test.com";
		public static string CheckoutUser3 = "CHeckoutuser@test.com";

		//Users for order placement
		public static string OrderUser1 = "abc@fd.com";
		public static string OrderUser2 = "testuser100@test.com";
		public static string OrderUser3 = "orderuser3@test.com";

		//Users for only log in use
		public static string LogInUser1="tp@capgemini.com";
		public static string LogInUser2 = "cancelorderuser@test.com";
		public static string LogInUser3 ="testuserA3@test.com";

		//Chef table user
		public static string ChefTableUSer = "testingUser@g.com";

		//PROD USERNAME
		/*public static string ValidUser = "fdxtester17@gmail.com";
		public static string InvalidUser = "test@test";
		public static string ExistingUser = "tfdxtester17@gmail.com";
		public static string WDCUser = "wdcbulkorder@gmail.com";
		public static string ProdUser = "fdxtester17@gmail.com";

		//Users for Add To cart
		public static string CartUser1 = "fdxtester17@gmail.com";
		public static string CartUser2 = "fdxtester17@gmail.com";
		public static string CartUser3 = "fdxtester17@gmail.com";
		public static string CartUser4 = "fdxtester17@gmail.com";

		//Users for add/Edit address and payment
		public static string AddUser1 = "fdxtester17@gmail.com";
		public static string AddUser2 = "fdxtester17@gmail.com";

		//Users for checkout
		public static string CheckoutUser1 = "fdxtester17@gmail.com";
		public static string CheckoutUser2 = "fdxtester17@gmail.com";

		//Users for order placement
		public static string OrderUser1 = "fdxtester17@gmail.com";
		public static string OrderUser2 = "fdxtester17@gmail.com";

		//Users for only log in use
		public static string LogInUser1 = "fdxtester17@gmail.com";
		public static string LogInUser2 = "fdxtester17@gmail.com";
		public static string LogInUser3 = "fdxtester17@gmail.com";

		//Chef table user
		public static string ChefTableUSer = "fdxtester17@gmail.com";*/

		//Password
		public static string Password = "123456";
		public static string Password1 = "qwerty";
		public static string InvalidPassword = "12we3";
		public static string ChefPass = "testing";
		public static string WDCPass = "test12";
		public static string ProdPass = "ilovefood";

		//PROD PASSWORD
		/*public static string Password = "ilovefood";
		public static string Password1 = "ilovefood";
		public static string InvalidPassword = "12we3";
		public static string ChefPass = "ilovefood";
		public static string WDCPass = "test12";
		public static string ProdPass = "ilovefood";*/

	    //Data for Search Product name
		public static string ProductSearch1 = "Apples";
		public static string ProductSearch2 = "BANANAS";
		public static string ProductSearch3 = "Rome Apple";
		public static string ProductSearch4 = "Orange";
		public static string ProductSearch5 = "Q-Tips Cotton Swabs";
		public static string ProductFreshDeals = "Pink Peony Bunch";
		public static string Product1="Rome Apple";
		public static string Product3 = "grapes";
		public static string Product2 = "Gala Apples";
		public static string ProductSearchCarrot = "CARROT";
		public static string RegularProdInStock1 = "Organic Yellow Bananas";
		public static string RegularProdInStockCarrot = "Organic Carrots";
		public static string ProductSearchWine = "WINE";
		public static string CustomizableProd="Rib Eye Roast";
		public static string ProductSearch7UP = "7UP";
		public static string CouponProduct = "Invisible Solid Antiperspirant and Deodorant";
		public static string ProductSearchAsparagus = "White Asparagus";
		public static string ProductCoupon = "Dove invisible solid antiperspirant";
		public static string ProductOrganicValleyHalfNHalf = "Organic Valley Half & Half";
		//public static string RegularProdInStockAsparagus = "White Asparagus";
		public static string ProductJumboCarrot = "Jumbo Carrots";
		public static string ProductCarrot = "Carrot";
		public static string ProductSearchBaked = "Baked Ziti";
		public static string ProductCottonSwabs = "Q-tips Cotton Swabs";
		public static string ProductWhiskey = "Whiskey";
		public static string ProductSearchPineapple = "Fresh Pineapple Chunks";
		public static string ProductRedWine = "75 Wine Company";
		public static string ProductGrapes = "Red Seedless Grapes";
		public static string ProductAxelrod = "Axelrod Chunk Style Cottage Cheese";
		public static string ProdFinlandiaCheese = "Finlandia All Natural Muenster Cheese Deli Slices";
		public static string ProdPolandSpring = "Poland Spring Natural Spring Water";
		public static string prodBabyBanana = "Baby Banana case";

		//PROD PRODUCTS
		//public static string ProductFreshDeals = "Pink Peony Bunch";
		/*public static string Product1 = "Organic Honeycrisp Apples";
		public static string Product3 = "grapes";
		public static string Product2 = "Granny Smith Apples";
		public static string ProductSearchCarrot = "Pitted Greek Olive Mix";
		public static string RegularProdInStock1 = "Crumbled Domestic Gorgonzola";
		public static string RegularProdInStockCarrot = "Natural Crumbled Blue Cheese";
		public static string ProductSearchWine = "WINE";
		public static string CustomizableProd = "Rib Eye Roast";
		public static string ProductSearch7UP = "7UP";
		public static string CouponProduct = "Invisible Solid Antiperspirant and Deodorant";
		public static string ProductSearchAsparagus = "All Natural Cold Brew Coffee Concentrate";
		public static string ProductCoupon = "Dove invisible solid antiperspirant";
		public static string ProductOrganicValleyHalfNHalf = "Organic Valley Half & Half";
		//public static string RegularProdInStockAsparagus = "White Asparagus";
		public static string ProductJumboCarrot = "";
		public static string ProductCarrot = "Pitted Kalamata Olives";
		public static string ProductSearchBaked = "Baked Ziti";
		public static string ProductCottonSwabs = "Q-tips Cotton Swabs";
		public static string ProductWhiskey = "Whiskey";
		public static string ProductSearchPineapple = "Oven-Ready Chocolate Croissants, Frozen";
		public static string ProductRedWine = "75 Wine Company";
		public static string ProductGrapes = "Red Seedless Grapes";
		public static string ProductAxelrod = "Axelrod Chunk Style Cottage Cheese";
		public static string ProdFinlandiaCheese = "Finlandia All Natural Muenster Cheese Deli Slices";
		public static string ProdPolandSpring = "Poland Spring Natural Spring Water";
		//public static string ProdPolandGallon =*/

		//Departments/Category/Subcategory
		public static String ExpectedDepartment = "Fresh Deals,Meals,Fruit,Vegetables,Meat,Seafood,Dairy,Pantry,Beverages,Wines & Spirits,Beer,Cheese Shop,Deli,Bakery & Pastry,Frozen,Household,Health & Beauty,Party Platters,At the Office,Flowers,Baby,Pet";
		public static string SubDeptMeat = "Meat,Kosher,Beef and Lamb";
		public static string HeaderBeefAndLamb = "Beef and Lamb";
		public static string ProdRedWine = "Red Wine";
		public static string ProdSparklingWine = "Sparkling Wine";
		public static string DeptSubdeptCoupon = "Health & Beauty,Deodorant,Female";
		public static string DeptSubDeptFruit = "Fruit,Avocados,Avocados from Mexico";
		public static string DeptSubDeptCarrots = "Vegetables,Carrots";
		public static string DeptSubDeptWines = "Wines & Spirits,Rosé Wine,Still";
		public static string DeptSubDeptLocalFarm = "Vegetables,Local Farm Share";

		//Quantity
		public static int QuantityFreshDeals = 3;
		public static string DecreaseQuantity = "3";
		public static string IncreaseQuantity = "5";
		public static int Increase = 5;
		public static string Quantity = "2";
		public static int Quantity1 = 2; //QuantityWineProd //Decrease
		public static int QuantityRegularProdInStock1 = 1; //QuantityRegularProdInStockcheez
		public static int Quantity3 = 6;
		public static int Decrease = 2;
		public static int Quantity5 = 5;
		public static int Quantity8 = 8;
		public static int Quantity4 = 4;
		public static int Quantity10 = 10;
		public static int Quantity03 = 3;
		public static int Quantity12 = 12;

		//PROD QUANTITY
		/*public static int QuantityFreshDeals = 11;
		public static string DecreaseQuantity = "13";
		public static string IncreaseQuantity = "15";
		public static int Increase = 5;
		public static string Quantity = "12";
		public static int Quantity1 = 12; //QuantityWineProd //Decrease
		public static int QuantityRegularProdInStock1 = 1; //QuantityRegularProdInStockcheez
		public static int Quantity3 = 16;
		public static int Decrease = 2;
		public static int Quantity5 = 15;
		public static int Quantity8 = 8;
		public static int Quantity4 = 14;
		public static int Quantity10 = 10;
		public static int Quantity03 = 13;
		public static int Quantity12 = 12;*/
		//PDP page
		public static string Description = "DESCRIPTION";

		//Credit Card Details:
		public static string CCHolderName="Mark Test Acc";
		public static string CCNumber = "5555555555555557";
		public static string CCType = "MasterCard";
		public static string Address ="55 CLARK ST";
		public static string Apt = "";
		public static string City="Brooklyn"; //city1
		public static string ZipCode = "11201"; //zip
		public static string Country="USA";
		public static string CCExpire = "05/19";
		public static string StateProve = "New York";

		//PROD CC
		//Credit Card Details:
		/*public static string CCHolderName = "Fresh Direct";
		public static string CCNumber = "4444444444444448";
		public static string CCType = "American Express";
		public static string Address = "2330 Borden Avenue";
		public static string Apt = "";
		public static string City = "Long Island City"; //city1
		public static string ZipCode = "11101"; //zip
		public static string Country = "USA";
		public static string CCExpire = "09/21";
		public static string StateProve = "New York";*/
		//Invalid credit card
		public static string CCNumberInvalid = "4444444444444444";
		public static string CCTypeInvalid = "Discover";
		public static string CCExpireInvalid = "01/17";
		public static string CCHolderNameInvalid = "01212416";


		//Add New Address details
		public static string Stamp = DateTime.Now.ToString ("yyyyMMddHHmmss");
		public static string FirstName = "Test1";
		public static string LastName = "Test1";
		public static string AddressType = "Home";
		public static string AddressTypeOffice = "Office";
		public static string CompanyName = "Capgemini";
		//public static string Apartment = "";
		//public static string StreetAddress = "55 Clark street";
		//public static string City1 = "Brooklyn";
		//public static string Zip = "11201";
		public static string State = "New York"; //styateprove
		public static string StreetAddress = "907 6th ST SW";
		public static string Apartment = "501B";
		public static string City1 = "Washington";
		public static string Zip = "20024";
		public static string Telephone = "3151121111";
		public static string AdditionalDeliveryInstructions = "";
		public static string LeaveWithDoorman = "";
		public static string Floor = "";

		//Select Delivery Day and Time
		public static string SelectDay = "Tuesday";
		public static string SelectTime = "7 - 9 am";
		public static string Slot1="8 - 10 pm";
		public static string OrderTime = null;
		public static string Slot = "8 - 10";

		//Invalid Address details
		public static string InvalidStreetAddress1 = "ABCD";
		public static string InvalidZip = "0000";
		public static string InvalidTelephone1 = "8888888888";
		public static string InvalidTelephone2 = "11111111";

		//Address
		public static string PickupAddress="PICKUP: FRESHDIRECT PICKUP";
		public static string EcoFriendlyAddress = "ECO FRIENDLY";
		public static string AddressLocatorAddress = "55 Clark Street Brooklyn NY"; 
		public static string DefaultAddress = null;
		public static string DCAddress = "907 6TH ST SW 501B,Washington, DC, 20024";
		public static string AlcoholRestrictedAddress = "TEST USER";

		//Delivery Instruction
		public static string DeliveryInstuction1 = "Deliver On Time To Address";

		//select Tip
		public static string Tip ="$4";
		public static string CustomTipVal = "7.5";

		//Homepage Banner Department and Category
		public static string DeptRandom = "";
		public static string DeptFreshDeals = "FRESH DEALS";
		public static string CatFreshDeals = "Fresh Deals";
		public static string DeptLaborDay = "LABOR DAY BBQ MUST-HAVES";
		public static string CatLaborDay = "Grilling Essentials";
		public static string DeptSaveOnRose = "SAVE ON ROSÉ";
		public static string CatSaveOnRose = "Rosé Sale";	
		public static string DeptBigBeverage = "BIG BEVERAGE SALE";
		public static string CatBigBeverage = "Ice Cold Drinks";
		public static string DeptSugarKissMealons = "SUGAR KISS MELONS";
		public static string CatSugarKissMealons = "Melons";
		public static string DeptSummerSeafood = "SUMMER SEAFOOD";
		public static string CatSummerSeafood = "In-Season Seafood";
		public static string DeptSnakeOnSale = "SNACKS ON SALE";
		public static string CatSnakeOnSale = "Snacks";
		public static string DeptFruityWater = "MAKE IT NOW: FRUITY WATER";
		public static string CatFruityWater = "Sparkling Fruit Water";
		public static string DeptLunchBox = "LUNCH BOX SNACKS & DRINKS";
		public static string CatLunchBox = "Lunch Box Heroes";
		public static string DeptDinnerIdeas = "KID-FRIENDLY DINNER IDEAS";
		public static string CatDinnerIdeas = "Quick and Easy Kids' Meals";
		public static string DeptEverythingApple = "EVERYTHING APPLE";
		public static string CatEverythingApple = "Applefest Season";
		public static string DeptNewyorkClassics = "NEW YORK CLASSICS";
		public static string CatNewyorkClassics = "Evian and US Open Present NY Favorites";
		public static string DeptGreatCartStarts = "GREAT CART STARTS";
		public static string CatGreatCartStarts = "Great Cart Starts";

		//Edit Address
		public static string EditAddressType = "";
		public static string EditCompanyName = "";
		public static string EditFirstName = "EditedUser";
		public static string EditLastName = "EditedUser";
		public static string EditFloor = "";
		public static string EditApt = "";
		public static string EditStreetAddress = "";
		public static string EditCity = "";
		public static string EditZip = "";
		public static string EditState = "";
		public static string EditTelephone = "";
		public static string EditAdditionalDeliveryInstructions = "";
		public static string EditLeaveWithDoorman = "";

		//Invalid Search-homepage
		public static string InvalidProduct="ghsjd";

		//Edit CC Detail
		public static string CCNumberEdit = "Ending: 4448   Exp. 5/18";
		public static string CCHolderNameEdit="Mark Test Updated";
		public static string CCExpireEdit = "05/18";

		public static string EditPayAddress = "10 Parkway";
		public static string EditPayApt="";
		public static string EditPayCity="";
		public static string EditPayStateProv="";
		public static string EditPayZipCode="";
		public static string EditPayCountry="";

		//Section Names:
		public static string PDPSections = "NUTRITION,DESCRIPTION,INGREDIENTS,ALLERGENS";

		//Modify Email
		public static string NewEmailAddress = "testuser" + Stamp + "@test.com";
		public static string ConfirmNewEmailAddress = NewEmailAddress;

		// Promo code 
		public static string PromoCode ="Test1";

		//Contact Us
		public static string Message = "Kindly provide bill on registered email address";

		//Modify Password
		public static string NewPassword = "1234567";

		//Declaring timeslot variable for using it in CheckoutPage.cs
		public static string timeslot = null;
		public static string chkoutmobileNumber = "9173926760";
		public static int ResiMaxLimit = 750;
		public static string ResiMax = "$750";
		public static string CorpMax = "$1500";
		public static int ModifyResiMaxLimit = 1500;



		//Adress Select In Checkout
		public static string WDCAddress = "907 6TH ST SW";

		//ATP Product 
		public static string ATPProduct = "Broccoli Rabe";

	}
}