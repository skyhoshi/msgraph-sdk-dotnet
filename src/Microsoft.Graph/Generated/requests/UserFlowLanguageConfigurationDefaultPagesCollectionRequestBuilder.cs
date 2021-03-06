// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder.
    /// </summary>
    public partial class UserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder : BaseRequestBuilder, IUserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserFlowLanguageConfigurationDefaultPagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserFlowLanguageConfigurationDefaultPagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserFlowLanguageConfigurationDefaultPagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserFlowLanguagePageRequestBuilder"/> for the specified UserFlowLanguageConfigurationUserFlowLanguagePage.
        /// </summary>
        /// <param name="id">The ID for the UserFlowLanguageConfigurationUserFlowLanguagePage.</param>
        /// <returns>The <see cref="IUserFlowLanguagePageRequestBuilder"/>.</returns>
        public IUserFlowLanguagePageRequestBuilder this[string id]
        {
            get
            {
                return new UserFlowLanguagePageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
