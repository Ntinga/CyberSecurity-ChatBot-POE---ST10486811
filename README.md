# CyberSecurity ChatBot POE - ST10486811
Part 1 Submission

UIClass.cs
This utility class manages the "Enhanced Console UI" by handling all visual and formatting elements. It uses a static structure to provide an ASCII logo header and a custom typeMessage method that simulates a conversational typing effect through thread delays. By centralizing color management and decorative borders here, the application maintains a consistent, professional look for South African users.


ChatbotClass.cs
As the primary logic engine, this file handles user interaction, voice integration, and the response system. It utilizes the System.Media namespace to trigger a recorded .wav greeting upon launch and employs a while loop to maintain a continuous dialogue. The class features keyword-based decision logic and robust input validation to ensure that empty or unsupported queries are handled gracefully with helpful default prompts.


Program.cs
This file serves as the application's entry point, orchestrating the execution flow between the UI and the Chatbot logic. It follows clean code principles by keeping the Main method slim, focusing only on initializing the components in the correct sequence: audio playback, visual branding, and the start of the interactive session. This separation of concerns ensures the code is readable, modular, and easy to maintain for future updates.

