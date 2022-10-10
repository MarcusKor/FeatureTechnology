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
// File: StudyClass.cs 
// Date: 2022, 10, 11, 오전 12:36
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
    #region Class StudyClass
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class StudyClass : PropertyAccessor, IStudyClass
    {
        #region Properties
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement(IsNullable = false)]
        public int NumberOfRegularClassParticipants { get; set; }
        [XmlElement(IsNullable = false)]
        public string RequiredPassLevel { get; set; }
        [XmlElement(IsNullable = false)]
        public List<KeyValuePair<DateTime, List<KeyValuePair<ITeacher, double>>>> ClassTimeTables { get; set; }
        [XmlElement(IsNullable = true)]
        public List<KeyValuePair<DateTime, List<double>>> AttendanceRates { get; set; }
        [XmlElement(IsNullable = true)]
        public List<KeyValuePair<DateTime, List<double>>> PassRates { get; set; }
        [XmlElement(IsNullable = true)]
        public List<KeyValuePair<DateTime, Dictionary<IStudent, ITestScore>>> TestScores { get; set; }
        [XmlElement(IsNullable = false)]
        public TimeSpan RequiredStudyTime { get; set; }
        [XmlElement(IsNullable = true)]
        public List<KeyValuePair<DateTime, IStudent>> HighestTestScoreStudents { get; set; }
        [XmlElement(IsNullable = true)]
        public List<KeyValuePair<DateTime, IStudent>> LowestTestScoreStudents { get; set; }
        [XmlElement(IsNullable = false)]
        public StudentAcademicAchievementLevel AcademicAchievementLevel { get; set; }
        [XmlElement(IsNullable = true)]
        public ITeacher TeacherInCharge { get; set; }
        [XmlElement(IsNullable = true)]
        public List<ITeacher> Teachers { get; set; }
        [XmlElement(IsNullable = true)]
        public List<KeyValuePair<double, ITeacher>> TeacherRankByPassRate { get; set; }
        [XmlElement(IsNullable = true)]
        public List<KeyValuePair<double, ITeacher>> TeacherRankByAttendanceRate { get; set; }
        #endregion
        #region Constructors
        public StudyClass() { }
        public StudyClass(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public StudyClass(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion