Funcionamiento:
	Esta solución consta de tres proyecto
	El primero tiene una interfaz con los metodos (Suma, resta, multiplicación, división) que se llama Icalculadora. También
		está la clase que la implementa Calculadora.
	En el segundo se realizan tests de Integracion.
	En el tercero se reailzan tests de Integración mediante xUnit.

Cómo Ejecutarlo:
	El primer proyecto no se ejecutará.
	Para realizar el de integreación del propio Visual Studio, tendremos que cargar nuestro proyecto en el propio visual studio y ejecutarlo mediante Pruebas->Ejecutar Pruebas->(Seleccionar tipo de pruebas)
	Para realizar los tests en XUNIT, tendremos que buscar la localización del xunit.console.exe y ejecutarlo hacia la dll del proyecto que hemso creado. Un ejemplo sería:
	>packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.exe PooVuelingXunitTests\bin\Debug\PooVuelingXunitTests.dll