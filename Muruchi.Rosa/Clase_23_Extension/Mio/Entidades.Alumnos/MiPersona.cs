using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades.Alumnos
{
  public class MiPersona :PersonaExterna  
  {

    public MiPersona (string nombre, string apellido, int edad, ESexo sexo) :base(nombre,apellido,edad,(Entidades.Externa.ESexo)edad)
    {

    }
    
  }
}
