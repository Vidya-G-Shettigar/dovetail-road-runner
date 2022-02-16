# RoadRunner

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 12.2.0.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.


# To Run Docker UI below are the commands that are to be used


1) The Dockerfile is already available in the RoadRunner.Ui Project

after pointing the location on the UI directory below commands needs to be executed

    CMD 1: 
        docker build -t <tagname> .
    ex:
       docker build -t roadrunnerclient .


After the sucessfull build, Run the below command to host the environment
    CMD 2: 
        docker run -it -p<portnumber>:80 --name <container tag name> <image name>
    ex:
        docker run -it -p 4300:80 --name roadrunner_ui roadrunnerclient
		
# To Know all Running Container 

	CMD 3: docker ps -a

# To Stop a running container

	cmd 4: 
		docker stop <container Id>

	ex: docker stop 9fcc233edef

# To View all images

	cmd 5: docker images 


# to remove an existing Images

	cmd 6: 
		docker rmi <image id>

	ex: 
		docker rmi 9tced676ef2
		
# If the image is not getting deleted and throwing error. below command will help to remove the image

	cmd 7: 
		docker rmi <image id> -force

	ex: 
	docker rmi 9tced676ef2 --force
		