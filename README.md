## Requirements

 - **dotnet-ef** 7.0
 - **dotnet** 7.0

## Setup

 - run command `dotnet ef database update` to initialize database
 - run command `dotnet run` to start the app

## Test users

 - admin: 
    - email: admin@gmail.com
    - password: Admin123#
 - user:
   - email: user@gmail.com
   - password: User123#

# Functionality description

User from main page can go to subpage books where they can see available books and preview book details. 

User can also login by clicking login button, and filling in login form.

If user has `admin` role they get the ability to: **create**, **edit**, and **remove** books on the books page.