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
// File: NotificationInfo.cs 
// Date: 2022, 10, 6, 오후 11:58
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
    #region Class NotificationInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class NotificationInfo : PropertyAccessor, INotificationInfo
    {
        #region Properties
        [XmlElement(IsNullable = false)]
        public NotificationMode NotificationMode { get; set; }
        [XmlElement(IsNullable = false)]
        public NotificationWay NotificationWay { get; set; }
        [XmlElement(IsNullable = false)]
        public NotificationRepeatMode RepeatMode { get; set; }
        [XmlElement(IsNullable = false)]
        public bool Usage { get; set; }
        [XmlIgnore]
        public bool Status { get; set; }
        #endregion
    }
    #endregion
}
#endregion