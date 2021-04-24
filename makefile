COMPILER = dotnet

main:
	sudo ${COMPILER} build

run: main
	sudo ${COMPILER} run