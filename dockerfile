# Use the official .NET SDK image for development.
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Install the EF Core CLI global tool.
RUN dotnet tool install --global dotnet-ef --version 9.0.1

# Add the directory where global tools are installed to the PATH.
ENV PATH="/root/.dotnet/tools:${PATH}"

# Set the working directory in the container.
WORKDIR /app

# Copy the project file and restore dependencies first (for caching).
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code.
COPY . ./

# Expose port 80 (the app will listen on this port).
EXPOSE 80

# Start the app using dotnet watch for live reload (binds to 0.0.0.0 to listen on all network interfaces).
CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:80"]

