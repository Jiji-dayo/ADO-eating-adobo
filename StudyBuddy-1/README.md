# StudyBuddy

StudyBuddy is a Blazor Server application designed to provide a simple and intuitive platform for users to manage their study activities. The application includes essential features such as user authentication, a dashboard for tracking progress, and a clean, user-friendly interface.

## Features

- **User Authentication**: Users can log in and sign up to access personalized features.
- **Dashboard**: A central hub for users to view their study progress and access various functionalities.
- **Responsive Design**: The application is designed to be visually appealing and easy to navigate on both desktop and mobile devices.

## Project Structure

- **Program.cs**: Entry point of the application, configuring services and the application pipeline.
- **StudyBuddy.csproj**: Project file containing metadata and dependencies.
- **appsettings.json**: Configuration settings for the application.
- **Properties/launchSettings.json**: Settings for launching the application in different environments.
- **_Imports.razor**: Common namespaces and components for Razor files.
- **Pages**: Contains all the Razor pages including:
  - **_Host.cshtml**: Host page for the Blazor application.
  - **Index.razor**: Main landing page.
  - **Login.razor**: Login form for user authentication.
  - **Signup.razor**: Sign-up form for new users.
  - **Dashboard.razor**: Main dashboard for authenticated users.
  - **Error.razor**: Error handling page.
- **Shared**: Contains shared components like:
  - **MainLayout.razor**: Main layout for the application.
  - **NavMenu.razor**: Navigation menu for easy access to different pages.
- **Components**: Contains reusable components:
  - **LoginForm.razor**: Logic and UI for the login form.
  - **SignupForm.razor**: Logic and UI for the sign-up form.
- **Data**: Contains services and models:
  - **AuthenticationService.cs**: Handles authentication logic.
  - **Models/User.cs**: Defines the user entity.
- **wwwroot/css/app.css**: CSS styles for the application.

## Getting Started

To get started with the StudyBuddy application, follow these steps:

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd StudyBuddy
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

5. Open your browser and navigate to `http://localhost:5000` to view the application.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.