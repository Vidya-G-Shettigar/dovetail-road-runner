Please use the below command accordingly for creating the project

Pre-requisites of Using the project

- .Net core 3.1 SDK is Needed. 


1) Command to Create a sln file (Must to be done if sln file does not exist)

        dotnet new sln -n <filename>

    ex: 
        dotnet new sln -n RoadRunner-API

2) To add a project to the sln file (Must to be done)

    dotnet sln <path to solution file> add <path to .csproj file>

    ex.
        let us suppose, the current working directory in cmd is where sln file is present , then below command will add project to sln

        dotnet sln RoadRunner-API.sln add .\RoadRunner.API\RoadRunner.Api.Authorization\RoadRunner.Api.Authorization.csproj 


3) To Add a Web APi Project

    Create the required Folder in its place and execute the below command

        dotnet new webapi 

    This will create the project name as Folder name 

    or 

        dotnet new webapi -n <project name>

4) To Add a Class lib

    Create the required Folder in its place and execute the below command

        dotnet new classlib 

    This will create the project name as Folder name 

    or 

        dotnet new classlib -n <project name>

5) To add reference to the project

    cd into the folder where your .csproj is there and execute the below command

        dotnet add reference <path to csproj file>

    ex 
        let us suppose current folder is containing .csproj file , then below command will add reference and need to add reference to generic repo proj

            dotnet add reference ..\..\RoadRunner.GenericRepository\RoadRunner.GenericRepository.csproj

6) To add any nuget to project

    cd into the folder where your .csproj is there and execute the below command
    
        dotnet add package <packagename> 

    ex

        dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
        
        or
        dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 8.1.1


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
		
