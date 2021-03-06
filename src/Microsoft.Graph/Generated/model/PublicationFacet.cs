// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PublicationFacet.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PublicationFacet>))]
    public partial class PublicationFacet
    {

        /// <summary>
        /// Gets or sets level.
        /// The state of publication for this document. Either published or checkout. Read-only.
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }
    
        /// <summary>
        /// Gets or sets versionId.
        /// The unique identifier for the version that is visible to the current caller. Read-only.
        /// </summary>
        [JsonPropertyName("versionId")]
        public string VersionId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
