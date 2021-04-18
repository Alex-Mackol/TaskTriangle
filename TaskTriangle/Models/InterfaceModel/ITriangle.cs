
namespace TaskTriangle.Models.InterfaceModel
{
    interface ITriangle
    {
        string Name { get; }
        double Square { get; }
        double Side1 { get; set; }
        double Side2 { get; set; }
        double Side3 { get; set; }
    }
}
