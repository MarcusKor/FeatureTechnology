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
// File: RelationInfo.cs 
// Date: 2022, 10, 6, 오후 11:53
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
    #region Class RelationInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class RelationInfo : PropertyAccessor, IRelationInfo
    {
        #region Properties
        [XmlIgnore]
        private string relationType;
        [XmlAttribute]
        public string RelationType
        {
            get => relationType??string.Empty;
            set => relationType = value;
        }
        [XmlElement(IsNullable = true)]
        public string FirstImpressions { get; set; }
        [XmlElement(IsNullable = true)]
        public string FirstMeetingPlace { get; set; }
        [XmlArrayItem("Plan")]
        [XmlArray("Plans")]
        public List<string> Plans { get; set; }
        #endregion
        #region Constructors
        public RelationInfo() { }
        public RelationInfo(string arg, char delimiter = '/')
        {
            AssignValues<IRelationInfo.Properties>(arg, delimiter);
        }
        public RelationInfo(params string[] args)
        {
            AssignValues<IRelationInfo.Properties>(args);
        }
        #endregion
    }
    #endregion
}
#endregion