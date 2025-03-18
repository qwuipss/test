// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Json;
using Moira.ApiClient.Config;
using Moira.ApiClient.Contact;
using Moira.ApiClient.Event;
using Moira.ApiClient.Health;
using Moira.ApiClient.Notification;
using Moira.ApiClient.Pattern;
using Moira.ApiClient.Subscription;
using Moira.ApiClient.Tag;
using Moira.ApiClient.Teams;
using Moira.ApiClient.Trigger;
using Moira.ApiClient.User;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Moira.ApiClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MoiraApiClient : BaseRequestBuilder
    {
        /// <summary>The config property</summary>
        public global::Moira.ApiClient.Config.ConfigRequestBuilder Config
        {
            get => new global::Moira.ApiClient.Config.ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contact property</summary>
        public global::Moira.ApiClient.Contact.ContactRequestBuilder Contact
        {
            get => new global::Moira.ApiClient.Contact.ContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The event property</summary>
        public global::Moira.ApiClient.Event.EventRequestBuilder Event
        {
            get => new global::Moira.ApiClient.Event.EventRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The health property</summary>
        public global::Moira.ApiClient.Health.HealthRequestBuilder Health
        {
            get => new global::Moira.ApiClient.Health.HealthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notification property</summary>
        public global::Moira.ApiClient.Notification.NotificationRequestBuilder Notification
        {
            get => new global::Moira.ApiClient.Notification.NotificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pattern property</summary>
        public global::Moira.ApiClient.Pattern.PatternRequestBuilder Pattern
        {
            get => new global::Moira.ApiClient.Pattern.PatternRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscription property</summary>
        public global::Moira.ApiClient.Subscription.SubscriptionRequestBuilder Subscription
        {
            get => new global::Moira.ApiClient.Subscription.SubscriptionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tag property</summary>
        public global::Moira.ApiClient.Tag.TagRequestBuilder Tag
        {
            get => new global::Moira.ApiClient.Tag.TagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public global::Moira.ApiClient.Teams.TeamsRequestBuilder Teams
        {
            get => new global::Moira.ApiClient.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The trigger property</summary>
        public global::Moira.ApiClient.Trigger.TriggerRequestBuilder Trigger
        {
            get => new global::Moira.ApiClient.Trigger.TriggerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public global::Moira.ApiClient.User.UserRequestBuilder User
        {
            get => new global::Moira.ApiClient.User.UserRequestBuilder(PathParameters, RequestAdapter);
        } 
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.MoiraApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MoiraApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "file:///api";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
#pragma warning restore CS0618
