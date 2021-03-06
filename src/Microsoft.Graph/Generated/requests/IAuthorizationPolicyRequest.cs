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
    /// The interface IAuthorizationPolicyRequest.
    /// </summary>
    public partial interface IAuthorizationPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuthorizationPolicy using POST.
        /// </summary>
        /// <param name="authorizationPolicyToCreate">The AuthorizationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthorizationPolicy.</returns>
        System.Threading.Tasks.Task<AuthorizationPolicy> CreateAsync(AuthorizationPolicy authorizationPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AuthorizationPolicy using POST and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="authorizationPolicyToCreate">The AuthorizationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthorizationPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> CreateResponseAsync(AuthorizationPolicy authorizationPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AuthorizationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AuthorizationPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AuthorizationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthorizationPolicy.</returns>
        System.Threading.Tasks.Task<AuthorizationPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AuthorizationPolicy and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthorizationPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PATCH.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthorizationPolicy.</returns>
        System.Threading.Tasks.Task<AuthorizationPolicy> UpdateAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PATCH and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuthorizationPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> UpdateResponseAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PUT.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AuthorizationPolicy> PutAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PUT and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AuthorizationPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> PutResponseAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthorizationPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthorizationPolicyRequest Expand(Expression<Func<AuthorizationPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthorizationPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthorizationPolicyRequest Select(Expression<Func<AuthorizationPolicy, object>> selectExpression);

    }
}
