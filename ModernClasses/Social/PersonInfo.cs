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
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class PersonInfo
    public class PersonInfo : ElementAccessor, IPersonInfo
    {
        #region Properties
        [XmlElement]
        public NameInfo Name { get; set; }
        [XmlElement]
        public AddressInfo Address { get; set; }
        [XmlIgnore]
        public string NameString => Name.TokenizedString;
        [XmlIgnore]
        public string AddressString => Address.TokenizedString;
        #endregion
        #region Constructors
        public PersonInfo() { }
        public PersonInfo(string arg, char delimiter = '/')
        {
            AssignValues<PersonInfo>(arg, delimiter);
        }
        public PersonInfo(params string[] args)
        {
            AssignValues<PersonInfo>(args);
        }
        #endregion
    }
    #endregion
}
#endregion