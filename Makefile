# Project Variables

PROJECT_NAME ?= Books

.PHONY: migrations db hello

migrations:
	cd .\BooksApp.Data && dotnet ef --startup-project ..\BooksApp.Web migrations add $(mname) && cd ..
	
db: 
	cd .\BooksApp.Data && dotnet ef --startup-project ..\BooksApp.Web database update && cd ..
	
hello: 
	echo "Welcome" + $(username)


