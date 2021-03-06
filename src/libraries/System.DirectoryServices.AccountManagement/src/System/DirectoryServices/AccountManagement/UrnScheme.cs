// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace System.DirectoryServices.AccountManagement
{
    internal static class UrnScheme
    {
        public const string GuidScheme = IdentityTypeStringMap.Guid;
        public const string SidScheme = IdentityTypeStringMap.Sid;
        public const string DistinguishedNameScheme = IdentityTypeStringMap.DistinguishedName;
        public const string SamAccountScheme = IdentityTypeStringMap.SamAccount;
        public const string UpnScheme = IdentityTypeStringMap.Upn;
        public const string NameScheme = IdentityTypeStringMap.Name;
    }
}
