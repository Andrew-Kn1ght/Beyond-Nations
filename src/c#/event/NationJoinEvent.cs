namespace osg {

    public class NationJoinEvent : Event {
        private Nation nation;
        private EntityId entityId;

        public NationJoinEvent(Nation nation, EntityId entityId) : base(EventType.NationJoin, "The entity " + entityId + " has joined the nation " + nation.getName() + ".") {
            this.nation = nation;
            this.entityId = entityId;
        }

        public Nation getNation() {
            return nation;
        }

        public EntityId getEntityId() {
            return entityId;
        }

        public override string ToString() {
            return "NationJoinEvent [" + "nation=" + nation.getName() + ", entityId=" + entityId + ", type=" + getType() + ", description=" + getDescription() + ", date=" + getDate() + "]";
        }
    }
}