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
// File: Instructor.cs 
// Date: 2022, 10, 10, 오후 11:01
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
    #region Class Instructor
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class Instructor : PersonInfo, IInstructor
    {
        #region Properties
        [XmlArrayItem("Major")]
        [XmlArray("Majors")]
        public List<string> Majors { get; set; }
        [XmlArrayItem("Subject")]
        [XmlArray("SubjectsInCharge")]
        public List<KeyValuePair<IStudyClass, List<double>>> SubjectsInCharge { get; set; }
        [XmlArrayItem("ClassExperience")]
        [XmlArray("ClassExperiences")]
        public List<KeyValuePair<IStudyClass, List<double>>> StudyClassExperiences { get; set; }
        [XmlElement(IsNullable = false)]
        public TimeSpan Carrier { get; set; }
        [XmlElement(IsNullable = false)]
        public IPayInfo PayInfo { get; set; }
        #endregion
        #region Constructors
        public Instructor() { }
        public Instructor(string arg, char delimiter = '/')
        {
            AssignValues(this, arg, TokenDelimiter = delimiter);
        }
        public Instructor(params string[] args)
        {
            AssignValues(this, args);
        }
        #endregion
    }
    #endregion
}
#endregion