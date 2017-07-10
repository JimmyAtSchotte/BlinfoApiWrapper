﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class SupplierStore
    {
        private readonly BaseRestClient _client;

        public SupplierStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetSupplierResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetSupplierResponseItem>(ApiControllers.SupplierPath);
        }

        public async Task<GetSupplierResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetSupplierResponseItem>($"{ApiControllers.SupplierPath}/{id}");
        }
    }
}
