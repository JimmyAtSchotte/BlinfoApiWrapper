﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class CustomerStore
    {
        private readonly BaseRestClient _client;

        public CustomerStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetCustomerResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetCustomerResponseItem>(ApiControllers.CustomerPath);
        }

        public async Task<GetCustomerResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetCustomerResponseItem>($"{ApiControllers.CustomerPath}/{id}");
        }
        public async Task<PostCustomerResponseItem> Post(PostCustomerRequestItem item)
        {
            return await _client.PostAsync<PostCustomerResponseItem>(item, ApiControllers.CustomerPath);
        }
        public async Task<PutCustomerResponseItem> Put(PutCustomerRequestItem item)
        { 
            return await _client.PutAsync<PutCustomerResponseItem>(item, ApiControllers.CustomerPath);
        }
    }
}
