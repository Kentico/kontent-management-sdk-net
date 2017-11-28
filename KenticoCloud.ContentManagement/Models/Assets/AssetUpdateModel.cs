﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace KenticoCloud.ContentManagement.Models.Assets
{
    public class AssetUpdateModel
    {
        [JsonProperty("descriptions", Required = Required.Always)]
        public IEnumerable<AssetDescriptionsModel> Descriptions { get; set; }
    }
}