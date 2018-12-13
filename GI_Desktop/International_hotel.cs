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
    ///The International_hotel recording.
    /// </summary>
    [TestModule("5ea96b67-c1ab-453e-8163-93c5696c5493", ModuleType.Recording, 1)]
    public partial class International_hotel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the GI_DesktopRepository repository.
        /// </summary>
        public static GI_DesktopRepository repo = GI_DesktopRepository.Instance;

        static International_hotel instance = new International_hotel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public International_hotel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static International_hotel Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma' at 76;6.", repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideImaInfo, new RecordItemIndex(0));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma.Click("76;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.IconHotelsDbBlueIco28Lh12PadT2Pa' at 20;27.", repo.OnlineFlightBookingHotelsBusAmp.IconHotelsDbBlueIco28Lh12PadT2PaInfo, new RecordItemIndex(1));
            repo.OnlineFlightBookingHotelsBusAmp.IconHotelsDbBlueIco28Lh12PadT2Pa.Click("20;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL' at 137;28.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(2));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.Click("137;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}Singa' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(4));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("{Back}Singa");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MainTxt' at 161;0.", repo.OnlineFlightBookingHotelsBusAmp.MainTxtInfo, new RecordItemIndex(5));
            repo.OnlineFlightBookingHotelsBusAmp.MainTxt.Click("161;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.Text' at 127;17.", repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.TextInfo, new RecordItemIndex(6));
            repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.Text.Click("127;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DayPickerNavButtonDayPickerNavButton' at 12;5.", repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DayPickerNavButtonDayPickerNavButtonInfo, new RecordItemIndex(7));
            repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DayPickerNavButtonDayPickerNavButton.Click("12;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DivTag10' at 15;10.", repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DivTag10Info, new RecordItemIndex(8));
            repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DivTag10.Click("15;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DivTag11' at 8;8.", repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DivTag11Info, new RecordItemIndex(9));
            repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.DivTag11.Click("8;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.GetSetGo' at 39;22.", repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.GetSetGoInfo, new RecordItemIndex(10));
            repo.OnlineHotelBookingBookCheapBudge.ColMd12ColSm12ColXs12Pad0.GetSetGo.Click("39;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(11));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.BookNow' at 46;6.", repo.OnlineHotelBookingBookCheapBudge.BookNowInfo, new RecordItemIndex(13));
            repo.OnlineHotelBookingBookCheapBudge.BookNow.Click("46;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(14));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.BookNow1' at 163;25.", repo.OnlineHotelBookingBookCheapBudge.BookNow1Info, new RecordItemIndex(15));
            repo.OnlineHotelBookingBookCheapBudge.BookNow1.Click("163;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1440 units.", new RecordItemIndex(16));
            Mouse.ScrollWheel(-1440);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(17));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(18));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(19));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.CancelPolicyLinkV3' at 67;14.", repo.OnlineFlightBookingHotelsBusAmp.CancelPolicyLinkV3Info, new RecordItemIndex(21));
            repo.OnlineFlightBookingHotelsBusAmp.CancelPolicyLinkV3.Click("67;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.JavascriptVoid0' at 5;5.", repo.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0Info, new RecordItemIndex(22));
            repo.OnlineFlightBookingHotelsBusAmp.JavascriptVoid0.Click("5;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.FULLREFUNDGOAMEXIH' at 2;2.", repo.OnlineFlightBookingHotelsBusAmp.FULLREFUNDGOAMEXIHInfo, new RecordItemIndex(23));
            repo.OnlineFlightBookingHotelsBusAmp.FULLREFUNDGOAMEXIH.Click("2;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.ButtonTagOk' at 7;8.", repo.OnlineHotelBookingBookCheapBudge.ButtonTagOkInfo, new RecordItemIndex(24));
            repo.OnlineHotelBookingBookCheapBudge.ButtonTagOk.Click("7;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.FULLREFUNDIHCASHBACK' at 1;4.", repo.OnlineFlightBookingHotelsBusAmp.FULLREFUNDIHCASHBACKInfo, new RecordItemIndex(25));
            repo.OnlineFlightBookingHotelsBusAmp.FULLREFUNDIHCASHBACK.Click("1;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.ButtonTagOk' at 9;9.", repo.OnlineHotelBookingBookCheapBudge.ButtonTagOkInfo, new RecordItemIndex(26));
            repo.OnlineHotelBookingBookCheapBudge.ButtonTagOk.Click("9;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item 'OnlineHotelBookingBookCheapBudge.Choose'.", repo.OnlineHotelBookingBookCheapBudge.ChooseInfo, new RecordItemIndex(28));
            repo.OnlineHotelBookingBookCheapBudge.Choose.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item 'OnlineHotelBookingBookCheapBudge.Choose'.", repo.OnlineHotelBookingBookCheapBudge.ChooseInfo, new RecordItemIndex(29));
            repo.OnlineHotelBookingBookCheapBudge.Choose.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.Firstname1' at 85;19.", repo.OnlineHotelBookingBookCheapBudge.Firstname1Info, new RecordItemIndex(30));
            repo.OnlineHotelBookingBookCheapBudge.Firstname1.Click("85;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 19}D{LShiftKey up}evendra{Tab}{Back}Gupta' with focus on 'OnlineHotelBookingBookCheapBudge.Firstname1'.", repo.OnlineHotelBookingBookCheapBudge.Firstname1Info, new RecordItemIndex(31));
            repo.OnlineHotelBookingBookCheapBudge.Firstname1.PressKeys("{Back 19}D{LShiftKey up}evendra{Tab}{Back}Gupta");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.Email' at 185;12.", repo.OnlineHotelBookingBookCheapBudge.EmailInfo, new RecordItemIndex(32));
            repo.OnlineHotelBookingBookCheapBudge.Email.Click("185;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Back}testnoc9{LShiftKey down}{@ down}{LShiftKey up}gmail.com' with focus on 'OnlineHotelBookingBookCheapBudge.Email'.", repo.OnlineHotelBookingBookCheapBudge.EmailInfo, new RecordItemIndex(33));
            repo.OnlineHotelBookingBookCheapBudge.Email.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}testnoc9{LShiftKey down}{@ down}{LShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.Mobile' at 133;23.", repo.OnlineHotelBookingBookCheapBudge.MobileInfo, new RecordItemIndex(34));
            repo.OnlineHotelBookingBookCheapBudge.Mobile.Click("133;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 31}999999999' with focus on 'OnlineHotelBookingBookCheapBudge.Mobile'.", repo.OnlineHotelBookingBookCheapBudge.MobileInfo, new RecordItemIndex(35));
            repo.OnlineHotelBookingBookCheapBudge.Mobile.PressKeys("{Back 31}999999999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.MakePayment' at 199;15.", repo.OnlineHotelBookingBookCheapBudge.MakePaymentInfo, new RecordItemIndex(36));
            repo.OnlineHotelBookingBookCheapBudge.MakePayment.Click("199;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(37));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(38));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(39));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(40));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(41));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(42));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(43));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(44));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(45));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(46));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(47));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(48));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(49));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(50));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(51));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(52));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(53));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(54));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(55));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(56));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(57));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(58));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(59));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(60));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(61));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(62));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(63));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(64));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(65));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(66));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.NetBanking' at 43;18.", repo.OnlineHotelBookingBookCheapBudge.NetBankingInfo, new RecordItemIndex(67));
            repo.OnlineHotelBookingBookCheapBudge.NetBanking.Click("43;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(68));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.GreyBgBorderAllPad10FlWidth100' at 21;32.", repo.OnlineHotelBookingBookCheapBudge.GreyBgBorderAllPad10FlWidth100Info, new RecordItemIndex(69));
            repo.OnlineHotelBookingBookCheapBudge.GreyBgBorderAllPad10FlWidth100.Click("21;32");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.Submit' at 180;13.", repo.OnlineHotelBookingBookCheapBudge.SubmitInfo, new RecordItemIndex(70));
            repo.OnlineHotelBookingBookCheapBudge.Submit.Click("180;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'StateBankOfIndiaInternetBanking.ClickHere' at 17;8.", repo.StateBankOfIndiaInternetBanking.ClickHereInfo, new RecordItemIndex(71));
            repo.StateBankOfIndiaInternetBanking.ClickHere.Click("17;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1' at 60;10.", repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1Info, new RecordItemIndex(72));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1.Click("60;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5' at 10;32.", repo.OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5Info, new RecordItemIndex(73));
            repo.OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5.Click("10;32");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
