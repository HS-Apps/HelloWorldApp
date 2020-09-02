#HelloWorld

There are 2 primary projects

**HelloWorldAPI**
==================
    API Endpoint http://localhost:56485/message

    HelloWorld.Service supports the API

    HelloWorld.Test has unit test cases for API
    
    The API Endpoint will be behind API Gateway
    
    
**HelloWorldApplication**
========================
    HelloWorldMessage calls HelloWorldAPI and gets the Hello World message and then calls HelloWorldMessage.Service to process the message 
    
    HelloWorldMessage.Service module supports writing to console and has starting point for future concerns like writing to the database

