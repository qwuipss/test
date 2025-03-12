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
    public partial class ScheduleData : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The days property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Moira.Client.Models.Moira.ScheduleDataDay>? Days { get; set; }
#nullable restore
#else
        public List<global::Moira.Client.Models.Moira.ScheduleDataDay> Days { get; set; }
#endif
        /// <summary>The endOffset property</summary>
        public long? EndOffset { get; set; }
        /// <summary>The startOffset property</summary>
        public long? StartOffset { get; set; }
        /// <summary>The tzOffset property</summary>
        public long? TzOffset { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Models.Moira.ScheduleData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.Client.Models.Moira.ScheduleData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.Client.Models.Moira.ScheduleData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "days", n => { Days = n.GetCollectionOfObjectValues<global::Moira.Client.Models.Moira.ScheduleDataDay>(global::Moira.Client.Models.Moira.ScheduleDataDay.CreateFromDiscriminatorValue)?.AsList(); } },
                { "endOffset", n => { EndOffset = n.GetLongValue(); } },
                { "startOffset", n => { StartOffset = n.GetLongValue(); } },
                { "tzOffset", n => { TzOffset = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Moira.Client.Models.Moira.ScheduleDataDay>("days", Days);
            writer.WriteLongValue("endOffset", EndOffset);
            writer.WriteLongValue("startOffset", StartOffset);
            writer.WriteLongValue("tzOffset", TzOffset);
        }
    }
}
#pragma warning restore CS0618
