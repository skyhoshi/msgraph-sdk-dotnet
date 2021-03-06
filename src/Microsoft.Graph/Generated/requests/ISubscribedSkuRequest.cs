// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISubscribedSkuRequest.
    /// </summary>
    public partial interface ISubscribedSkuRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SubscribedSku using POST.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> CreateAsync(SubscribedSku subscribedSkuToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SubscribedSku using POST and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SubscribedSku}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> CreateResponseAsync(SubscribedSku subscribedSkuToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SubscribedSku.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SubscribedSku and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SubscribedSku.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SubscribedSku and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SubscribedSku}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> UpdateAsync(SubscribedSku subscribedSkuToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SubscribedSku}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> UpdateResponseAsync(SubscribedSku subscribedSkuToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubscribedSku using PUT.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SubscribedSku> PutAsync(SubscribedSku subscribedSkuToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SubscribedSku using PUT and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SubscribedSku}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> PutResponseAsync(SubscribedSku subscribedSkuToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Expand(Expression<Func<SubscribedSku, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Select(Expression<Func<SubscribedSku, object>> selectExpression);

    }
}
