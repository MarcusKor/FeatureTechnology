﻿#region License
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
}
#endregion