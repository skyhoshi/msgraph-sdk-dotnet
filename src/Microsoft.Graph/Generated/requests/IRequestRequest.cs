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
    /// The interface IRequestRequest.
    /// </summary>
    public partial interface IRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RequestObject using POST.
        /// </summary>
        /// <param name="requestObjectToCreate">The RequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RequestObject.</returns>
        System.Threading.Tasks.Task<RequestObject> CreateAsync(RequestObject requestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified RequestObject using POST and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="requestObjectToCreate">The RequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RequestObject>> CreateResponseAsync(RequestObject requestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RequestObject.</returns>
        System.Threading.Tasks.Task<RequestObject> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RequestObject and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RequestObject>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RequestObject using PATCH.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RequestObject.</returns>
        System.Threading.Tasks.Task<RequestObject> UpdateAsync(RequestObject requestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RequestObject using PATCH and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RequestObject>> UpdateResponseAsync(RequestObject requestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RequestObject using PUT.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<RequestObject> PutAsync(RequestObject requestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RequestObject using PUT and returns a <see cref="GraphResponse{RequestObject}"/> object.
        /// </summary>
        /// <param name="requestObjectToUpdate">The RequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{RequestObject}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<RequestObject>> PutResponseAsync(RequestObject requestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRequestRequest Expand(Expression<Func<RequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRequestRequest Select(Expression<Func<RequestObject, object>> selectExpression);

    }
}
