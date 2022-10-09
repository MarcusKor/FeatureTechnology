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
// File: IInstructor.cs 
// Date: 2022, 10, 9, 오후 9:31
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using System;
using System.Collections.Generic;
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    #region Interface IInstructor
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public interface IInstructor : IPersonInfo
    {
        #region Properties
        List<string> Majors { get; set; }
        Dictionary<IStudyClass, List<double>> SubjectsInCharge { get; set; } // NumberOfRetakes,TotalTeachingTime,AttendanceRate,PassRate
        Dictionary<IStudyClass, List<double>> ClassExperiences { get; set; } // NumberOfRetakes,TotalTeachingTime,AttendanceRate,PassRate
        TimeSpan Carrier { get; set; } // Total experiences
        IPayInfo PayInfo { get; set; }
        #endregion
    }
    #endregion
}
#endregion