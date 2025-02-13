﻿using AltenChallengeApp.AzureStorage.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AltenChallengeApp.AzureStorage.Storage
{
    public interface IAzureTableStorage<T> where T : AzureTableEntity, new()
    {
        Task Delete(string partitionKey, string rowKey);
        Task<T> GetItem(string partitionKey, string rowKey);
        Task<List<T>> GetList();
        Task<List<T>> GetList(string filter);
        Task Insert(T item);
        Task Update(T item);
    }
}
