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
// File: IStudyClass.cs 
// Date: 2022, 10, 9, 오후 9:06
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
#endregion
#region Program
using ModernClasses.Attributes;
using ModernClasses.Social;
using System;
using System.Collections.Generic;

namespace ModernClasses.Interfaces
{
    #region Interface IStudyClass
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public interface IStudyClass
    {
        #region Properties
        string Name { get; set; }
        int NumberOfRegularClassParticipants { get; set; }
        string RequiredPassLevel { get; set; }
        List<KeyValuePair<DateTime, List<KeyValuePair<ITeacher, double>>>> ClassTimeTables {get; set; }
        List<KeyValuePair<DateTime, List<double>>> AttendanceRates { get; set; }
        List<KeyValuePair<DateTime, List<double>>> PassRates { get; set; }
        List<KeyValuePair<DateTime, Dictionary<IStudent, ITestScore>>> TestScores { get; set; }
        TimeSpan RequiredStudyTime { get; set; }
        List<KeyValuePair<DateTime, IStudent>> HighestTestScoreStudents { get; set; }
        List<KeyValuePair<DateTime, IStudent>> LowestTestScoreStudents { get; set; }
        StudentAcademicAchievementLevel AcademicAchievementLevel { get; set; }
        ITeacher TeacherInCharge { get; set; }
        List<ITeacher> Teachers { get; set; }
        List<KeyValuePair<double, ITeacher>> TeacherRankByPassRate { get; set; }
        List<KeyValuePair<double, ITeacher>> TeacherRankByAttendanceRate { get; set; }
        #endregion
    }
    #endregion
}
#endregion