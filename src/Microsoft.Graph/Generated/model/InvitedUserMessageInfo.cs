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
    /// The type InvitedUserMessageInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<InvitedUserMessageInfo>))]
    public partial class InvitedUserMessageInfo
    {

        /// <summary>
        /// Gets or sets ccRecipients.
        /// Additional recipients the invitation message should be sent to. Currently only 1 additional recipient is supported.
        /// </summary>
        [JsonPropertyName("ccRecipients")]
        public IEnumerable<Recipient> CcRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets customizedMessageBody.
        /// Customized message body you want to send if you don't want the default message.
        /// </summary>
        [JsonPropertyName("customizedMessageBody")]
        public string CustomizedMessageBody { get; set; }
    
        /// <summary>
        /// Gets or sets messageLanguage.
        /// The language you want to send the default message in. If the customizedMessageBody is specified, this property is ignored, and the message is sent using the customizedMessageBody. The language format should be in ISO 639. The default is en-US.
        /// </summary>
        [JsonPropertyName("messageLanguage")]
        public string MessageLanguage { get; set; }
    
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
