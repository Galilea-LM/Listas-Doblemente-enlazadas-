using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Listas_doblemente_enlazadas
{
    class Inventario
    {
       private Producto inicio;
        Producto temp;


        public Inventario()
        {
            inicio = null;
        }

        void InsertarPrimero(Producto producto)
        {
            Producto nuevo;
            nuevo = producto;
            nuevo.sig = inicio;
            if (inicio != null)
            {
                inicio.ant = nuevo;
            } 
            inicio = nuevo;
        }

        public void InsertarUtlimo(Producto producto)
        {
            Producto nuevo;
            nuevo = producto;
            if (inicio == null)
                inicio = nuevo;
            else
            {
                Producto temp = inicio;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
                nuevo.ant = temp;
            }
        }



        public void BorrarPrimero()
        {
            if (inicio!=null)
            {
                inicio = inicio.sig;
            }
        }

        public void BorrarUltimo()
        {
            if (inicio != null)
            {
                if (inicio.sig == null)
                {
                    inicio = null;
                }
                else
                {
                    Producto temp = inicio;
                    while (temp.sig != null)
                    {
                        temp = temp.sig;
                    }
                    temp = temp.ant;
                    temp.sig = null;
                }
            }

        }
        public string ImprimirNormal()
        {
            String datos = "";
            temp = inicio;
            while (temp != null)
            {
                datos += temp.ToString() + Environment.NewLine;
                temp = temp.sig;
            }
            return datos;
        }

        public string ImprimirInverso()
        {
            String datos = "";
            temp = inicio;
            while (temp != null)
            {
                datos += temp.ToString() + Environment.NewLine;
                temp = temp.ant;
            }
            return datos;
        }

    }
}
