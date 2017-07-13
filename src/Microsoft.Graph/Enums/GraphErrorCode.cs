// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    /// <summary>
    /// Error codes to expect from OneDrive
    /// https://dev.onedrive.com/misc/errors.htm
    /// </summary>
    public enum GraphErrorCode
    {
        /// <summary>
        /// The caller doesn't have permission to perform the action.
        /// </summary>
        AccessDenied,
        /// <summary>
        /// The app or user has been throttled
        /// </summary>
        ActivityLimitReached,
        /// <summary>
        /// Access restricted to the item's owner
        /// </summary>
        AccessRestricted,
        /// <summary>
        /// The authentication request has been cancelled
        /// </summary>
        AuthenticationCancelled,
        /// <summary>
        /// The authentication request failed
        /// </summary>
        AuthenticationFailure,
        /// <summary>
        /// Failed to get a consistent delta snapshot. Try again later
        /// </summary>
        CannotSnapshotTree,
        /// <summary>
        /// Max limit on the number of child items was reached
        /// </summary>
        ChildItemCountExceeded,
        /// <summary>
        /// ETag does not match the current item's value
        /// </summary>
        EntityTagDoesNotMatch,
        /// <summary>
        /// Declared total size for this fragment is different from that of the upload session
        /// </summary>
        FragmentLengthMismatch,
        /// <summary>
        /// Uploaded fragment is out of order
        /// </summary>
        FragmentOutOfOrder,
        /// <summary>
        /// Uploaded fragment overlaps with existing data
        /// </summary>
        FragmentOverlap,
        /// <summary>
        /// An unspecified error has occurred
        /// </summary>
        GeneralException,
        /// <summary>
        /// Invalid accept type
        /// </summary>
        InvalidAcceptType,
        /// <summary>
        /// Invalid parameter format
        /// </summary>
        InvalidParameterFormat,
        /// <summary>
        /// Name contains invalid characters
        /// </summary>
        InvalidPath,
        /// <summary>
        /// Invalid query option
        /// </summary>
        InvalidQueryOption,
        /// <summary>
        /// The specified byte range is invalid or unavailable
        /// </summary>
        InvalidRange,
        /// <summary>
        /// The request is malformed or incorrect
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// Invalid start index
        /// </summary>
        InvalidStartIndex,
        /// <summary>
        /// The resource could not be found.
        /// </summary>
        ItemNotFound,
        /// <summary>
        /// Lock token does not match existing lock
        /// </summary>
        LockMismatch,
        /// <summary>
        /// There is currently no unexpired lock on the item
        /// </summary>
        LockNotFoundOrAlreadyExpired,
        /// <summary>
        /// Lock Owner ID does not match provided ID
        /// </summary>
        LockOwnerMismatch,
        /// <summary>
        /// ETag header is malformed. ETags must be quoted strings
        /// </summary>
        MalformedEntityTag,
        /// <summary>
        /// Malware was detected in the requested resource
        /// </summary>
        MalwareDetected,
        /// <summary>
        /// Max limit on number of Documents is reached
        /// </summary>
        MaxDocumentCountExceeded,
        /// <summary>
        /// Max file size exceeded
        /// </summary>
        MaxFileSizeExceeded,
        /// <summary>
        /// Max limit on number of Folders is reached
        /// </summary>
        MaxFolderCountExceeded,
        /// <summary>
        /// Max file size exceeded
        /// </summary>
        MaxFragmentLengthExceeded,
        /// <summary>
        /// Max limit on number of Items is reached
        /// </summary>
        MaxItemCountExceeded,
        /// <summary>
        /// Max query length exceeded
        /// </summary>
        MaxQueryLengthExceeded,
        /// <summary>
        /// Maximum stream size exceeded
        /// </summary>
        MaxStreamSizeExceeded,
        /// <summary>
        /// The specified item name already exists
        /// </summary>
        NameAlreadyExists,
        /// <summary>
        /// The action is not allowed by the system
        /// </summary>
        NotAllowed,
        /// <summary>
        /// The request is not supported by the system
        /// </summary>
        NotSupported,
        /// <summary>
        /// Parameter Exceeds Maximum Length
        /// </summary>
        ParameterIsTooLong,
        /// <summary>
        /// Parameter is smaller then minimum value
        /// </summary>
        ParameterIsTooSmall,
        /// <summary>
        /// Path exceeds maximum length
        /// </summary>
        PathIsTooLong,
        /// <summary>
        /// Folder hierarchy depth limit reached
        /// </summary>
        PathTooDeep,
        /// <summary>
        /// Property not updateable
        /// </summary>
        PropertyNotUpdateable,
        /// <summary>
        /// The resource being updated has changed since the caller last read it, 
        /// usually an eTag mismatch
        /// </summary>
        ResourceModified,
        /// <summary>
        /// Resync required. Replace any local items with the server's version (including deletes) 
        /// if you're sure that the service was up to date with your local changes when you last sync'd. 
        /// Upload any local changes that the server doesn't know about.
        /// </summary>
        ResyncApplyDifferences,
        /// <summary>
        /// Resync is required
        /// </summary>
        ResyncRequired,
        /// <summary>
        /// Resync required. Upload any local items that the service did not return, 
        /// and upload any files that differ from the server's version 
        /// (keeping both copies if you're not sure which one is more up-to-date).
        /// </summary>
        ResyncUploadDifferences,
        /// <summary>
        /// The server is unable to process the current request
        /// </summary>
        ServiceNotAvailable,
        /// <summary>
        /// Resource is temporarily read-only
        /// </summary>
        ServiceReadOnly,
        /// <summary>
        /// Too many requests
        /// </summary>
        ThrottledRequest,
        /// <summary>
        /// The request timed out
        /// </summary>
        Timeout,
        /// <summary>
        /// Too many redirects
        /// </summary>
        TooManyRedirects,
        /// <summary>
        /// Too many results requested
        /// </summary>
        TooManyResultsRequested,
        /// <summary>
        /// Too many terms in the query
        /// </summary>
        TooManyTermsInQuery,
        /// <summary>
        /// Operation is not allowed because the number of affected items exceeds threshold
        /// </summary>
        TotalAffectedItemCountExceeded,
        /// <summary>
        /// Data truncation is not allowed
        /// </summary>
        TruncationNotAllowed,
        /// <summary>
        /// The user has reached their quota limit
        /// </summary>
        QuotaLimitReached,
        /// <summary>
        /// The caller is not authenticated
        /// </summary>
        Unauthenticated,
        /// <summary>
        /// Upload session failed
        /// </summary>
        UploadSessionFailed,
        /// <summary>
        /// Upload session incomplete
        /// </summary>
        UploadSessionIncomplete,
        /// <summary>
        /// Upload session not found
        /// </summary>
        UploadSessionNotFound,
        /// <summary>
        /// This document is suspicious and may have a virus
        /// </summary>
        VirusSuspicious,
        /// <summary>
        /// Zero or fewer results requested
        /// </summary>
        ZeroOrFewerResultsRequested,
    }
}
