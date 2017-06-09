//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class JobBookSubscribeRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6592;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Byte> m_jobIds;
        
        public virtual List<System.Byte> JobIds
        {
            get
            {
                return m_jobIds;
            }
            set
            {
                m_jobIds = value;
            }
        }
        
        public JobBookSubscribeRequestMessage(List<System.Byte> jobIds)
        {
            m_jobIds = jobIds;
        }
        
        public JobBookSubscribeRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_jobIds.Count)));
            int jobIdsIndex;
            for (jobIdsIndex = 0; (jobIdsIndex < m_jobIds.Count); jobIdsIndex = (jobIdsIndex + 1))
            {
                writer.WriteByte(m_jobIds[jobIdsIndex]);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int jobIdsCount = reader.ReadUShort();
            int jobIdsIndex;
            m_jobIds = new System.Collections.Generic.List<byte>();
            for (jobIdsIndex = 0; (jobIdsIndex < jobIdsCount); jobIdsIndex = (jobIdsIndex + 1))
            {
                m_jobIds.Add(reader.ReadByte());
            }
        }
    }
}