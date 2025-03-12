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
namespace Moira.Client.Event.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \event\{triggerID}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithTriggerItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTriggerItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/event/{triggerID}{?from*,metric*,p*,size*,states*,to*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTriggerItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/event/{triggerID}{?from*,metric*,p*,size*,states*,to*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets all trigger events for current page and their count
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Models.Dto.EventsList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.Client.Models.Api.ErrorInvalidRequestExample">When receiving a 400 status code</exception>
        /// <exception cref="global::Moira.Client.Models.Api.ErrorNotFoundExample">When receiving a 404 status code</exception>
        /// <exception cref="global::Moira.Client.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.Client.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.Client.Models.Dto.EventsList?> GetAsync(Action<RequestConfiguration<global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.Client.Models.Dto.EventsList> GetAsync(Action<RequestConfiguration<global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Moira.Client.Models.Api.ErrorInvalidRequestExample.CreateFromDiscriminatorValue },
                { "404", global::Moira.Client.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.Client.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.Client.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.Client.Models.Dto.EventsList>(requestInfo, global::Moira.Client.Models.Dto.EventsList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all trigger events for current page and their count
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Moira.Client.Event.Item.WithTriggerItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets all trigger events for current page and their count
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithTriggerItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Start time of the time range</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("from")]
            public string? From { get; set; }
#nullable restore
#else
            [QueryParameter("from")]
            public string From { get; set; }
#endif
            /// <summary>Regular expression that will be used to filter events</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("metric")]
            public string? Metric { get; set; }
#nullable restore
#else
            [QueryParameter("metric")]
            public string Metric { get; set; }
#endif
            /// <summary>Defines the number of the displayed page. E.g, p=2 would display the 2nd page</summary>
            [QueryParameter("p")]
            public int? P { get; set; }
            /// <summary>Number of items to be displayed on one page. if size = -1 then all events returned</summary>
            [QueryParameter("size")]
            public int? Size { get; set; }
            /// <summary>String of &apos;,&apos; separated state names. If empty then all states will be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("states")]
            public string[]? States { get; set; }
#nullable restore
#else
            [QueryParameter("states")]
            public string[] States { get; set; }
#endif
            /// <summary>End time of the time range</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("to")]
            public string? To { get; set; }
#nullable restore
#else
            [QueryParameter("to")]
            public string To { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
