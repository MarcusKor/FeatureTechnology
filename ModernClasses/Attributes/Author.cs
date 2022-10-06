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
// File: Author.cs 
// Date: 2022, 10, 6, 오후 10:52
// Project: ModernClasses
// Namespace: ModernClasses.Attributes
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
#endregion
#region Program
namespace ModernClasses.Attributes
{
    #region Class AuthorAttribute
    [System.AttributeUsage(System.AttributeTargets.Interface | System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple = true)]
    public class AuthorAttribute : System.Attribute
    {
        #region Properties
        public string Name { get; private set; }
        public string Nick { get; private set; }
        public double Version { get; private set; }
        #endregion
        #region Constructors
        public AuthorAttribute(string name, string nick = "", double version = 1.0)
        {
            Name = name;
            Nick = nick;
            Version = version;
        }
        #endregion
    }
    #endregion
}
#endregion