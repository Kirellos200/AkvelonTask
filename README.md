# FizzBuzz Coding Task

This repository contains a C# .NET solution for the Akvelon FizzBuzz string manipulation task. 

## Project Structure

The solution follows standard C# architecture and the principle of Separation of Concerns, consisting of three distinct projects:

*   **`AkvelonTask`**: A Class Library containing the core business logic (`FizzBuzzDetector`) and the data model (`FizzBuzzResult`).
*   **`AkvelonTask.ConsoleApp`**: A runnable console application that serves as the entry point to demonstrate the code in action using the provided example.
*   **`AkvelonTask.Tests`**: An xUnit project containing comprehensive unit tests verifying major scenarios, constraints, and edge cases.

## Design Decisions & Constraints Handled

*   **Custom Parsing:** The algorithm evaluates the string character-by-character. This ensures that all original formatting, punctuation, and varying whitespace characters (including line breaks) are perfectly preserved in the final output.
*   **Alphanumeric Filtering:** As per the constraints, tokens consisting entirely of non-alphanumeric characters (e.g., `,`) are skipped during the FizzBuzz word count, but are strictly preserved in the output text.

## Prerequisites

To run this application, you will need:
*   [.NET SDK 8.0 or newer](https://dotnet.microsoft.com/download) (The project targets .NET 10.0)

## How to Run the Application

To execute the console application and see the FizzBuzz logic applied to the sample text, open your terminal in the root directory (where the `.sln` file is located) and run:

```bash
dotnet run --project AkvelonTask.ConsoleApp
