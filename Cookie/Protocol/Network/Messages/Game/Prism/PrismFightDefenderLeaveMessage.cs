//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Prism
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class PrismFightDefenderLeaveMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5892;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private ushort m_fightId;
        
        public virtual ushort FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        private ulong m_fighterToRemoveId;
        
        public virtual ulong FighterToRemoveId
        {
            get
            {
                return m_fighterToRemoveId;
            }
            set
            {
                m_fighterToRemoveId = value;
            }
        }
        
        public PrismFightDefenderLeaveMessage(ushort subAreaId, ushort fightId, ulong fighterToRemoveId)
        {
            m_subAreaId = subAreaId;
            m_fightId = fightId;
            m_fighterToRemoveId = fighterToRemoveId;
        }
        
        public PrismFightDefenderLeaveMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_subAreaId);
            writer.WriteVarUhShort(m_fightId);
            writer.WriteVarUhLong(m_fighterToRemoveId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_subAreaId = reader.ReadVarUhShort();
            m_fightId = reader.ReadVarUhShort();
            m_fighterToRemoveId = reader.ReadVarUhLong();
        }
    }
}
