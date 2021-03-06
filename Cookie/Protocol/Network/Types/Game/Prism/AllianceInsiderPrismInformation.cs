//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Prism
{
    using Cookie.Protocol.Network.Types.Game.Data.Items;
    using Cookie.IO;
    using System.Collections.Generic;


    public class AllianceInsiderPrismInformation : PrismInformation
    {
        
        public new const short ProtocolId = 431;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItem> m_modulesObjects;
        
        public virtual List<ObjectItem> ModulesObjects
        {
            get
            {
                return m_modulesObjects;
            }
            set
            {
                m_modulesObjects = value;
            }
        }
        
        private int m_lastTimeSlotModificationDate;
        
        public virtual int LastTimeSlotModificationDate
        {
            get
            {
                return m_lastTimeSlotModificationDate;
            }
            set
            {
                m_lastTimeSlotModificationDate = value;
            }
        }
        
        private uint m_lastTimeSlotModificationAuthorGuildId;
        
        public virtual uint LastTimeSlotModificationAuthorGuildId
        {
            get
            {
                return m_lastTimeSlotModificationAuthorGuildId;
            }
            set
            {
                m_lastTimeSlotModificationAuthorGuildId = value;
            }
        }
        
        private ulong m_lastTimeSlotModificationAuthorId;
        
        public virtual ulong LastTimeSlotModificationAuthorId
        {
            get
            {
                return m_lastTimeSlotModificationAuthorId;
            }
            set
            {
                m_lastTimeSlotModificationAuthorId = value;
            }
        }
        
        private string m_lastTimeSlotModificationAuthorName;
        
        public virtual string LastTimeSlotModificationAuthorName
        {
            get
            {
                return m_lastTimeSlotModificationAuthorName;
            }
            set
            {
                m_lastTimeSlotModificationAuthorName = value;
            }
        }
        
        public AllianceInsiderPrismInformation(List<ObjectItem> modulesObjects, int lastTimeSlotModificationDate, uint lastTimeSlotModificationAuthorGuildId, ulong lastTimeSlotModificationAuthorId, string lastTimeSlotModificationAuthorName)
        {
            m_modulesObjects = modulesObjects;
            m_lastTimeSlotModificationDate = lastTimeSlotModificationDate;
            m_lastTimeSlotModificationAuthorGuildId = lastTimeSlotModificationAuthorGuildId;
            m_lastTimeSlotModificationAuthorId = lastTimeSlotModificationAuthorId;
            m_lastTimeSlotModificationAuthorName = lastTimeSlotModificationAuthorName;
        }
        
        public AllianceInsiderPrismInformation()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_modulesObjects.Count)));
            int modulesObjectsIndex;
            for (modulesObjectsIndex = 0; (modulesObjectsIndex < m_modulesObjects.Count); modulesObjectsIndex = (modulesObjectsIndex + 1))
            {
                ObjectItem objectToSend = m_modulesObjects[modulesObjectsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteInt(m_lastTimeSlotModificationDate);
            writer.WriteVarUhInt(m_lastTimeSlotModificationAuthorGuildId);
            writer.WriteVarUhLong(m_lastTimeSlotModificationAuthorId);
            writer.WriteUTF(m_lastTimeSlotModificationAuthorName);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int modulesObjectsCount = reader.ReadUShort();
            int modulesObjectsIndex;
            m_modulesObjects = new System.Collections.Generic.List<ObjectItem>();
            for (modulesObjectsIndex = 0; (modulesObjectsIndex < modulesObjectsCount); modulesObjectsIndex = (modulesObjectsIndex + 1))
            {
                ObjectItem objectToAdd = new ObjectItem();
                objectToAdd.Deserialize(reader);
                m_modulesObjects.Add(objectToAdd);
            }
            m_lastTimeSlotModificationDate = reader.ReadInt();
            m_lastTimeSlotModificationAuthorGuildId = reader.ReadVarUhInt();
            m_lastTimeSlotModificationAuthorId = reader.ReadVarUhLong();
            m_lastTimeSlotModificationAuthorName = reader.ReadUTF();
        }
    }
}
