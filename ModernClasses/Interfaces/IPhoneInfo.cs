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
// File: ContactInfos.cs 
// Date: 2022, 10, 5, 오전 1:14
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using System.Collections.Generic;
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    #region Interface IPhoneInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public interface IPhoneInfo : IPropertyAccessor
    {
        #region Enumerations
        enum Properties : int
        {
            PhoneType,
            PhoneNumber,
            ShortNumber,
            IsEmergencyCall
        }
        #endregion
        #region Properties
        string PhoneType { get; set; }
        string PhoneNumber { get; set; }
        string ShortNumber { get; set; }
        bool IsEmergencyCall { get; set; }
        #endregion
    }
    #endregion
}
#endregion