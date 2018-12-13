﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace GI_Desktop
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Train_Vertical recording.
    /// </summary>
    [TestModule("9ccaf61f-da92-47a7-aaf0-5d7b825edff0", ModuleType.Recording, 1)]
    public partial class Train_Vertical : ITestModule
    {
        /// <summary>
        /// Holds an instance of the GI_DesktopRepository repository.
        /// </summary>
        public static GI_DesktopRepository repo = GI_DesktopRepository.Instance;

        static Train_Vertical instance = new Train_Vertical();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Train_Vertical()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Train_Vertical Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'OnlineFlightBookingHotelsBusAmp.Trains' at 21;10.", repo.OnlineFlightBookingHotelsBusAmp.TrainsInfo, new RecordItemIndex(0));
            repo.OnlineFlightBookingHotelsBusAmp.Trains.MoveTo("21;10");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'OnlineFlightBookingHotelsBusAmp.Trains' at 21;10.", repo.OnlineFlightBookingHotelsBusAmp.TrainsInfo, new RecordItemIndex(1));
            repo.OnlineFlightBookingHotelsBusAmp.Trains.MoveTo("21;10");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(3620);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL' at 215;26.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(2));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.Click("215;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(4));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'delhi' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(5));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("delhi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MainTxt' at 190;9.", repo.OnlineFlightBookingHotelsBusAmp.MainTxtInfo, new RecordItemIndex(6));
            repo.OnlineFlightBookingHotelsBusAmp.MainTxt.Click("190;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.GosuggestInputL' at 144;9.", repo.OnlineHotelBookingBookCheapBudge.GosuggestInputLInfo, new RecordItemIndex(7));
            repo.OnlineHotelBookingBookCheapBudge.GosuggestInputL.Click("144;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'OnlineHotelBookingBookCheapBudge.GosuggestInputL'.", repo.OnlineHotelBookingBookCheapBudge.GosuggestInputLInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.OnlineHotelBookingBookCheapBudge.GosuggestInputL);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}ka' with focus on 'OnlineHotelBookingBookCheapBudge.GosuggestInputL'.", repo.OnlineHotelBookingBookCheapBudge.GosuggestInputLInfo, new RecordItemIndex(9));
            repo.OnlineHotelBookingBookCheapBudge.GosuggestInputL.PressKeys("{Back}ka");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'lya' with focus on 'OnlineHotelBookingBookCheapBudge.GosuggestInputL'.", repo.OnlineHotelBookingBookCheapBudge.GosuggestInputLInfo, new RecordItemIndex(10));
            repo.OnlineHotelBookingBookCheapBudge.GosuggestInputL.PressKeys("lya");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MainTxt' at 137;12.", repo.OnlineFlightBookingHotelsBusAmp.MainTxtInfo, new RecordItemIndex(11));
            repo.OnlineFlightBookingHotelsBusAmp.MainTxt.Click("137;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiSearch.Text' at 114;12.", repo.OnlineFlightBookingHotelsBusAmp.GiSearch.TextInfo, new RecordItemIndex(12));
            repo.OnlineFlightBookingHotelsBusAmp.GiSearch.Text.Click("114;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiSearch.DayPickerNavButtonDayPickerNavButton' at 9;10.", repo.OnlineFlightBookingHotelsBusAmp.GiSearch.DayPickerNavButtonDayPickerNavButtonInfo, new RecordItemIndex(13));
            repo.OnlineFlightBookingHotelsBusAmp.GiSearch.DayPickerNavButtonDayPickerNavButton.Click("9;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OnlineFlightBookingHotelsBusAmp.GiSearch.DayPickerNavButtonDayPickerNavButton' at 9;10.", repo.OnlineFlightBookingHotelsBusAmp.GiSearch.DayPickerNavButtonDayPickerNavButtonInfo, new RecordItemIndex(14));
            repo.OnlineFlightBookingHotelsBusAmp.GiSearch.DayPickerNavButtonDayPickerNavButton.DoubleClick("9;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiSearch.DivTag12' at 21;16.", repo.OnlineFlightBookingHotelsBusAmp.GiSearch.DivTag12Info, new RecordItemIndex(15));
            repo.OnlineFlightBookingHotelsBusAmp.GiSearch.DivTag12.Click("21;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiSearchBtn1' at 21;22.", repo.OnlineFlightBookingHotelsBusAmp.GiSearchBtn1Info, new RecordItemIndex(16));
            repo.OnlineFlightBookingHotelsBusAmp.GiSearchBtn1.Click("21;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1320 units.", new RecordItemIndex(17));
            Mouse.ScrollWheel(-1320);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(18));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.CheckAvailability1' at 43;8.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.CheckAvailability1Info, new RecordItemIndex(19));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.CheckAvailability1.Click("43;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.LiTag3A1' at 42;9.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.LiTag3A1Info, new RecordItemIndex(20));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.LiTag3A1.Click("42;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.LiTagSL' at 35;4.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.LiTagSLInfo, new RecordItemIndex(21));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.LiTagSL.Click("35;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.BOOKNOW4' at 35;5.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.BOOKNOW4Info, new RecordItemIndex(22));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.BOOKNOW4.Click("35;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1560 units.", new RecordItemIndex(23));
            Mouse.ScrollWheel(-1560);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1320 units.", new RecordItemIndex(24));
            Mouse.ScrollWheel(1320);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(25));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(26));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Male' on item 'OnlineFlightBookingHotelsBusAmp.SomeDivTag.FormControlInputMedium'.", repo.OnlineFlightBookingHotelsBusAmp.SomeDivTag.FormControlInputMediumInfo, new RecordItemIndex(28));
            repo.OnlineFlightBookingHotelsBusAmp.SomeDivTag.FormControlInputMedium.Element.SetAttributeValue("TagValue", "Male");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SomeDivTag.Text1' at 112;29.", repo.OnlineFlightBookingHotelsBusAmp.SomeDivTag.Text1Info, new RecordItemIndex(29));
            repo.OnlineFlightBookingHotelsBusAmp.SomeDivTag.Text1.Click("112;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 16}Devendra' with focus on 'OnlineFlightBookingHotelsBusAmp.SomeDivTag.Text1'.", repo.OnlineFlightBookingHotelsBusAmp.SomeDivTag.Text1Info, new RecordItemIndex(30));
            repo.OnlineFlightBookingHotelsBusAmp.SomeDivTag.Text1.PressKeys("{Back 16}Devendra");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(31));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(32));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2' at 243;26.", repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2Info, new RecordItemIndex(34));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2.Click("243;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2'.", repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2Info, new RecordItemIndex(35));
            Keyboard.PrepareFocus(repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}TESTNOC00{LShiftKey down}{@ down}{LShiftKey up}GMAIL.COM' with focus on 'OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2'.", repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2Info, new RecordItemIndex(36));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text2.PressKeys("{Back}TESTNOC00{LShiftKey down}{@ down}{LShiftKey up}GMAIL.COM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(37));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(38));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3' at 115;8.", repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3Info, new RecordItemIndex(39));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3.Click("115;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3'.", repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3Info, new RecordItemIndex(40));
            Keyboard.PrepareFocus(repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}999999999' with focus on 'OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3'.", repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3Info, new RecordItemIndex(41));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Text3.PressKeys("{Back}999999999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(42));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Button1' at 213;22.", repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Button1Info, new RecordItemIndex(43));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComTrainsBooking.Button1.Click("213;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.SpanTagFareBreakup1' at 4;3.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.SpanTagFareBreakup1Info, new RecordItemIndex(44));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.SpanTagFareBreakup1.Click("4;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.FrIconCloseFont12LtPopClose' at 1;7.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.FrIconCloseFont12LtPopCloseInfo, new RecordItemIndex(45));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.FrIconCloseFont12LtPopClose.Click("1;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.Button' at 128;11.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.ButtonInfo, new RecordItemIndex(46));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.Button.Click("128;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.ButtonTagYes' at 43;17.", repo.OnlineFlightBookingHotelsBusAmp.ButtonTagYesInfo, new RecordItemIndex(47));
            repo.OnlineFlightBookingHotelsBusAmp.ButtonTagYes.Click("43;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(48));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.NetBanking' at 37;21.", repo.OnlineFlightBookingHotelsBusAmp.NetBankingInfo, new RecordItemIndex(49));
            repo.OnlineFlightBookingHotelsBusAmp.NetBanking.Click("37;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GreyBgBorderAllPad10FlWidth100' at 32;16.", repo.OnlineFlightBookingHotelsBusAmp.GreyBgBorderAllPad10FlWidth100Info, new RecordItemIndex(50));
            repo.OnlineFlightBookingHotelsBusAmp.GreyBgBorderAllPad10FlWidth100.Click("32;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Submit' at 235;5.", repo.OnlineFlightBookingHotelsBusAmp.SubmitInfo, new RecordItemIndex(51));
            repo.OnlineFlightBookingHotelsBusAmp.Submit.Click("235;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'StateBankOfIndiaInternetBanking.ClickHere' at 26;6.", repo.StateBankOfIndiaInternetBanking.ClickHereInfo, new RecordItemIndex(52));
            repo.StateBankOfIndiaInternetBanking.ClickHere.Click("26;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.BookAgain' at 157;19.", repo.OnlineFlightBookingHotelsBusAmp.BookAgainInfo, new RecordItemIndex(53));
            repo.OnlineFlightBookingHotelsBusAmp.BookAgain.Click("157;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma' at 82;10.", repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideImaInfo, new RecordItemIndex(54));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma.Click("82;10");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
