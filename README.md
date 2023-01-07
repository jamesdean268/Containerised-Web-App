# Containerised-Web-App
A containerised web application example for learning purposes

## Usage
1. Clone the respository from Github: ``` git clone https://github.com/jamesdean268/Containerised-Web-App.git ```
2. Build the dockerfiles for each of the frontend, backend, and database: 
frontend:
``` 
cd frontend
docker build -t frontend . 
```
backend:
``` 
cd backend
docker build -t backend . 
```
database:
``` 
cd database
docker build -t database . 
```
3. Return to the root directory and run docker compose
```
docker-compose up
```
4. View the item list at [http://localhost:3000](http://localhost:3000)

