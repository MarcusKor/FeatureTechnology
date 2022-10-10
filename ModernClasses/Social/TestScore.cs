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
// File: TestScore.cs 
// Date: 2022, 10, 11, 오전 12:46
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
#region Imports
namespace ModernClasses.Social
{
    #region Class TestScore
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class TestScore : PropertyAccessor, ITestScore
    {
        #region Properties
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement(IsNullable = false)]
        public string Value { get; set; }
        [XmlElement(IsNullable = false)]
        public Type DataType { get; set; }
        [XmlElement(IsNullable = false)]
        public DateTime BeginTime { get; set; }
        [XmlElement(IsNullable = false)]
        public DateTime EndTime { get; set; }
        [XmlElement(IsNullable = false)]
        public DateTime TestTime { get; set; }
        [XmlElement(IsNullable = false)]
        public TimeSpan TestDuration { get; set; }
        #endregion
        #region Constructors
        public TestScore() { }
        public TestScore(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public TestScore(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion