﻿// Copyright (c) Lykke Corp.
// See the LICENSE file in the project root for more information.

namespace Ironclad.Client
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Exposes the public members of the Ironclad client.
    /// </summary>
    public interface IIroncladClient
    {
        /// <summary>
        /// Gets the client summaries (or a subset thereof).
        /// </summary>
        /// <param name="start">The zero-based start ordinal of the client set to return.</param>
        /// <param name="size">The total size of the client set.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The client summaries.</returns>
        Task<ResourceSet<ClientSummary>> GetClientSummariesAsync(int start = default, int size = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The client.</returns>
        Task<Client> GetClientAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Registers the specified client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        Task RegisterClientAsync(Client client, CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task.</returns>
        Task ModifyClientAsync(Client client, CancellationToken cancellationToken = default);

        /*
        // delete
        Task UnregisterClientAsync(string clientId, CancellationToken cancellationToken = default);
        */
    }
}
