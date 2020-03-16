# Redfox Extension
This project is an example extension for the Redfox Server. The DLL file it produces should be put in the Extensions folder in the Redfox Server directory.

## Configuration
In order for the extension to be used by a zone in Redfox Server, you will need to edit the zone config and add the extension name to zone __extensions__ array.

## Custom Message Handlers
Custom message handlers should be created in Messages/Requests or Messages/Responses. Redfox server will detect any __public__ class deriving from _IZoneRequestMessage_ automagically. 

## Custom Zone Authenticators
Custom zone authenticators can be used to implement a login authentication systems for a zone the extension is used in. An authenticator decides if a user should be let into a zone or not.
