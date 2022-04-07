## HelloWorld Minimal API
A containerised Hello World application utilising Docker and .NET 6 Minimal API.

To deploy with Docker:
    
    sudo docker build -t minimalapi .
    sudo docker run -d -p 80:80 --name minimalapi minimalapi
