#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

dotnet restore src/notesapi/ && \
    dotnet build src/notesapi/ && \
    echo "Now, run the following to start the project: dotnet run -p src/notesapi/notesapi.csproj --launch-profile web"
