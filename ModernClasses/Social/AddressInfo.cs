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
// File: AddressInfo.cs 
// Date: 2022, 10, 2, 오전 12:49
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using ModernClasses.Interfaces;
using System;
using System.Linq;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class AddressInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class AddressInfo : PropertyAccessor, IAddressInfo
    {
        #region Properties

        [XmlIgnore]
        private string? residenceType { get; set; }
        [XmlAttribute]
        public string ResidenceType
        {
            get => residenceType ?? string.Empty;
            set => residenceType = value;
        }
        [XmlIgnore]
        private string? siteUrl { get; set; }
        [XmlAttribute]
        public string SiteUrl
        {
            get => siteUrl ?? string.Empty;
            set => siteUrl = value;
        }
        [XmlIgnore]
        private string? geoGraphicLocation { get; set; }
        [XmlAttribute]
        public string GeographicLocation
        {
            get => geoGraphicLocation ?? string.Empty;
            set => geoGraphicLocation = value;
        }
        [XmlElement(IsNullable = true)]
        public string Street1 { get; set; }
        [XmlElement(IsNullable = true)]
        public string Street2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string City { get; set; }
        [XmlElement(IsNullable = true)]
        public string State { get; set; }
        [XmlElement(IsNullable = true)]
        public string Country { get; set; }
        [XmlIgnore]
        public string TokenizedString => $"{ResidenceType}{TokenDelimiter}{SiteUrl}{TokenDelimiter}{GeographicLocation}{TokenDelimiter}{Street1}{TokenDelimiter}{Street2}{TokenDelimiter}{City}{TokenDelimiter}{State}{TokenDelimiter}{Country}";
        #endregion
        #region Constructors
        public AddressInfo() { }
        public AddressInfo(string arg, char delimiter = '/')
        {
            AssignValues<IAddressInfo.Properties>(arg, delimiter);
        }
        public AddressInfo(params string[] args)
        {
            AssignValues<IAddressInfo.Properties>(args);
        }
        #endregion
    }
    #endregion
}
#endregion