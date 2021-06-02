using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jordy_P1_APL2.Models;
using Jordy_P1_APL2.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Jordy_P1_APL2.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos productos)
        {
            if (!Existe(productos.ProductoId))
                return Insertar(productos);
            else
                return Modificar(productos);
        }

        public static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Productos.Any(p => p.ProductoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }

        public static bool Insertar(Productos productos)
        {
            bool siguiente = false;
            Contexto db = new Contexto();

            try
            {
                db.Productos.Add(productos);
                siguiente = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return siguiente;
        }

        public static bool Modificar(Productos productos)
        {
            bool siguiente = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(productos).State = EntityState.Modified;
                siguiente = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return siguiente;
        }

        public static bool Eliminar(int id)
        {
            bool siguiente = false;
            Contexto db = new Contexto();

            try
            {
                var producto = db.Productos.Find(id);

                if (producto != null)
                {
                    db.Productos.Remove(producto);
                    siguiente = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return siguiente;
        }

        public static Productos Buscar(int id)
        {
            Contexto db = new Contexto();
            Productos productos;

            try
            {
                productos = db.Productos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return productos;
        }

        public static List<Productos> GetProductos()
        {
            List<Productos> lista = new List<Productos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Productos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            List<Productos> lista = new List<Productos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Productos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}