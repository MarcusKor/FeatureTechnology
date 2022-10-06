#region License
///////////////////////////////////////////////////////////////////////////////
//               Commercial Product Licence from CODEFACTORY Inc.
//               ===============================================
// 
// Copyright(c) 2022. Il Hwan, Jeong. All rights reserved.  (WWW.VS3CODEFACTORY.COM)
//
// Use and redistribution of CODE FACTORY products requires approval from
// CODEFACTORY. Authorization for use and redistribution must be attested
// with license information purchased from CODEFACTORY.
// 
// EXCEPTION NOTICE
//
// If CODEFACTORY uses and redistributes open software binaries and libraries,
// CODEFACTORY will display license rules and exceptions related to open
// software binaries and libraries at the top of the "License.txt" file, and
// comply with the license rules and exceptions.
///////////////////////////////////////////////////////////////////////////////
// File: Enumerations.cs 
// Date: 2022, 10, 2, 오전 12:27
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using System;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Residence type
    public enum ResidenceType
    {
        Unknown,
        Home,
        Company,
        Office,
        Factory,
        Store,
        Garage,
        Misc
    }
    #endregion
    #region Gender type
    public enum GenderType
    {
        Unknown = -1,
        Female,
        Male
    }
    #endregion
    #region Contact type
    public enum ContactType
    {
        None = -1,
        InstantMessenger,
        SocialNetworkService,
        Mail,
        MobilePhone,
        HomeTelephone,
        OfficeTelephone,
        Fax,
        PostalService
    }
    #endregion
    #region Case conversion type
    public enum CaseConversionType
    {
        None = -1,
        ToLower,
        ToUpper
    }
    #endregion
    #region PrivacyLevel
    public enum PrivacyLevel : int
    {
        HideAll,
        OpenToPeer,
        OpenToFriend,
        OpenToFamily,
        OpenToDesignatedPersons,
        OpenAll,
    }
    #endregion
    #region Notification mode
    public enum NotificationMode : int
    {
        BeforeAYear,
        BeforeAMonth,
        BeforeAWeek,
        BeforeADay,
        BeforeAHour,
        BeforeTenMinitures,
        BeforeOneMiniture,
        BeforeTenSecond,
        BeforeFiveSecond,
        BeforeOneSecond,
        JustInTime,
        AfterOneSecond,
        AfterFiveSecond,
        AfterTenSecond,
        AfterOneMiniture,
        AfterTenMinitures,
        AfterAHour,
        AfterADay,
        AfterAWeek,
        AfterAMonth,
        AfterAYear
    }
    #endregion
    #region Notification way
    public enum NotificationWay : int
    {
        Buzzer,
        Lighting,
        Vibration,
        Bell,
        Music,
        Video,
        Mail,
        Memo,
        Messenger,
        Call,
        ShortMessageService,
        MultimediaMessageService,
        Push,
        Fax
    }
    #endregion
    #region Notification repeat mode
    public enum NotificationRepeatMode : int
    {
        EveryOneMiniture,
        EveryThreeMinitures,
        EveryFiveMinitures,
        EveryTenMinitures,
        EveryHalfHourMinitures,
        EveryHourMinitures,
        EveryWorkDays,
        EveryWeekend,
        EveryPublicHoliday,
        EveryMemorialDay,
        EverySpecificEventDay,
        EveryDay,
    }
    #endregion
}
#endregion