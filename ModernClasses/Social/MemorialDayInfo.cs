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
// File: MemorialDayInfo.cs 
// Date: 2022, 10, 7, 오전 12:09
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
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class MemorialDayInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class MemorialDayInfo : PropertyAccessor, IMemorialDayInfo
    {
        #region Properties
        [XmlElement(IsNullable = false)]
        public DateTime Date { get; set; }
        [XmlElement(IsNullable = false)]
        public DateTime BeginTime { get; set; }
        [XmlElement]
        public DateTime EndTime { get; set; }
        [XmlArrayItem("Place")]
        [XmlArray("Places")]
        public List<string> Places { get; set; }
        [XmlElement(IsNullable = true)]
        public NotificationInfo NotificationInfo { get; set; }
        [XmlElement(IsNullable = true)]
        public string RelatedPerson { get; set; }
        [XmlElement(IsNullable = false)]
        public PrivacyLevel PrivacyLevel { get; set; }
        #endregion
        #region Constructors
        public MemorialDayInfo() { }
        public MemorialDayInfo(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public MemorialDayInfo(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion