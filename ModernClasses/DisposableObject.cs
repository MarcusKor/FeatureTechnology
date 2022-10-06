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
// File: DisposableObject.cs 
// Date: 2022, 10, 2, 오전 12:40
// Project: ModernClasses
// Namespace: ModernClasses
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using ModernClasses.Attributes;
using System;
using System.Diagnostics;
#endregion
#region Program
namespace ModernClasses
{
    #region Class DisposableObject
    [Author("IL HWAN, JEONG", "Marcus", 1.0)]
    public class DisposableObject : IDisposable
    {
        #region Fields
        private bool disposedValue;
        #endregion
        #region Protected methods
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    DisposeManagedResources();
                }
                DisposeUnmanagedResources();
                disposedValue = true;
            }
        }
        ~DisposableObject()
        {
            Debug.Assert(disposedValue, "The object is not disposed.");
            Dispose(disposing: false);
        }
        protected virtual void DisposeManagedResources() { }
        protected virtual void DisposeUnmanagedResources() { }
        #endregion
        #region Public methods
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
    #endregion
}
#endregion