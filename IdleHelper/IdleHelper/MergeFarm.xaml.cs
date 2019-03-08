using IdleHelper.Reusables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IdleHelper
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MergeFarm : ContentPage
	{
		public MergeFarm ()
		{
			InitializeComponent ();

            LoadPickers();
		}

        public void LoadPickers()
        {
            #region Tomato Picker
            pickerTomato.ItemsSource = GetPlantList(PlantEnums.Tomato);
            pickerTomato.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Tomato Picker

            #region Wheat Picker
            pickerWheat.ItemsSource = GetPlantList(PlantEnums.Wheat);
            pickerWheat.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Wheat Picker

            #region Eggplant Picker
            pickerEggplant.ItemsSource = GetPlantList(PlantEnums.Eggplant);
            pickerEggplant.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Eggplant Picker

            #region Grape Picker
            pickerGrape.ItemsSource = GetPlantList(PlantEnums.Grape);
            pickerGrape.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Grape Picker

            #region Carrot Picker
            pickerCarrot.ItemsSource = GetPlantList(PlantEnums.Carrot);
            pickerCarrot.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Carrot Picker

            #region Pumpkin Picker
            pickerPumpkin.ItemsSource = GetPlantList(PlantEnums.Pumpkin);
            pickerPumpkin.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Pumpkin Picker

            #region Pepper Picker
            pickerPepper.ItemsSource = GetPlantList(PlantEnums.Pepper);
            pickerPepper.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Pepper Picker

            #region Cucumber Picker
            pickerCucumber.ItemsSource = GetPlantList(PlantEnums.Cucumber);
            pickerCucumber.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Cucumber Picker

            #region Blueberry Picker
            pickerBlueberry.ItemsSource = GetPlantList(PlantEnums.Blueberry);
            pickerBlueberry.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Blueberry Picker

            #region Cabbage Picker
            pickerCabbage.ItemsSource = GetPlantList(PlantEnums.Cabbage);
            pickerCabbage.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Cabbage Picker

            #region Corn Picker
            pickerCorn.ItemsSource = GetPlantList(PlantEnums.Corn);
            pickerCorn.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Corn Picker

            #region Potato Picker
            pickerPotato.ItemsSource = GetPlantList(PlantEnums.Potato);
            pickerPotato.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Potato Picker

            #region Strawberry Picker
            pickerStrawberry.ItemsSource = GetPlantList(PlantEnums.Strawberry);
            pickerStrawberry.SelectedIndexChanged += UpdateAllTheThings;
            #endregion Strawberry Picker
        }

        public double SumSelectionControls()
        {
            Dictionary<PlantEnums, Picker> allPickers = new Dictionary<PlantEnums, Picker>
            {
                  { PlantEnums.Tomato, pickerTomato }
                , { PlantEnums.Wheat, pickerWheat }
                , { PlantEnums.Eggplant, pickerEggplant }
                , { PlantEnums.Grape, pickerGrape }
                , { PlantEnums.Carrot, pickerCarrot }
                , { PlantEnums.Pumpkin, pickerPumpkin }
                , { PlantEnums.Pepper, pickerPepper }
                , { PlantEnums.Cucumber, pickerCucumber }
                , { PlantEnums.Blueberry, pickerBlueberry }
                , { PlantEnums.Cabbage, pickerCabbage }
                , { PlantEnums.Corn, pickerCorn }
            };

            double totalValue = 0;

            foreach (var item in allPickers)
            {
                int i = item.Value.SelectedIndex;
                if (i > 0)
                {
                    int unitPrice = GetPlantUnitPrice(item.Key);
                    double count = Math.Pow(2, i - 1);
                    totalValue += unitPrice * count;
                }
            }

            return totalValue;
        }

        public int GetPlantUnitPrice(PlantEnums plant)
        {
            int retVal = -1;
            switch(plant)
            {
                case PlantEnums.Tomato:
                    retVal = 6;
                    break;
                case PlantEnums.Wheat:
                    retVal = 12;
                    break;
                case PlantEnums.Eggplant:
                    retVal = 18;
                    break;
                case PlantEnums.Grape:
                    retVal = 30;
                    break;
                case PlantEnums.Carrot:
                    retVal = 42;
                    break;
                case PlantEnums.Pumpkin:
                    retVal = 60;
                    break;
                case PlantEnums.Pepper:
                    retVal = 90;
                    break;
                case PlantEnums.Cucumber:
                    retVal = 120;
                    break;
                case PlantEnums.Blueberry:
                    retVal = 150;
                    break;
                case PlantEnums.Cabbage:
                    retVal = 180;
                    break;
                case PlantEnums.Corn:
                    retVal = 210;
                    break;
                case PlantEnums.Potato:
                    retVal = 240;
                    break;
                case PlantEnums.Strawberry:
                    retVal = 270;
                    break;
                case PlantEnums.Watermelon:
                    retVal = 330;
                    break;
                case PlantEnums.Apple:
                    retVal = 360;
                    break;
                case PlantEnums.Cherry:
                    retVal = 390;
                    break;
                case PlantEnums.Vanilla:
                    retVal = 420;
                    break;
                case PlantEnums.Avocado:
                    retVal = 450;
                    break;
                case PlantEnums.Cotton:
                    retVal = 480;
                    break;
                case PlantEnums.Orange:
                    retVal = 510;
                    break;
                case PlantEnums.Sugarcane:
                    retVal = 540;
                    break;
                case PlantEnums.Pineapple:
                    retVal = 570;
                    break;
                case PlantEnums.Kiwi:
                    retVal = 600;
                    break;
                case PlantEnums.Peach:
                    retVal = 630;
                    break;
                case PlantEnums.Fig:
                    retVal = 660;
                    break;
                case PlantEnums.Pear:
                    retVal = 690;
                    break;
                case PlantEnums.Pomegranite:
                    retVal = 720;
                    break;
                case PlantEnums.Coffee:
                    retVal = 750;
                    break;
                case PlantEnums.Banana:
                    retVal = 780;
                    break;
                case PlantEnums.Lemon:
                    retVal = 780;
                    break;
            }
            return retVal;
        }

        public List<string> GetPlantList(PlantEnums plant)
        {
            List<string> retVal = new List<string>();
            switch(plant)
            {
                #region tomato case
                case PlantEnums.Tomato:
                    retVal.Add("Select a Tomato Level");
                    retVal.Add("Tomato Sapling");
                    retVal.Add("Tiny Tomato Plant");
                    retVal.Add("Small Tomato Shrub");
                    retVal.Add("Rich Tomato Bush");
                    retVal.Add("Bountiful Tomato Blush");
                    retVal.Add("Luscious Tomato Field");
                    retVal.Add("Rustic Tomato Field");
                    retVal.Add("Modern Tomato Plot");
                    retVal.Add("Polished Tomato Plot");
                    retVal.Add("Spage Age Tomato Plot");
                    break;
                #endregion tomato case
                #region wheat case
                case PlantEnums.Wheat:
                    retVal.Add("Select a Wheat Level");
                    retVal.Add("Small Wheat Plant");
                    retVal.Add("Normal Wheat Plant");
                    retVal.Add("Healthy Wheat Crop");
                    retVal.Add("Robust Wheat Crop");
                    retVal.Add("Large Wheat Crop");
                    retVal.Add("Stuffed Wheat Crop");
                    retVal.Add("Fantastic Wheat Crop");
                    retVal.Add("Magnificent Wheat Crop");
                    retVal.Add("Elevated Wheat Field");
                    retVal.Add("Hydroponic Wheat Field");
                    break;
                #endregion wheat case
                #region eggplant case
                case PlantEnums.Eggplant:
                    retVal.Add("Select a Eggplant Level");
                    retVal.Add("Eggplant Sapling");
                    retVal.Add("Small Eggplant Crop");
                    retVal.Add("Large Eggplant Crop");
                    retVal.Add("Rich Eggplant Crop");
                    retVal.Add("Grand Eggplant Crop");
                    retVal.Add("Fenced Eggplant Field");
                    retVal.Add("Wooden Eggplant Field");
                    retVal.Add("Stone Eggplant Field");
                    retVal.Add("Brick Eggplant Field");
                    retVal.Add("Luscious Eggplant Cradle");
                    break;
                #endregion eggplant case
                #region grape case
                case PlantEnums.Grape:
                    retVal.Add("Select a Grape Level");
                    retVal.Add("Small Grape Plant");
                    retVal.Add("Healthy Grape Vines");
                    retVal.Add("Tangled Grape Vines");
                    retVal.Add("Noble Grapes");
                    retVal.Add("Mature Grapes Vines");
                    retVal.Add("Makeshift Grape Arbor");
                    retVal.Add("Solid Grape Arbor");
                    retVal.Add("Luxurious Grape Arbor");
                    retVal.Add("Shiny Grape Arbor");
                    retVal.Add("Fancy Grape Arbor");
                    break;
                #endregion grape case
                #region carrot case
                case PlantEnums.Carrot:
                    retVal.Add("Select a Carrot Level");
                    retVal.Add("Single Carrot Plant");
                    retVal.Add("Pair of Carrots");
                    retVal.Add("Burrow of Carrots");
                    retVal.Add("Carrot Quad");
                    retVal.Add("Plentiful Carrot Plot");
                    retVal.Add("Nestled Carrot Plot");
                    retVal.Add("Raised Carrot Plot");
                    retVal.Add("Earthy Carrot Plot");
                    retVal.Add("Premium Carrot Plot");
                    retVal.Add("Designer Carrot Plot");
                    break;
                #endregion carrot case
                #region pumpkin case
                case PlantEnums.Pumpkin:
                    retVal.Add("Select a Pumpkin Level");
                    retVal.Add("Small Pumpkin Plant");
                    retVal.Add("Nice Pumpkin Patch");
                    retVal.Add("Grand Pumpkin Patch");
                    retVal.Add("Pristine Pumpkin Patch");
                    retVal.Add("Massive Pumpkin Patch");
                    retVal.Add("Overflowing Pumpkin Patch");
                    retVal.Add("Crafted Pumpkin Patch");
                    retVal.Add("Clay Pumpkin Patch");
                    retVal.Add("Hardened Pumpkin Patch");
                    retVal.Add("Prismatic Pumpkin Patch");
                    break;
                #endregion pumpkin case
                #region pepper case
                case PlantEnums.Pepper:
                    retVal.Add("Select a Pepper Level");
                    retVal.Add("Minor Pepper Plant");
                    retVal.Add("Paired Pepper Plants");
                    retVal.Add("Big Pepper Bush");
                    retVal.Add("Plentiful Pepper Bush");
                    retVal.Add("Super Stacked Pepper Plant");
                    retVal.Add("Grounded Pepper Shrub");
                    retVal.Add("Small Pepper Plot");
                    retVal.Add("Plentiful Pepper Plot");
                    retVal.Add("Grandiouse Pepper Plot");
                    retVal.Add("Awesome Pepper Plot");
                    break;
                #endregion pepper case
                #region cucumber case
                case PlantEnums.Cucumber:
                    retVal.Add("Select a Cucumber Level");
                    retVal.Add("Tiny Cucumber Bush");
                    retVal.Add("Normal Cucumber Bush");
                    retVal.Add("Crowded Cucumber Bush");
                    retVal.Add("Excellent Cucumber Bush");
                    retVal.Add("Magnificent Cucumber Bush");
                    retVal.Add("Sturdy Cucumber Bush");
                    retVal.Add("Excellent Cucumber Bush");
                    retVal.Add("Regal Cucumber Bush");
                    retVal.Add("Grand Cucumber Bush");
                    retVal.Add("Masterful Cucumber Bush");
                    break;
                #endregion cucumber case
                #region blueberry case
                case PlantEnums.Blueberry:
                    retVal.Add("Select a Blueberry Level");
                    retVal.Add("Fledgling Blueberry Plant");
                    retVal.Add("Plain Blueberry Plant");
                    retVal.Add("Wild Blueberry Plant");
                    retVal.Add("Young Blueberry Bush");
                    retVal.Add("Bright Blueberry Bush");
                    retVal.Add("Outdoor Blueberry Bush");
                    retVal.Add("Boxed Blueberry Bush");
                    retVal.Add("Potted Blueberry Bush");
                    retVal.Add("Refined Blueberry Bush");
                    retVal.Add("Deluxe Blueberry Bush");
                    break;
                #endregion blueberry case
                #region cabbage case
                case PlantEnums.Cabbage:
                    retVal.Add("Select a Cabbage Level");
                    retVal.Add("Lone Cabbage Plant");
                    retVal.Add("Cabbage Duo");
                    retVal.Add("Level 3 Cabbage");
                    retVal.Add("Level 4 Cabbage");
                    retVal.Add("Level 5 Cabbage");
                    retVal.Add("Level 6 Cabbage");
                    retVal.Add("Sealed Cabbage Patch");
                    retVal.Add("Earthy Cabbage Patch");
                    retVal.Add("Level 9 Cabbage");
                    retVal.Add("Artistic Cabbage Patch");
                    break;
                #endregion cabbage case
                #region corn case
                case PlantEnums.Corn:
                    retVal.Add("Select a Corn Level");
                    retVal.Add("Single Ear Of Corn");
                    retVal.Add("Pair Of Corn Ears");
                    retVal.Add("Trio Of Corn Ears");
                    retVal.Add("Corn Ear Quadruplet");
                    retVal.Add("Lush Bushel of Corn");
                    retVal.Add("Proud Plot Of Corn");
                    retVal.Add("Sturdy Plot Of Corn");
                    retVal.Add("Tiled Plot Of Corn");
                    retVal.Add("Stylized Corn Plot");
                    retVal.Add("Art Deco Corn Plot");
                    break;
                #endregion corn case
                #region potato case
                case PlantEnums.Potato:
                    retVal.Add("Select a Potato Level");
                    retVal.Add("Single Ear Of Corn");
                    retVal.Add("Potato Pair");
                    retVal.Add("Pretty Potato Patch");
                    retVal.Add("Bunch O' Potatoes");
                    retVal.Add("Golden Potato Plot");
                    retVal.Add("Organic Potato Plot");
                    retVal.Add("Peaceful Potato Plot");
                    retVal.Add("Precious Potato Plot");
                    retVal.Add("Prosperous Potato Plot");
                    retVal.Add("Priceless Potato Plot");
                    break;
                #endregion potato case
                #region strawberry case
                case PlantEnums.Strawberry:
                    retVal.Add("Select a Strawberry Level");
                    retVal.Add("Singular Strawberry Shrub");
                    retVal.Add("Sweet Strawberry Shrub");
                    retVal.Add("Special Strawberry Bush");
                    retVal.Add("Shiny Strawberry Bush");
                    retVal.Add("Sublime Strawberry Bush");
                    retVal.Add("Scenic Strawberry Bush");
                    retVal.Add("Sightly Strawberry Bush");
                    retVal.Add("Snazzy Strawberry Bush");
                    retVal.Add("Slick Strawberry Bush");
                    retVal.Add("Sensational Strawberry Bush");
                    break;
                #endregion strawberry case
                #region watermelon case
                case PlantEnums.Watermelon:
                    retVal.Add("Select a Watermelon Level");
                    retVal.Add("Tasty Watermelon Plant");
                    retVal.Add("Wise Watermelon Plot");
                    retVal.Add("Worthy Watermelon Plot");
                    retVal.Add("Wholesome Watermelon Plot");
                    retVal.Add("Wide Watermelon Plot");
                    retVal.Add("Woody Watermelon Plot");
                    retVal.Add("Wondrous Watermelon Plot");
                    retVal.Add("Whimsical Watermelons");
                    retVal.Add("Well-built Watermelon Plot");
                    retVal.Add("World-class Watermelons");
                    break;
                #endregion watermelon case
                #region apple case
                case PlantEnums.Apple:
                    retVal.Add("Select an Apple Level");
                    retVal.Add("Level 1 Apple");
                    retVal.Add("Level 2 Apple");
                    retVal.Add("Level 3 Apple");
                    retVal.Add("Level 4 Apple");
                    retVal.Add("Level 5 Apple");
                    retVal.Add("Level 6 Apple");
                    retVal.Add("Level 7 Apple");
                    retVal.Add("Level 8 Apple");
                    retVal.Add("Level 9 Apple");
                    retVal.Add("Level 10 Apple");
                    break;
                #endregion apple case
                #region cherry case
                case PlantEnums.Cherry:
                    retVal.Add("Select a Cherry Level");
                    retVal.Add("Cherry Tree Sapling");
                    retVal.Add("Twin Cherry Tree");
                    retVal.Add("Triple Cherry Tree");
                    retVal.Add("Tasteful Cherry Tree");
                    retVal.Add("Sweet Cherry Tree");
                    retVal.Add("Sour Cherry Tree");
                    retVal.Add("Tumultuous Cherry Tree");
                    retVal.Add("True Cherry Tree");
                    retVal.Add("Chipper Cherry Tree");
                    retVal.Add("Care Free Cherry Tree");
                    break;
                #endregion cherry case
                #region vanilla case
                case PlantEnums.Vanilla:
                    int v = 0;
                    retVal.Add("Select a Vanilla Level");
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(v++).Append(" Vanilla").ToString());
                    break;
                #endregion vanilla case
                #region avocado case
                case PlantEnums.Avocado:
                    int a = 0;
                    retVal.Add("Select an Avocado Level");
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(a++).Append(" Avocado").ToString());
                    break;
                #endregion avocado case
                #region cotton case
                case PlantEnums.Cotton:
                    int c = 0;
                    retVal.Add("Select a Cotton Level");
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    retVal.Add(new StringBuilder("Level ").Append(c++).Append(" Cotton").ToString());
                    break;
                #endregion cotton case
            }
            return retVal;
        }

        public void UpdateAllTheThings(object sender, EventArgs e)
        {
            double selectedCropValue = SumSelectionControls();
            lblValue.Text = new StringBuilder(selectedCropValue.ToString()).Append(" gold").ToString();

            if (string.IsNullOrEmpty(SellNow.Text))
            {
                lblRecommend.Text = "No Sell Now Provided";
            }
            else if (double.TryParse(SellNow.Text, out double sellNowValue))
            {
                double profit = sellNowValue - selectedCropValue;
                StringBuilder result = new StringBuilder();

                if (profit < 0)
                {
                    result.Append("Skip! [");
                    result.Append(profit);
                    result.Append(" loss]");
                    lblRecommend.BackgroundColor = Color.Red;
                    lblRecommend.TextColor = Color.Black;
                }

                else
                {
                    result.Append("Sell! [");
                    result.Append(profit);
                    result.Append(" profit]");
                    lblRecommend.BackgroundColor = Color.Green;
                    lblRecommend.TextColor = Color.White;
                }
                lblRecommend.Text = result.ToString();
            }
        }

        private void BtnReturn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}