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
    /// The type RubricQualityFeedbackModel.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RubricQualityFeedbackModel>))]
    public partial class RubricQualityFeedbackModel
    {

        /// <summary>
        /// Gets or sets feedback.
        /// Specific feedback for one quality of this rubric.
        /// </summary>
        [JsonPropertyName("feedback")]
        public EducationItemBody Feedback { get; set; }
    
        /// <summary>
        /// Gets or sets qualityId.
        /// The ID of the rubricQuality that this feedback is related to.
        /// </summary>
        [JsonPropertyName("qualityId")]
        public string QualityId { get; set; }
    
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
