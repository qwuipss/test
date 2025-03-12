// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Moira.Client.Models.Moira
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Trigger : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alone_metrics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.Client.Models.Moira.Trigger_alone_metrics? AloneMetrics { get; set; }
#nullable restore
#else
        public global::Moira.Client.Models.Moira.Trigger_alone_metrics AloneMetrics { get; set; }
#endif
        /// <summary>The cluster_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClusterId { get; set; }
#nullable restore
#else
        public string ClusterId { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The desc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Desc { get; set; }
#nullable restore
#else
        public string Desc { get; set; }
#endif
        /// <summary>The error_value property</summary>
        public double? ErrorValue { get; set; }
        /// <summary>The expression property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expression { get; set; }
#nullable restore
#else
        public string Expression { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The mute_new_metrics property</summary>
        public bool? MuteNewMetrics { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The patterns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Patterns { get; set; }
#nullable restore
#else
        public List<string> Patterns { get; set; }
#endif
        /// <summary>The python_expression property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PythonExpression { get; set; }
#nullable restore
#else
        public string PythonExpression { get; set; }
#endif
        /// <summary>The sched property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.Client.Models.Moira.ScheduleData? Sched { get; set; }
#nullable restore
#else
        public global::Moira.Client.Models.Moira.ScheduleData Sched { get; set; }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The targets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Targets { get; set; }
#nullable restore
#else
        public List<string> Targets { get; set; }
#endif
        /// <summary>The trigger_source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TriggerSource { get; set; }
#nullable restore
#else
        public string TriggerSource { get; set; }
#endif
        /// <summary>The trigger_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TriggerType { get; set; }
#nullable restore
#else
        public string TriggerType { get; set; }
#endif
        /// <summary>The ttl property</summary>
        public long? Ttl { get; set; }
        /// <summary>The ttl_state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TtlState { get; set; }
#nullable restore
#else
        public string TtlState { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>The updated_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedBy { get; set; }
#nullable restore
#else
        public string UpdatedBy { get; set; }
#endif
        /// <summary>The warn_value property</summary>
        public double? WarnValue { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Models.Moira.Trigger"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.Client.Models.Moira.Trigger CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.Client.Models.Moira.Trigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alone_metrics", n => { AloneMetrics = n.GetObjectValue<global::Moira.Client.Models.Moira.Trigger_alone_metrics>(global::Moira.Client.Models.Moira.Trigger_alone_metrics.CreateFromDiscriminatorValue); } },
                { "cluster_id", n => { ClusterId = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "created_by", n => { CreatedBy = n.GetStringValue(); } },
                { "desc", n => { Desc = n.GetStringValue(); } },
                { "error_value", n => { ErrorValue = n.GetDoubleValue(); } },
                { "expression", n => { Expression = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "mute_new_metrics", n => { MuteNewMetrics = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "patterns", n => { Patterns = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "python_expression", n => { PythonExpression = n.GetStringValue(); } },
                { "sched", n => { Sched = n.GetObjectValue<global::Moira.Client.Models.Moira.ScheduleData>(global::Moira.Client.Models.Moira.ScheduleData.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "targets", n => { Targets = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "trigger_source", n => { TriggerSource = n.GetStringValue(); } },
                { "trigger_type", n => { TriggerType = n.GetStringValue(); } },
                { "ttl", n => { Ttl = n.GetLongValue(); } },
                { "ttl_state", n => { TtlState = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetLongValue(); } },
                { "updated_by", n => { UpdatedBy = n.GetStringValue(); } },
                { "warn_value", n => { WarnValue = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Moira.Client.Models.Moira.Trigger_alone_metrics>("alone_metrics", AloneMetrics);
            writer.WriteStringValue("cluster_id", ClusterId);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteStringValue("created_by", CreatedBy);
            writer.WriteStringValue("desc", Desc);
            writer.WriteDoubleValue("error_value", ErrorValue);
            writer.WriteStringValue("expression", Expression);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("mute_new_metrics", MuteNewMetrics);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("patterns", Patterns);
            writer.WriteStringValue("python_expression", PythonExpression);
            writer.WriteObjectValue<global::Moira.Client.Models.Moira.ScheduleData>("sched", Sched);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteCollectionOfPrimitiveValues<string>("targets", Targets);
            writer.WriteStringValue("trigger_source", TriggerSource);
            writer.WriteStringValue("trigger_type", TriggerType);
            writer.WriteLongValue("ttl", Ttl);
            writer.WriteStringValue("ttl_state", TtlState);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteStringValue("updated_by", UpdatedBy);
            writer.WriteDoubleValue("warn_value", WarnValue);
        }
    }
}
#pragma warning restore CS0618
