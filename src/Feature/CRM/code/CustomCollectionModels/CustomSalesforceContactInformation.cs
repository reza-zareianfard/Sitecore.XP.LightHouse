﻿using Sitecore.XConnect;
using System;

namespace Sitecore.Demo.Platform.Feature.CRM.CustomCollectionModels
{
    [FacetKey("CustomSalesforceContact")]
    [Serializable]
    public class CustomSalesforceContactInformation : Facet
    {
        public const string DefaultFacetKey = "CustomSalesforceContact";
        public string MemberTier { get; set; }
    }
}
