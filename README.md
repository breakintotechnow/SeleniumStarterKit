# SeleniumStarterKit

SeleniumStarterKit (C#)
A simple, foundational Selenium setup in C# to help you learn and build a robust test automation framework. This project provides a basic but scalable structure that can be extended to test any web application.

Table of Contents
Overview
Project Structure
Prerequisites
Getting Started
Running Tests
Extending the Framework
Contributing
License
Overview
This repository is a starter plate for anyone looking to learn or teach Selenium test automation using C#. It’s organized into logical folders for pages, tests, and utilities, making it easy to see how each piece fits into a complete test framework.

Project Structure

SeleniumStarterKit
├── SeleniumStarterKit.sln
├── SeleniumStarterKit
│   ├── Pages
│   │   ├── BasePage.cs
│   │   └── HomePage.cs
│   ├── Tests
│   │   └── TestClass.cs
│   ├── Utilities
│   │   ├── DriverPage.cs
│   │   └── WaitUtilities.cs
│   └── ...
├── .gitignore
└── README.md



Pages: Contains Page Object classes. Each class represents a page or component of the web application.

Tests: Holds test classes, each often corresponding to a single feature or page being tested.

Utilities: Helper classes like DriverPage (for browser initialization) and WaitUtilities (for explicit waits).


Extending the Framework
Adding New Pages
Create a new .cs file in the Pages folder. Inherit from BasePage and include methods/elements relevant to that page.

Writing More Tests
Create additional test classes in the Tests folder. Reference the new page objects to keep logic separated from the test code.

Utilities

DriverPage.cs: Contains logic for setting up and tearing down the WebDriver. You can modify it for different browsers or remote setups (e.g., Selenium Grid).

WaitUtilities.cs: Provides methods for explicit waits, making your tests more stable against varying load times.
