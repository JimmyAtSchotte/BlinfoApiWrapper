using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class JournalStore
    {
        private readonly BaseRestClient _client;

        public JournalStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetJournalResponseItem>> GetFromDateIntervalAsync(DateTime fromDate, DateTime toDate)
        {
            var path = $"{ApiControllers.JournalPath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}";
            return await _client.GetAsync<GetJournalResponseItem>(path);
        }


        public async Task<PostJournalResponseItem> PostAsync(PostJournalRequestItem item)
        {
            return await _client.PostAsync<PostJournalResponseItem>(item, ApiControllers.JournalPath);
        }

        public async Task<GetJournalResponseItem> GetJournalByJournalAndEntryId(string journalId, int journalEntryId,
            string journalEntryDate)
        {
            var path = $"{ApiControllers.JournalIdPath}/{journalId}/{journalEntryId}/{journalEntryDate}";
            return await _client.GetSingleAsync<GetJournalResponseItem>(path);
        }
    }
}
