//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Idol
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class Idol : NetworkType
    {
        
        public const short ProtocolId = 489;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_ObjectId;
        
        public virtual ushort ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        private ushort m_xpBonusPercent;
        
        public virtual ushort XpBonusPercent
        {
            get
            {
                return m_xpBonusPercent;
            }
            set
            {
                m_xpBonusPercent = value;
            }
        }
        
        private ushort m_dropBonusPercent;
        
        public virtual ushort DropBonusPercent
        {
            get
            {
                return m_dropBonusPercent;
            }
            set
            {
                m_dropBonusPercent = value;
            }
        }
        
        public Idol(ushort objectId, ushort xpBonusPercent, ushort dropBonusPercent)
        {
            m_ObjectId = objectId;
            m_xpBonusPercent = xpBonusPercent;
            m_dropBonusPercent = dropBonusPercent;
        }
        
        public Idol()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_ObjectId);
            writer.WriteVarUhShort(m_xpBonusPercent);
            writer.WriteVarUhShort(m_dropBonusPercent);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_ObjectId = reader.ReadVarUhShort();
            m_xpBonusPercent = reader.ReadVarUhShort();
            m_dropBonusPercent = reader.ReadVarUhShort();
        }
    }
}
