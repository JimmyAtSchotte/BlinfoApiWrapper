using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PostSupplierInvoiceFixedRequestItem
    {
        [JsonProperty(PropertyName = "amountInLocalCurrency")]
        public decimal AmountInLocalCurrency { get; set; }
        [JsonProperty(PropertyName = "amountInOriginalCurrency")]
        public decimal AmountInOriginalCurrency { get; set; }
        [JsonProperty(PropertyName = "amountPaidInLocalCurrency")]
        public decimal AmountPaidInLocalCurrency { get; set; }
        [JsonProperty(PropertyName = "amountPaidInOriginalCurrency")]
        public decimal AmountPaidInOriginalCurrency { get; set; }

        [JsonProperty(PropertyName = "attested")]
        public bool Attested { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "costBearerId")]
        public string CostBearerId { get; set; }

        [JsonProperty(PropertyName = "costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }


        [JsonProperty(PropertyName = "documentIds")]
        public List<string> DocumentIds { get; set; }

        [JsonProperty(PropertyName = "dueDate")]
        public string DueDate { get; set; }


        [JsonProperty(PropertyName = "externalWatch")]
        public bool ExternalWatch { get; set; }

        [JsonProperty(PropertyName = "invoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonProperty(PropertyName = "invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty(PropertyName = "journalEntryDate")]
        public string JournalEntryDate { get; set; }

        [JsonProperty(PropertyName = "journalEntryId")]
        public int JournalEntryId { get; set; }

        [JsonProperty(PropertyName = "journalId")]
        public string JournalId { get; set; }

        [JsonProperty(PropertyName = "lockedFromPayment")]
        public bool LockedFromPayment { get; set; }

        [JsonProperty(PropertyName = "ocr")]
        public string Ocr { get; set; }

        [JsonProperty(PropertyName = "paid")]
        public bool Paid { get; set; }

        [JsonProperty(PropertyName = "preliminary")]
        public bool Preliminary { get; set; }

        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }

        [JsonProperty(PropertyName = "registeredByUser")]
        public string RegisteredByUser { get; set; }

        [JsonProperty(PropertyName = "supplierId")]
        public string SupplierId { get; set; }



        public PostSupplierInvoiceFixedRequestItem()
        {

            Comment = string.Empty;
            CostBearerId = string.Empty;
            CostCenterId = string.Empty;
            Currency = string.Empty;
            DocumentIds = new List<string>();
            DueDate = string.Empty;
            InvoiceDate = string.Empty;
            InvoiceNumber = string.Empty;
            JournalEntryDate = string.Empty;
            JournalId = string.Empty;
            Ocr = string.Empty;
            ProjectId = string.Empty;
            RegisteredByUser = string.Empty;
            SupplierId = string.Empty;
        }
    }

    public class PostSupplierInvoiceRequestItem : PostSupplierInvoiceFixedRequestItem
    {
       
    }
}