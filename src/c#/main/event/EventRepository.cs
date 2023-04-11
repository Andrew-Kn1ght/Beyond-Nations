using System.Collections.Generic;

namespace osg {

    public class EventRepository {
        private Dictionary<EventType, List<Event>> events;

        public EventRepository() {
            events = new Dictionary<EventType, List<Event>>();
        }

        public void addEvent(Event e) {
            try {
                List<Event> list = events[e.getType()];
                list.Add(e);
            } catch (KeyNotFoundException) {
                List<Event> list = new List<Event>();
                list.Add(e);
                events.Add(e.getType(), list);
            }
        }

        public List<Event> getEvents(EventType eventType) {
            return events[eventType];
        }
    }
}