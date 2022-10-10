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
// Date: 2022, 10, 2, 오후 9:33
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using ModernClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class NameInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class NameInfo : PropertyAccessor, INameInfo
    {
        #region Properties
        [XmlElement]
        public string FirstName { get; set; }
        [XmlElement]
        public string MiddleName { get; set; }
        [XmlElement]
        public string LastName { get; set; }
        [XmlArrayItem("Nick")]
        [XmlArray("Nicks")]
        public List<string> NickNames { get; set; }
        [XmlElement]
        public string Honorifics { get; set; }
        [XmlIgnore]
        public string TokenizedString => $"{FirstName}{TokenDelimiter}{MiddleName}{TokenDelimiter}{LastName}" +
                                        $"{TokenDelimiter}{Honorifics}{TokenDelimiter}" +
                                        string.Join(TokenDelimiter, NickNames);
        #endregion
        #region Constructors
        public NameInfo() { }
        public NameInfo(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public NameInfo(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion