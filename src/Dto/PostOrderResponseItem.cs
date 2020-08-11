using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlInfoApiWrapper.Dto
{
    public class PostOrderResponseItem
    {
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("costBearerId")]
        public string CostBearerId { get; set; }


        [JsonProperty("customerOrderNumber")]
        public string CustomerOrderNumber { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("lines")]
        public List<OrderResponseLine> Lines { get; set; }

        [JsonProperty(PropertyName = "deliveryBox")]
        public string DeliveryBox { get; set; }

        [JsonProperty(PropertyName = "deliveryStreet")]
        public string DeliveryStreet { get; set; }

        [JsonProperty(PropertyName = "deliveryCity")]
        public string DeliveryCity { get; set; }

        [JsonProperty(PropertyName = "deliveryZip")]
        public string DeliveryZip { get; set; }

        [JsonProperty(PropertyName = "box")]
        public string Box { get; set; }

        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        [JsonProperty(PropertyName = "id")] 
        public int Id { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("yourReference")]
        public string YourReference { get; set; }

        [JsonProperty("ourReference")]
        public string OurReference { get; set; }

        [JsonProperty("noVat")]
        public bool NoVat { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }

        public PostOrderResponseItem()
        {
            CustomerId = string.Empty;
            CustomerOrderNumber = string.Empty;
            Comment = string.Empty;
            CostBearerId = string.Empty;
            CostCenterId = string.Empty;
            DeliveryBox = string.Empty;
            Box = string.Empty;
            DeliveryCity = string.Empty;
            City = string.Empty;
            DeliveryStreet = string.Empty;
            Street = string.Empty;
            DeliveryZip = string.Empty;
            Zip = string.Empty;
            ProjectId = string.Empty;
            Name = string.Empty;
            YourReference = string.Empty;
            OurReference = string.Empty;
            Lines = new List<OrderResponseLine>();
        }
    }

    public class OrderResponseLine
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("articleId")]
        public string ArticleId { get; set; }

        [JsonProperty("deliveredQuantity")]
        public decimal DeliveredQuantity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("orderedQuantity")]
        public decimal OrderedQuantity { get; set; }

        [JsonProperty("unitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("discountPercentage")]
        public decimal DiscountPercentage { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }


        public OrderResponseLine()
        {
            ProjectId = string.Empty;
            ArticleId = string.Empty;
            Description = string.Empty;
            Unit = string.Empty;
            CostCenterId = string.Empty;
            AccountId = string.Empty;
        }
    }
}
