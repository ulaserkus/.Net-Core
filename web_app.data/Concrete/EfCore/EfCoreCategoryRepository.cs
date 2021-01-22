using System;
using System.Collections.Generic;
using web_app.data.Abstract;
using web_app.entity;

namespace web_app.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category,ShopContext>,ICategoryRepository
    {

    }
}
