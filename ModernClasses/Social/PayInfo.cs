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
// File: PayInfo.cs 
// Date: 2022, 10, 10, 오후 9:10
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
    #region Class PayInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class PayInfo : PropertyAccessor, IPayInfo
    {
        #region Properties
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement(IsNullable = false)]
        public string Sender { get; set; }
        [XmlElement(IsNullable = false)]
        public string Reciever { get; set; }
        [XmlElement(IsNullable = true)]
        public string RemittanceBank { get; set; }
        [XmlElement(IsNullable = true)]
        public string Receipt { get; set; }
        [XmlElement(IsNullable = false)]
        public string PaymentMethod { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = false)]
        public double Amount { get; set; }
        [XmlElement(IsNullable = false)]
        public DateTime PaymentDate { get; set; }
        #endregion
    }
    #endregion
}
#endregion