using System;
using System.Collections.Generic;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    //public class FakeProductRepository : IRepository<Product>
    //{
    //    private Dictionary<long, Product> products;

    //    public FakeProductRepository()
    //    {
            
    //    }

    //    /// <summary>
    //    /// Инициализация хранилища продуктов
    //    /// </summary>
    //    public void InitializeProducts()
    //    {
    //        products = new Dictionary<long, Product>
    //        {
    //            {
    //                0, new Product
    //                {
    //                    Id = 0,
    //                    Name = "Лампа",
    //                    Price = 1000,
    //                    Category = new Category()
    //                    {
    //                        Id = 0,
    //                        Description = "Ретро лампы",
    //                        Image = new Image
    //                        {
    //                            Id = 0,
    //                            Height = 100,
    //                            Width = 100,
    //                            Path = "Content/Images/Lamps/Retro/retro1.jpg"
    //                        }
    //                    },
    //                    Color = "черный",
    //                    Quantity = 10
    //                }
    //            },
    //           {
    //                0, new Product
    //                {
    //                    Id = 1,
    //                    Name = "Китайская лампа Чи Бу Сань",
    //                    Price = 899,
    //                    Category = new Category()
    //                    {
    //                        Id = 1,
    //                        Description = "Китайские лампы",
    //                        Image = new Image
    //                        {
    //                            Id = 1,
    //                            Height = 100,
    //                            Width = 100,
    //                            Path = "Content/Images/Lamps/China/ChiBuSan.jpg"
    //                        }
    //                    },
    //                    Color = "Белый",
    //                    Quantity = 7
    //                }
    //            },
    //            {
    //                2, new Product
    //                {
    //                    Id = 2,
    //                    Name = "Обычная Лампа, с красивым абажуром",
    //                    Price = 500,
    //                    Category = new Category()
    //                    {
    //                        Id = 2,
    //                        Description = "Обычные лампы",
    //                        Image = new Image
    //                        {
    //                            Id = 2,
    //                            Height = 100,
    //                            Width = 100,
    //                            Path = "Content/Images/Lamps/Simple/W34SimpleLamp.jpg"
    //                        }
    //                    },
    //                    Color = "красный",
    //                    Quantity = 100
    //                }
    //            }
    //        };
    //    }

    //    public Product GetProductById(long id)
    //    {
    //        if (products.ContainsKey(id))
    //        {
    //            return products[id];
    //        }
    //        return null;
    //    }

    //    public Product GetEntityById(long id)
    //    {
    //        //TODO: Реализовать метод, который будет брать из хранилища продукт по IDшнику
    //        return null;
    //    }

    //    public IList<Product> GetEntities()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IList<Product> GetEntities(SpecialSearchParameters searchParameters)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool CreateEntity(Product entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool UpdateEntity(Product entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool DeleteEntity(Product entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool CreateEntities(IEnumerable<Product> entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool UpdateEntities(IEnumerable<Product> entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool DeleteEntities(IEnumerable<Product> entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
