# DotNetLogStashLogging

## Overview
DotNetLogStashLogging is an ASP.NET Core 6 application demonstrating the integration with the Elastic Logstash Kibana (ELK) stack. The project utilizes Serilog for logging, emphasizing on transmitting logs in JSON format over UDP. This example provides a basic setup with one action, showcasing parametrized logging capabilities.

## Prerequisites
- .NET Core 6 SDK (For running locally)
- Docker

## Setup and Configuration
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/fuaddev/.net-logstash.git
   ```

## Running the Application
1. **Using Docker:**
   - Use the following command to build and run the application in Docker:
     ```bash
     docker-compose up --build
     ```
   - This will set up the necessary environment including the ELK stack.

2. **Accessing the Application:**
   - Once the application is running, access it at `http://localhost:8081/swagger/index.html`.
   - The application provides a basic example with a single action to demonstrate logging.
   - For Kibana dashboard, go to `http://localhost:5601/`.

## Logging
- The application logs are configured to be sent to Logstash in JSON format over UDP.
- Parametrized logging can be observed in the example action provided.

## Contributing
Contributions to the DotNetLogStashLogging project are welcome. Please follow the standard procedures for contributing to open-source projects, including submitting pull requests and issues.

## License
This project is licensed under the [MIT License](LICENSE).
