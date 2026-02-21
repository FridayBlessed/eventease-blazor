# EventEase

Blazor WebAssembly event management application built for **Course 4: Blazor for Front-End Development** in the Microsoft Frontend Developer Professional Certificate on Coursera.

## Features

- **Event Card Component** - reusable component with `[Parameter]` properties, `EventCallback<int>` for parent-child communication, and conditional rendering (available/sold out states)
- **Search & Filter** - real-time text search across event titles and descriptions, location dropdown filter, and availability status filter with two-way data binding (`@bind`, `@bind:event`, `@bind:after`)
- **Registration Form** - `EditForm` with `DataAnnotationsValidator`, `InputText`, `InputSelect`, `InputDate`, `InputNumber` controls, validation messages, and duplicate registration prevention
- **Session Management** - `SessionService` singleton tracking user login state across pages, pre-filling forms for returning users, with `OnSessionChanged` event notifications
- **Attendance Tracker** - per-event stats grid (registered/capacity/available/fill rate), visual progress bar, filterable registrations table with timestamps
- **Create Event** - full form with `DataAnnotationsValidator` for adding new events with title, description, date, location, and capacity
- **Routing** - parameterized routes (`/register/{EventId:int}`, `/attendance/{EventId:int}`), `NavigationManager` for programmatic navigation, 404 Not Found page
- **Input Validation** - `[Required]`, `[StringLength]`, `[EmailAddress]`, `[Range]` annotations on all models with `ValidationMessage` and `ValidationSummary` components
- **Responsive Design** - CSS grid layouts, mobile breakpoints, custom styling for cards, forms, tables, badges, and progress bars.

## Project Structure

```
EventEase/
├── Components/
│   └── EventCard.razor            # reusable event card with parameters and callbacks
├── Models/
│   ├── EventModel.cs              # event model with DataAnnotations validation
│   └── RegistrationModel.cs       # registration model with email validation
├── Pages/
│   ├── Home.razor                 # events listing with search/filter
│   ├── Register.razor             # registration form with EditForm
│   ├── Attendance.razor           # attendance tracker with stats
│   ├── CreateEvent.razor          # new event creation form
│   └── NotFound.razor             # 404 error page
├── Services/
│   ├── EventService.cs            # event CRUD + registration logic (singleton)
│   └── SessionService.cs          # user session state management (singleton)
├── Layout/
│   ├── MainLayout.razor           # app shell layout
│   └── NavMenu.razor              # navigation sidebar
└── wwwroot/css/app.css            # custom responsive styles
```

## Tech Stack

- .NET 10.0 / C#
- Blazor WebAssembly
- Bootstrap 5
- DataAnnotations for validation.

## Build

```bash

dotnet restore   # Restore dependencies

dotnet build     # Compiles the code

dotnet run       # launches at https://localhost:5077
```

## AUTHOR

[Friday Blessed](https://github.com/FridayBlessed)
