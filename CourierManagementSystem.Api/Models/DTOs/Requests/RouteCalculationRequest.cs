using System.ComponentModel.DataAnnotations;

namespace CourierManagementSystem.Api.Models.DTOs.Requests;

public class RouteCalculationRequest
{
    [Required(ErrorMessage = "Точки маршрута обязательны")]
    [MinLength(2, ErrorMessage = "Требуется минимум 2 точки маршрута")]
    public List<RoutePoint> Points { get; set; } = new();
}

public class RoutePoint
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}
