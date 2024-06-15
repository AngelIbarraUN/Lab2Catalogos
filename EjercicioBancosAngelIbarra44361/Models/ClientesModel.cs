using EjercicioBancosAngelIbarra44361.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EjercicioBancosAngelIbarra44361.Models;
public class ClientesModel
{
     public string Name { get; set; }
     public string apellido { get; set; }
        public Guid Id  { get; set; }
        public string Direccion { get; set; }

        public string telefono { get; set; }

        public string email  { get; set; }
       
        /*
        public Guid? BancosId { get; set; }
        public BancosModel? BancosModel { get; set; }

        public string BancosName { get; set; }  
        
       public List<SelectListItem> ListaBancos {get; set;}
        */
}