using System.ComponentModel;

namespace OrderingService.Dal.Models
{
    public enum ProductType
    {
        [Description("Электроника")]
        Electronics = 0,

        [Description("Автомобильные товары")]
        Cars = 1,

        [Description("Стройматериалы и инструменты")]
        BuildingMaterialsInstruments = 2,

        [Description("Всё для дома")]
        HouseHoldGoods = 3
    }
}
