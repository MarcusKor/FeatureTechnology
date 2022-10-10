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
// File: StudentGrade.cs 
// Date: 2022, 10, 11, 오전 12:31
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
    #region Class StudentGrade
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class StudentGrade : PropertyAccessor, IStudentGrade
    {
        #region Properties
        [XmlElement(IsNullable = false)]
        public IStudyClass Subject { get; set; }
        [XmlElement(IsNullable = false)]
        public bool IsPassed { get; }
        [XmlElement(IsNullable = false)]
        public uint NumberOfRetakes { get; set; }
        [XmlElement(IsNullable = false)]
        public double AttendanceRate { get; set; }
        [XmlElement(IsNullable = false)]
        public ITestScore AchievedScore { get; set; }
        [XmlElement(IsNullable = false)]
        public StudentAcademicAchievementLevel AcademicAchievementLevel { get; set; }
        [XmlElement(IsNullable = false)]
        public TimeSpan TotalStudyTime { get; set; }
        #endregion
        #region Constructors
        public StudentGrade() { }
        public StudentGrade(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public StudentGrade(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion