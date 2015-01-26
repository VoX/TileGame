# TileGame

## Requirements
Wyvern type game
Uses NServiceKit forked from servicestack 
https://github.com/ServiceStack/ServiceStack
Rest API for pushing to server, Sever Sent Events for pushing to client
https://github.com/ServiceStack/ServiceStack/wiki/Server-Events

Dependency injection using 
https://github.com/ServiceStack/ServiceStack/wiki/The-IoC-container
 

### Ticks
* Used to determine order events

### Zones
* Each zone is kept in a servers memory, 1 zone per server
* Zones consist of tiles, actors, items, and links to other zones
* Tiles are in a 2d grid

### Tiles
* Passability
* GameProperties
* DisplayProperties
* ActiveActions

### Actors
* Position
* Controller
* ActiveActions
* ActiveItems
* Items
* CharacterProperties

### Players
* Username
* Actor
* Session

### Items
* Actions
* ActiveActions

### Actions
* Activate
* Context
* ActivatedOn
* ActivatedBy
* ActivatedTime

## Layout

## API

GET /zone
GET, PUT /zone

GET, PUT /tiles
GET, PUT /tiles/id

GET, POST /actors
GET, PUT, DELETE /actors/id
GET, POST /actors/id/actions
GET, /actors/id/items

GET, POST /items
GET, PUT, DELETE /items/id
GET, POST /items/id/actions

GET, POST /actions
GET /actions/id

