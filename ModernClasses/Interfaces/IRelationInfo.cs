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
// File: IRelationInfo.cs 
// Date: 2022, 10, 6, 오후 11:11
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    #region Interface IRelationInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public interface IRelationInfo : IPropertyAccessor
    {
        #region Enumerations
        enum Properties : int
        {
            RelationType,
            FirstImpressions,
            FirstMeetingPlace,
            Plans
        }
        #endregion
        #region Properties
        string RelationType { get; set; }
        string FirstImpressions { get; set; }
        string FirstMeetingPlace { get; set; }
        List<string> Plans { get; set; }
        #endregion
    }
    #endregion
}
#endregion