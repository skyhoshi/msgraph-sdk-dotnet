// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    /// <summary>
    /// Constants for navigating file and mail systems
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Url constants
        /// </summary>
        public static class Url
        {
            /// <summary>
            /// The application's personal folder
            /// </summary>
            public const string AppRoot = "approot";

            /// <summary>
            /// The deleted items folder
            /// </summary>
            public const string DeletedItems = "DeletedItems";

            /// <summary>
            /// The drafts folder
            /// </summary>
            public const string Drafts = "Drafts";

            /// <summary>
            /// The base URL to call Graph
            /// </summary>
            public const string GraphBaseUrlFormatString = "https://graph.microsoft.com/{0}";

            /// <summary>
            /// The inbox folder
            /// </summary>
            public const string Inbox = "Inbox";

            /// <summary>
            /// The sent items folder
            /// </summary>
            public const string SentItems = "SentItems";
        }
    }
}
