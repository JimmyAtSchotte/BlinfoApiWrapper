﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class ProjectStore
    {
        private readonly BaseRestClient _client;

        public ProjectStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetProjectResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetProjectResponseItem>(ApiControllers.ProjectPath);
        }

        public async Task<GetProjectResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetProjectResponseItem>($"{ApiControllers.ProjectPath}/{id}");
        }
    }
}
