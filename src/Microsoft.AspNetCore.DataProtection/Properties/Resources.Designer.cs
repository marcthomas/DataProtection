// <auto-generated />
namespace Microsoft.AspNetCore.DataProtection
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.DataProtection.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// An error occurred during a cryptographic operation.
        /// </summary>
        internal static string CryptCommon_GenericError
        {
            get { return GetString("CryptCommon_GenericError"); }
        }

        /// <summary>
        /// An error occurred during a cryptographic operation.
        /// </summary>
        internal static string FormatCryptCommon_GenericError()
        {
            return GetString("CryptCommon_GenericError");
        }

        /// <summary>
        /// The provided buffer is of length {0} byte(s). It must instead be exactly {1} byte(s) in length.
        /// </summary>
        internal static string Common_BufferIncorrectlySized
        {
            get { return GetString("Common_BufferIncorrectlySized"); }
        }

        /// <summary>
        /// The provided buffer is of length {0} byte(s). It must instead be exactly {1} byte(s) in length.
        /// </summary>
        internal static string FormatCommon_BufferIncorrectlySized(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Common_BufferIncorrectlySized"), p0, p1);
        }

        /// <summary>
        /// The payload was invalid.
        /// </summary>
        internal static string CryptCommon_PayloadInvalid
        {
            get { return GetString("CryptCommon_PayloadInvalid"); }
        }

        /// <summary>
        /// The payload was invalid.
        /// </summary>
        internal static string FormatCryptCommon_PayloadInvalid()
        {
            return GetString("CryptCommon_PayloadInvalid");
        }

        /// <summary>
        /// Property {0} cannot be null or empty.
        /// </summary>
        internal static string Common_PropertyCannotBeNullOrEmpty
        {
            get { return GetString("Common_PropertyCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// Property {0} cannot be null or empty.
        /// </summary>
        internal static string FormatCommon_PropertyCannotBeNullOrEmpty(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Common_PropertyCannotBeNullOrEmpty"), p0);
        }

        /// <summary>
        /// The provided payload could not be decrypted. Refer to the inner exception for more information.
        /// </summary>
        internal static string Common_DecryptionFailed
        {
            get { return GetString("Common_DecryptionFailed"); }
        }

        /// <summary>
        /// The provided payload could not be decrypted. Refer to the inner exception for more information.
        /// </summary>
        internal static string FormatCommon_DecryptionFailed()
        {
            return GetString("Common_DecryptionFailed");
        }

        /// <summary>
        /// An error occurred while trying to encrypt the provided data. Refer to the inner exception for more information.
        /// </summary>
        internal static string Common_EncryptionFailed
        {
            get { return GetString("Common_EncryptionFailed"); }
        }

        /// <summary>
        /// An error occurred while trying to encrypt the provided data. Refer to the inner exception for more information.
        /// </summary>
        internal static string FormatCommon_EncryptionFailed()
        {
            return GetString("Common_EncryptionFailed");
        }

        /// <summary>
        /// The key {0:B} was not found in the key ring.
        /// </summary>
        internal static string Common_KeyNotFound
        {
            get { return GetString("Common_KeyNotFound"); }
        }

        /// <summary>
        /// The key {0:B} was not found in the key ring.
        /// </summary>
        internal static string FormatCommon_KeyNotFound()
        {
            return GetString("Common_KeyNotFound");
        }

        /// <summary>
        /// The key {0:B} has been revoked.
        /// </summary>
        internal static string Common_KeyRevoked
        {
            get { return GetString("Common_KeyRevoked"); }
        }

        /// <summary>
        /// The key {0:B} has been revoked.
        /// </summary>
        internal static string FormatCommon_KeyRevoked()
        {
            return GetString("Common_KeyRevoked");
        }

        /// <summary>
        /// The provided payload cannot be decrypted because it was not protected with this protection provider.
        /// </summary>
        internal static string ProtectionProvider_BadMagicHeader
        {
            get { return GetString("ProtectionProvider_BadMagicHeader"); }
        }

        /// <summary>
        /// The provided payload cannot be decrypted because it was not protected with this protection provider.
        /// </summary>
        internal static string FormatProtectionProvider_BadMagicHeader()
        {
            return GetString("ProtectionProvider_BadMagicHeader");
        }

        /// <summary>
        /// The provided payload cannot be decrypted because it was protected with a newer version of the protection provider.
        /// </summary>
        internal static string ProtectionProvider_BadVersion
        {
            get { return GetString("ProtectionProvider_BadVersion"); }
        }

        /// <summary>
        /// The provided payload cannot be decrypted because it was protected with a newer version of the protection provider.
        /// </summary>
        internal static string FormatProtectionProvider_BadVersion()
        {
            return GetString("ProtectionProvider_BadVersion");
        }

        /// <summary>
        /// Value must be non-negative.
        /// </summary>
        internal static string Common_ValueMustBeNonNegative
        {
            get { return GetString("Common_ValueMustBeNonNegative"); }
        }

        /// <summary>
        /// Value must be non-negative.
        /// </summary>
        internal static string FormatCommon_ValueMustBeNonNegative()
        {
            return GetString("Common_ValueMustBeNonNegative");
        }

        /// <summary>
        /// The type '{1}' is not assignable to '{0}'.
        /// </summary>
        internal static string TypeExtensions_BadCast
        {
            get { return GetString("TypeExtensions_BadCast"); }
        }

        /// <summary>
        /// The type '{1}' is not assignable to '{0}'.
        /// </summary>
        internal static string FormatTypeExtensions_BadCast(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TypeExtensions_BadCast"), p0, p1);
        }

        /// <summary>
        /// The new key lifetime must be at least one week.
        /// </summary>
        internal static string KeyManagementOptions_MinNewKeyLifetimeViolated
        {
            get { return GetString("KeyManagementOptions_MinNewKeyLifetimeViolated"); }
        }

        /// <summary>
        /// The new key lifetime must be at least one week.
        /// </summary>
        internal static string FormatKeyManagementOptions_MinNewKeyLifetimeViolated()
        {
            return GetString("KeyManagementOptions_MinNewKeyLifetimeViolated");
        }

        /// <summary>
        /// The key {0:B} already exists in the keyring.
        /// </summary>
        internal static string XmlKeyManager_DuplicateKey
        {
            get { return GetString("XmlKeyManager_DuplicateKey"); }
        }

        /// <summary>
        /// The key {0:B} already exists in the keyring.
        /// </summary>
        internal static string FormatXmlKeyManager_DuplicateKey()
        {
            return GetString("XmlKeyManager_DuplicateKey");
        }

        /// <summary>
        /// Argument cannot be null or empty.
        /// </summary>
        internal static string Common_ArgumentCannotBeNullOrEmpty
        {
            get { return GetString("Common_ArgumentCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// Argument cannot be null or empty.
        /// </summary>
        internal static string FormatCommon_ArgumentCannotBeNullOrEmpty()
        {
            return GetString("Common_ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// Property {0} must have a non-negative value.
        /// </summary>
        internal static string Common_PropertyMustBeNonNegative
        {
            get { return GetString("Common_PropertyMustBeNonNegative"); }
        }

        /// <summary>
        /// Property {0} must have a non-negative value.
        /// </summary>
        internal static string FormatCommon_PropertyMustBeNonNegative(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Common_PropertyMustBeNonNegative"), p0);
        }

        /// <summary>
        /// GCM algorithms require the Windows platform.
        /// </summary>
        internal static string Platform_WindowsRequiredForGcm
        {
            get { return GetString("Platform_WindowsRequiredForGcm"); }
        }

        /// <summary>
        /// GCM algorithms require the Windows platform.
        /// </summary>
        internal static string FormatPlatform_WindowsRequiredForGcm()
        {
            return GetString("Platform_WindowsRequiredForGcm");
        }

        /// <summary>
        /// A certificate with the thumbprint '{0}' could not be found.
        /// </summary>
        internal static string CertificateXmlEncryptor_CertificateNotFound
        {
            get { return GetString("CertificateXmlEncryptor_CertificateNotFound"); }
        }

        /// <summary>
        /// A certificate with the thumbprint '{0}' could not be found.
        /// </summary>
        internal static string FormatCertificateXmlEncryptor_CertificateNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CertificateXmlEncryptor_CertificateNotFound"), p0);
        }

        /// <summary>
        /// Decrypting EncryptedXml-encapsulated payloads is not yet supported on Core CLR.
        /// </summary>
        internal static string EncryptedXmlDecryptor_DoesNotWorkOnCoreClr
        {
            get { return GetString("EncryptedXmlDecryptor_DoesNotWorkOnCoreClr"); }
        }

        /// <summary>
        /// Decrypting EncryptedXml-encapsulated payloads is not yet supported on Core CLR.
        /// </summary>
        internal static string FormatEncryptedXmlDecryptor_DoesNotWorkOnCoreClr()
        {
            return GetString("EncryptedXmlDecryptor_DoesNotWorkOnCoreClr");
        }

        /// <summary>
        /// The symmetric algorithm block size of {0} bits is invalid. The block size must be between 64 and 2048 bits, inclusive, and it must be a multiple of 8 bits.
        /// </summary>
        internal static string AlgorithmAssert_BadBlockSize
        {
            get { return GetString("AlgorithmAssert_BadBlockSize"); }
        }

        /// <summary>
        /// The symmetric algorithm block size of {0} bits is invalid. The block size must be between 64 and 2048 bits, inclusive, and it must be a multiple of 8 bits.
        /// </summary>
        internal static string FormatAlgorithmAssert_BadBlockSize(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AlgorithmAssert_BadBlockSize"), p0);
        }

        /// <summary>
        /// The validation algorithm digest size of {0} bits is invalid. The digest size must be between 128 and 2048 bits, inclusive, and it must be a multiple of 8 bits.
        /// </summary>
        internal static string AlgorithmAssert_BadDigestSize
        {
            get { return GetString("AlgorithmAssert_BadDigestSize"); }
        }

        /// <summary>
        /// The validation algorithm digest size of {0} bits is invalid. The digest size must be between 128 and 2048 bits, inclusive, and it must be a multiple of 8 bits.
        /// </summary>
        internal static string FormatAlgorithmAssert_BadDigestSize(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AlgorithmAssert_BadDigestSize"), p0);
        }

        /// <summary>
        /// The symmetric algorithm key size of {0} bits is invalid. The key size must be between 128 and 2048 bits, inclusive, and it must be a multiple of 8 bits.
        /// </summary>
        internal static string AlgorithmAssert_BadKeySize
        {
            get { return GetString("AlgorithmAssert_BadKeySize"); }
        }

        /// <summary>
        /// The symmetric algorithm key size of {0} bits is invalid. The key size must be between 128 and 2048 bits, inclusive, and it must be a multiple of 8 bits.
        /// </summary>
        internal static string FormatAlgorithmAssert_BadKeySize(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AlgorithmAssert_BadKeySize"), p0);
        }

        /// <summary>
        /// The key ring does not contain a valid default protection key. The data protection system cannot create a new key because auto-generation of keys is disabled.
        /// </summary>
        internal static string KeyRingProvider_NoDefaultKey_AutoGenerateDisabled
        {
            get { return GetString("KeyRingProvider_NoDefaultKey_AutoGenerateDisabled"); }
        }

        /// <summary>
        /// The key ring does not contain a valid default protection key. The data protection system cannot create a new key because auto-generation of keys is disabled.
        /// </summary>
        internal static string FormatKeyRingProvider_NoDefaultKey_AutoGenerateDisabled()
        {
            return GetString("KeyRingProvider_NoDefaultKey_AutoGenerateDisabled");
        }

        /// <summary>
        /// {0} must not be negative
        /// </summary>
        internal static string LifetimeMustNotBeNegative
        {
            get { return GetString("LifetimeMustNotBeNegative"); }
        }

        /// <summary>
        /// {0} must not be negative
        /// </summary>
        internal static string FormatLifetimeMustNotBeNegative(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LifetimeMustNotBeNegative"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
