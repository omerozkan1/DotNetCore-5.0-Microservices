﻿namespace FreeCourse.Web.Models
{
    public class ServiceApiSetting
    {
        public string IdentityBaseUri { get; set; }
        public string GatewayBaseUri { get; set; }
        public string PhotoStockUri { get; set; }
        public ServiceApi Catalog { get; set; }
        public ServiceApi PhotoStock { get; set; }
        public ServiceApi Basket { get; set; }
        public ServiceApi Discount { get; set; }
        public ServiceApi Payment { get; set; }
        public ServiceApi Order { get; set; }
    }
}
