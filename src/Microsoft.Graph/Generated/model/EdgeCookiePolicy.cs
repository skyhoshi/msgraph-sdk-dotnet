// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum EdgeCookiePolicy.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EdgeCookiePolicy
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Allow
        /// </summary>
        Allow = 1,
	
        /// <summary>
        /// Block Third Party
        /// </summary>
        BlockThirdParty = 2,
	
        /// <summary>
        /// Block All
        /// </summary>
        BlockAll = 3,
	
    }
}