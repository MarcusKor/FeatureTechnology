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
// File: CompanyInfo.cs 
// Date: 2022, 10, 6, 오후 10:45
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
    #region Class CompanyInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class CompanyInfo : PropertyAccessor, ICompanyInfo
    {
        #region Properties
        [XmlIgnore]
        private string companyName;
        [XmlAttribute]
        public string CompanyName
        {
            get => companyName??string.Empty;
            set => companyName = value;
        }
        [XmlElement(IsNullable = true)]
        public WebInfo WebInfo { get; set; }
        [XmlElement(IsNullable = true)]
        public AddressInfo AddressInfo { get; set; }
        [XmlElement(IsNullable = true)]
        public MailInfo MailInfo { get; set; }
        [XmlElement(IsNullable = true)]
        public string Department { get; set; }
        [XmlElement(IsNullable = true)]
        public string Position { get; set; }
        #endregion
    }
    #endregion
}
#endregion