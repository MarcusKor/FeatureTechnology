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
// File: PhoneInfo.cs 
// Date: 2022, 10, 5, 오전 1:22
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using ModernClasses.Interfaces;
using System;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class PhoneInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class PhoneInfo : PropertyAccessor, IPhoneInfo
    {
        #region Properties
        [XmlIgnore]
        private string phoneType;
        [XmlAttribute]
        public string PhoneType
        {
            get => phoneType ?? string.Empty;
            set => phoneType = value; 
        }
        [XmlElement(IsNullable = true)]
        public string PhoneNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ShortNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public bool IsEmergencyCall { get; set; }
        #endregion
        #region Constructors
        public PhoneInfo() { }
        public PhoneInfo(string arg, char delimiter = '/')
        {
            AssignValues<IPhoneInfo.Properties>(arg, delimiter);
        }
        public PhoneInfo(params string[] args)
        {
            AssignValues<IPhoneInfo.Properties>(args);
        }
        #endregion
    }
    #endregion
}
#endregion