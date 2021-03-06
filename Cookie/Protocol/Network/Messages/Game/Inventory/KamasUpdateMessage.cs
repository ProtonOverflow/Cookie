//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class KamasUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5537;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_kamasTotal;
        
        public virtual ulong KamasTotal
        {
            get
            {
                return m_kamasTotal;
            }
            set
            {
                m_kamasTotal = value;
            }
        }
        
        public KamasUpdateMessage(ulong kamasTotal)
        {
            m_kamasTotal = kamasTotal;
        }
        
        public KamasUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhLong(m_kamasTotal);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_kamasTotal = reader.ReadVarUhLong();
        }
    }
}
