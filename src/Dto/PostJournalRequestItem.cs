using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PostJournalRequestItem
    {
        [JsonProperty(PropertyName = "documentIds")]
        public List<string> DocumentIds { get; set; }
        [JsonProperty(PropertyName = "entryInfoBy")]
        public string EntryInfoBy { get; set; }
        [JsonProperty(PropertyName = "entryInfoDate")]
        public string EntryInfoDate { get; set; }

        [JsonProperty(PropertyName = "financialYearId")]
        public string FinancialYearId { get; set; }

        [JsonProperty(PropertyName = "journalEntryDate")]
        public string JournalEntryDate { get; set; }
        [JsonProperty(PropertyName = "journalEntryId")]
        public int JournalEntryId { get; set; }
        [JsonProperty(PropertyName = "journalEntryText")]
        public string JournalEntryText { get; set; }
        [JsonProperty(PropertyName = "journalId")]
        public string JournalId { get; set; }
        [JsonProperty(PropertyName = "journalName")]
        public string JournalName { get; set; }
        [JsonProperty(PropertyName = "ledgerEntries")]
        public List<GetLedgerEntryResponseItem> LedgerEntries { get; set; }
        [JsonProperty(PropertyName = "lockingInfoBy")]
        public string LockingInfoBy { get; set; }

        [JsonProperty(PropertyName = "lockingInfoDate")]
        public string LockingInfoDate { get; set; }

        [JsonProperty(PropertyName = "reportDate")]
        public string ReportDate { get; set; }

        public PostJournalRequestItem()
        {
            DocumentIds = new List<string>();
            EntryInfoBy = string.Empty;
            JournalEntryText = string.Empty;
            JournalId = string.Empty;
            JournalName = string.Empty;
            LedgerEntries = new List<GetLedgerEntryResponseItem>();
            LockingInfoBy = string.Empty;
            LockingInfoDate = string.Empty;
            FinancialYearId = string.Empty;
            EntryInfoDate = string.Empty;
            JournalEntryDate = string.Empty;
        }
    }
}