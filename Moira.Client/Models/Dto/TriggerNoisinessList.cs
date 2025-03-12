// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Moira.Client.Models.Dto
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TriggerNoisinessList : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of entities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Moira.Client.Models.Dto.TriggerNoisiness>? List { get; set; }
#nullable restore
#else
        public List<global::Moira.Client.Models.Dto.TriggerNoisiness> List { get; set; }
#endif
        /// <summary>Page number.</summary>
        public long? Page { get; set; }
        /// <summary>Size is the amount of entities per Page.</summary>
        public long? Size { get; set; }
        /// <summary>Total amount of entities in the database.</summary>
        public long? Total { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Models.Dto.TriggerNoisinessList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.Client.Models.Dto.TriggerNoisinessList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.Client.Models.Dto.TriggerNoisinessList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "list", n => { List = n.GetCollectionOfObjectValues<global::Moira.Client.Models.Dto.TriggerNoisiness>(global::Moira.Client.Models.Dto.TriggerNoisiness.CreateFromDiscriminatorValue)?.AsList(); } },
                { "page", n => { Page = n.GetLongValue(); } },
                { "size", n => { Size = n.GetLongValue(); } },
                { "total", n => { Total = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Moira.Client.Models.Dto.TriggerNoisiness>("list", List);
            writer.WriteLongValue("page", Page);
            writer.WriteLongValue("size", Size);
            writer.WriteLongValue("total", Total);
        }
    }
}
#pragma warning restore CS0618
