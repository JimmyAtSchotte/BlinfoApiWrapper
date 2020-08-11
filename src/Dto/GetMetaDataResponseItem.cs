using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetMetaDataResponseItem<T>
    {

        [JsonProperty(PropertyName = "data")]
        public T[] Data { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        public string EndDate { get; set; }

        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }

        [JsonProperty(PropertyName = "pageRequested")]
        public int PageRequested { get; set; }

        [JsonProperty(PropertyName = "rowsRequested")]
        public int RowsRequested { get; set; }

        [JsonProperty(PropertyName = "rowsReturned")]
        public int RowsReturned { get; set; }

        [JsonProperty(PropertyName = "totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty(PropertyName = "totalRows")]
        public int TotalRows { get; set; }

        [JsonProperty(PropertyName = "startDate")]
        public string StartDate { get; set; }

    }
}
