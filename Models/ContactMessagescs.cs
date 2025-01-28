using System.ComponentModel.DataAnnotations;

namespace WebFormContact.Models
{
    public class ContactMessagescs
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no puede exceder los 75 caracteres")]
        [StringLength(75, ErrorMessage = "El correo no puede exceder los 75 caracteres")]
        public string Correo { get; set; }
        

        [Required(ErrorMessage = "El Mensaje es obligatorio")]
        [StringLength(150, ErrorMessage = "El mensaje no puede exceder los 150 caracteres")]
        public string Mensaje { get; set; }
       

    }
}
