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
// File: IMemorialDayInfo.cs 
// Date: 2022, 10, 6, 오후 11:20
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using ModernClasses.Social;
using System;
using System.Collections.Generic;
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    #region Interface IMemorialDayInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public interface IMemorialDayInfo : IPropertyAccessor
    {
        #region Enumerations
        enum Properties : int
        {
            Date,
            BeginTime,
            EndTime,
            Places,
            NotificationInfo,
            RelatedPerson,
            PrivacyLevel
        }
        #endregion
        #region Properties
        DateTime Date { get; set; }
        DateTime BeginTime { get; set; }
        DateTime EndTime { get; set; }
        List<string> Places { get; set; }
        NotificationInfo NotificationInfo { get; set; }
        string RelatedPerson { get; set; }
        PrivacyLevel PrivacyLevel { get; set; }
        #endregion
    }
    #endregion
}
#endregion