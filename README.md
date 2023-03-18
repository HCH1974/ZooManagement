# Zoo Management

This project is a zoo management system. It can hold details of species, animals and animal enclosures. The following endpoints have been created:

- create new animal (including validation on the dates entered, validtion that the species and enclosure exist and that the species is allowed in that enclosure)
- retrieve an animal by its id
- search for a list of animals by species, classification or age (including pagination)
- list all species

This project includes an sqlite database. Sample data is created if the project is run with no data in the database.

## Setup

To execute this program, run the command dotnet run. The endpoints can be accessed by going to the localhost page /swagger
