using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ClientesTelefonosBLL
    {
        public static bool Guardar(ClientesTelefonos Clientest)
        {
            bool retorno = false;
            try
            {
                var db = new Parcial2Db();
                db.ClientesTelefono.Add(Clientest);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }
        public static ClientesTelefonos Buscar(int ClientesTelefonoId)
        {
            var CleTel = new ClientesTelefonos();
            using (var Conn = new Parcial2Db())
            {
                try
                {
                    CleTel = Conn.ClientesTelefono.Find(ClientesTelefonoId);
                }
                catch (Exception)
                {

                    throw;
                }
                return CleTel;
            }
        }
        public static List<ClientesTelefonos> GetList()
        {
            var lista = new List<ClientesTelefonos>();
            using (var db = new Parcial2Db())
            {
                lista = db.ClientesTelefono.ToList();
                return lista;
            }
        }
    }
}
