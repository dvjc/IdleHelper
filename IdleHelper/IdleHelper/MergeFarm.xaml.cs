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
            }
            return retVal;
        }

        public List<string> GetPlantList(PlantEnums plant)
        {
            List<string> retVal = new List<string>();
            switch(plant)
            {
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