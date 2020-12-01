#!/usr/bin/env bash
# Initializes & builds a new C# project
dotnet new console -n 1-new_project
dotnet build 1-new_project/1-new_project.csproj
