using Capa_Modelo.LD;
using Capa_Modelo.LS;

namespace Capa_Logica.Lista_Simple
{
    public class Orquestador_Lista_Simple
    {

        private NodoInt_LS cabeza;
        private NodoInt_LS final;
        private int tammano = 0;

        private bool Cabeza_No_Nula()
        {

            if (cabeza != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Agregar_NodoInt_LS(int valor)
        {

            NodoInt_LS nodoNuevo = new NodoInt_LS(valor);

            if (!Cabeza_No_Nula())
            {
                cabeza = nodoNuevo;
            }
            else
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
            }
        }



        public void Mostrar_Lista_Simple()
        {

            Console.WriteLine("*-*-*-*Empieza Lista*-*-*-*");
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }
            }
            Console.WriteLine("*-*-*-*Termina Lista*-*-*-*");
        }

        public void Eliminar_Nodos_Seleccionados(int valorNodo, int cantidadNodosABorrar)
        {
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;

                // Buscar el nodo con el valor especificado
                while (nodoActual != null && nodoActual.Valor != valorNodo)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                if (nodoActual != null)
                {
                    NodoInt_LS nodoBorrar = nodoActual.Siguiente;

                    // Borrar la cantidad de nodos especificada
                    for (int i = 0; i < cantidadNodosABorrar; i++)
                    {
                        if (nodoBorrar != null)
                        {
                            nodoActual.Siguiente = nodoBorrar.Siguiente;
                            nodoBorrar = nodoBorrar.Siguiente;
                        }
                        else
                        {
                            break; // Si no hay más nodos disponibles, se detiene el bucle
                        }
                    }
                }
            }
        }



        public double CalcularPromedioElementosMayoresOIguales(int valorReferencia)
            {
                int suma = 0;
                int cantidadElementos = 0;

                if (Cabeza_No_Nula())
                {
                    NodoInt_LS nodoActual = cabeza;

                    while (nodoActual != null)
                    {
                        if (nodoActual.Valor >= valorReferencia)
                        {
                            suma += nodoActual.Valor;
                            cantidadElementos++;
                        }

                        nodoActual = nodoActual.Siguiente;
                    }
                }

                if (cantidadElementos > 0)
                {
                    double promedio = (double)suma / cantidadElementos;
                    return promedio;
                }
                else
                {
                    return 0; // Si no hay elementos mayores o iguales al valor de referencia, se devuelve 0 como promedio.
                }
            }
        }
    }


 