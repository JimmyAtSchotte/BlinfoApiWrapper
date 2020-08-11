using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;

namespace BlInfoApiWrapper.Stores
{
    public class MetaStore
    {
        private readonly BaseRestClient _client;

        public MetaStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<GetMetaDataResponseItem<GetJournalResponseItem>> GetBatchJournals(string queryString)
        {
            var path = $"/batch/journalentry?{queryString}";
            return await _client.GetSingleAsync<GetMetaDataResponseItem<GetJournalResponseItem>>(path);
        }

        public async Task<GetMetaDataResponseItem<GetSupplierInvoiceResponseItem>> GetBatchSupplierInvoices(string queryString)
        {
            var path = $"/batch/supplierinvoice?{queryString}";
            return await _client.GetSingleAsync<GetMetaDataResponseItem<GetSupplierInvoiceResponseItem>>(path);
        }

        public async Task<GetMetaDataResponseItem<GetArticleResponseItem>> GetBatchArticles(string queryString)
        {
            var path = $"/batch/article?{queryString}";
            return await _client.GetSingleAsync<GetMetaDataResponseItem<GetArticleResponseItem>>(path);
        }

        public async Task<GetMetaDataResponseItem<GetCustomerInvoiceResponseItem>> GetBatchCustomerInvoices(string queryString)
        {
            var path = $"/batch/customerinvoice?{queryString}";
            return await _client.GetSingleAsync<GetMetaDataResponseItem<GetCustomerInvoiceResponseItem>>(path);
        }

        public async Task<GetMetaDataResponseItem<GetCustomerResponseItem>> GetBatchCustomers(string queryString)
        {
            var path = $"/batch/customer?{queryString}";
            return await _client.GetSingleAsync<GetMetaDataResponseItem<GetCustomerResponseItem>>(path);
        }

        public async Task<GetMetaDataResponseItem<GetOrderResponseItem>> GetBatchOrders(string queryString)
        {
            var path = $"/batch/order?{queryString}";
            return await _client.GetSingleAsync<GetMetaDataResponseItem<GetOrderResponseItem>>(path);
        }
    }
}
