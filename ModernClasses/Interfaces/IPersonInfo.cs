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
// File: IPersonInfo.cs 
// Date: 2022, 10, 2, 오후 10:20
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion

using ModernClasses.Social;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernClasses.Interfaces
{
    public interface IPersonInfo : IPropertyAccessor
    {
        #region Enumerations
        enum Properties : int
        {
            NameInfo,
            AddressInfos,
            PhoneInfos,
            MailInfos
        }
        #endregion
        #region Properties
        NameInfo NameInfo { get; set; }
        List<AddressInfo> AddressInfos { get; set; }
        List<PhoneInfo> PhoneInfos { get; set; }
        List<MailInfo> MailInfos { get; set; }
        #endregion
    }
}
