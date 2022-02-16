echo 'Building WebUI Docker for Dovetail RoadRunner'
#
docker stop drr_ui_client
docker rm drr_ui_client

docker-compose -f ./docker-compose.yml up --build -d

