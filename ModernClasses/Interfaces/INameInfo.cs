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
// File: NameInfo.cs 
// Date: 2022, 10, 2, 오후 9:24
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using System;
using System.Collections.Generic;
using System.Text;
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    #region Interface INameInfo
    public interface INameInfo : IElementAccessor
    {
        #region Enumerations
        enum Elements : int
        {
            FirstName,
            MiddleName,
            LastName,
            Nick
        }
        #endregion
        #region Properties
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Nick { get; set; }
        string TokenizedString { get; }
        #endregion
    }
    #endregion
}
#endregion