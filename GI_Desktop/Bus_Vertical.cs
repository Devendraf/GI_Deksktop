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
    ///The Bus_Vertical recording.
    /// </summary>
    [TestModule("163a9f9a-e5a5-40c1-bad6-e7582d9de865", ModuleType.Recording, 1)]
    public partial class Bus_Vertical : ITestModule
    {
        /// <summary>
        /// Holds an instance of the GI_DesktopRepository repository.
        /// </summary>
        public static GI_DesktopRepository repo = GI_DesktopRepository.Instance;

        static Bus_Vertical instance = new Bus_Vertical();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bus_Vertical()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bus_Vertical Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma' at 71;16.", repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideImaInfo, new RecordItemIndex(0));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma.Click("71;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5' at 22;24.", repo.OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5Info, new RecordItemIndex(1));
            repo.OnlineFlightBookingHotelsBusAmp.IconBusDbBlueIco24Lh12PadT5PadB5.Click("22;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiSource' at 106;17.", repo.OnlineFlightBookingHotelsBusAmp.GiSourceInfo, new RecordItemIndex(2));
            repo.OnlineFlightBookingHotelsBusAmp.GiSource.Click("106;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'de' with focus on 'OnlineFlightBookingHotelsBusAmp.GiSource'.", repo.OnlineFlightBookingHotelsBusAmp.GiSourceInfo, new RecordItemIndex(3));
            repo.OnlineFlightBookingHotelsBusAmp.GiSource.PressKeys("de");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MainTxt1' at 115;11.", repo.OnlineFlightBookingHotelsBusAmp.MainTxt1Info, new RecordItemIndex(4));
            repo.OnlineFlightBookingHotelsBusAmp.MainTxt1.Click("115;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiDestination' at 93;13.", repo.OnlineFlightBookingHotelsBusAmp.GiDestinationInfo, new RecordItemIndex(5));
            repo.OnlineFlightBookingHotelsBusAmp.GiDestination.Click("93;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'mum' with focus on 'OnlineFlightBookingHotelsBusAmp.GiDestination'.", repo.OnlineFlightBookingHotelsBusAmp.GiDestinationInfo, new RecordItemIndex(6));
            repo.OnlineFlightBookingHotelsBusAmp.GiDestination.PressKeys("mum");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MumbaiMaharashtra' at 90;3.", repo.OnlineFlightBookingHotelsBusAmp.MumbaiMaharashtraInfo, new RecordItemIndex(7));
            repo.OnlineFlightBookingHotelsBusAmp.MumbaiMaharashtra.Click("90;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiDestination' at 38;21.", repo.OnlineFlightBookingHotelsBusAmp.GiDestinationInfo, new RecordItemIndex(8));
            repo.OnlineFlightBookingHotelsBusAmp.GiDestination.Click("38;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'OnlineFlightBookingHotelsBusAmp.GiDestination'.", repo.OnlineFlightBookingHotelsBusAmp.GiDestinationInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.OnlineFlightBookingHotelsBusAmp.GiDestination);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Agr' with focus on 'OnlineFlightBookingHotelsBusAmp.GiDestination'.", repo.OnlineFlightBookingHotelsBusAmp.GiDestinationInfo, new RecordItemIndex(10));
            repo.OnlineFlightBookingHotelsBusAmp.GiDestination.PressKeys("Agr");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.AgraUttarPradesh' at 65;4.", repo.OnlineFlightBookingHotelsBusAmp.AgraUttarPradeshInfo, new RecordItemIndex(11));
            repo.OnlineFlightBookingHotelsBusAmp.AgraUttarPradesh.Click("65;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiOnwardText' at 58;15.", repo.OnlineFlightBookingHotelsBusAmp.GiOnwardTextInfo, new RecordItemIndex(12));
            repo.OnlineFlightBookingHotelsBusAmp.GiOnwardText.Click("58;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineHotelBookingBookCheapBudge.SpanTag21' at 7;7.", repo.OnlineHotelBookingBookCheapBudge.SpanTag21Info, new RecordItemIndex(13));
            repo.OnlineHotelBookingBookCheapBudge.SpanTag21.Click("7;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GiSearchBtn' at 111;18.", repo.OnlineFlightBookingHotelsBusAmp.GiSearchBtnInfo, new RecordItemIndex(14));
            repo.OnlineFlightBookingHotelsBusAmp.GiSearchBtn.Click("111;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(15));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(16));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(17));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(18));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(19));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.FtBookbtn3' at 35;8.", repo.OnlineFlightBookingHotelsBusAmp.FtBookbtn3Info, new RecordItemIndex(21));
            repo.OnlineFlightBookingHotelsBusAmp.FtBookbtn3.Click("35;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(22));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.OnwRedbusnewAt200001192973000153036' at 5;5.", repo.OnlineFlightBookingHotelsBusAmp.OnwRedbusnewAt200001192973000153036Info, new RecordItemIndex(23));
            repo.OnlineFlightBookingHotelsBusAmp.OnwRedbusnewAt200001192973000153036.Click("5;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '25288-Sagar Pur' on item 'OnlineFlightBookingHotelsBusAmp.BpOnwRedbusnewAt2000011929730001530'.", repo.OnlineFlightBookingHotelsBusAmp.BpOnwRedbusnewAt2000011929730001530Info, new RecordItemIndex(24));
            repo.OnlineFlightBookingHotelsBusAmp.BpOnwRedbusnewAt2000011929730001530.Element.SetAttributeValue("TagValue", "25288-Sagar Pur");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '25304-Agra' on item 'OnlineFlightBookingHotelsBusAmp.DpOnwRedbusnewAt2000011929730001530'.", repo.OnlineFlightBookingHotelsBusAmp.DpOnwRedbusnewAt2000011929730001530Info, new RecordItemIndex(25));
            repo.OnlineFlightBookingHotelsBusAmp.DpOnwRedbusnewAt2000011929730001530.Element.SetAttributeValue("TagValue", "25304-Agra");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Confirm' at 45;17.", repo.OnlineFlightBookingHotelsBusAmp.ConfirmInfo, new RecordItemIndex(26));
            repo.OnlineFlightBookingHotelsBusAmp.Confirm.Click("45;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(28));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(29));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(30));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GetUptoRs100OffOnFirstBooking' at 25;10.", repo.OnlineFlightBookingHotelsBusAmp.GetUptoRs100OffOnFirstBookingInfo, new RecordItemIndex(31));
            repo.OnlineFlightBookingHotelsBusAmp.GetUptoRs100OffOnFirstBooking.Click("25;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.JavascriptVoid01' at 2;3.", repo.OnlineFlightBookingHotelsBusAmp.JavascriptVoid01Info, new RecordItemIndex(32));
            repo.OnlineFlightBookingHotelsBusAmp.JavascriptVoid01.Click("2;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SpanTagFareBreakup' at 33;18.", repo.OnlineFlightBookingHotelsBusAmp.SpanTagFareBreakupInfo, new RecordItemIndex(33));
            repo.OnlineFlightBookingHotelsBusAmp.SpanTagFareBreakup.Click("33;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.JavascriptVoid02' at 6;6.", repo.OnlineFlightBookingHotelsBusAmp.JavascriptVoid02Info, new RecordItemIndex(34));
            repo.OnlineFlightBookingHotelsBusAmp.JavascriptVoid02.Click("6;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(35));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item 'OnlineFlightBookingHotelsBusAmp.Adultchoose1'.", repo.OnlineFlightBookingHotelsBusAmp.Adultchoose1Info, new RecordItemIndex(36));
            repo.OnlineFlightBookingHotelsBusAmp.Adultchoose1.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Adultfirstname11' at 35;24.", repo.OnlineFlightBookingHotelsBusAmp.Adultfirstname11Info, new RecordItemIndex(37));
            repo.OnlineFlightBookingHotelsBusAmp.Adultfirstname11.Click("35;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Devendra' with focus on 'OnlineFlightBookingHotelsBusAmp.Adultfirstname11'.", repo.OnlineFlightBookingHotelsBusAmp.Adultfirstname11Info, new RecordItemIndex(38));
            repo.OnlineFlightBookingHotelsBusAmp.Adultfirstname11.PressKeys("Devendra");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Adultlastname1' at 16;19.", repo.OnlineFlightBookingHotelsBusAmp.Adultlastname1Info, new RecordItemIndex(39));
            repo.OnlineFlightBookingHotelsBusAmp.Adultlastname1.Click("16;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Gupta' with focus on 'OnlineFlightBookingHotelsBusAmp.Adultlastname1'.", repo.OnlineFlightBookingHotelsBusAmp.Adultlastname1Info, new RecordItemIndex(40));
            repo.OnlineFlightBookingHotelsBusAmp.Adultlastname1.PressKeys("Gupta");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Adultage1' at 15;19.", repo.OnlineFlightBookingHotelsBusAmp.Adultage1Info, new RecordItemIndex(41));
            repo.OnlineFlightBookingHotelsBusAmp.Adultage1.Click("15;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '22' with focus on 'OnlineFlightBookingHotelsBusAmp.Adultage1'.", repo.OnlineFlightBookingHotelsBusAmp.Adultage1Info, new RecordItemIndex(42));
            repo.OnlineFlightBookingHotelsBusAmp.Adultage1.PressKeys("22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Email' at 147;28.", repo.OnlineFlightBookingHotelsBusAmp.EmailInfo, new RecordItemIndex(43));
            repo.OnlineFlightBookingHotelsBusAmp.Email.Click("147;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'OnlineFlightBookingHotelsBusAmp.Email'.", repo.OnlineFlightBookingHotelsBusAmp.EmailInfo, new RecordItemIndex(44));
            Keyboard.PrepareFocus(repo.OnlineFlightBookingHotelsBusAmp.Email);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}test{o up}c009{LShiftKey down}{@ down}{LShiftKey up}gmail.com' with focus on 'OnlineFlightBookingHotelsBusAmp.Email'.", repo.OnlineFlightBookingHotelsBusAmp.EmailInfo, new RecordItemIndex(45));
            repo.OnlineFlightBookingHotelsBusAmp.Email.PressKeys("{Back}test{o up}c009{LShiftKey down}{@ down}{LShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Mobile' at 45;24.", repo.OnlineFlightBookingHotelsBusAmp.MobileInfo, new RecordItemIndex(46));
            repo.OnlineFlightBookingHotelsBusAmp.Mobile.Click("45;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}a{LControlKey up}{Back}99999999999' with focus on 'OnlineFlightBookingHotelsBusAmp.Mobile'.", repo.OnlineFlightBookingHotelsBusAmp.MobileInfo, new RecordItemIndex(47));
            repo.OnlineFlightBookingHotelsBusAmp.Mobile.PressKeys("{LControlKey down}a{LControlKey up}{Back}99999999999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MakePayment' at 230;11.", repo.OnlineFlightBookingHotelsBusAmp.MakePaymentInfo, new RecordItemIndex(48));
            repo.OnlineFlightBookingHotelsBusAmp.MakePayment.Click("230;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(49));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(50));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(51));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(52));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(53));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(54));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(55));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(56));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(57));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(58));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(59));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.NetBanking' at 27;17.", repo.OnlineFlightBookingHotelsBusAmp.NetBankingInfo, new RecordItemIndex(60));
            repo.OnlineFlightBookingHotelsBusAmp.NetBanking.Click("27;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.BankNameSpriteSbiFlMarginL5' at 22;27.", repo.OnlineFlightBookingHotelsBusAmp.BankNameSpriteSbiFlMarginL5Info, new RecordItemIndex(61));
            repo.OnlineFlightBookingHotelsBusAmp.BankNameSpriteSbiFlMarginL5.Click("22;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Submit' at 242;41.", repo.OnlineFlightBookingHotelsBusAmp.SubmitInfo, new RecordItemIndex(62));
            repo.OnlineFlightBookingHotelsBusAmp.Submit.Click("242;41");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'StateBankOfIndiaInternetBanking.ClickHere' at 6;5.", repo.StateBankOfIndiaInternetBanking.ClickHereInfo, new RecordItemIndex(63));
            repo.StateBankOfIndiaInternetBanking.ClickHere.Click("6;5");
            Delay.Milliseconds(2580);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1' at 21;7.", repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1Info, new RecordItemIndex(64));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1.Click("21;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
