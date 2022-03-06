using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SMTP_Free_frontend
{
    public static class _encryption
    {

        public static byte[] EncryptString(string RawValue, string Salt)
        {
            try
            {

                //Convert our raw vaulues to bytes
                byte[] RawValueBytes = Encoding.UTF8.GetBytes(RawValue);
                byte[] SaltBytes = Encoding.UTF8.GetBytes(Salt);


                return ProtectedData.Protect(RawValueBytes, SaltBytes, DataProtectionScope.LocalMachine);
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occured during password encryption: {e.InnerException.ToString()}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Encoding.UTF8.GetBytes("");
            }

        }

        public static string DecryptByteArray(byte[] EncryptedBytes,string SaltUsedForEncryption)
        {
             try
            {

                //Convert our raw vaulues to bytes
                byte[] SaltBytes = Encoding.UTF8.GetBytes(SaltUsedForEncryption);

                byte[] DecryptedValue = ProtectedData.Unprotect(EncryptedBytes, SaltBytes, DataProtectionScope.LocalMachine);
                return Encoding.UTF8.GetString(DecryptedValue);

           }
            catch (Exception e)
            {
                if (e.ToString().Contains("The data is invalid"))
                {
                    MessageBox.Show("Failed to decrypt the SMTP password.\nThis failure could indicate that the SMTP key file was tampered with.\nPlease set the password again.","Fatal Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return "";
                }
                else
                {
                    MessageBox.Show($"An error occured during password decryption: {e.ToString()}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            }
        }

    }
}
