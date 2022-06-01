# Dotnet Core Web Api and Repository Pattern

### Create a SQL Server database in Docker

Create a new container with the SQL Server 2019 Ubuntu Linux image:

```sh
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=My@Passw0rd" -p 1433:1433 --name sql1 -d mcr.microsoft.com/mssql/server:2019-latest
```

Edit the DefaultConnection string in the `appsettings.json` file:

`"DefaultConnection": "Server=localhost,1433; Database=CompanyEmployee; User Id=sa; Password=My@Passw0rd;"`

In case you want to access the container, run this command:

```sh
docker exec -it sql1 "bash"
```

Stop and remove the container when needed:

```sh
docker stop sql1 && docker rm sql1
```

### Migrations

Create the database based on the current migrations:

```sh
dotnet ef database update
```

If you need to add more migrations, run this command:

```sh
dotnet ef migrations add MyNewMigration
```

### Get Data

Use Postman or the browser to fetch some data:

[https://localhost:5001/api/companies](https://localhost:5001/api/companies)
