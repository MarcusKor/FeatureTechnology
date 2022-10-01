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
// File: AddressInfo.cs 
// Date: 2022, 10, 2, 오전 12:49
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;

namespace ModernClasses.Social
{
    public class AddressInfo
    {
        public enum Elements : int
        {
            ResidenceType,
            SiteUrl,
            GeographicLocation,
            Street1,
            Street2,
            City,
            State,
            Country
        }
        public AddressInfo() { }
        public AddressInfo(string address, char delimiter = '/')
        {
            AssignValues(address, delimiter);
        }
        public AddressInfo(params string[] address)
        {
            AssignValues(address);
        }
        public ResidenceType ResidenceType { get; set; } = ResidenceType.Unknown;
        public string SiteUrl { get; set; } = string.Empty;
        public string GeographicLocation { get; set; } = string.Empty;
        public string Street1 { get; set; } = string.Empty;
        public string Street2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        [XmlIgnore]
        public string TokenizedAddress => $"{ResidenceType}/{SiteUrl}/{GeographicLocation}/{Street1}/{Street2}/{City}/{State}/{Country}";
        public string[]? RelocaeValues(ref int result, params string[] address)
        {
            ResidenceType residence;

            if (address.First() is not null)
            {
                if (Enum.TryParse(address[0], out residence))
                {
                    return address;
                }
                else if (Enum.TryParse(address.Last(), out residence))
                {
                    return address.Reverse().ToArray();
                }
            }
            else if (address.Last() is not null && Enum.TryParse(address.Last(), out residence))
            {
                return address.Reverse().ToArray();
            }

            return null;
        }
        public void SetValue(Elements element, string value)
        {
            switch (element)
            {
                case Elements.ResidenceType:
                    {
                        if (Enum.TryParse(value, out ResidenceType residence)) ResidenceType = residence;
                    }
                    break;
                case Elements.SiteUrl: SiteUrl = value; break;
                case Elements.GeographicLocation: GeographicLocation = value; break;
                case Elements.Street1: Street1 = value; break;
                case Elements.Street2: Street2 = value; break;
                case Elements.City: City = value; break;
                case Elements.State: State = value; break;
                case Elements.Country: Country = value; break;
            }
        }
        public bool AssignValues(string address, char delimiter = '/')
        {
            int result = 0;

            if (!string.IsNullOrEmpty(address))
            {   // Assign tokenized values
                var tokens = address.Split(delimiter);
                if (tokens.Length == Enum.GetValues(typeof(Elements)).Length)
                {
                    var relocatedValues = RelocaeValues(ref result, tokens);

                    if (relocatedValues is not null)
                    {
                        for (int i = 0; i < relocatedValues.Length; i++)
                        {
                            SetValue((Elements)i, relocatedValues[i]);
                        }
                    }
                }
            }

            return result > 0;
        }
        public string[] GetElements(int convertMode = 0)
        {
            switch (convertMode)
            {
                case -1: return Enum.GetValues(typeof(Elements)).Cast<int>().Select(x => x.ToString().ToLower()).ToArray();
                case 1: return Enum.GetValues(typeof(Elements)).Cast<int>().Select(x => x.ToString().ToUpper()).ToArray();
                default:
                case 0: return Enum.GetValues(typeof(Elements)).Cast<int>().Select(x => x.ToString()).ToArray();
            }
        }
        public bool AssignValues(params string[] address)
        {
            bool result = false;
            int element = -1;

            if (address is not null)
            {   // Assign KeyValuePair
                if (address.Length % 2 == 0 && address.Any(x => GetElements(-1).Contains(x.ToLower())))
                {
                    foreach (string value in address)
                    {
                        switch (value.ToLower())
                        {
                            case "residencetype": element = (int)Elements.ResidenceType; break;
                            case "siteurl": element = (int)Elements.SiteUrl; break;
                            case "geographiclocation": element = (int)Elements.GeographicLocation; break;
                            case "stree1": element = (int)Elements.Street1; break;
                            case "stree2": element = (int)Elements.Street2; break;
                            case "city": element = (int)Elements.City; break;
                            case "state": element = (int)Elements.State; break;
                            case "country": element = (int)Elements.Country; break;
                            default:
                                {
                                    SetValue((Elements)element, value);
                                    result = true;
                                }
                                break;
                        }
                    }
                }
                else if (address.Length == Enum.GetValues(typeof(Elements)).Length)
                {   // Assign sequencial values
                    var relocatedValues = RelocaeValues(ref element, address);

                    if (relocatedValues is not null)
                    {
                        for (int i = 0; i < relocatedValues.Length; i++)
                        {
                            SetValue((Elements)i, relocatedValues[i]);
                            result = true;
                        }
                    }
                }
            }

            return result;
        }
    }
}
