using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DomMezonin.DomainModel.Entity;

namespace DomMezonin.DomainModel.Repository
{
    public class RepositoryContext
    {
        #region private containers

        private IList<Category> categories;
        private IList<Product> products;
        private IList<Image> images;
        private IList<OrderDetails> orderDetailses;
        private IList<Orders> Orderss;

        #endregion

        #region Public Ctors

        public RepositoryContext()
        {
            InitializeContainers();
        }

        #endregion

        #region Private Methods

        private void InitializeImages()
        {
            images = new List<Image>();

            images.Add(new Image
            {
                Id = 0,
                Height = 128,
                Width = 96,
                Path = "images/Categories/SimpleLamps/lamp1.jpg"
            });
            images.Add(new Image
            {
                Id = 1,
                Height = 128,
                Width = 96,
                Path = "images/Categories/SimpleLamps/lamp2.jpg"
            });
            images.Add(new Image
            {
                Id = 2,
                Height = 128,
                Width = 96,
                Path = "images/Categories/SimpleLamps/lamp3.jpg"
            });
            images.Add(new Image
            {
                Id = 3,
                Height = 128,
                Width = 96,
                Path = "images/Categories/ChinaLamps/lamp1.jpg"
            });
            images.Add(new Image
            {
                Id = 4,
                Height = 128,
                Width = 96,
                Path = "images/Categories/ChinaLamps/lamp2.jpg"
            });
            images.Add(new Image
            {
                Id = 5,
                Height = 128,
                Width = 96,
                Path = "images/Categories/ChinaLamps/lamp3.jpg"
            });
            images.Add(new Image
            {
                Id = 6,
                Height = 128,
                Width = 96,
                Path = "images/Categories/RetroLamps/lamp1.jpg"
            });
            images.Add(new Image
            {
                Id = 7,
                Height = 128,
                Width = 96,
                Path = "images/Categories/RetroLamps/lamp2.jpg"
            });
            images.Add(new Image
            {
                Id = 8,
                Height = 128,
                Width = 96,
                Path = "images/Categories/RetroLamps/lamp3.jpg"
            });
        }

        private void InitializeCategories()
        {
            categories = new List<Category>();

            categories.Add( new Category
            {
                Name = "Обычные лампы",
                Description = "Хоть это обычные лампы, но они в тельнягах",
                Id = 0,
                ParentCategory = null,
                Image = images[0]
            });

            categories.Add(new Category
            {
                Name = "Китайские лампы",
                Description = "Сам Лао Цзы ахуел бы от этих ламп, хоть и делали их китайцы",
                Id = 1,
                ParentCategory = null,
                Image = images[3]
            });

            categories.Add(new Category
            {
                Name = "Ретро лампы",
                Description = "Ретро лампы, их в фильме стиляги использовали",
                Id = 2,
                ParentCategory = null,
                Image = images[6]
            });
        }

        private void InitializeProducts()
        {
            products = new List<Product>();
            {
                products.Add(new Product
                {
                    Id = 0,
                    Name = "Лампа",
                    Price = 1000,
                    Category = categories[2],
                    Color = "черный",
                    Quantity = 10,
                    Images = new List<Image>()
                    {
                        images[6],
                        images[7]
                    }
                }
                    );
                products.Add(new Product
                {
                    Id = 1,
                    Name = "Китайская лампа Чи Бу Сань",
                    Price = 899,
                    Category = categories[1],
                    Color = "Белый",
                    Quantity = 7,
                    Images = new List<Image>()
                    {
                        images[3],
                        images[4]
                    }
                }
                    );
                products.Add(new Product
                {
                    Id = 2,
                    Name = "Обычная Лампа, с красивым абажуром",
                    Price = 500,
                    Category = categories[0],
                    Color = "красный",
                    Images = new List<Image>()
                    {
                        images[1],
                        images[2]
                    },
                    Quantity = 100,

                });
                products.Add(new Product
                {
                    Id = 3,
                    Name = "Просто лампочка",
                    Price = 670,
                    Category = categories[0],
                    Color = "красный",
                    Quantity = 100,
                    Images = new List<Image>()
                    {
                        images[0],
                        images[1]
                    }
                }
                    );
                products.Add(new Product
                {
                    Id = 4,
                    Name = "Обычная Лампа, с красивым абажуром",
                    Price = 500,
                    Category = categories[0],
                    Color = "синий",
                    Quantity = 10,
                    Images = new List<Image>()
                    {
                        images[1],
                        images[2]
                    }
                }
                    );
                products.Add(new Product
                {
                    Id = 5,
                    Name = "Обычная Лампа, Шалай балай",
                    Price = 777,
                    Category = categories[0],
                    Color = "красный",
                    Quantity = 100,
                    Images = new List<Image>()
                    {
                        images[0],
                        images[1]
                    }
                }
                    );
                products.Add(new Product
                {
                    Id = 6,
                        Name = "Лампа Хе Бу Лей",
                        Price = 3000,
                        Category = categories[1],
                        Color = "желтый",
                        Quantity = 100,
                         Images = new List<Image>()
                        {
                            images[1],
                            images[2]
                        }
                        }
                    );
                products.Add(new Product
                {
                    Id = 7,
                    Name = "Ретро-фигетро лампень",
                    Price = 500,
                    Category = categories[2],
                    Color = "красный",
                    Quantity = 100,
                    Images = new List<Image>()
                    {
                        images[6],
                        images[7]
                    }
                });
            };
        }

        private void InitializeContainers()
        {
            InitializeImages();
            InitializeCategories();
            InitializeProducts();
        }

        #endregion

        public IList<Category> GetCategories()
        {
            return categories;
        }

        public IList<Product> GetProducts()
        {
            return products;
        }

        public IList<Image> GetImages()
        {
            return images;
        }


    }
}
