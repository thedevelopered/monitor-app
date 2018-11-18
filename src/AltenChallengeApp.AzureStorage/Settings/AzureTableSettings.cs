using System;

namespace AltenChallengeApp.AzureStorage.Settings
{
    public class AzureTableSettings
    {
        public AzureTableSettings(string _storageAccount, string _storageKey, string _tableName)
        {
            if (string.IsNullOrEmpty(_storageAccount))
                throw new ArgumentNullException("StorageAccount");

            if (string.IsNullOrEmpty(_storageKey))
                throw new ArgumentNullException("StorageKey");

            if (string.IsNullOrEmpty(_tableName))
                throw new ArgumentNullException("TableName");

            this.StorageAccount = _storageAccount;
            this.StorageKey = _storageKey;
            this.TableName = _tableName;
        }

        public string StorageAccount { get; }
        public string StorageKey { get; }
        public string TableName { get; }
    }
}
