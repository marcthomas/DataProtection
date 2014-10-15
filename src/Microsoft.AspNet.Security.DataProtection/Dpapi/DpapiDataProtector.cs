﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Microsoft.AspNet.Security.DataProtection.Dpapi
{
    // Provides a temporary implementation of IDataProtector for non-Windows machines
    // or for Windows machines where we can't depend on the user profile.
    internal sealed class DpapiDataProtector : IDataProtector
    {
        private static readonly UTF8Encoding _secureUtf8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        private readonly byte[] _combinedPurposes;
        private readonly DataProtectionScope _scope;
        private readonly IProtectedData _shim;

        internal DpapiDataProtector(IProtectedData shim, byte[] combinedPurposes, DataProtectionScope scope)
        {
            _combinedPurposes = combinedPurposes;
            _scope = scope;
            _shim = shim;
        }

        public IDataProtector CreateProtector([NotNull] string purpose)
        {
            // Appends the provided purpose to the existing list
            using (var memoryStream = new MemoryStream())
            {
                memoryStream.Write(_combinedPurposes, 0, _combinedPurposes.Length);
                using (var writer = new BinaryWriter(memoryStream, _secureUtf8Encoding, leaveOpen: true))
                {
                    writer.Write(purpose);
                }
                return new DpapiDataProtector(_shim, memoryStream.ToArray(), _scope);
            }
        }

        public byte[] Protect([NotNull] byte[] unprotectedData)
        {
            try
            {
                return _shim.Protect(unprotectedData, _combinedPurposes, _scope)
                    ?? CryptoUtil.Fail<byte[]>("Null return value.");
            }
            catch (Exception ex) if (!(ex is CryptographicException))
            {
                // Homogenize to CryptographicException
                throw Error.CryptCommon_GenericError(ex);
            }
        }

        public byte[] Unprotect([NotNull] byte[] protectedData)
        {
            try
            {
                return _shim.Unprotect(protectedData, _combinedPurposes, _scope)
                    ?? CryptoUtil.Fail<byte[]>("Null return value.");
            }
            catch (Exception ex) if (!(ex is CryptographicException))
            {
                // Homogenize to CryptographicException
                throw Error.CryptCommon_GenericError(ex);
            }
        }
    }
}