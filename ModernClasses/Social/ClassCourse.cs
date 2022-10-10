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
// File: ClassCourse.cs 
// Date: 2022, 10, 10, 오후 10:12
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
    #region Class ClassCourse
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class ClassCourse : PropertyAccessor, IClassCourse
    {
        #region Properties
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement(IsNullable = false)]
        public TimeSpan StudyTime { get; set; }
        [XmlElement(IsNullable = false)]
        public int TotalNumberOfRegularClassParticipants { get; set; }
        [XmlArrayItem("Subject")]
        [XmlArray("Subjects")]
        public List<KeyValuePair<IStudyClass, List<ITeacher>>> Subjects { get; set; }
        [XmlArrayItem("AttendanceRate")]
        [XmlArray("AttendanceRates", IsNullable = true)]
        public List<KeyValuePair<DateTime, double>> AttendanceRates { get; set; }
        [XmlArrayItem("PassRate")]
        [XmlArray("PassRates", IsNullable = true)]
        public List<KeyValuePair<DateTime, double>> PassRates { get; set; }
        [XmlArrayItem("TestScore")]
        [XmlArray("TestScores", IsNullable = true)]
        public List<KeyValuePair<DateTime, KeyValuePair<ITestScore, List<IStudent>>>> TestScores { get; set; }
        [XmlArrayItem("HighestTestScoreStudent")]
        [XmlArray("HighestTestScoreStudents", IsNullable = true)]
        public List<KeyValuePair<ITestScore, List<IStudent>>> HighestTestScoreStudents { get; set; }
        [XmlArrayItem("LowestTestScoreStudent")]
        [XmlArray("LowestTestScoreStudents", IsNullable = true)]
        public List<KeyValuePair<ITestScore, List<IStudent>>> LowestTestScoreStudents { get; set; }
        [XmlArrayItem("TestPassedStudent")]
        [XmlArray("TestPassedStudents", IsNullable = true)]
        public List<KeyValuePair<ITestScore, List<IStudent>>> TestPassedStudents { get; set; }
        [XmlArrayItem("TestFailedStudent")]
        [XmlArray("TestFailedStudents", IsNullable = true)]
        public List<KeyValuePair<ITestScore, List<IStudent>>> TestFailedStudents { get; set; }
        #endregion
        #region Constructors
        public ClassCourse() { }
        public ClassCourse(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public ClassCourse(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion