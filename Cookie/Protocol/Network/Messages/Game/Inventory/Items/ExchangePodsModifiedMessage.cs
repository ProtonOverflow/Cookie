//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Items
{
    using Cookie.Protocol.Network.Messages.Game.Inventory.Exchanges;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ExchangePodsModifiedMessage : ExchangeObjectMessage
    {
        
        public new const uint ProtocolId = 6670;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_currentWeight;
        
        public virtual uint CurrentWeight
        {
            get
            {
                return m_currentWeight;
            }
            set
            {
                m_currentWeight = value;
            }
        }
        
        private uint m_maxWeight;
        
        public virtual uint MaxWeight
        {
            get
            {
                return m_maxWeight;
            }
            set
            {
                m_maxWeight = value;
            }
        }
        
        public ExchangePodsModifiedMessage(uint currentWeight, uint maxWeight)
        {
            m_currentWeight = currentWeight;
            m_maxWeight = maxWeight;
        }
        
        public ExchangePodsModifiedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(m_currentWeight);
            writer.WriteVarUhInt(m_maxWeight);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_currentWeight = reader.ReadVarUhInt();
            m_maxWeight = reader.ReadVarUhInt();
        }
    }
}
