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
// File: IInternetServiceAccount.cs 
// Date: 2022, 10, 10, 오후 10:48
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    public interface IInternetServiceAccount
    {
        #region Properties
        string UrlString { get; set; }
        string Server { get; set; }
        string Account { get; set; }
        #endregion
    }
}
#endregion