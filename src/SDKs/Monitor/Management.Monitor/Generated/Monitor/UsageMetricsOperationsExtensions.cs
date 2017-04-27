// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsageMetricsOperations.
    /// </summary>
    public static partial class UsageMetricsOperationsExtensions
    {
            /// <summary>
            /// The List operation lists the usage metrics for the
            /// resource.&lt;br&gt;**WARNING**: This operation will be *deprecated* in the
            /// next release.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='apiVersion'>
            /// Client Api Version. NOTE: This is not a client property, it must be
            /// explicit in the call and there is no default value.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IEnumerable<UsageMetric> List(this IUsageMetricsOperations operations, string resourceUri, string apiVersion, ODataQuery<UsageMetric> odataQuery = default(ODataQuery<UsageMetric>))
            {
                return ((IUsageMetricsOperations)operations).ListAsync(resourceUri, apiVersion, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation lists the usage metrics for the
            /// resource.&lt;br&gt;**WARNING**: This operation will be *deprecated* in the
            /// next release.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='apiVersion'>
            /// Client Api Version. NOTE: This is not a client property, it must be
            /// explicit in the call and there is no default value.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<UsageMetric>> ListAsync(this IUsageMetricsOperations operations, string resourceUri, string apiVersion, ODataQuery<UsageMetric> odataQuery = default(ODataQuery<UsageMetric>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceUri, apiVersion, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
