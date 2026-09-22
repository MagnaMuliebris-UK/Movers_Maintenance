## Movers_Maintenance
A C# Winforms application, to be paired with an active database. This is designed to be a 'subsystem' rather than a full whole, so there is no 'sign-in' functionality for it.

# NOTE:
Almost everything in the application requires a worker or multiple different types of workers, please make workers first.

Workers must exist to make cars, session appointments, and checkups. Although checkups also require cars too.
Items must exist for an active checkup appointment too, alongside the checkup itself.
A scheduled session must be made prior to a session appointment's creation.

If you wish to delete a worker for any reason, the relevant checkups, sessions, or cars the worker is assigned to will either also be deleted or will be deleted in a cascade depending on the settings chosen.

The Report functionality is limited, and deposits the report (labelled Report_{DATE-TIME}) in the bin segment of the application.

This project is still being worked on as of the time of making this (22/09/2026).
