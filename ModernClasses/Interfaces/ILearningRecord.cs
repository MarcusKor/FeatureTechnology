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
// File: ILearningRecord.cs 
// Date: 2022, 10, 9, 오후 9:52
// Project: ModernClasses
// Namespace: ModernClasses.Interfaces
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
#endregion
#region Program
namespace ModernClasses.Interfaces
{
    #region Interface ILearningRecord
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public interface ILearningRecord
    {
        #region Properties
        IStudyClass StudyClass { get; set; }
        IStudentGrade HighestGrade { get; set; }
        IStudentGrade LowestGrade { get; set; }
        IStudentGrade FinalGrade { get; set; }
        List<KeyValuePair<DateTime, ITestScore>> TestResults { get; set; }
        uint NumberOfRetakes { get; set; }
        uint NumberOfTest { get; set; }
        uint NumberOfPass { get; set; }
        #endregion
    }
    #endregion
}
#endregion