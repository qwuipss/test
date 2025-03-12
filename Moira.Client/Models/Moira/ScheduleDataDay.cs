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
    public partial class ScheduleDataDay : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The name property</summary>
        public global::Moira.Client.Models.Moira.ScheduleDataDay_name? Name { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.Client.Models.Moira.ScheduleDataDay"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.Client.Models.Moira.ScheduleDataDay CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.Client.Models.Moira.ScheduleDataDay();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetEnumValue<global::Moira.Client.Models.Moira.ScheduleDataDay_name>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<global::Moira.Client.Models.Moira.ScheduleDataDay_name>("name", Name);
        }
    }
}
#pragma warning restore CS0618
