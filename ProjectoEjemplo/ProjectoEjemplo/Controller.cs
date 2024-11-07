using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoEjemplo
{
    internal class Controller
    {
        public Controller() { }

        public bool RegistrarLibro(tienda tienda, libro libro)
        {
            if (BuscarPorIsbn(tienda,libro.ISBN) != null){
                throw new Exception("Existe otro libro registrado con ese ISBN");
            }
            
            for (int i = 0; i < tienda.Catalogo.Length; i++) {
                if (tienda.Catalogo[i] == null) {
                    tienda.Catalogo[i] = libro;
                    return true;
                }
            }
            return false;
        }

        public libro BuscarPorIsbn(tienda tienda, int iSBN)
        {
            foreach(libro lib in tienda.Catalogo){
                if (lib !=null && lib.ISBN == iSBN) { 
                    return lib;
                }
            }
            return null;
        }

        public bool EliminarLibro(tienda tienda, int iSBN)
        {
            libro lib = BuscarPorIsbn(tienda, iSBN);
            if (lib == null)
            {
                throw new Exception("NO Existe un libro registrado con ese ISBN");
            }

            for (int i = 0; i < tienda.Catalogo.Length; i++)
            {
                if (tienda.Catalogo[i] == lib)
                {
                    tienda.Catalogo[i] = null;
                    return true;
                }
            }
            return false;
        }

        public libro BuscarPorTitulo(tienda tienda, string titulo)
        {
            foreach (libro lib in tienda.Catalogo)
            {
                if (lib != null && lib.Titulo.ToLower().Equals(titulo.ToLower()))
                {
                    return lib;
                }
            }
            return null;
        }

        public void Abastecer(tienda tienda, int cantidad, int iSBN) { 
            libro lib = BuscarPorIsbn(tienda,iSBN);
            if (lib == null) {
                throw new Exception("No existe un libro registrado con ese ISBN");
            }
            if (tienda.Caja < (lib.Precio_de_compra * cantidad)) {
                throw new Exception("No hay suficiente dinero en caja para esta operacion");
            }
            lib.Cantidad_actual += cantidad;
            tienda.Caja-=(lib.Precio_de_compra*cantidad);
            transaccion trans = new transaccion(lib, new DateTime(), "abastecimiento");
            tienda.TransaccionList.Add(trans);
        }

        public void Venta(tienda tienda, int cantidad, int iSBN)
        {
            libro lib = BuscarPorIsbn(tienda, iSBN);
            if (lib == null)
            {
                throw new Exception("No existe un libro registrado con ese ISBN");
            }
            if (lib.Cantidad_actual < ( cantidad))
            {
                throw new Exception("No hay suficientes ejemplares del libro");
            }
            lib.Cantidad_actual -= cantidad;
            tienda.Caja += (lib.Precio_de_venta * cantidad);
            transaccion trans = new transaccion(lib, new DateTime(), "venta");
            tienda.TransaccionList.Add(trans);
        }

        public libro BuscarMasCostoso(tienda tienda) {
            libro masCostoso = null;
            foreach (libro lib in tienda.Catalogo) {
                if (masCostoso == null && lib != null) { 
                    masCostoso=lib;
                }
                if ((masCostoso != null) && (lib != null) && (masCostoso.Precio_de_compra < lib.Precio_de_compra)) {
                    masCostoso = lib;
                }
            }
            return masCostoso;
        }

        public libro BuscarMenosCostoso(tienda tienda)
        {
            libro menosCostoso = null;
            foreach (libro lib in tienda.Catalogo)
            {
                if (menosCostoso == null && lib != null)
                {
                    menosCostoso = lib;
                }
                if ((menosCostoso != null) && (lib != null) && (menosCostoso.Precio_de_compra > lib.Precio_de_compra))
                {
                    menosCostoso = lib;
                }
            }
            return menosCostoso;
        }

        public int CantidadDeAbastecimientos(tienda tienda, int iSBN) {
            int contador = 0;
            foreach (transaccion trans in tienda.TransaccionList) {
                if (trans.Libro.ISBN == iSBN && trans.Tipo.Equals("abastecimiento")) { 
                contador++;
                }
            }
            return contador;
        }

        public int CantidadDeVentas(tienda tienda, int iSBN)
        {
            int contador = 0;
            foreach (transaccion trans in tienda.TransaccionList)
            {
                if (trans.Libro.ISBN == iSBN && trans.Tipo.Equals("venta"))
                {
                    contador++;
                }
            }
            return contador;
        }

        public libro LibroMasVendido(tienda tienda)
        {
            Dictionary<libro, int> estadisticas = new Dictionary<libro, int>();
            foreach (libro lib in tienda.Catalogo)
            {
                if (lib != null)
                {
                    int cantidad = CantidadDeVentas(tienda, lib.ISBN);
                    estadisticas[lib] = cantidad;
                }
            }
            libro masVendido = null;
            foreach (libro lib in estadisticas.Keys)
            {
                if (masVendido == null)
                {
                    masVendido = lib;
                }
                if ((masVendido != null) && (estadisticas[masVendido] < estadisticas[lib]))
                {
                    masVendido = lib;
                }
            }
            return masVendido;
        }



    }
}
