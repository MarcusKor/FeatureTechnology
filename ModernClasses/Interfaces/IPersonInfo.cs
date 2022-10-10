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
#region Imports
using ModernClasses.Attributes;
using ModernClasses.Social;
using System.Collections.Generic;
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    #region Interface IPersonInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public interface IPersonInfo
    {
        #region Properties
        NameInfo NameInfo { get; set; }
        List<CompanyInfo> Companies { get; set; }
        List<AddressInfo> Addresses { get; set; }
        List<PhoneInfo> Phones { get; set; }
        List<MailInfo> Mails { get; set; }
        List<RelationInfo> Relations { get; set; }
        List<MessengerInfo> Messengers { get; set; }
        List<MemorialDayInfo> MemorialDays { get; set; }
        List<MedicalInfo> MedicalInfos { get; set; }
        #endregion
    }
    #endregion
}
#endregion