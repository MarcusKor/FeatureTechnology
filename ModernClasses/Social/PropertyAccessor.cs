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
// File: ElementHelper.cs 
// Date: 2022, 10, 2, 오후 9:03
// Project: ModernClasses
// Namespace: ModernClasses.Helpers
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using ModernClasses.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class PropertyAccessor
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public abstract class PropertyAccessor : DisposableObject 
    {
        #region Properties
        [XmlAttribute]
        public char TokenDelimiter { get; protected set; } = '/';
        #endregion
        #region Protected methods
        #endregion
        #region Public methods
        public static PropertyInfo? GetProperty(string property, object src, CaseConversionType caseConversionType = 0)
        {
            return GetProperties(src)?.Where(x => x.Name == property).FirstOrDefault();
        }
        public static string[]? GetAllPropertyNames(object src, CaseConversionType caseConversion = CaseConversionType.None)
        {
            var type = src.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            if (properties != null)
            {
                return caseConversion switch
                {
                    CaseConversionType.ToLower => properties.Select(x => x.Name.ToLower()).ToArray(),
                    CaseConversionType.ToUpper => properties.Select(x => x.Name.ToUpper()).ToArray(),
                    _ => properties.Select(x => x.Name).ToArray(),
                };
            }
            return null;
        }
        public static PropertyInfo[]? GetProperties(object src)
        {
            var type = src.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            return properties != null ? properties.ToArray() : null;
        }
        public static bool AssignValues(object src, string args, char delimiter = '/')
        {   // Assign tokenized values
            return string.IsNullOrEmpty(args) ? false : AssignValues(src, args.Split(delimiter));
        }
        public static bool AssignValues(object src, params string[] args)
        {
            bool result = false;
            if (args is not null)
            {   // Assign KeyValuePair
                if (args.First().Contains("="))
                {
                    List<string> keys = new ();
                    List<string> values = new ();
                    foreach (var arg in args)
                    {
                        if (arg.Contains("="))
                        {
                            var tokens = arg.Split('=');
                            keys.Add(tokens.First());
                            values.Add(tokens.Last());
                        }
                    }
                    if (keys.Any(x => GetAllPropertyNames(src).Contains(x)))
                    {
                        for (int i = 0; i < keys.Count; i++)
                        {
                            var property = GetProperty(keys[i], src);
                            if (property != null)
                            {
                                SetValue(src, property.Name, values[i]);
                            }
                        }
                    }
                }
                else if (args.Length == GetAllPropertyNames(src)?.Length)
                {   // Assign sequencial values
                    var properties = GetProperties(src);
                    if (properties != null)
                    {
                        for (int i = 0; i < properties?.Length; i++)
                        {
                            SetValue(src, properties[i].Name, args[i]);
                        }
                    }
                }
            }
            return result;
        }
        public static Dictionary<string, PropertyInfo> GetAllPropertyInfo<T>(BindingFlags bindingAttr = BindingFlags.Default)
        {
            Dictionary<string, PropertyInfo> result = new ();
            foreach (var property in typeof(T).GetProperties(bindingAttr))
            {
                result.Add(property.Name, property);
            }
            return result;
        }
        public static T GetValue<T>(object src, string property) => (T)GetValue(src, property);
        public static object GetValue(object src, string property) => src.GetType().GetProperty(property).GetValue(src, null);
        public static void SetValue(object src, string property, object value)
        {
            try
            {
                var propertyInfo = src.GetType().GetProperty(property);
                propertyInfo?.SetValue(src, value);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        #endregion
    }
    #endregion
}
#endregion