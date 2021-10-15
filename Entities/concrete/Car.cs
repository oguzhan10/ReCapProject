using Core1.Entitites;

namespace Entities.concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

    }
}
