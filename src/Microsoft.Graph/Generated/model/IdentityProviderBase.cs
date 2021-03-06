// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Identity Provider Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IdentityProviderBase>))]
    public partial class IdentityProviderBase : Entity
    {
    
        ///<summary>
        /// The internal IdentityProviderBase constructor
        ///</summary>
        protected internal IdentityProviderBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the identity provider.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
    }
}

