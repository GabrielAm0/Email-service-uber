# Email Microservice
## Uber Backend Challenge

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![AWS](https://img.shields.io/badge/AWS-000.svg?style=for-the-badge&logo=amazon-aws&logoColor=white)

This project is an API built using **C#, .NET CORE, AWS Simple Email Service.**

The microservice was developed to demonstrate how to solve the [Uber Backend Challenge](https://github.com/uber-archive/coding-challenge-tools/blob/master/coding_challenge.md)

I chose the Email Service and Amazon SES to implement the backend technical specification.

## Contents

- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)

## Installation

1. Clone the repository:

```bash
git clone https://github.com/GabrielAm0/Email-service-uber.git
```

2. Update `appsettings.json` puting your AWS Credentials

```yaml
aws.accessKeyId=1111111
aws.secretKey=111111
```
## Usage

1. Start the application with .NET
2. The API will be accessible at https://localhost:7262

## API Endpoints
The API provides the following endpoints:

**GET EMAIL**
```markdown
POST /send-email - Send a e-mail from your sender to the destination
```

**BODY**
```json
{
  "to": "example@email.com",
  "subject": "test",
  "body": "test"
}
```

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request to the repository.

When contributing to this project, please follow the existing code style, [commit conventions](https://www.conventionalcommits.org/en/v1.0.0/), and submit your changes in a separate branch.
