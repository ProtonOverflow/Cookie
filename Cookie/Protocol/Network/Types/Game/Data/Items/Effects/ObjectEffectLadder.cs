//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Data.Items.Effects
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ObjectEffectLadder : ObjectEffectCreature
    {
        
        public new const short ProtocolId = 81;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_monsterCount;
        
        public virtual uint MonsterCount
        {
            get
            {
                return m_monsterCount;
            }
            set
            {
                m_monsterCount = value;
            }
        }
        
        public ObjectEffectLadder(uint monsterCount)
        {
            m_monsterCount = monsterCount;
        }
        
        public ObjectEffectLadder()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(m_monsterCount);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_monsterCount = reader.ReadVarUhInt();
        }
    }
}
