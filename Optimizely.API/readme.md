# Setup a SQL Server database

Pull the SQL Server image:

``docker pull mcr.microsoft.com/mssql/server:2019-latest``

## Run the SQL Server image:

``
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=SysteAdminPassword123!@" \
   -p 1433:1433 --name sql1 -h sql1 \
   -d mcr.microsoft.com/mssql/server:2019-latest``

## Create a database user

``create database optimizely;
use optimizely;
CREATE LOGIN optimizely WITH PASSWORD = 'Password123!@';
CREATE USER optimizely FOR LOGIN optimizely;
ALTER SERVER ROLE [sysadmin] ADD MEMBER optimizely;``