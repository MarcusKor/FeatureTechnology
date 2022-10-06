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
// File: MedicalInfo.cs 
// Date: 2022, 10, 7, 오전 12:14
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Interfaces;
using System.Collections.Generic;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class MedicalInfo
    public class MedicalInfo : PropertyAccessor, IMedicalInfo
    {
        #region Properties
        [XmlElement(IsNullable = false)]
        public string BloodType { get; set; }
        [XmlArrayItem("Disease")]
        [XmlArray("Diseases", IsNullable = true)]
        public List<string> Diseases { get; set; }
        [XmlArrayItem("VisitedHospital")]
        [XmlArray("LatestVisitedHospital", IsNullable = true)]
        public List<string> LatestVisitedHospital { get; set; }
        [XmlArrayItem("ContactHospital")]
        [XmlArray("EmergencyContactHospital", IsNullable = true)]
        public List<string> EmergencyContactHospital { get; set; }
        #endregion
    }
    #endregion
}
#endregion