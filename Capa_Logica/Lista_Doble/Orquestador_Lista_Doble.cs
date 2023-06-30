﻿using Capa_Modelo.LD;

namespace Capa_Logica.Lista_Doble
{
    public class Orquestador_Lista_Doble
    {
        private NodoInt_LD cabeza;
        private NodoInt_LD final;
        private int tammano = 0;

        private bool Cabeza_No_Nula()
        {

            return cabeza != null ? true : false;

        }
        public void Agregue_NodoInt_LD_Final(int _valor)
        {

            if (Cabeza_No_Nula())
            {
                //Nodo de referencia
                NodoInt_LD nodoActual = cabeza;

                //Creación del nodo nuevo
                NodoInt_LD nodoNuevo = new NodoInt_LD(_valor);

                //Avanzamos en la lista hasta el último elemento
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                //Agregar  referencia hacia adelante
                nodoActual.Siguiente = nodoNuevo;

                //Agregar  referencia hacia atrás
                nodoNuevo.Anterior = nodoActual;

                //Se define el nuevo final
                final = nodoNuevo;
                tammano++;
            }
            else
            {

                NodoInt_LD nodoNuevo = new NodoInt_LD(_valor);
                cabeza = nodoNuevo;
                final = nodoNuevo;
                tammano++;
            }
        }

        public void Agregue_NodoInt_LD_Inicio(int _valor)
        {

            //Nodo Referencia
            NodoInt_LD nodoActual = cabeza;

            //Creación del nodo nuevo
            NodoInt_LD nodoNuevo = new NodoInt_LD(_valor);

            //Referencia hacia adelante 
            nodoNuevo.Siguiente = nodoActual;

            //Referencia hacia atrás
            nodoActual.Anterior = nodoNuevo;

            //Actualizar la referencia de la cabeza
            cabeza = nodoNuevo;
            tammano++;

        }

        public void Muestre_Lista_Inicio_Fin()
        {

            Console.WriteLine("+-+-+ Empieza Lista Doble +-+-+");
            if (Cabeza_No_Nula())
            {

                //Nodo de referencia
                NodoInt_LD nodoActual = cabeza;

                //Avanzamos en la lista y mostramos el valor
                while (nodoActual != null)
                {

                    Console.WriteLine(nodoActual.Valor);
                    nodoActual = nodoActual.Siguiente;
                }

            }
            Console.WriteLine("+-+-+ Final Lista Doble +-+-+");

        }

        public void Muestre_Lista_Fin_Inicio()
        {

            Console.WriteLine("+-+-+ Final Lista Doble +-+-+");

            if (Cabeza_No_Nula())
            {

                //Nodo de referencia
                NodoInt_LD nodoActual = final;

                //Avanzamos en la lista y mostramos el valor
                while (nodoActual != null)
                {

                    Console.WriteLine(nodoActual.Valor);
                    nodoActual = nodoActual.Anterior;
                }

            }
            Console.WriteLine("+-+-+ Empieza Lista Doble +-+-+");
        }

     

        /// <summary>
        /// Busque el nodo con el primer parametro y luego agrege un nodo despues de
        /// ese nodo con el valor del segundo parametro
        /// </summary>
        /// <param name="_valorBuscado"></param>
        /// <param name="_valorNodo"></param>
        public void Agregue_Nodo_Despues_De_Valor(int _valorBuscado, int _valorNodo)
        {
            if (Cabeza_No_Nula())
            {
                //Nodo de referencia
                NodoInt_LD nodoActual = cabeza;

                while (nodoActual != null && nodoActual.Valor != _valorBuscado)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                if (nodoActual != null)
                {
                    //Creación del nodo nuevo
                    NodoInt_LD nodoNuevo = new NodoInt_LD(_valorNodo);

                    nodoNuevo.Anterior = nodoActual;
                    nodoNuevo.Siguiente = nodoActual.Siguiente;

                    if (nodoActual.Siguiente != null)
                    {
                        nodoActual.Siguiente.Anterior = nodoNuevo;
                    }
                    else
                    {
                        final = nodoNuevo;
                    }

                    nodoActual.Siguiente = nodoNuevo;
                }
            }
        }
     
        }
    }



