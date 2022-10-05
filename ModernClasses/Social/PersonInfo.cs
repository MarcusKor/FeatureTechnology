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
// File: PersonInfo.cs 
// Date: 2022, 10, 2, 오후 10:19
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class PersonInfo
    public class PersonInfo : PropertyAccessor, IPersonInfo
    {
        #region Properties
        [XmlElement]
        public NameInfo NameInfo { get; set; }
        [XmlArrayItem("Address")]
        [XmlArray("Addresses")]
        public List<AddressInfo> AddressInfos { get; set; }
        [XmlArrayItem("Phone")]
        [XmlArray("Phones")]
        public List<PhoneInfo> PhoneInfos { get; set; }
        [XmlArrayItem("MailAccount")]
        [XmlArray("MailAccounts")]
        public List<MailInfo> MailInfos { get; set; }
        [XmlIgnore]
        public string FullName => NameInfo.TokenizedString;
        [XmlIgnore]
        public string Nick => NameInfo.NickNames.FirstOrDefault();
        [XmlIgnore]
        public string? Address1 => AddressInfos.First()?.TokenizedString;
        #endregion
        #region Constructors
        public PersonInfo() { }
        public PersonInfo(string arg, char delimiter = '/')
        {
            AssignValues<IPersonInfo.Properties>(arg, delimiter);
        }
        public PersonInfo(params string[] args)
        {
            AssignValues<IPersonInfo.Properties>(args);
        }
        #endregion
    }
    #endregion
}
#endregion