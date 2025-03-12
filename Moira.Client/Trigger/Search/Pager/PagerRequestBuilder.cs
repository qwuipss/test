// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Moira.Client.Models.Api;
using Moira.Client.Models.Dto;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Moira.Client.Trigger.Search.Pager
{
    /// <summary>
    /// Builds and executes requests for operations under \trigger\search\pager
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PagerRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PagerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/trigger/search/pager{?pagerID*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PagerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/trigger/search/pager{?pagerID*}", rawUrl)
        {
        }
        /// <summary>
        /// Delete triggers pager
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Models.Dto.TriggersSearchResultDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.Client.Models.Api.ErrorNotFoundExample">When receiving a 404 status code</exception>
        /// <exception cref="global::Moira.Client.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.Client.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.Client.Models.Dto.TriggersSearchResultDeleteResponse?> DeleteAsync(Action<RequestConfiguration<global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder.PagerRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.Client.Models.Dto.TriggersSearchResultDeleteResponse> DeleteAsync(Action<RequestConfiguration<global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder.PagerRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Moira.Client.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.Client.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.Client.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.Client.Models.Dto.TriggersSearchResultDeleteResponse>(requestInfo, global::Moira.Client.Models.Dto.TriggersSearchResultDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete triggers pager
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder.PagerRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder.PagerRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Moira.Client.Trigger.Search.Pager.PagerRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Delete triggers pager
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PagerRequestBuilderDeleteQueryParameters 
        {
            /// <summary>Pager ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("pagerID")]
            public string? PagerID { get; set; }
#nullable restore
#else
            [QueryParameter("pagerID")]
            public string PagerID { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
