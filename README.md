# todo-spike
Exploratory project for ASP.NET Core, Docker and SQL Server

`docker-compose up -- build`

`docker-compose -f docker-compose.yml -f docker-compose.prod.yml up`

Production compose has nginx has a loadbalancer. What 3 web apps? No borr...

`docker-compose -f docker-compose.yml -f docker-compose.prod.yml up --scale web=5 --build`

### Why use a reverse proxy server?

Kestrel is great for serving dynamic content from ASP.NET Core; however, the web serving parts aren’t as feature rich as servers like IIS, Apache, or Nginx. A reverse proxy server can offload work like serving static content, caching requests, compressing requests, and SSL termination from the HTTP server. A reverse proxy server may reside on a dedicated machine or may be deployed alongside an HTTP server.