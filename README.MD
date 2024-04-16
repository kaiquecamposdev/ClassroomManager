<p align="center">
  <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center"></h1>
</p>
<p align="center">
    <em>Innovating classroom management, one code at a time.</em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/kaiquecamposdev/ClassroomManager?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/kaiquecamposdev/ClassroomManager?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/kaiquecamposdev/ClassroomManager?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/kaiquecamposdev/ClassroomManager?style=default&color=0080ff" alt="repo-language-count">
<p>
<p align="center">
	<!-- default option, no dependency badges. -->
</p>

<br><!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary><br>

- [ Overview](#-overview)
- [ Features](#-features)
- [ Repository Structure](#-repository-structure)
- [ Modules](#-modules)
- [ Getting Started](#-getting-started)
  - [ Installation](#-installation)
  - [ Usage](#-usage)
  - [ Tests](#-tests)
- [ Project Roadmap](#-project-roadmap)
- [ Contributing](#-contributing)
- [ License](#-license)
- [ Acknowledgments](#-acknowledgments)
</details>
<hr>

##  Overview

The ClassroomManager project is a comprehensive CLI application facilitating equipment and employee management. It empowers users to create, authenticate, and report on employees, along with creating and consulting equipment. By leveraging sharp interactions and robust data repositories, ClassroomManager ensures secure authentication, efficient data handling, and accurate reporting. With clear menu options and structured repositories, this project streamlines workflow processes and enhances overall user experience.

## How to Login as Administrator

This guide will show you how to log in as an administrator using the enrollment login **123456** and password **admin**.

Prerequisites:

- Have access to the system's login page.

---

##  Features

|    |   Feature         | Description |
|----|-------------------|---------------------------------------------------------------|
| ⚙️  | **Architecture**  | The project follows a modular architecture with clear separation of concerns. It utilizes repositories and use cases to interact with data models, enhancing maintainability and scalability. The codebase is organized with well-defined classes and interfaces. The project is built on .NET Core 8.0.   |
| 🔩 | **Code Quality**  | The codebase demonstrates good quality and style practices with consistent naming conventions, proper documentation, and clear structure. It adheres to SOLID principles and utilizes design patterns for improved code maintainability. The codebase is easy to read and understand. |
| 📄 | **Documentation** | The project includes extensive documentation throughout the codebase, explaining the purpose and functionality of each component. It provides clear explanations of classes, methods, and interfaces, aiding developers in understanding and contributing to the project efficiently. |
| 🔌 | **Integrations**  | Key external dependencies include Bcrypt for secure password hashing and Sharprompt for user input handling. These integrations enhance security and user interaction within the application. The project also relies on JSON for data storage and retrieval.|
| 🧩 | **Modularity**    | The codebase exhibits high modularity and reusability, allowing for easy extension and maintenance. Components are well encapsulated, promoting code reuse and separation of concerns. The use of factories to create instances enhances flexibility and modularity.  |
| 🧪 | **Testing**       | The project employs testing frameworks and tools such as xUnit for unit testing, ensuring code reliability and functionality. Test coverage is crucial for maintaining the quality of the codebase and facilitating future enhancements. |
| ⚡️  | **Performance**   | The project emphasizes efficiency and speed in data retrieval and processing. By utilizing in-memory storage and efficient data structures, the application optimizes resource usage. Performance optimizations are key to providing a seamless user experience.|
| 🛡️ | **Security**      | Security measures include password hashing using Bcrypt for secure authentication. The project follows best practices for data protection and access control, safeguarding sensitive information. Error handling and validation further enhance security within the application. |
| 📦 | **Dependencies**  | Key dependencies include Bcrypt for password hashing, Sharprompt for user interaction, and JSON for data storage. These external libraries augment the project's functionality and security measures. The codebase efficiently manages external dependencies to ensure smooth integration. |

---

##  Repository Structure

```sh
└── /
    ├── ClassroomManager
    │   ├── CLI
    │   ├── ClassroomManager.csproj
    │   ├── Program.cs
    │   ├── Properties
    │   ├── db
    │   ├── lib
    │   ├── models
    │   ├── net8.0
    │   ├── promptio
    │   ├── repositories
    │   ├── usecases
    │   └── utils
    ├── ClassroomManager.sln
    └── LICENSE.txt
```

---

##  Modules

<details closed><summary>.</summary>

| File                                                                                                         | Summary                                                                                                                                                                                           |
| ---                                                                                                          | ---                                                                                                                                                                                               |
| [LICENSE.txt](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/LICENSE.txt)                   | Grants permission to use, modify, and distribute the software under the MIT License terms. It obliges attribution and disclaims liability.                                                        |
| [ClassroomManager.sln](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager.sln) | Manages project configurations for the ClassroomManager solution, defining Debug and Release options for the main project. Controls build settings and Visual Studio properties for the solution. |

</details>

<details closed><summary>ClassroomManager</summary>

| File                                                                                                                                | Summary                                                                                                                                                                                                                                             |
| ---                                                                                                                                 | ---                                                                                                                                                                                                                                                 |
| [Program.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/Program.cs)                           | Handles user authentication and registration flow in Classroom Manager. Initiate session, authenticate user, or register new user, with customizable exit option. Centralizes user interaction via SharpromptProvider for seamless user experience. |
| [ClassroomManager.csproj](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/ClassroomManager.csproj) | Manages project settings, dependencies, and target framework for the Classroom Manager CLI application. Facilitates building and executing the CLI tool with essential package references and configuration details.                                |

</details>

<details closed><summary>ClassroomManager.db</summary>

| File                                                                                                                   | Summary                                                                                                                                                                                                                                        |
| ---                                                                                                                    | ---                                                                                                                                                                                                                                            |
| [equipments.json](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/db/equipments.json) | Manages equipment data for the Classroom Manager. Stores equipment details like ID, name, model, brand, quantity, and status in a JSON file. Critical for tracking equipment availability and status within the application.                   |
| [reports.json](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/db/reports.json)       | Provides report data structure in JSON format for equipment usage. Supports tracking equipment assignments to employees with relevant IDs and creation timestamps. Essential for generating usage reports in the ClassroomManager application. |

</details>

<details closed><summary>ClassroomManager.net8.0</summary>

| File                                                                                                                                                               | Summary                                                                                                                                                                                                |
| ---                                                                                                                                                                | ---                                                                                                                                                                                                    |
| [ClassroomManager.deps.json](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/net8.0/ClassroomManager.deps.json)                   | Defines dependencies for the.NETCoreApp and the associated packages used by the ClassroomManager project.                                                                                              |
| [ClassroomManager.runtimeconfig.json](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/net8.0/ClassroomManager.runtimeconfig.json) | Defines runtime configuration for.NET Core App 8.0 in `ClassroomManager.runtimeconfig.json`. Enforces safe serialization settings, supporting core functionality for the Classroom Manager repository. |

</details>

<details closed><summary>ClassroomManager.promptio.controllers</summary>

| File                                                                                                                               | Summary                                                                                                                                                                                                           |
| ---                                                                                                                                | ---                                                                                                                                                                                                               |
| [report.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/promptio/controllers/report.cs)       | Generates and retrieves reports for classroom equipment usage based on employee ID. Interacts with use case classes to handle report creation and retrieval. Handles resource not found errors.                   |
| [employee.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/promptio/controllers/employee.cs)   | Manages employee registration and authentication.-Guides user input for employee details and validates credentials.-Utilizes specific use cases for registration and authentication to interact with the backend. |
| [equipment.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/promptio/controllers/equipment.cs) | Manages equipment creation and consultation operations. Implements error handling and uses relevant use cases to execute actions. Enhances user experience through clear feedback messages.                       |

</details>

<details closed><summary>ClassroomManager.models</summary>

| File                                                                                                                                         | Summary                                                                                                                                                                                                                   |
| ---                                                                                                                                          | ---                                                                                                                                                                                                                       |
| [report.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/models/report.cs)                               | Defines a Report model for tracking employee usage of equipment, integral to ClassroomManagers functionality. Captures report details such as ID, employee ID, equipment ID, and creation timestamp.                      |
| [employee.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/models/employee.cs)                           | Defines an Employee model implementing the IEmployee interface. Stores employee details like ID, name, telephone, password, enrollment, and role. Central to managing employees within the ClassroomManager architecture. |
| [equipment.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/models/equipment.cs)                         | Defines Equipment model properties linking to the IEquipment interface for the ClassroomManager.                                                                                                                          |
| [authenticate-employee.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/models/authenticate-employee.cs) | Enables employee authentication by storing enrollment number and password. Key part of the ClassroomManager system architecture to ensure secure access.                                                                  |

</details>

<details closed><summary>ClassroomManager.models.interfaces</summary>

| File                                                                                                                                                    | Summary                                                                                                                                                                                                                       |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                           |
| [IEquipment.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/models/interfaces/IEquipment.cs)                       | Defines equipment attributes with validation rules for status, name, model, brand, and quantity. Supports equipment management within the ClassroomManager repositorys architecture.                                          |
| [IEmployee.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/models/interfaces/IEmployee.cs)                         | Defines employee interface with required fields and role enum, ensuring data consistency and validation. Crucial for managing employee data in the ClassroomManager system, facilitating role-based access and functionality. |
| [IAuthenticateEmployee.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/models/interfaces/IAuthenticateEmployee.cs) | Defines an interface for employee authentication with properties for enrollment ID and password, crucial for managing user access within the Classroom Manager repositorys architecture.                                      |

</details>

<details closed><summary>ClassroomManager.CLI</summary>

| File                                                                                                    | Summary                                                                                                                                                                                                                                 |
| ---                                                                                                     | ---                                                                                                                                                                                                                                     |
| [menu.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/CLI/menu.cs) | Orchestrates menu options for equipment management based on employee role.-Enables equipment consultation, request, creation, and reporting within the CLI.-Provides a seamless user experience for navigating equipment-related tasks. |

</details>

<details closed><summary>ClassroomManager.CLI.interfaces</summary>

| File                                                                                                                 | Summary                                                                                                                                                              |
| ---                                                                                                                  | ---                                                                                                                                                                  |
| [IMenu.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/CLI/interfaces/IMenu.cs) | Defines menu options for handling equipment requests and reports in the Classroom Manager CLI. Allows displaying menu choices for users to interact with the system. |

</details>

<details closed><summary>ClassroomManager.Properties</summary>

| File                                                                                                                                   | Summary                                                                                                                                                                               |
| ---                                                                                                                                    | ---                                                                                                                                                                                   |
| [launchSettings.json](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/Properties/launchSettings.json) | Defines launch settings for the ClassroomManager project, enabling native debugging. Integrates with the parent repositorys architecture to configure the project execution behavior. |

</details>

<details closed><summary>ClassroomManager.repositories</summary>

| File                                                                                                                                               | Summary                                                                                                                                                                         |
| ---                                                                                                                                                | ---                                                                                                                                                                             |
| [employees-repository.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/repositories/employees-repository.cs)   | Enables creation and retrieval of employees in the ClassroomManager system. Provides essential interface methods for managing employee data within the repository architecture. |
| [equipments-repository.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/repositories/equipments-repository.cs) | Manages equipment data with CRUD operations. Implements an interface for creating, retrieving, and searching equipment entries.                                                 |
| [reports-repository.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/repositories/reports-repository.cs)       | Enables creation and retrieval of reports based on employee ID. Maintains a structured interface for managing report data within the Classroom Manager repository architecture. |

</details>

<details closed><summary>ClassroomManager.repositories.in-memory</summary>

| File                                                                                                                                                                           | Summary                                                                                                                                                                                                                        |
| ---                                                                                                                                                                            | ---                                                                                                                                                                                                                            |
| [in-memory-employees-repository.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/repositories/in-memory/in-memory-employees-repository.cs) | Manages employee data using in-memory storage. Creates and retrieves employees by ID or enrollment number. Implements basic CRUD operations for the employee repository, enhancing the ClassroomManager systems functionality. |

</details>

<details closed><summary>ClassroomManager.repositories.json</summary>

| File                                                                                                                                                              | Summary                                                                                                                                                                                                                                             |
| ---                                                                                                                                                               | ---                                                                                                                                                                                                                                                 |
| [json-equipments-repository.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/repositories/json/json-equipments-repository.cs) | Manages equipment data storage, retrieval, and modification. Utilizes JSON format and file I/O for persistence within the db directory. Implements create, read, and search operations for equipment entities.                                      |
| [json-employees-repository.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/repositories/json/json-employees-repository.cs)   | Manages employee data storage using JSON format. Creates, finds employees by ID or enrollment, and persistently saves employee data to a file. Improves projects data handling and provides a reliable and scalable way to manage employee records. |
| [json-reports-repository.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/repositories/json/json-reports-repository.cs)       | Manages reports storage and retrieval. Creates, stores, and retrieves reports by employee ID in JSON format. Implements file I/O operations for persisting report data within the repository structure.                                             |

</details>

<details closed><summary>ClassroomManager.usecases</summary>

| File                                                                                                                                   | Summary                                                                                                                                                                                                |
| ---                                                                                                                                    | ---                                                                                                                                                                                                    |
| [create-equipment.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/create-equipment.cs)   | Creates equipment in ClassroomManager by interfacing with repositories to store equipment data efficiently.                                                                                            |
| [authenticate.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/authenticate.cs)           | Enables authentication of employees in the ClassroomManager system. Validates credentials using bcrypt hashing. Contributes to system security and user access control.                                |
| [consult-equipment.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/consult-equipment.cs) | Retrieves all equipment from the repository and validates if any exist. If none found, raises a ResourceNotFoundError exception; else, returns the list of equipment.                                  |
| [register.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/register.cs)                   | Registers employees securely, preventing duplicate enrollments. Utilizes bcrypt for password hashing and repository pattern for data operations, adhering to the architectures separation of concerns. |
| [consult-report.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/consult-report.cs)       | Retrieves employee reports from the repository and throws a resource not found error if no reports are found. Core feature for consulting reports in the Classroom Manager system.                     |
| [generate-report.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/generate-report.cs)     | Generates reports based on equipment data fetched through Repositories, ensuring accuracy and handling errors effectively within the Classroom Manager architecture.                                   |

</details>

<details closed><summary>ClassroomManager.usecases.factories</summary>

| File                                                                                                                                                                                 | Summary                                                                                                                                                                                                                               |
| ---                                                                                                                                                                                  | ---                                                                                                                                                                                                                                   |
| [make-create-equipment-use-case.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/factories/make-create-equipment-use-case.cs)           | Generates CreateEquipmentUseCase instance with JsonEquipmentsRepository for ClassroomManager system.                                                                                                                                  |
| [make-consult-equipment-use-case.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/factories/make-consult-equipment-use-case.cs)         | Creates ConsultEquipmentUseCase instance using JsonEquipmentsRepository for managing equipment information. Enables dynamic configuration and easy maintenance of equipment-related functionality within the ClassroomManager system. |
| [make-consult-report-use-case.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/factories/make-consult-report-use-case.cs)               | Creates `MakeConsultReportUseCase` with `JsonReportsRepository` dependency to facilitate generating consultation reports, supporting the Classroom Managers architecture.                                                             |
| [make-authenticate-employee-use-case.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/factories/make-authenticate-employee-use-case.cs) | Creates an authentication use case instance by initializing an employee repository. Enhances the repositorys modularity within the parent repositorys architecture.                                                                   |
| [make-generate-report-use-case.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/factories/make-generate-report-use-case.cs)             | Creates Generate Report use case by instantiating Equipments and Reports repositories, then initializes Generate Report use case with the repositories.                                                                               |
| [make-register-use-case.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/factories/make-register-use-case.cs)                           | Creates a Register Use Case via JsonEmployeesRepository to facilitate employee registration in the ClassroomManager repositorys ecosystem.                                                                                            |

</details>

<details closed><summary>ClassroomManager.usecases.errors</summary>

| File                                                                                                                                                          | Summary                                                                                                                                                                                                                                                |
| ---                                                                                                                                                           | ---                                                                                                                                                                                                                                                    |
| [employee-already-exist.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/errors/employee-already-exist.cs)       | Signals an existing employee within the use cases, enhancing error handling.                                                                                                                                                                           |
| [resource-not-found-error.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/errors/resource-not-found-error.cs)   | Defines custom exception for resource not found error in the usecases folder. Subclass of Exception; provides a message Conteúdo não encontrado. A critical feature in handling missing resources within the ClassroomManager repository architecture. |
| [invalid-credentials-error.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/usecases/errors/invalid-credentials-error.cs) | Defines custom exception for invalid credentials. Enhances error handling within use cases. Extends the parent repositorys architecture by providing specialized error classes for specific scenarios.                                                 |

</details>

<details closed><summary>ClassroomManager.utils</summary>

| File                                                                                                                          | Summary                                                                                                                                           |
| ---                                                                                                                           | ---                                                                                                                                               |
| [GetEquipmentId.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/utils/GetEquipmentId.cs) | Extracts equipment ID from a string using key-value parsing. Crucial for processing equipment data inputs in ClassroomManagers utility functions. |
| [DateFormat.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/utils/DateFormat.cs)         | Formats a given date and time into a specific language format for the ClassroomManager app.                                                       |

</details>

<details closed><summary>ClassroomManager.lib</summary>

| File                                                                                                                                  | Summary                                                                                                                                                                                                                                                             |
| ---                                                                                                                                   | ---                                                                                                                                                                                                                                                                 |
| [bcrypt-provider.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/lib/bcrypt-provider.cs)         | Handles password hashing and verification through the Bcrypt algorithm for secure authentication within the ClassroomManager repository.                                                                                                                            |
| [sharprompt-provider.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/lib/sharprompt-provider.cs) | Enables user input handling through a SharpromptProvider class, offering methods to request integer, string, password, boolean inputs, select options, and multi-select choices. Supports flexible interaction within the ClassroomManager repository architecture. |

</details>

<details closed><summary>ClassroomManager.lib.interfaces</summary>

| File                                                                                                                                                       | Summary                                                                                                                                                                                                                  |
| ---                                                                                                                                                        | ---                                                                                                                                                                                                                      |
| [IBcryptProvider.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/lib/interfaces/IBcryptProvider.cs)                   | Enables secure password hashing and verification for the ClassroomManager system, enhancing data protection and user authentication within the application.                                                              |
| [ISharpromptInputProvider.cs](https://github.com/kaiquecamposdev/ClassroomManager/blob/master/ClassroomManager/lib/interfaces/ISharpromptInputProvider.cs) | Defines interfaces for interacting with input methods in the ClassroomManager. Includes methods for getting integer, string, password, and boolean inputs, as well as selecting options and multi-selecting from a list. |

</details>

---

##  Getting Started

**System Requirements:**

* **CSharp**: `version x.y.z`

###  Installation

<h4>From <code>source</code></h4>

> 1. Clone the  repository:
>
> ```console
> $ git clone https://github.com/kaiquecamposdev/ClassroomManager/
> ```
>
> 2. Change to the project directory:
> ```console
> $ cd 
> ```
>
> 3. Install the dependencies:
> ```console
> $ dotnet build
> ```

###  Usage

<h4>From <code>source</code></h4>

> Run  using the command below:
> ```console
> $ dotnet run
> ```

###  Tests

> Run the test suite using the command below:
> ```console
> $ dotnet test
> ```

---

##  Contributing

Contributions are welcome! Here are several ways you can contribute:

- **[Report Issues](https://github.com/kaiquecamposdev/ClassroomManager/issues)**: Submit bugs found or log feature requests for the `` project.
- **[Submit Pull Requests](https://github.com/kaiquecamposdev/ClassroomManager/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.
- **[Join the Discussions](https://github.com/kaiquecamposdev/ClassroomManager/discussions)**: Share your insights, provide feedback, or ask questions.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/kaiquecamposdev/ClassroomManager/
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="center">
   <a href="https://github.com{/kaiquecamposdev/ClassroomManager/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=kaiquecamposdev/ClassroomManager">
   </a>
</p>
</details>

---

##  License

This project is protected under the [SELECT-A-LICENSE](https://choosealicense.com/licenses) License. For more details, refer to the [LICENSE](https://choosealicense.com/licenses/) file.

---

##  Acknowledgments

- List any resources, contributors, inspiration, etc. here.

[**Return**](#-overview)

---
