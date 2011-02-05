﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;

namespace Simplisticky {
    class SecureCredential {

        private static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("Salt Is Not A Password");

        public SecureCredential() { }

        public string EncryptString(System.Security.SecureString input) {
            byte[] encryptedData = System.Security.Cryptography.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)),
                entropy,
                System.Security.Cryptography.DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public SecureString DecryptString(string encryptedData) {
            try {
                byte[] decryptedData = System.Security.Cryptography.ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    entropy,
                    System.Security.Cryptography.DataProtectionScope.CurrentUser);
                return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));
            }
            catch {
                return new SecureString();
            }
        }

        public SecureString ToSecureString(string input) {
            SecureString secure = new SecureString();
            foreach (char c in input) {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        public string ToInsecureString(SecureString input) {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }

    }
}
