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
// File: Teacher.cs 
// Date: 2022, 10, 11, 오전 12:40
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
    #region Class Teacher
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class Teacher : Instructor, ITeacher
    {
        #region Properties
        [XmlElement(IsNullable = true)]
        public string School { get; set; }
        [XmlElement(IsNullable = false)]
        public TimeSpan ElapsedTimeFromTeaching { get; set; }
        [XmlElement(IsNullable = false)]
        public TimeSpan CounselorExperience { get; set; }
        #endregion
        #region Constructors
        public Teacher() { }
        public Teacher(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public Teacher(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion