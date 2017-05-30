using System;
using System.Linq;
using System.Threading;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

/*
 * Query containing object definition
 */

namespace Freshdirect_iPhone
{
	public class ObjectRepository : Data
	{
		public Query strlaunch = x => x.Marked("Getting you the good stuff");
		public Query nul = null;

		// UI validation of Registration Page
		public Query strcreateAccount = x => x.Marked("Create Account");
		public Query idmeTab = x => x.Id("TabStore");
		public Query txtcreateAccount = x => x.Text("Create Account").Index(0);

		// Terms of use locators
		public Query strtermsOfUse = x => x.Marked("By registering you agree to the Terms of Use.");
		public Query btncloseIcon = x => x.Marked("IconClose");
		public Query strwebView = x => x.Class("UIWebView");

		// Email and password locators
		public Query stremail = x => x.Marked("Email");
		public Query strpassword = x => x.Marked("Password");
		public Query strminCharacters = x => x.Marked("minimum 6 characters");

		// social login locators
		public Query strfacebook = x => x.Marked("facebook");
		public Query strgoogleplus = x => x.Marked("googleplus");

		//Locators related to Logout Method
		public Query tabme = x => x.Id("TabStore");
		public Query tabmeSettings = x => x.Id("Icons/settings");
		public Query btnlogout = x => x.Marked("Logout");
		public Query iconhandleLoading = x => x.Id("IconLoadingPurple");

		//Locators related to VerifySignIn Tabs Method
		public Query tabfoodkick = x => x.Marked("Foodkick");
		public Query tabfacebook = x => x.Marked("facebook");
		public Query tabgoogleplus = x => x.Marked("googleplus");

		//Locators related to InvalidLoginCredentials Method
		public Query btnsignIn = x => x.Marked("Forgot your password?").Sibling().Marked("Sign In");
		public Query txtemail = x => x.Class("SignInValidationTextField").Index(0);
		public Query txtpassword = x => x.Class("SignInValidationTextField").Index(1);
		public Query txtloginFailed = x => x.Marked("Login Failed");
		public Query txtok = x => x.Marked("OK");
		public Query txtincompleteEmailMsg = x => x.Marked("Incomplete e-mail address");

		// Login 
		public Query strsignIn = x => x.Property("text").Contains("Sign In");
		public Query tabsignIn = x => x.Class("UIButtonLabel").Text("Sign In").Index(0);
		public Query tabemail = x => x.Marked("Email");
		public Query tabpassword = x => x.Marked("Password");
		public Query txtme = x => x.Property("text").Contains("Me");

		// Create Account
		public Query idhomeshop = x => x.Id("TabShop");
		public Query txtshopFromPastItem = x => x.Text("Shop From Past Items");
		public Query idfreshdirectLogo = x => x.Id("freshdirect");

		//Locators related to MandatoryFieldCheck Method
		public Query strrequiredEmail = x => x.Text("Required").Index(0);
		public Query strrequiredPassword = x => x.Text("Required").Index(1);

		//Locators related to Verify existing Email
		public Query strwhoopswarning = x => x.Property("text").Contains("An account with the referenced e-mail address already exists.");
		public Query btncreateAccount = x => x.Marked("Create Account").Index(1);

		//Locators related to Validate Shop from Past Items button on Home page script
		public Query stritems = x => x.Text("Items");
		//Locators related to Search PLP
		public Query txtsearchField = x => x.Marked("Search");
		public Query clsproductContainer = x => x.Class("FD_IOS_Shared_ProductDetailInformationView");
		public Query idsearchField = x => x.Id("IconSearch");

		//VerifyAnonUserInteraction
		public Query btncloseSignin = x => x.Marked("␡");

		//VerifyInvalidCredential
		public Query txtpasswordAtlstSixChar = x => x.Text("Password must be at least 6 characters");

		// Verify Categeory
		public Query idburger = x => x.Id("IconHamburger");
		public Query txtpastPurchse = x => x.Marked("Past Purchases");
		public Query txtdeals = x => x.Marked("Deals");
		public Query txtallShops = x => x.Marked("All Shops");
		public Query clsdepartment = x => x.Class("UITableViewCellContentView");
		public Query clsDepartScroll = x => x.Class("UITableView");

		//CheckHeader
		public Query icndelivery = x => x.Id("IconTruck");
		public Query imgmainLogo = x => x.Id("FeaturedHeader");

		// Locators related to Add To Cart From PLP
		public Query clsproductList = x => x.Class("FD_IOS_Shared_ProductDetailInformationView");
		public Query clsproductName = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Child(1);
		public Query btnquickAdd1 = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Sibling().Class("UIButton").Index(0);
		public Query btnquickAdd2 = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Sibling().Class("UIButton").Index(1);
		public Query btnquickAdd3 = x => x.Class("UIButton").Index(1);

		//Locators for Verify Freshdeals 
		public Query leftdrwFirstElement = x => x.Class("ShopMenuDeptCell").Index(1).Child(0).Child(0);
		public Query iconhamburger = x => x.Marked("IconHamburger");
		public Query verifyleftDrawer = x => x.Class("ShopMenuDeptCell").Index(0);
		public Query txtfreshDeals = x => x.Marked("Fresh Deals");
		public Query txtfreshDealsHeader = x => x.Id("Fresh Deals");

		//Locators related to IncreaseQuantityPDP,DecreaseQuantityPDP,AddToCartFromPDP
		public Query btnaddToCart = x => x.Marked("ADD TO CART");
		public Query btnupdateCart = x => x.Marked("UPDATE CART");
		public Query btnquantityPlus = x => x.Class("FD_IOS_Shared_PlusMinusQuantityView").Child().Index(2);
		public Query btnquantityMinus = x => x.Class("FD_IOS_Shared_PlusMinusQuantityView").Child().Index(0);
		public Query strquantity = x => x.Class("FD_IOS_Shared_PlusMinusQuantityView").Child().Index(1);

		//Locators related to VerifyItemAdded
		public Query stritemAddedMsg = x => x.Marked("Item was added to bag");

		// Carosel
		public Query clsproductCarosel = x => x.Class("FD_IOS_Shared_ProductCarousel");
		public Query txtforYouToday = x => x.Property("text").Contains("For You Today");

		//Cart validation
		public Query tabbag = x => x.Id("TabBag");
		public Query strbag = x => x.Text("BAG");
		public Query btnststartShopping = x => x.Text("START SHOPPING");
		public Query stremptyBag = x => x.Text("Your shopping bag is empty.");

		// Add New Payment
		public Query txtnewCard = x => x.Text("New Card");
		public Query txtpaymentMethodChange = x => x.Property("text").Contains("Payment");
		public Query txtedit = x => x.Text("Edit");
		public Query txtaddNew = x => x.Text("Add New");
		public Query txtscanYourCard = x => x.Text("SCAN YOUR CARD");
		public Query txtselectExistingAddress = x => x.Text("SELECT FROM EXISTING ADDRESSES");
		public Query txtnameAppearsonCC = x => x.Text("Name As It Appears On Card");
		public Query txtcardNumber = x => x.Text("Card Number");
		public Query txttypeOfCard = x => x.Text("Type Of Card");
		public Query txttypeOfCardAutoPop = x => x.Text("Type Of Card").Sibling();
		public Query txtdone = x => x.Text("Done");
		public Query txtexpireDate = x => x.Text("Expiration Date");

		public Query txtstreetAddress = x => x.Text("Street Address");
		public Query txtapt = x => x.Text("Apt.");
		public Query txtcity = x => x.Text("City");
		public Query txtzipCode = x => x.Text("Zip Code");
		public Query txtstateProv = x => x.Text("State/Province");
		public Query txtcountry = x => x.Text("Country");
		public Query txtcountryAutoPop = x => x.Text("Country").Sibling();
		public Query txtsave = x => x.Text("SAVE");

		public Query txtcheckoutBtn = x => x.Text("Checkout");
		public Query txtplaceOrderBtn = x => x.Text("Place Order");
		public Query txtSelectCountry = x => x.Text(Data.Country);

		//Select Pickup Address
		public Query btncheckout = x => x.Marked("Checkout");
		public Query btnplaceOrder = x => x.Marked("Place Order");
		public Query btnchangeDeliveryAddress = x => x.Marked("Change").Index(0);
		public Query straddressBook = x => x.Marked("ADDRESS BOOK");

		public Query straddress = x => x.Marked (PickupAddress).Sibling ().Class ("D3Label"); 
		public Query strselectedAddress = x=>x.Marked("Change").Index(0).Sibling().Class("D3Label").Index(1); 

		//Address Locator
		public Query txtaddressLocator = x => x.Property("text").Contains("Type your full address here");
		public Query clsdefaultAddress = x => x.Class("FD_IOS_Shared_AddressPopupListCell");
		public Query radselectAddress = x => x.Marked(PickupAddress).Sibling().Class("D3RadioButton");
		public Query btnselectDeliveryTime = x => x.Text("SELECT DELIVERY TIME");

		//UiProductPLP
		public Query imgplpProduct = x => x.Class("FD_IOS_Shared_ProductCardCell").Index(0).Child().Class("UIImageView");
		public Query txtnameProductPLP = x => x.Class("FD_IOS_Shared_ProductCardCell").Index(0).Child().Class("FD_IOS_Shared_ProductDetailInformationView").Child();
		public Query icnbagFirstProductPLP = x => x.Class("FD_IOS_Shared_ProductCardCell").Index(0).Child().Class("UIButton");
		public Query icnbagProductPLP = x => x.Class("FD_IOS_Shared_ProductCardCell").Child().Class("UIButton");
		public Query icnrefine = x => x.Id("IconRefine");
		public Query btnreset = x => x.Text("RESET");

		//AddCustomizableProductToCartFromPDP
		public Query lnkcustomizeAttribute = x => x.Property("text").Contains("Choose");
		public Query lnkselCustomizeAttribute = x => x.Property("text").Contains("Choose").Sibling();
		public Query btndone = x => x.Text("Done");
		public Query errconfigPopUp = x => x.Text("Please select the product configuration");

		//ColseOrderPlacedpage
		public Query txtorderPlaced = x => x.Text("ORDER PLACED");
		public Query btnclose = x => x.Class("UINavigationButton");

		//ModifyOrderOnHomepage
		public Query btnmodifyOrder = x => x.Class("UIButtonLabel").Property("text").Contains("Modify Order");
		public Query txtmodifyingOrder = x => x.Text("MODIFYING ORDER");

		//ModifyOrder
		public Query btnmodifyQuantity = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Index(0).Sibling().Class("UIButton").Index(0);
		public Query idmodifyIncreaseQuantity = x => x.Id("IconPlusWhite");
		public Query idmodifyDecreaseQuantity = x => x.Id("IconMinusWhite");
		public Query strorderSubtotal = x => x.Property("text").Contains("Order Subtotal").Sibling().Index(0);
		public Query btndelete = x => x.Marked("Delete");
		public Query clsprdctonBag = x => x.Class("FD_IOS_Shared_ProductDetailInformationView");
		public Query clsdeleteProduct = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Index(1);
		public Query btnsave1 = x => x.Marked ("SAVE");
		public Query btncancel = x => x.Marked ("CANCEL");
		public Query txtdeliveryTime1 = x => x.Marked("DELIVERY TIME");
		public Query txtwhoops = x => x.Text("Whoops");
		public Query txtwhoopsDetails = x => x.Text("Whoops").Sibling(0);

		//Locators for Add Wine products from PLP and Select Alcohol restricted timeslot
		public Query iconshoppingCart = x => x.Marked("Shopping cart");
		public Query txtdeliveryTime = x => x.Marked("DELIVERY TIME");
		public Query lnkdeliveryTime = x => x.Property("text").Contains("Delivery Time");
		public Query strAlcRestrictedTime = x => x.Marked("alcoholUnavailable").Index(0).Sibling();

		//Locators for Booze Alert
		public Query strboozeAlert = x => x.Marked("BOOZE ALERT!");
		public Query txtcancel = x => x.Text ("CANCEL");

		//UiSearch
		public Query btncancel1 = x => x.Text("Cancel");
		public Query txtprefilledsearch = x => x.Id("IconSearch").Sibling().Class("UITextFieldLabel");
	
		//Invalid search
		public Query txtinvalidSearch= x=>x.Property("text").Contains("No results found");
		public Query idrefine = x => x.Id ("IconRefine");
		public Query idsearchBar = x => x.Id("IconSearch").Sibling().Index(1);
		public Query idsearchIcon = x => x.Id ("IconSearch");

		//Locators for Verify Wine Section Cart
		public Query txtbag = x => x.Marked("BAG");
		public Query txtfdWines = x => x.Marked("FD WINES").Index(0);
		public Query txtorderSubTotal = x => x.Class ("FD_IOS_Shared_CartSummaryView").Child (2).Child (0).Child (0).Property ("text").Contains ("Order Subtotal");
		public Query txtfdWineSubTotal = x => x.Class ("FD_IOS_Shared_CartSummaryView").Child (1).Child (0).Child (0).Property ("text").Contains ("FD Wine Subtotal");

		//Locators for age verification popup
		public Query txtageVerify = x => x.Marked("AGE VERIFICATION FOR ORDERS CONTAINING ALCOHOL");
		public Query btnradioAgeVerify = x => x.Class("UISwitch");
		public Query btnsubmit = x => x.Marked("SUBMIT");

		//select Delivery Time and Day
		public Query idnxtIcon = x => x.Id("Icons/newRightArrow.png");
		public Query txtchooseDate = x => x.Property("text").Contains("CHOOSE DATE");
		public Query txtselectedTime = x => x.Property("text").Contains("day");


		public Query lnkselectTimeSlot = x => x.Class("FD_IOS_Shared_CheckoutRowCell").Index(1);
		public Query txtNoTimeSlotSelected = x => x.Text("+ DELIVERY TIME");


		//public Query lnkselectTimeSlot = x => x.Property("text").Contains("Delivery Time");

		public Query lnkfirstTimeSlot = x => x.Class("FD_IOS_Shared_DeliveryTimeTableCell").Index(0).Child().Class("UILabel");

		//Locators For Validate Orders Page From Me Section
		public Query clsordersInPage = x => x.Class("DetailedOrderTableViewCell");
		public String clsorders = "DetailedOrderTableViewCell";
		public String clsTableViewInOrders = "UITableViewCellContentView";
		public Query btninOrders = x => x.Class("DetailedOrderTableViewCell").Index(0).Child(0).Child(0);
		//public Query txtorderStatus = x => x.Class("UITableViewCellContentView").Index(1).Child(1);
		//public Query txtdeliveryDate = x => x.Class("UITableViewCellContentView").Index(1).Child(2);
		//public Query txttotalPrice = x => x.Class("UITableViewCellContentView").Index(1).Child(3);
		public String idarrowIcon = "Icons/RightArrow.png";

		//Locators for description on PDP page
		public Query txtdescription = x => x.Text("DESCRIPTION");

		//Add New Address
		public Query strcheckout = x => x.Text("Checkout");
		public Query lnkdeliveryAddress = x => x.Marked("Delivery Address");
		public Query btnaddNewAddress = x => x.Property("text").Contains("Add New");
		public Query straddNewAddress = x => x.Property("text").Contains("ADD NEW ADDRESS");
		public Query strdeliveryAddress = x => x.Property("text").Contains("DELIVERY ADDRESS");
		public Query radoffice = x => x.Class("D3RadioButton").Child().Marked("Office");
		public Query radhome = x => x.Class("D3RadioButton").Child().Marked("Home");
		public Query txtfirstName = x => x.Marked ("First Name");
		public Query txtlastName = x => x.Marked ("Last Name");
		public Query txtapartment = x => x.Marked ("Apt.");
		public Query txtzip = x => x.Marked ("Zip");
		public Query txtstate = x => x.Marked ("State");
		public Query txttelephone = x => x.Marked ("Telephone");
		public Query txtdeliveryInstructions = x => x.Marked ("Additional delivery instructions");
		public Query btnsave = x => x.Text ("Save");
		public Query btndoorman = x => x.Marked ("Leave With Doorman").Sibling ();
		public Query txtcompanyName = x => x.Marked ("Company Name");
		public Query txtfloor = x => x.Property("text").Contains("Floor/Suite");
		public Query btnremove = x => x.Marked("REMOVE");
		public Query btnconfirm = x => x.Marked("Confirm");

		//Select Tip
		public Query lnkselectTip = x => x.Text("Tip").Sibling().Property("text").Contains("Change");
		public Query btnapply = x => x.Text("Apply");
		public Query txttipSelect = x => x.Class("UIPickerTableView").Index(1).Child().Index(1).Child().Index(1);
		public Query txtfirstTip = x => x.Property("text").Contains("$").Index(0);
		public Query lsttipVal = x => x.Text("$3");
		public Query txtestimatedTotal = x => x.Text("Estimated Total*:").Sibling().Index(0);
		public Query txttipCheckout = x => x.Text("Tip:").Sibling().Index(0);

		//Locators for UiCoupons
		public Query idcouponOpenClose = x => x.Id("Coupon/scissor-coupon").Sibling(1);
		public Query idcouponScissorIcon = x => x.Id("Coupon/scissor-coupon");
		public Query idcouponScissorSavedIcon = x => x.Id("Coupon/scissor-coupon-saved");
		public Query idcouponOpenCloseSaved = x => x.Id("Coupon/scissor-coupon-saved").Sibling(1);
		public Query txtsaveCoupon = x => x.Property("text").Contains("Save $");
		public Query clscouponDescription = x => x.Class("FD_IOS_Shared_ECouponDetailView").Child(1).Child(0);
		public Query txttapToSavebtn = x => x.Marked("Tap to Save");
		public Query txtcouponProduct = x => x.Marked(CouponProduct);
		public String clscouponlabel = "FD_IOS_Shared_SaleAndCouponInfoView";
		public Query txtboxCustomTip = x => x.Class("UITextField");
		public Query lnkcustom = x => x.Text("Custom");
		public Query popupErrorOnTip = x => x.Property ("text").Contains ("As of now, we cap all electronic tips at 32% of the subtotal, making the highest allowed tip to be");

		//Modify Order Attributes
		public Query txtorders = x => x.Text("Orders");
		public Query txtmodifyBtn = x => x.Text("Modify").Index(0);
		public Query txttotalTax = x => x.Property("text").Contains("Total Tax:").Sibling().Index(0);
		public Query txttip = x => x.Property("text").Contains("Tip:").Sibling().Index(0);
		public Query txtdeliveryFee = x => x.Property("text").Contains("Delivery Fee:").Sibling().Index(0);
		public Query txtunitPrice = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Index(0).Child().Index(3).Child(0);
		public Query txtUpdatedPrice = x => x.Class("UIButtonLabel").Index(0);
		public Query txtswipeProduct = x => x.Class("FD_IOS_Shared_ProductDetailInformationView");
		public Query txtCartFirstProduct = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Index(0)	;
		public Query txtdeleteBtn = x => x.Text("Delete");

		//Edit Delivery Address
		public Query lnkedit = x => x.Marked("Edit").Index(1);
		public Query streditAddress = x => x.Marked("EDIT ADDRESS");

		//Invalid delivery address
		public Query popinvalidStreetAddress = x => x.Property("text").Contains("NOTIFY ME");
		public Query lnktryAnotherAddress = x => x.Property("text").Contains("Try another address");
		public Query strinvalidZip = x => x.Property("text").Contains("Invalid zip code");
		public Query popinvalidTelephone = x => x.Property("text").Contains("Telephone:Incomplete phone number (U.S. Only)");
		public Query btnok = x => x.Text("OK"); 
		public Query strinvalidName = x => x.Property("text").Contains("Last Name:Required First Name:Required ");

		//Cart Quantity
		public Query txtquantity = x => x.Id("BagItemsCount");

		//Banners on Home Page
		public Query clsbanner=x => x.Class("HomePageTableCell");

		//Product unavailable
		public Query txtprodUnavailable = x => x.Marked("Product unavailable");
		public Query txtname= x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Class("D3Label");
		public Query btnaddToCartPLP = x => x.Id("Icons/FDRQuickAdd.png");

		//Alcohol Notification
		public Query btncontinue = x=>x.Marked("Continue");

		//Select Payment
		public Query lnkselectPayment = x => x.Text("+ Select a Payment Method");
		public Query txtPaymentMethod = x => x.Property("text").Contains("Payment Method");
		public Query lnkfirstPayment = x => x.Class("PaymentTableViewCell").Index(0);
		public Query txtverifyPaymentPage = x => x.Text("PAYMENT METHOD");

		//About App Page Locators
		public Query txtaboutApp = x => x.Marked("ABOUT APP");
		public Query txtappVersion = x => x.Class("UITableViewLabel").Property("text").Contains("App Version");
		public Query clsappVersion = x => x.Class("UITableViewLabel").Property("text").Contains("App Version").Sibling();
		public Query txtiOSDevice = x => x.Class("UITableViewLabel").Property("text").Contains("iOS Device");
		public Query clsiOSDevice = x => x.Class("UITableViewLabel").Property("text").Contains("iOS Device").Sibling();
		public Query txtiOSVersion = x => x.Class("UITableViewLabel").Property("text").Contains("iOS Version");
		public Query clsiOSVersion = x => x.Class("UITableViewLabel").Property("text").Contains("iOS Version").Sibling();
		public Query txthelpAboutApp = x => x.Marked("About App");

		//Edit Payment
		public Query txteditCC = x => x.Text("Edit").Index(0);
		public Query txtdoneCaps = x => x.Text("DONE");
		public Query txtEditCard = x => x.Text("Edit Card");
		public Query txtpaymentMethod = x => x.Text("PAYMENT METHOD");

		//Legal Page
		public Query idhelp = x => x.Id("Icons/help");
		public Query txtlegal = x => x.Text("Legal");
		public Query txtlegalHeader = x => x.Text("LEGAL");
		public Query txtcustomerAgreement = x => x.Text("CUSTOMER AGREEMENT");
		public Query txtprivacyPolicy1 = x => x.Text("PRIVACY POLICY");
		public Query txtplatformTerms = x => x.Text("PLATFORM TERMS OF USE");
		public Query icback = x => x.Marked("Back");

		//Empty Bag
		public Query lnkemptyBag = x => x.Marked("emptycart");
		public Query btnyes = x => x.Text("Yes");
		public Query btncancelCheckout = x => x.Marked("Cancel");
		public Query idiconArrow = x => x.Id("Icons/NavArrow.png");

		//Cancel Order
		public Query txtmodifyOrder = x => x.Property("text").Contains("Modify Order:");
		public Query idrightArrow = x => x.Id("Icons/RightArrow.png").Index(0);
		public Query txtcancelOrderbtn = x => x.Text("CANCEL ORDER");
		public Query txtcancelOrderPopup = x => x.Text("Cancel Order");
		public Query txtyouOrderCancelSadFace = x => x.Text("Your order has been canceled. Sad face.");
		public Query txtfirstOrderStatus = x => x.Class("UITableViewCellContentView").Index(0).Child().Index(1);

		//PDP page of Product via Shop
		public Query strcarrots = x => x.Property("text").Contains("Carrots");
		public Query strlocal = x => x.Property("text").Contains("Local");

		//Add To cart From Home Page via PDP
		public Query clsfirstProductNavPDP = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Index(0).Child(1);

		//Add new address from ME settings page
		public Query lstaddress = x => x.Class("UITableViewCellContentView");

		//Product Validation on PDP
		public Query txtexpertRating = x => x.Property("text").Contains("Expert Rating");
		public Query txtguaranteedFresh = x => x.Text("Guaranteed Fresh");
		public Query txtguaranteedFreshLink = x => x.Text("Guaranteed Fresh").Sibling().Index(2);
		public Query txtguaranteedFreshCaps = x => x.Text("FRESHNESS GUARANTEE");
		public Query btnCancel = x => x.Marked("Cancel");

		//Modify from Me Orders page
		public Query taborders = x => x.Marked("Orders");
		public Query btnmodify = x => x.Marked("Modify");

		//Locators for Mobile number and Delivery Instruction
		public Query txtdeliveryInstruction = x => x.Marked("Delivery Instructions");
		public Query txtmobileNumber = x => x.Marked("Mobile Number");
		public Query iddeliveryInstruction = x => x.Id("DELIVERY INSTRUCTIONS");
		public Query txtsomethingMissing = x => x.Property("text").Contains("Looks like something's missing...");
		public Query txtmissingMobileNum = x => x.Marked("Please enter your mobile number.");
		public Query clsdeliveryTextView = x => x.Class("UITextView");

		//Validate Order Placed page
		public Query txtyourOrderHasBeenPlaced = x => x.Property("text").Contains("YOUR ORDER HAS BEEN PLACED SUCCESSFULLY");
		public Query txtdeliveryTimeOnPlacedOrder = x => x.Property("text").Contains("Fresh and tasty food will be delivered:");
		public Query txtestTotal = x => x.Property("text").Contains("Est. Total: $");
		public Query btnviewReceipt = x => x.Class("UIButtonLabel").Text("VIEW RECEIPT");
		public Query txtwhatNext = x => x.Property("text").Contains("What's Next?");
		public Query txtfinalOrderTotal = x => x.Property("text").Contains("Final Order Total");
		public Query txttipping = x => x.Property("text").Contains("Tipping");
		public Query txtbelowFinalOrderTotal = x => x.Property("text").Contains("Final Order Total").Sibling().Index(1);
		public Query textBelowTipping = x => x.Property("text").Contains("Tipping").Sibling().Index(3);

		//validate Receipt page
		public Query txtreceipt = x => x.Text("RECEIPT");
		public Query btncancelOrder = x => x.Class("UIButtonLabel").Text("CANCEL ORDER");
		public Query txtcartDetails = x => x.Text("Cart Details");
		public Query txtdeliveryInstructionsOnReceipt = x => x.Text("Delivery Instructions");
		public Query txtcontactNumber = x => x.Text("Contact Number");
		public Query txtphoneNumber1 = x => x.Text("Contact Number").Sibling().Index(7);
		public Query txtorderNumber = x => x.Property("text").Contains("Order Number: ");
		public Query txtorderStatus = x => x.Property("text").Contains("Order Status: ");

		//Modify Email
		public Query strheaderEmail = x => x.Text("E-mail");
		public Query txtnewEmailAddress = x => x.Text("New email address");
		public Query txtconfirmNewEmailAddress = x => x.Text("Confirm new email address");
		public Query txtenterPassword = x => x.Text("Enter password");
		public Query popemailUpdated = x => x.Property("text").Contains("Your email has been successfully updated.");
		public Query icnclose = x => x.Marked("IconClose");

		//Promo Code
		public Query txtpromoCode = x => x.Text ("Promo Code:");
		public Query txtenterPromoCode = x => x.Text("ENTER YOUR CODE HERE");
		public Query txtcodeApplied = x => x.Text("Code Applied!");
		public Query txtyouhveSave = x => x.Text("You've saved:");
		public Query txtyouhveSaveAmount = x => x.Text("You've saved:").Sibling().Index(0);

		//Contact Us
		public Query strcontactUs = x => x.Marked("Contact Us");
		public Query lnkhelp = x => x.Id("Icons/help");
		public Query lnksubject = x => x.Marked("Subject");
		public Query txtmessage = x => x.Marked("Message").Sibling().Index(0);
		public Query btnsendMessage = x => x.Marked("Send Message");
		public Query strmessageSent = x => x.Marked("Message Sent!");

		//Add To Cart From Me List Page via Quick add
		public Query txtlists = x => x.Marked("Lists");
		public Query txtuserList = x => x.Property("text").Contains("'s List").Index(0);
		public Query clslistItemCount = x => x.Class("UITableViewCellContentView").Child();
		public String clslistItem = "UITableViewCellContentView";

		//Validate Me List Page
		public Query clsproductCellPLP = x => x.Class("FD_IOS_Shared_ProductCardView").Index(0);
	
		//Remove and Continue in Age verification Popup
	    public Query btnremoveAndProceed= x => x.Marked("REMOVE & PROCEED");

		//Shop from Past Orders
		public Query btnshopFromOrder=x=>x.Text("Shop").Index(0);
		public Query strshopFromOrdersPage = x => x.Marked("Shop From Order");
		public Query txtquantityShopFromOrder = x => x.Class ("FD_IOS_Shared_QuickAddView_QuantityView").Class ("D3Label");
		public Query btnremoveQuantity = x => x.Id("IconTrashWhite");
	
		//Edit Paylist
		public Query clspaymentList = x => x.Class("PaymentTableViewCell");
		public Query txtleftDrawer = x => x.Class("UIImageView");

		// SMS Alert
		public Query txtnotificationSMSAlert = x => x.Text("Notifications & SMS Alerts");
		public Query txtmessageAlert = x => x.Text("Text Message Alerts");
		public Query txttermsNCondition = x => x.Property ("text").Contains ("Terms and Conditions");
		public Query txtsmsTermsOfUse = x => x.Property("text").Contains("SMS TERMS OF USE");
		public Query txtprivacyPolicy = x => x.Property("text").Contains("Privacy Policy");
		public Query txtprivacyPolicyCaps = x => x.Property("text").Contains("PRIVACY POLICY");
		public Query txtmobileNumberNew = x => x.Class("UITextFieldLabel");

		// ME Stting
		public Query txtpaymentMethodSetting = x => x.Text("Payment Method");

		//Modify Password
		public Query txtcurrentPassword = x => x.Text("Current password");
		public Query txtnewPassword = x => x.Text("New password");
		public Query txtretypeNewPassword = x => x.Text("Re-type new password");
		public Query poppasswordUpdated = x => x.Property("text").Contains("Your password has been successfully updated.");
		public Query strheaderPassword = x => x.Text("Password");

		//Payment
		public Query txtCredit = x => x.Property("text").Contains("Credit");

		//Full and Eco friendly Time Slot
		public Query txtfullSlot = x => x.Property("text").Contains("Full").Index(0);
		public Query txtoopsError = x => x.Property("text").Contains("Ooops!");
		//public Query txtecoFriendlySlot = x => x.Id("Icons/DeliveryEco.png").Index(0).Parent().Sibling().Index(0);
		public Query icnecoFriendly = x => x.Class("FD_IOS_Shared_DeliveryTimeTableCell").Class("D3Button").Marked("DeliveryEco").Index(0).Sibling().Index(0);

		//Verify Alcohol Notification Locators
		public Query txtfirstProductAlcohol =  x => x.Id("IconTradeAlcohol").Index(0).Sibling().Class("FD_IOS_Shared_ProductDetailInformationView").Child();

		//Food Safety
		public Query idhelpIcon = x => x.Id("Icons/help");
		public Query lnkfoodSafety = x => x.Marked("Food Safety");
		public Query strfoodSafety = x => x.Marked("FOOD SAFETY");
		public Query lnkproductRecalls = x => x.Marked("Product Recalls");
		public Query lnkcookingStorage = x => x.Marked("Cooking & Storage");
		public Query lnkhandlingFoodSafety = x => x.Marked("Handling Food Safety");
		public Query webview = x => x.Class("UIWebView");
		public Query btnback = x => x.Marked("Back");

		// Cart Validation
		public Query clstotalItemsBag = x => x.Class("FD_IOS_Shared_BagTopLineView").Child().Index(0);
		public Query clssubTotalBag = x => x.Class("FD_IOS_Shared_BagTopLineView").Child().Index(1);
		public Query txtBagTemplate = x => x.Property("text").Contains("T = TAXABLE ITEM");
		public Query txtchkoutSubTotal = x => x.Text ("Order Subtotal:").Sibling ().Index (0);
		public Query txtchkoutEstimated = x => x.Text ("Estimated Total*:").Sibling ().Index (0);
		public Query txtchkoutTax = x => x.Text ("Total Tax:").Sibling ().Index (0);
		public Query txtchkoutDeliveryFee = x => x.Text ("Delivery Fee:").Sibling ().Index (0);
		public Query txtemptyMsg = x => x.Text ("Are you sure you want delete all items in your cart?");
		public Query txtchkoutTip = x => x.Text("Tip:").Sibling().Index(0);
		public Query clsprodCntr = x => x.Class("FD_IOS_Shared_BagLineItemCell");
	
	    //Validate FAQ and Freshness Guarantee Page
		public Query txtfaq = x => x.Marked("Frequently Asked Questions");
		public Query txtfreshnessGuarantee = x => x.Marked("Freshness Guarantee");
		public String clstableFAQ = "UITableViewLabel";
		public Query clsquestionsAsked = x => x.Class("D3TableViewCell");
		public Query txtguaranteeSatisfaction = x => x.Marked("100% Satisfaction Guarantee with Every Product Every Time");
		public Query idfaq = x => x.Id("FAQ");
		public Query idhelpHeader = x => x.Id("HELP");

		//Chef table benefits
		public Query tabchefTableBenefit = x => x.Text("Chef's Table Benefits");
		public Query verifychefTableBenefitPage = x => x.Id("Chef's Table Benefits");
		public Query strchefTableContent1 = x => x.Marked("Dedicated Service Specialists");
		public Query strchefTableContent2 = x => x.Marked("Reserve Delivery Privilege");
		public Query strchefTableContent3 = x => x.Marked("Product Guarantee");
		public Query btnReserveDeliverySpot = x => x.Text("Reserve Delivery Spot");
		public Query strchefTableContent = x => x.Class("UITableViewWrapperView").Child();

		//Change Address :
		public Query txtdelivAdd = x => x.Class("FD_IOS_Shared_AddressLocatorPopup").Child().Class("UIView").Class("UITextFieldLabel");
		public Query lstaddressLocator = x => x.Class("Door3_IOS_Shared_D3ListView_1").Child().Class("FD_IOS_Shared_AddressPopupListCell");
		public Query txtAdd0 = x => x.Class("Door3_IOS_Shared_D3ListView_1").Child().Class("FD_IOS_Shared_AddressPopupListCell").Index(0);
		public Query txtAdd1 = x => x.Class("Door3_IOS_Shared_D3ListView_1").Child().Class("FD_IOS_Shared_AddressPopupListCell").Index(1);
		public Query txtChkoutAdd = x => x.Text("Delivery Address").Sibling().Index(3);

		//Address Locator popup
		public Query clsaddressLocatorPopup = x => x.Class("FD_IOS_Shared_AddressLocatorPopup");
		public Query strwhereToDeliver = x => x.Class("FD_IOS_Shared_AddressLocatorPopup").Child(0).Child(1);
		public Query txtwhereToDeliver = x => x.Property("text").Contains("WHERE SHOULD WE DELIVER?");
		public Query clsaddressField = x => x.Class("D3TextField");
		public Query strcurrentLocation = x => x.Class("FD_IOS_Shared_AddressLocatorPopup").Child(0).Child(2);
		public Query txtcurrentLocation = x => x.Property("text").Contains("Current Location");
		public Query address1 = x => x.Class("Door3_IOS_Shared_D3ListView_1").Child().Class("FD_IOS_Shared_AddressPopupListCell").Index(0);
		public Query btndeleteText = x => x.Class("D3TextField").Child(1);
		public Query popallow = x => x.Property("text").Contains("Allow");

		//Pre-reservation
		public Query strsuccessfulMessage = x => x.Text("Timeslot has been reserved successfully.");

		//Coupon product
		public Query btnexpandCoupon = x => x.Id("IconPlusWhite").Index(0);
		public Query btntapToSave = x => x.Marked("Tap to Save");

		// Banner
		public Query clsfirstBanner = x => x.Class("HomePageTableCell").Child().Class("UILabel").Index(1);
		//Locator
		public Query txtselectedDate = x => x.Property("text").Contains("day").Index(0);
		public Query txtageVeri = x => x.Property("text").Contains("Age Verification for orders");

		//Mandate Fields
		public Query txtlooksLike = x => x.Property("text").Contains("Looks like something's missing");
		public Query txtselectDeliveryTime = x => x.Text("Please select a delivery time.");
		public Query txtselectPayment= x => x.Text("Please select a payment method.");
		public Query txtenterMobileNumber= x => x.Text("Please enter your mobile number.");

		//Shop From Order
		public Query txtshopFirst = x => x.Text("Shop").Index(0);
		public Query txtshopFromOrder = x => x.Text("Shop From Order");
		public Query txtorder = x => x.Property("text").Contains("Order #");

		// Mobile Number 
		public Query txtmblNumber = x => x.Text("Mobile Number").Index(0);
		public Query txtMobileChange = x => x.Text("Mobile Number").Sibling().Text("Change");

		// Banners
		public Query txtbannerFirst =  x => x.Class("UITableViewCellContentView").Child(2);


		// Max Limit
		public Query txtpricePDP = x => x.Class("FD_IOS_Shared_ProductDetailInformationView").Child().Child().Property("text").Contains("$");
		public Query txtLimitDetails = x => x.Text("Whoops").Sibling(0).Property("text").Contains("accept orders over");
		public Query txtestmatedTotal = x => x.Text("Estimated Total*:").Sibling(0);
		public Query txtorderChanged = x => x.Text("ORDER CHANGED");

		//Item Alerts
		public Query clsunavailableItem = x => x.Class("FD_IOS_Shared_ATPCurrentLineItemView");
		public Query txtitemAlert = x => x.Property("text").Contains("Item Alerts");
		public Query btnremoveItem = x => x.Class("FD_IOS_Shared_ATPFooterView").Child("D3Button");

		// Delivery Pass
		public Query txtlearnMore = x => x.Text("LEARN MORE");
		public Query txtdeliveryPass = x => x.Text("DeliveryPass");
		public Query txtgetFreeDelivery = x => x.Text("Delivery Fee: Get Free Delivery!");
		public Query txtdeliveryPassOption = x => x.Text("Delivery Pass options");

	}
}

