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
using ModernClasses.Interfaces;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Class ElementAccessor
    [Serializable]
    public abstract class ElementAccessor : DisposableObject, IElementAccessor
    {
        #region Properties
        [XmlAttribute]
        public char TokenDelimiter { get; protected set; } = '/';
        #endregion
        #region Protected methods
        protected virtual string[]? RelocateValues(ref int result, params string[] args)
        {
            ResidenceType residence;
            if (args.First() is not null)
            {
                if (Enum.TryParse(args[0], out residence))
                {
                    return args;
                }
                else if (Enum.TryParse(args.Last(), out residence))
                {
                    return args.Reverse().ToArray();
                }
            }
            else if (args.Last() is not null && Enum.TryParse(args.Last(), out residence))
            {
                return args.Reverse().ToArray();
            }
            return null;
        }
        #endregion
        #region Public methods
        public virtual T GetElement<T>(string element, CaseConversionType caseConversion = CaseConversionType.ToLower)
        {
            return (T)Enum.ToObject(typeof(T), GetElements<T>(caseConversion).Where(x => x == element).Select(x => x.IndexOf(x)));
        }
        public virtual string[] GetElements<T>(CaseConversionType caseConversion = 0)
        {
            return caseConversion switch
            {
                CaseConversionType.ToLower => Enum.GetValues(typeof(T)).Cast<int>().Select(x => x.ToString().ToLower()).ToArray(),
                CaseConversionType.ToUpper => Enum.GetValues(typeof(T)).Cast<int>().Select(x => x.ToString().ToUpper()).ToArray(),
                _ => Enum.GetValues(typeof(T)).Cast<int>().Select(x => x.ToString()).ToArray(),
            };
        }
        public virtual bool AssignValues<T>(string args, char delimiter = '/')
        {
            int result = 0;
            if (!string.IsNullOrEmpty(args))
            {   // Assign tokenized values
                var tokens = args.Split(TokenDelimiter = delimiter);
                if (tokens.Length == Enum.GetValues(typeof(T)).Length)
                {
                    var relocatedValues = RelocateValues(ref result, tokens);
                    if (relocatedValues is not null)
                    {
                        for (int i = 0; i < relocatedValues.Length; i++)
                        {
                            var property = (T)Convert.ChangeType(i, typeof(T));
                            if (property != null)
                            {
                                SetValue(this, nameof(property), relocatedValues[i]);
                            }
                            else
                            {
                                Trace.WriteLine($"Property={property} is not available!");
                            }
                        }
                    }
                }
            }
            return result > 0;
        }
        public virtual bool AssignValues<T>(params string[] args)
        {
            bool result = false;
            int element = -1;
            if (args is not null)
            {   // Assign KeyValuePair
                if (args.Length % 2 == 0 && args.Any(x => GetElements<T>(CaseConversionType.ToLower).Contains(x.ToLower())))
                {
                    foreach (string value in args)
                    {
                        var property = GetElement<T>(value.ToLower(), CaseConversionType.None);
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
                    var relocatedValues = RelocateValues(ref element, args);
                    if (relocatedValues is not null)
                    {
                        for (int i = 0; i < relocatedValues.Length; i++)
                        {
                            var property = (T)Convert.ChangeType(i, typeof(T));
                            if (property != null)
                            {
                                SetValue(this, nameof(property), relocatedValues[i]);
                            }
                            else
                            {
                                Trace.WriteLine($"Property={property} is not available!");
                            }
                        }
                    }
                }
            }
            return result;
        }
        public static object GetValue(object src, string property) => src.GetType().GetProperty(property).GetValue(src, null);
        public static void SetValue(object src, string property, object value)
        {
            try
            {
                PropertyInfo propertyInfo = src.GetType().GetProperty(property);
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