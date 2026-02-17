using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<EventModel> _events = new();
        private readonly List<RegistrationModel> _registrations = new();
        private int _nextEventId = 1;

        public EventService()
        {
            SeedEvents();
        }

        private void SeedEvents()
        {
            _events.AddRange(new[]
            {
                new EventModel
                {
                    Id = _nextEventId++,
                    Title = "Blazor Workshop",
                    Description = "Learn the fundamentals of Blazor WebAssembly and build interactive web applications.",
                    Date = DateTime.Now.AddDays(7),
                    Location = "Virtual",
                    MaxCapacity = 100,
                    CurrentAttendees = 42
                },
                new EventModel
                {
                    Id = _nextEventId++,
                    Title = ".NET Conference",
                    Description = "Annual .NET developer conference covering the latest in C#, ASP.NET, and Azure.",
                    Date = DateTime.Now.AddDays(14),
                    Location = "Convention Center",
                    MaxCapacity = 500,
                    CurrentAttendees = 320
                },
                new EventModel
                {
                    Id = _nextEventId++,
                    Title = "Azure Cloud Summit",
                    Description = "Deep dive into Azure services, deployment strategies, and cloud architecture.",
                    Date = DateTime.Now.AddDays(21),
                    Location = "Tech Hub",
                    MaxCapacity = 200,
                    CurrentAttendees = 198
                }
            });
        }

        public List<EventModel> GetAllEvents() => _events.ToList();

        public EventModel? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

        public void AddEvent(EventModel newEvent)
        {
            newEvent.Id = _nextEventId++;
            _events.Add(newEvent);
        }

        public bool RegisterForEvent(RegistrationModel registration)
        {
            var eventItem = GetEventById(registration.EventId);
            if (eventItem == null || eventItem.AvailableSpots <= 0)
                return false;

            // Check for duplicate registration
            bool alreadyRegistered = _registrations.Any(r =>
                r.Email.Equals(registration.Email, StringComparison.OrdinalIgnoreCase) &&
                r.EventId == registration.EventId);

            if (alreadyRegistered)
                return false;

            _registrations.Add(registration);
            eventItem.CurrentAttendees++;
            return true;
        }

        public List<RegistrationModel> GetRegistrationsForEvent(int eventId) =>
            _registrations.Where(r => r.EventId == eventId).ToList();

        public List<RegistrationModel> GetAllRegistrations() => _registrations.ToList();
    }
}
