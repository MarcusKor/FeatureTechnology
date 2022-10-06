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
// File: IWebInfo.cs 
// Date: 2022, 10, 6, 오전 1:50
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
    #region Interface IWebInfo
    public interface IWebInfo : IPropertyAccessor
    {
        #region Enumerations
        enum Properties : int
        {
            WebServer,
            WebAccount
        }
        #endregion
        #region Properties
        string WebServer { get; set; }
        string WebAccount { get; set; }
        #endregion
    }
    #endregion
}
#endregion