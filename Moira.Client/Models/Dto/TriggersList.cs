// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Moira.Client.Models.Moira;
using System.Collections.Generic;
using System.IO;
using System;
namespace Moira.Client.Models.Dto
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TriggersList : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Moira.Client.Models.Moira.TriggerCheck>? List { get; set; }
#nullable restore
#else
        public List<global::Moira.Client.Models.Moira.TriggerCheck> List { get; set; }
#endif
        /// <summary>The page property</summary>
        public long? Page { get; set; }
        /// <summary>The pager property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pager { get; set; }
#nullable restore
#else
        public string Pager { get; set; }
#endif
        /// <summary>The size property</summary>
        public long? Size { get; set; }
        /// <summary>The total property</summary>
        public long? Total { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Models.Dto.TriggersList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.Client.Models.Dto.TriggersList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.Client.Models.Dto.TriggersList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "list", n => { List = n.GetCollectionOfObjectValues<global::Moira.Client.Models.Moira.TriggerCheck>(global::Moira.Client.Models.Moira.TriggerCheck.CreateFromDiscriminatorValue)?.AsList(); } },
                { "page", n => { Page = n.GetLongValue(); } },
                { "pager", n => { Pager = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Moira.Client.Models.Moira.TriggerCheck>("list", List);
            writer.WriteLongValue("page", Page);
            writer.WriteStringValue("pager", Pager);
            writer.WriteLongValue("size", Size);
            writer.WriteLongValue("total", Total);
        }
    }
}
#pragma warning restore CS0618
