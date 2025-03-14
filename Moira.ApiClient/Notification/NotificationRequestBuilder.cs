// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Moira.ApiClient.Models.Api;
using Moira.ApiClient.Models.Dto;
using Moira.ApiClient.Notification.All;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Moira.ApiClient.Notification
{
    /// <summary>
    /// Builds and executes requests for operations under \notification
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class NotificationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The all property</summary>
        public global::Moira.ApiClient.Notification.All.AllRequestBuilder All
        {
            get => new global::Moira.ApiClient.Notification.All.AllRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Notification.NotificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NotificationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notification?id={id}{&end*,start*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Notification.NotificationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NotificationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notification?id={id}{&end*,start*}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a notification by id
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.NotificationDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample">When receiving a 400 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorForbiddenExample">When receiving a 403 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.ApiClient.Models.Dto.NotificationDeleteResponse?> DeleteAsNotificationDeleteResponseAsync(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.ApiClient.Models.Dto.NotificationDeleteResponse> DeleteAsNotificationDeleteResponseAsync(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample.CreateFromDiscriminatorValue },
                { "403", global::Moira.ApiClient.Models.Api.ErrorForbiddenExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.ApiClient.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.ApiClient.Models.Dto.NotificationDeleteResponse>(requestInfo, global::Moira.ApiClient.Models.Dto.NotificationDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a notification by id
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.NotificationResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample">When receiving a 400 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorForbiddenExample">When receiving a 403 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use DeleteAsNotificationDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.ApiClient.Models.Dto.NotificationResponse?> DeleteAsync(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.ApiClient.Models.Dto.NotificationResponse> DeleteAsync(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample.CreateFromDiscriminatorValue },
                { "403", global::Moira.ApiClient.Models.Api.ErrorForbiddenExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.ApiClient.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.ApiClient.Models.Dto.NotificationResponse>(requestInfo, global::Moira.ApiClient.Models.Dto.NotificationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a paginated list of notifications, all notifications are fetched if end = -1 and start = 0
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.NotificationsList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample">When receiving a 400 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.ApiClient.Models.Dto.NotificationsList?> GetAsync(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.ApiClient.Models.Dto.NotificationsList> GetAsync(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.ApiClient.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.ApiClient.Models.Dto.NotificationsList>(requestInfo, global::Moira.ApiClient.Models.Dto.NotificationsList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a notification by id
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/notification?id={id}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Gets a paginated list of notifications, all notifications are fetched if end = -1 and start = 0
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, "{+baseurl}/notification{?end*,start*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Notification.NotificationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Moira.ApiClient.Notification.NotificationRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Moira.ApiClient.Notification.NotificationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Delete a notification by id
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class NotificationRequestBuilderDeleteQueryParameters 
        {
            /// <summary>The ID of deleted notification</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("id")]
            public string? Id { get; set; }
#nullable restore
#else
            [QueryParameter("id")]
            public string Id { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class NotificationRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// Gets a paginated list of notifications, all notifications are fetched if end = -1 and start = 0
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class NotificationRequestBuilderGetQueryParameters 
        {
            /// <summary>Default Value: -1</summary>
            [QueryParameter("end")]
            public int? End { get; set; }
            /// <summary>Default Value: 0</summary>
            [QueryParameter("start")]
            public int? Start { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class NotificationRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Moira.ApiClient.Notification.NotificationRequestBuilder.NotificationRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
