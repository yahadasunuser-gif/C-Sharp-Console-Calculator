# Object-Oriented Console Calculator in C#

A robust, object-oriented Command Line Interface (CLI) calculator application built using C# and .NET. This project demonstrates clean **Separation of Concerns** by completely decoupling the user interaction layer from the underlying mathematical execution engine.

## 🚀 Key Features
* **Full Double Precision:** Uses `double` data types to handle both whole numbers and complex decimal mathematics seamlessly.
* **Robust Input Validation:** Uses continuous `while` loops combined with `double.TryParse` pattern matching to prevent application crashes from invalid non-numeric inputs.
* **Defensive Error Handling:** Contains multi-layered safety guards preventing runtime division-by-zero errors and avoiding contradictory console print layouts.
* **Continuous Operations Loop:** Implements an application-wide loop allowing users to perform multiple operations consecutively without needing to restart the program.

## 🛠️ Architecture Details
The project is split into two cleanly organized layers:

1. **The User Interface Layer (`Program.cs`):** Manages the application lifecycle, menu displays, input collection, character validation, and output presentation.
2. **The Core Logic Engine (`executions.cs`):** An isolated class that encapsulates properties (`num_1`, `num_2`) and mathematical methods (`Add`, `substraction`, `multiplication`, `division`) to process calculations independently.

## 💻 How To Run
1. Open the project folder in your preferred C# IDE (Visual Studio or VS Code).
2. Ensure both `Program.cs` and `executions.cs` are included under the same namespace (`Calculator`).
3. Compile and run the application, or execute the following command in your terminal:
   ```bash
   dotnet run
