using DePandaLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DePandaClassLib.Extensions
{
    public static class Extensions
    {
        public static List<Dish> DistinctDishByKey(this List<Dish> dishes)
        {
            List<Dish> TempDishes = new List<Dish>();

            foreach(Dish dish in dishes)
            {
                Dish res = TempDishes.FirstOrDefault(d => d.ID == dish.ID);
                if (res != null)
                {
                    res.Amount += dish.Amount;
                }
                else
                {
                    TempDishes.Add(new Dish() { ID = dish.ID, Amount = dish.Amount, Category = dish.Category, Description = dish.Description, Name = dish.Name, Price = dish.Price });
                }
            }
            return TempDishes;
        }
    }
}
