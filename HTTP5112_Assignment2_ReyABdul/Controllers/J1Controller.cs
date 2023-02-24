using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment2_ReyABdul.Controllers
{
    //Process into solving proble:
    //1. Arrange each food item into a categories with assigned number (create an array and designate each digit choice w/ corresponding calories)
    //2. Set route template to feature each category
    //3. Input numbers in URI to see if corresponding calories from each catogories is displayed
    //4. Return Calorie Total


    /// <summary>
    /// 
    /// </summary>

    public class J1Controller : ApiController
    {

        
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetTotalCalories(int burger, int drink, int side, int dessert)
        {
             /// <summary>
            /// Calculates total calories of selected food items from each category.
            /// </summary>
            /// <param name="burger"></param>
            /// <param name="drink"></param>
            /// <param name="side"></param>
            /// <param name="dessert"></param>
            /// <example>GET api/IFpractice/Menu/4/4/4/4 -> Your total calorie count is 0</example>
            /// <example>GET api/IFpractice/Menu/1/2/3/4 -> Your total calorie count is 691</example>
            /// <returns>Total calories of selected food items from each category.</returns>
            /// 


            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sideCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 157, 266, 75, 0 };

            //Burger
            if (burger == 1)
            {
               burger = burgerCalories[0];

            } else if (burger == 2) 
            {
                burger = burgerCalories[1];

            } else if (burger == 3)
            {
                burger = burgerCalories[2];

            } else
            {
                burger = burgerCalories[3];
            }

            //Drink
            if (drink == 1)
            {
                drink = drinkCalories[0];

            }
            else if (drink == 2)
            {
                drink = drinkCalories[1];

            }
            else if (drink == 3)
            {
                drink = drinkCalories[2];

            }   
            else
            {
                drink = drinkCalories[3];
            }

            //Side
            if (side == 1)
            {
                side = sideCalories[0];

            }
            else if (side == 2)
            {
                side = sideCalories[1];

            }
            else if (side == 3)
            {
                side = sideCalories[2];

            }
            else
            {
                side = sideCalories[3];
            }

            //Dessert
            if (dessert == 1)
            {
                dessert = dessertCalories[0];
                
            }
            else if (dessert == 2)
            {
                dessert = dessertCalories[1];

            }
            else if (dessert == 3)
            {
                dessert = dessertCalories[2];

            }
            else
            {
                dessert = dessertCalories[3];
            }

            return $"Your total calorie count is {burger + drink + side + dessert}";
        }
    }
}
