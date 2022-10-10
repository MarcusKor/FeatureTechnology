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
// File: LearningRecord.cs 
// Date: 2022, 10, 10, 오후 11:23
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
    #region Class LearningRecord
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class LearningRecord : PropertyAccessor, ILearningRecord
    {
        #region Properties
        [XmlElement(IsNullable = false)]
        public IStudyClass StudyClass { get; set; }
        [XmlElement(IsNullable = true)]
        public IStudentGrade HighestGrade { get; set; }
        [XmlElement(IsNullable = true)]
        public IStudentGrade LowestGrade { get; set; }
        [XmlElement(IsNullable = true)]
        public IStudentGrade FinalGrade { get; set; }
        [XmlArrayItem("TestResult")]
        [XmlArrayItem("TestResults", IsNullable = true)]
        public List<KeyValuePair<DateTime, ITestScore>> TestResults { get; set; }
        [XmlElement(IsNullable = true)]
        public uint NumberOfRetakes { get; set; }
        [XmlElement(IsNullable = true)]
        public uint NumberOfTest { get; set; }
        [XmlElement(IsNullable = true)]
        public uint NumberOfPass { get; set; }
        #endregion
        #region Constructors
        public LearningRecord() { }
        public LearningRecord(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public LearningRecord(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion