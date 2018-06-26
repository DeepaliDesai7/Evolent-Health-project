# Evolent-Health-project
EvolentHealth project
This application has following 3 layers
1.	UI
2.	Business Logic
3.	Database operations
1. UI:
UI layer contains following views 
•	Index.cshtml
•	Create.cshtml
•	Edit.cshtml
•	Delete.cshtml
•	Details.cshtml
2. Business Logic:
This layer contains logic that reside in Contactscontroller
3.  Database Operations:
All database operations are separated in namespace Evolent_Deepali.Repository
I have used MEF(Managed Extensibility Framework) to identify dependencies
Hence controller has access to IcontactsRepository interface only and this interface gives call to various database operations which achieves loose coupling
Hence implementation of database activities can be changed anytime.
We should place these DB operations in separate project but due to time constraint I placed it in same project.

