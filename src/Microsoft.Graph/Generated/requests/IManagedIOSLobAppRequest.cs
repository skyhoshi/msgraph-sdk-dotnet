// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedIOSLobAppRequest.
    /// </summary>
    public partial interface IManagedIOSLobAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedIOSLobApp using POST.
        /// </summary>
        /// <param name="managedIOSLobAppToCreate">The ManagedIOSLobApp to create.</param>
        /// <returns>The created ManagedIOSLobApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSLobApp> CreateAsync(ManagedIOSLobApp managedIOSLobAppToCreate);        /// <summary>
        /// Creates the specified ManagedIOSLobApp using POST.
        /// </summary>
        /// <param name="managedIOSLobAppToCreate">The ManagedIOSLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedIOSLobApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSLobApp> CreateAsync(ManagedIOSLobApp managedIOSLobAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedIOSLobApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedIOSLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedIOSLobApp.
        /// </summary>
        /// <returns>The ManagedIOSLobApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSLobApp> GetAsync();

        /// <summary>
        /// Gets the specified ManagedIOSLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedIOSLobApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSLobApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedIOSLobApp using PATCH.
        /// </summary>
        /// <param name="managedIOSLobAppToUpdate">The ManagedIOSLobApp to update.</param>
        /// <returns>The updated ManagedIOSLobApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSLobApp> UpdateAsync(ManagedIOSLobApp managedIOSLobAppToUpdate);

        /// <summary>
        /// Updates the specified ManagedIOSLobApp using PATCH.
        /// </summary>
        /// <param name="managedIOSLobAppToUpdate">The ManagedIOSLobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedIOSLobApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSLobApp> UpdateAsync(ManagedIOSLobApp managedIOSLobAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSLobAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSLobAppRequest Expand(Expression<Func<ManagedIOSLobApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSLobAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSLobAppRequest Select(Expression<Func<ManagedIOSLobApp, object>> selectExpression);

    }
}