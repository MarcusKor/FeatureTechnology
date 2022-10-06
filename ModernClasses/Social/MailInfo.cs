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
// File: MailInfo.cs 
// Date: 2022, 10, 6, 오전 1:39
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
using System.Data.SqlTypes;
using System.Text;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class MailInfo
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public class MailInfo : PropertyAccessor, IMailInfo
    {
        #region Properties
        [XmlIgnore]
        private string mailServer;
        [XmlAttribute]
        public string MailServer
        {
            get => mailServer ?? string.Empty;
            set => mailServer = value;
        }
        [XmlElement(IsNullable = true)]
        public string MailAccount { get; set; }
        #endregion
        #region Constructors
        public MailInfo() { }
        public MailInfo(string arg, char delimiter = '/')
        {
            AssignValues<IMailInfo.Properties>(arg, delimiter);
        }
        public MailInfo(params string[] args)
        {
            AssignValues<IMailInfo.Properties>(args);
        }
        #endregion
    }
    #endregion
}
#endregion