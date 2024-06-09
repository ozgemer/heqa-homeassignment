# heqa home assignment
link to docker hub: https://hub.docker.com/repository/docker/ozgemer/heqa-assignment/general.
# download the docker image:
```
docker run -d -p 5000:5000 -p 5001:5001 -e ASPNETCORE_HTTP_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 ozgemer/heqa-assignment
```

The endpoint is set to /networkinfo
