using Capa_Logica.Cola;
using Capa_Logica.Lista_Doble;
using Capa_Logica.Lista_Simple;

Orquestador_Lista_Simple orquestador_LS = new Orquestador_Lista_Simple();
Orquestador_Lista_Doble orquestador_LD = new Orquestador_Lista_Doble();
Orquestador_Cola orquestador_Cola   = new Orquestador_Cola();


//Examen hecho por Pablo Amador Jiménez.
//COLAS

/*orquestador_Cola.Enqueue(1);
orquestador_Cola.Enqueue(2);
orquestador_Cola.Enqueue(3);
orquestador_Cola.Enqueue(4);
orquestador_Cola.Imprimir_Cola();
Console.WriteLine(orquestador_Cola.Sume_Elementos_En_Cola());*/

//LISTA DOBLE
//Agregue_Nodo_Despues_De_Valor()
/*
orquestador_LD.Agregue_NodoInt_LD_Final(1);
orquestador_LD.Agregue_NodoInt_LD_Final(2);
orquestador_LD.Agregue_NodoInt_LD_Final(3);
orquestador_LD.Agregue_NodoInt_LD_Final(4);
orquestador_LD.Agregue_NodoInt_LD_Final(5);
orquestador_LD.Agregue_NodoInt_LD_Final(6);
orquestador_LD.Muestre_Lista_Inicio_Fin();
orquestador_LD.Agregue_Nodo_Despues_De_Valor( 1,5 );
orquestador_LD.Muestre_Lista_Inicio_Fin();
*/
//LISTA SIMPLE


// Agregar elementos a la lista
orquestador_LS.Agregar_NodoInt_LS(1);
orquestador_LS.Agregar_NodoInt_LS(2);
orquestador_LS.Agregar_NodoInt_LS(3);
orquestador_LS.Agregar_NodoInt_LS(4);
orquestador_LS.Agregar_NodoInt_LS(5);
orquestador_LS.Agregar_NodoInt_LS(6);

int valorNodo = 10;
int cantidadNodosABorrar = 4;
orquestador_LS.Eliminar_Nodos_Seleccionados(valorNodo, cantidadNodosABorrar);

// Mostrar la lista después de borrar los nodos
orquestador_LS.Mostrar_Lista_Simple();



/*
orquestador_LS.Agregar_NodoInt_LS(1);
orquestador_LS.Agregar_NodoInt_LS(5);
orquestador_LS.Agregar_NodoInt_LS(3);
orquestador_LS.Agregar_NodoInt_LS(4);
orquestador_LS.Mostrar_Lista_Simple();
*/

// Agregar elementos a la lista
/*
orquestador_LS.Agregar_NodoInt_LS(15);
orquestador_LS.Agregar_NodoInt_LS(22);
orquestador_LS.Agregar_NodoInt_LS(32);
orquestador_LS.Agregar_NodoInt_LS(42);

int valorReferencia = 10;
double promedio = orquestador_LS.CalcularPromedioElementosMayoresOIguales(valorReferencia);

Console.WriteLine("El promedio de los elementos mayores o iguales a {0} es: {1}", valorReferencia, promedio);
*/

