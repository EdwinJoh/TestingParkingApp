using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TestingParkingApp
{
    public class DialogToUser
    {
        public Form1 hej { get; set; }
        /// <summary>
        /// Here is out dialog class where we show messages to the user deppending on what they do in the program.
        /// </summary>
        public Configuration? settings { get; set; } = Configuration.ReadSettingsFromFile(); //instance the settings class to get our values from our json file
        public void SuccsessMessage(string option, ParkingSpot spot)
        {
            
        }
        public void ParkingHouseFull()
        {
         
        }
        public void ErrorCheckReg(string regNum)
        {
            
        }
        public void AskForNewSpot()
        {
           
        }
        public void PriceMessage(int price)
        {
           
        }
        public void PrintPriceList()
        {
         
        }
        public void MoveNotCompleted(string regNum)
        {
           
        }
        public void SearchSuccses(Vehicle vehicle, ParkingSpot spot)
        {
           
        }
        public void PrintVehicles()
        {
           

        }
        public void AskForNewValue()
        {
          
        }
        public void ErrorChangeSettings(int value)
        {
         
        }
        public void SettingChangeCompleted(string setting, int value)
        {
         
        }
        public void BigVehiceSuccsess(string option, int newspot, ParkingSpot spot)
        {
        
        }
    }
}
