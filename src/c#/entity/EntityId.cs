using System;

namespace osg {

    public class EntityId {
        private Guid id;

        public EntityId() {
            this.id = new Guid();
        }

        public Guid getId() {
            return id;
        }

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }

            EntityId other = obj as EntityId;
            if (other == null) {
                return false;
            }

            return id.Equals(other.id);
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }
    }
}