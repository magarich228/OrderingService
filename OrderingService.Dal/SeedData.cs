using OrderingService.Dal.Models;

namespace OrderingService.Dal
{
    public class SeedData
    {
        public IEnumerable<Client> Clients { get; } = new List<Client>()
            {
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Меркушев Бенедикт Алексеевич",
                    Phone = "89996225028"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Ефимов Аким Лаврентьевич",
                    Phone = "89506225027"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Савин Август Оскарович",
                    Phone = "89506225026"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Воронцов Любомир Антонович",
                    Phone = "89906225025"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Ларионов Аввакуум Христофорович",
                    Phone = "89506335028"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Беляков Демьян Степанович",
                    Phone = "89606225028"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Баранова Марьяна Рудольфовна",
                    Phone = "89506224428"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Зайцева Римма Аристарховна",
                    Phone = "89503335028"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Лазарева Лигия Пётровна",
                    Phone = "89506225268"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Фёдорова Асида Федоровна",
                    Phone = "89506225278"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Дорофеева Георгина Онисимовна",
                    Phone = "89506330270"
                }
            };

        public IEnumerable<Product> Products { get; } = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "IPhone 8s",
                    Price = 67530.50m,
                    Quantity = 12,
                    ProductTypeRefId = ProductType.Electronics,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "ASUS VivoBook 16X M1603QA",
                    Price = 51699m,
                    Quantity = 11,
                    ProductTypeRefId = ProductType.Electronics,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "LED Harper 43F660Y",
                    Price = 15199m,
                    Quantity = 6,
                    ProductTypeRefId = ProductType.Electronics,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "LET Prestigio PTV50SS08X",
                    Price = 23199.9m,
                    Quantity = 7,
                    ProductTypeRefId = ProductType.Electronics,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "AMD Ryzen 7 4700G OEM",
                    Price = 15499.99m,
                    Quantity = 20,
                    ProductTypeRefId = ProductType.Electronics,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Швабра Master House Бачата",
                    Price = 199.99m,
                    Quantity = 33,
                    ProductTypeRefId = ProductType.HouseHoldGoods,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Швабра Master House Джайв",
                    Price = 199.99m,
                    Quantity = 21,
                    ProductTypeRefId = ProductType.HouseHoldGoods,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Чистящее средство для нагревательных элементов электроплит/газовых плит Topper IR 5",
                    Price = 50m,
                    Quantity = 0,
                    ProductTypeRefId = ProductType.HouseHoldGoods,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Набор для ухода для стеклокерамических поверхностей Fiora bio ЭКО 20-002",
                    Price = 199m,
                    Quantity = 5,
                    ProductTypeRefId = ProductType.HouseHoldGoods,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Очиститель для тканей и мебели ОС-Гель",
                    Price = 280m,
                    Quantity = 15,
                    ProductTypeRefId = ProductType.HouseHoldGoods,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Газонокосилка-робот Champion RMB1828",
                    Price = 49499.99m,
                    Quantity = 8,
                    ProductTypeRefId = ProductType.HouseHoldGoods,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "ТВ розетка одинарная Schneider Electric Glossa GSL000391",
                    Price = 199.99m,
                    Quantity = 20,
                    ProductTypeRefId = ProductType.HouseHoldGoods,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Набор инструментов Квалитет 5027038",
                    Price = 5699.9m,
                    Quantity = 9,
                    ProductTypeRefId = ProductType.BuildingMaterialsInstruments,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Набор инструментов Swiss Tools ST-1077",
                    Price = 5799.99m,
                    Quantity = 20,
                    ProductTypeRefId = ProductType.BuildingMaterialsInstruments,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Набор инструментов Дело Техники 600937",
                    Price = 3033m,
                    Quantity = 30,
                    ProductTypeRefId = ProductType.BuildingMaterialsInstruments,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Инструмент для вскрытия техники Rexant 12-4335",
                    Price = 99.99m,
                    Quantity = 20,
                    ProductTypeRefId = ProductType.BuildingMaterialsInstruments,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Отвертка с набором насадок Matrix 11598",
                    Price = 110m,
                    Quantity = 25,
                    ProductTypeRefId = ProductType.BuildingMaterialsInstruments,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Набор инструментов КВТ Профи НИИ-09",
                    Price = 1699m,
                    Quantity = 10,
                    ProductTypeRefId = ProductType.BuildingMaterialsInstruments,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Паяльная станция Rexant 12-0714",
                    Price = 4399m,
                    Quantity = 2,
                    ProductTypeRefId = ProductType.BuildingMaterialsInstruments,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Видеорегистратор 70mai Dash Cam M300",
                    Price = 3199.99m,
                    Quantity = 5,
                    ProductTypeRefId = ProductType.Cars,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Адаптер для скрытого подключения видеорегистратора Roadgid Cord DC",
                    Price = 1199m,
                    Quantity = 10,
                    ProductTypeRefId = ProductType.Cars,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Камера заднего вида Silverstone F1 Interpower IP-662 LED",
                    Price = 799m,
                    Quantity = 6,
                    ProductTypeRefId = ProductType.Cars,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Инвертор DEXP CAR 150W",
                    Price = 750m,
                    Quantity = 0,
                    ProductTypeRefId = ProductType.Cars,
                }
            };

        public IEnumerable<Order> Orders { get; }

        public IEnumerable<OrderProduct> ProductsInOrders { get; }

        public IEnumerable<ClientCredentials> ClientsCredentials { get; }

        public SeedData()
        {
            var rnd = new Random();
            var orders = new List<Order>();
            var clientsLength = Clients.Count();

            for (int i = 0; i < clientsLength * 2; i++)
            {
                orders.Add(new Order()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow.AddDays(rnd.Next(-400, 401)),
                    ClientId = Clients.ElementAt(rnd.Next(0, clientsLength)).Id,
                });
            }

            Orders = orders;
            var productsInOrders = new List<OrderProduct>();

            foreach (var order in Orders)
            {
                int productInOrderCount = rnd.Next(0, 4);

                for (int productNum = 0; productNum < productInOrderCount; productNum++)
                {
                    var product = Products.ElementAt(rnd.Next(0, Products.Count()));
                    int quantity = (rnd.Next(0, 4) == 3) ?
                        1 :
                        rnd.Next(2, 6);

                    productsInOrders.Add(new OrderProduct()
                    {
                        Id = Guid.NewGuid(),
                        OrderId = order.Id,
                        ProductId = product.Id,
                        Quantity = quantity,
                        Price = product.Price * quantity
                    });
                }
            }

            ProductsInOrders = productsInOrders;

            var credentials = new List<ClientCredentials>();

            foreach (var client in Clients)
            {
                credentials.Add(new Models.ClientCredentials
                {
                    ClientId = client.Id,
                    Login = $"user{client.Id}",
                    Password = "qwe12345"
                });
            }

            ClientsCredentials = credentials;
        }
    }
}
