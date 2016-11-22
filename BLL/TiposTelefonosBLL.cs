using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TiposTelefonosBLL
    {
        public static bool Guardar(TiposTelefonos TiposTelefono)
        {
            bool retorno = false;
            try
            {
                var db = new Parcial2Db();
                db.TiposTelefono.Add(TiposTelefono);
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
            TiposTelefonos cliente = Buscar(ID);
            if (cliente != null)
            {
                db.Entry(cliente).State = EntityState.Deleted;
                db.SaveChanges();
                retorno = true;
            }
            return retorno;
        }

        public static TiposTelefonos Buscar(int ID)
        {
            var db = new Parcial2Db();

            return db.TiposTelefono.Find(ID);

        }

        public static void Modificar(TiposTelefonos TiposTelefono)
        {
            var db = new Parcial2Db();
            db.Entry(TiposTelefono).State = EntityState.Modified;
            db.SaveChanges();

        }

        public static List<TiposTelefonos> GetLista()
        {
            List<TiposTelefonos> lista = new List<TiposTelefonos>();

            var db = new Parcial2Db();

            lista = db.TiposTelefono.ToList();

            return lista;
        }

        public static List<TiposTelefonos> GetListaTiposTelefonoId(int TipoID)
        {
            List<TiposTelefonos> lista = new List<TiposTelefonos>();

            var db = new Parcial2Db();

            lista = db.TiposTelefono.Where(p => p.TipoId == TipoID).ToList();

            return lista;
        }
    }
}
