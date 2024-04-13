using System.ComponentModel.DataAnnotations;

namespace ClassroomManager.models.interfaces
{
    public enum STATUS
    {
        AVAILABLE,
        RESERVED,
        BORROWED,
    }
    public interface IEquipment
    {
        string Id { get; }
        [Required(ErrorMessage = "Nome é requirido")]
        string Name { get; set; }
        [Required(ErrorMessage = "Modelo é requirida")]
        string Model { get; set; }
        [Required(ErrorMessage = "Marca é requirida")]
        string? Description { get; set; }
        int Quantity { get; set; }
        [Required(ErrorMessage = "Status é requirido")]
        STATUS Status { get; set; }
    }
}
