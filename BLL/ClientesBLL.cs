using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;
using System.Data.Entity;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes Cliente)
        {
            bool retorno = false;
            try
            {
                 var db = new Parcial2Db();
                db.Cliente.Add(Cliente);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }

        public static bool Eliminar(int ID)
        {
            bool retorno = false;
            var db = new Parcial2Db();
            Clientes cliente = Buscar(ID);
            if (cliente != null)
            {
                db.Entry(cliente).State = EntityState.Deleted;
                db.SaveChanges();
                retorno = true;
            }
            return retorno;
        }

        public static Clientes Buscar(int ID)
        {
            var db = new Parcial2Db();

            return db.Cliente.Find(ID);

        }

        public static void Modificar(Clientes cliente)
        {
            var db = new Parcial2Db();
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();

        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Parcial2Db();

            lista = db.Cliente.ToList();

            return lista;
        }

        public static List<Clientes> GetListaClientes(string nombre)
        {
            List<Clientes> lista = new List<Clientes>();
            Parcial2Db db = new Parcial2Db();
            lista = db.Cliente.Where(p => p.Nombre == nombre).ToList();
            return lista;
        }

        public static List<Clientes> GetListaClienteId(int ClienteId)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Parcial2Db();

            lista = db.Cliente.Where(p => p.ClienteId == ClienteId).ToList();

            return lista;
        }
    }
}
