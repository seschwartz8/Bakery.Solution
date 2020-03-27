# Bakery

![LastCommit](https://img.shields.io/github/last-commit/seschwartz8/Bakery.Solution)
![Languages](https://img.shields.io/github/languages/top/seschwartz8/Bakery.Solution)
![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)

#### Epicodus Friday project: A C#/.NET Core MVC project with a focus on authentication and many-to-many database relationships. Current version: 03.27.20

#### By Sarah "Sasa" Schwartz

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [Specifications](#specs)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

## Description

Epicodus Friday independent project: A C#/.NET Core MVC project that shows bakery treats and flavors with a focus on authentication and many-to-many database relationships. This application requires users to register and log in prior to accessing any data. After logging in, users should be able to view all treats and flavors that the bakery offers. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. Upon clicking a treat or flavor, the user should see all the treats or flavors that go with the one they clicked (e.g. "sweet" might contain "chocolate", "donuts", and "cake"). The user should have create, edit, view, and delete functionality (CRUD functionality) for all treats and flavors.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the Bakery directory, within the Bakery.Solution directory
- \$dotnet restore
- Recreate my database structure with migration:
  - \$dotnet ef migrations add Initial
  - \$dotnet ef database update
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## Specs

- User must log in prior to attaining CRUD functionality.
  - Sample input: User opens website
  - Expected output: User is greeted with the log in screen
- Once logged in, user is shown a splash page with links to all treats and flavors.
  - Sample input: User logs in
  - Expected output: Splash page appears, with links to "see all treats" and "see all flavors"
- User can create a treat or flavor
  - Sample input: User clicks on "create flavor"
  - Expected output: User is taken to form to create a flavor
- User can click on any treat or flavor to view its details.
  - Sample input: User clicks on "sweet" flavor
  - Expected output: User is taken to page that shows all the "sweet" treats that exist (e.g. "chocolate" and "donuts")
- User can add or remove a treat from its flavor (and vice versa).
  - Sample input: User is on the "sweet" page and either clicks the "remove treat" button next to a treat or the "add treat" button.
  - Expected output: Selected treat is removed or added
- User can delete any treat or flavor from the bakery system.
  - Sample input: User clicks on "delete" button for "sweet" flavor
  - Expected output: "sweet" flavor is deleted from bakery system

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
