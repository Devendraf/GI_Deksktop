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
    ///The Car_Vertical recording.
    /// </summary>
    [TestModule("6fa22967-7af7-4513-8c31-88446f1e75fd", ModuleType.Recording, 1)]
    public partial class Car_Vertical : ITestModule
    {
        /// <summary>
        /// Holds an instance of the GI_DesktopRepository repository.
        /// </summary>
        public static GI_DesktopRepository repo = GI_DesktopRepository.Instance;

        static Car_Vertical instance = new Car_Vertical();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Car_Vertical()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Car_Vertical Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma' at 71;19.", repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideImaInfo, new RecordItemIndex(0));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma.Click("71;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.IconAirportTransferDbBlueIco24Lh1' at 16;31.", repo.OnlineFlightBookingHotelsBusAmp.IconAirportTransferDbBlueIco24Lh1Info, new RecordItemIndex(1));
            repo.OnlineFlightBookingHotelsBusAmp.IconAirportTransferDbBlueIco24Lh1.Click("16;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.DelhiCantonmentNewDelhiDelhiIndi' at 88;7.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.DelhiCantonmentNewDelhiDelhiIndiInfo, new RecordItemIndex(2));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.DelhiCantonmentNewDelhiDelhiIndi.Click("88;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL' at 133;15.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(3));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.Click("133;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(4));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'delhi' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(5));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("delhi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.DelhiCantonmentNewDelhiDelhiIndi' at 130;7.", repo.OnlineFlightBookingHotelsBusAmp.DelhiCantonmentNewDelhiDelhiIndiInfo, new RecordItemIndex(6));
            repo.OnlineFlightBookingHotelsBusAmp.DelhiCantonmentNewDelhiDelhiIndi.Click("130;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.Agra' at 85;8.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.AgraInfo, new RecordItemIndex(7));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.Agra.Click("85;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL' at 140;17.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(8));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.Click("140;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'agra' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(9));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("agra");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.CustomResult1' at 143;5.", repo.OnlineFlightBookingHotelsBusAmp.CustomResult1Info, new RecordItemIndex(10));
            repo.OnlineFlightBookingHotelsBusAmp.CustomResult1.Click("143;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.Text' at 19;17.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.TextInfo, new RecordItemIndex(11));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.Text.Click("19;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.DivTag24' at 12;8.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.DivTag24Info, new RecordItemIndex(13));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.DivTag24.Click("12;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.SearchCabs' at 233;22.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.SearchCabsInfo, new RecordItemIndex(14));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.SearchCabs.Click("233;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(15));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(16));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.IcongocarsInfoBlueIco20' at 8;7.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.IcongocarsInfoBlueIco20Info, new RecordItemIndex(17));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.IcongocarsInfoBlueIco20.Click("8;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(18));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.GOTIT1' at 19;4.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.GOTIT1Info, new RecordItemIndex(19));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.GOTIT1.Click("19;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Flexrow.BtnBigBlueWidth100Ico17' at 251;7.", repo.OnlineFlightBookingHotelsBusAmp.Flexrow.BtnBigBlueWidth100Ico17Info, new RecordItemIndex(21));
            repo.OnlineFlightBookingHotelsBusAmp.Flexrow.BtnBigBlueWidth100Ico17.Click("251;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(22));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1080 units.", new RecordItemIndex(23));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(24));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.PayOptMobTabs' at 474;-20.", repo.OnlineFlightBookingHotelsBusAmp.PayOptMobTabsInfo, new RecordItemIndex(25));
            repo.OnlineFlightBookingHotelsBusAmp.PayOptMobTabs.Click("474;-20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.NetBanking' at 72;14.", repo.OnlineFlightBookingHotelsBusAmp.NetBankingInfo, new RecordItemIndex(26));
            repo.OnlineFlightBookingHotelsBusAmp.NetBanking.Click("72;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.PayNetbRb' at 12;9.", repo.OnlineFlightBookingHotelsBusAmp.PayNetbRbInfo, new RecordItemIndex(28));
            repo.OnlineFlightBookingHotelsBusAmp.PayNetbRb.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Submit' at 124;18.", repo.OnlineFlightBookingHotelsBusAmp.SubmitInfo, new RecordItemIndex(29));
            repo.OnlineFlightBookingHotelsBusAmp.Submit.Click("124;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'StateBankOfIndiaInternetBanking.ClickHere' at 37;2.", repo.StateBankOfIndiaInternetBanking.ClickHereInfo, new RecordItemIndex(30));
            repo.StateBankOfIndiaInternetBanking.ClickHere.Click("37;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.SearchBox.GoibiboLogo' at 55;9.", repo.OnlineFlightBookingHotelsBusAmp.SearchBox.GoibiboLogoInfo, new RecordItemIndex(31));
            repo.OnlineFlightBookingHotelsBusAmp.SearchBox.GoibiboLogo.Click("55;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.FlightDetailsFl.MyTrips' at 47;15.", repo.OnlineFlightBookingHotelsBusAmp.FlightDetailsFl.MyTripsInfo, new RecordItemIndex(32));
            repo.OnlineFlightBookingHotelsBusAmp.FlightDetailsFl.MyTrips.Click("47;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1440 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(-1440);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(34));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(35));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(36));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(37));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(38));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(39));
            Mouse.ScrollWheel(-600);
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(44));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(45));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(46));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(47));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(48));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(49));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(50));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(51));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(52));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(53));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(54));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(55));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(56));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(57));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(58));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(59));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(60));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(61));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(62));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoibiboGoogleChrome.Back' at 14;16.", repo.GoibiboGoogleChrome.BackInfo, new RecordItemIndex(63));
            repo.GoibiboGoogleChrome.Back.Click("14;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Devendra' at 34;19.", repo.OnlineFlightBookingHotelsBusAmp.DevendraInfo, new RecordItemIndex(64));
            repo.OnlineFlightBookingHotelsBusAmp.Devendra.Click("34;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.FlightDetailsFl.MyGoCash' at 72;9.", repo.OnlineFlightBookingHotelsBusAmp.FlightDetailsFl.MyGoCashInfo, new RecordItemIndex(65));
            repo.OnlineFlightBookingHotelsBusAmp.FlightDetailsFl.MyGoCash.Click("72;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Devendra' at 41;16.", repo.OnlineFlightBookingHotelsBusAmp.DevendraInfo, new RecordItemIndex(66));
            repo.OnlineFlightBookingHotelsBusAmp.Devendra.Click("41;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MainLinks1.ConnectEarn' at 68;22.", repo.OnlineFlightBookingHotelsBusAmp.MainLinks1.ConnectEarnInfo, new RecordItemIndex(67));
            repo.OnlineFlightBookingHotelsBusAmp.MainLinks1.ConnectEarn.Click("68;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Devendra' at 43;12.", repo.OnlineFlightBookingHotelsBusAmp.DevendraInfo, new RecordItemIndex(68));
            repo.OnlineFlightBookingHotelsBusAmp.Devendra.Click("43;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.MainLinks1.PrintTicket' at 21;10.", repo.OnlineFlightBookingHotelsBusAmp.MainLinks1.PrintTicketInfo, new RecordItemIndex(69));
            repo.OnlineFlightBookingHotelsBusAmp.MainLinks1.PrintTicket.Click("21;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(70));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(71));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(72));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(73));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(74));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(75));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(76));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(77));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(78));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(79));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(80));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(81));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(82));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(83));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(84));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(85));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(86));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(87));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(88));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1320 units.", new RecordItemIndex(89));
            Mouse.ScrollWheel(1320);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(90));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(91));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(92));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(93));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(94));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(95));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(96));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(97));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoibiboGoogleChrome.Back' at 15;25.", repo.GoibiboGoogleChrome.BackInfo, new RecordItemIndex(98));
            repo.GoibiboGoogleChrome.Back.Click("15;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1' at 82;8.", repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1Info, new RecordItemIndex(99));
            repo.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1.Click("82;8");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
