// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsWorkDayRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsWorkDayRequestBody
    {
    
        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [JsonPropertyName("startDate")]
        public System.Text.Json.JsonDocument StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets Days.
        /// </summary>
        [JsonPropertyName("days")]
        public System.Text.Json.JsonDocument Days { get; set; }
    
        /// <summary>
        /// Gets or sets Holidays.
        /// </summary>
        [JsonPropertyName("holidays")]
        public System.Text.Json.JsonDocument Holidays { get; set; }
    
    }
}
