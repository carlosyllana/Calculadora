Funcionamiento:
	Esta soluci�n consta de tres proyecto
	El primero tiene una interfaz con los metodos (Suma, resta, multiplicaci�n, divisi�n) que se llama Icalculadora. Tambi�n
		est� la clase que la implementa Calculadora.
	En el segundo se realizan tests de Integracion.
	En el tercero se reailzan tests de Integraci�n mediante xUnit.

C�mo Ejecutarlo:
	El primer proyecto no se ejecutar�.
	Para realizar el de integreaci�n del propio Visual Studio, tendremos que cargar nuestro proyecto en el propio visual studio y ejecutarlo mediante Pruebas->Ejecutar Pruebas->(Seleccionar tipo de pruebas)
	Para realizar los tests en XUNIT, tendremos que buscar la localizaci�n del xunit.console.exe y ejecutarlo hacia la dll del proyecto que hemso creado. Un ejemplo ser�a:
	>packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.exe PooVuelingXunitTests\bin\Debug\PooVuelingXunitTests.dll