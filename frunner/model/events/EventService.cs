using frunner.infrastructure.events;

namespace frunner.model.events
{
    public class EventService
    {
        public EventService(EventRepository eventRepository)
        {

        }

        public void Create(Event newEvent) { }

        public IEnumerable<Event> FindPublicEvents() => null;
    }
}