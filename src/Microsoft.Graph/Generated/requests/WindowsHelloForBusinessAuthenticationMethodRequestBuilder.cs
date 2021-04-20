// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WindowsHelloForBusinessAuthenticationMethodRequestBuilder.
    /// </summary>
    public partial class WindowsHelloForBusinessAuthenticationMethodRequestBuilder : AuthenticationMethodRequestBuilder, IWindowsHelloForBusinessAuthenticationMethodRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsHelloForBusinessAuthenticationMethodRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsHelloForBusinessAuthenticationMethodRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindowsHelloForBusinessAuthenticationMethodRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindowsHelloForBusinessAuthenticationMethodRequest Request(IEnumerable<Option> options)
        {
            return new WindowsHelloForBusinessAuthenticationMethodRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Device.
        /// </summary>
        /// <returns>The <see cref="IDeviceRequestBuilder"/>.</returns>
        public IDeviceRequestBuilder Device
        {
            get
            {
                return new DeviceRequestBuilder(this.AppendSegmentToRequestUrl("device"), this.Client);
            }
        }
    
    }
}