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
using System.Reflection;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class PropertyAccessor
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    [Serializable]
    public abstract class PropertyAccessor : DisposableObject, IPropertyAccessor
    {
        #region Properties
        [XmlAttribute]
        public char TokenDelimiter { get; protected set; } = '/';
        #endregion
        #region Protected methods
        #endregion
        #region Public methods
        public virtual T GetProperty<T>(string element, CaseConversionType caseConversion = CaseConversionType.None)
        {
            return (T)Enum.ToObject(typeof(T), GetAllPropertyNames<T>(caseConversion).Where(x => x == element).Select(x => x.IndexOf(x)));
        }
        public virtual string[] GetAllPropertyNames<T>(CaseConversionType caseConversion = CaseConversionType.None)
        {
            ArrayList arrList = new ArrayList();
            return caseConversion switch
            {   
                CaseConversionType.ToLower => Enum.GetValues(typeof(T)).Cast<T>().Select(x => x.ToString().ToLower()).ToArray(),
                CaseConversionType.ToUpper => Enum.GetValues(typeof(T)).Cast<T>().Select(x => x.ToString().ToUpper()).ToArray(),
                _ => Enum.GetValues(typeof(T)).Cast<T>().Select(x => x.ToString()).ToArray(),
            };
        }
        public virtual bool AssignValues<T>(string args, char delimiter = '/')
        {
            int result = 0;
            if (!string.IsNullOrEmpty(args))
            {   // Assign tokenized values
                var properties = Enum.GetValues(typeof(T));
                var tokens = args.Split(TokenDelimiter = delimiter);
                for (int i = 0; i < tokens.Length; i++)
                {
                    var property = properties.GetValue(i);
                    if (property != null)
                    {
                        SetValue(this, nameof(property), tokens[i]);
                    }
                    else
                    {
                        Trace.WriteLine($"Property={property} is not available!");
                    }
                }
            }
            return result > 0;
        }
        public virtual bool AssignValues<T>(params string[] args)
        {
            bool result = false;
            if (args is not null)
            {   // Assign KeyValuePair
                if (args.Length % 2 == 0 && args.Any(x => GetAllPropertyNames<T>().Contains(x)))
                {
                    foreach (string value in args)
                    {
                        var property = GetProperty<T>(value.ToLower());
                        if (property != null)
                        {
                            SetValue(this, nameof(property), value);
                        }
                        else
                        {
                            Trace.WriteLine($"Property={property} is not available!");
                        }
                    }
                }
                else if (args.Length == Enum.GetValues(typeof(T)).Length)
                {   // Assign sequencial values
                    var properties = Enum.GetValues(typeof(T));
                    for (int i = 0; i < properties.Length; i++)
                    {
                        var property = properties.GetValue(i);
                        if (property != null)
                        {
                            SetValue(this, nameof(property), args[i]);
                        }
                        else
                        {
                            Trace.WriteLine($"Property={property} is not available!");
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