using SysDataAccess;
using SysDataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysServises
{
    public class EstuentServices
    {
        //para realizar operaciones CRUD Crear editar eliminar mostrar


        public bool InsertEstuent(Estudiante estudiante)
        {

            if (estudiante != null && estudiante.Id == 0)
            {
                using (ApplicationDbContext database = new ApplicationDbContext())
                {
                    database.Estudiantes.Add(estudiante);
                    database.SaveChanges();
                    return true;
                }
            }

            return false;
        }


        public List<Estudiante> GetEstudiantes() 
        {
            using (ApplicationDbContext database = new ApplicationDbContext())
            {
                return database.Estudiantes.ToList();
            }
        }

        public bool DeleteItem(Estudiante item)
        {

            using (ApplicationDbContext database = new ApplicationDbContext())
            {
                if (item != null && item.Id > 0)
                {
                    database.Estudiantes.Remove(item);
                    database.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}
