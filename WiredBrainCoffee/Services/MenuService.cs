﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public class MenuService : IMenuService
    {
        public List<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>()
            {
                new MenuItem()
                {
                    Name = "Frosted Pumpkin Bread",
                    Summary = "A seasonal delight we offer every autumn.  Pumpking bread with just a bit of spice, cream cheese frosting with just a hint of home.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "pumpkinbread.png",
                    Id = 1,
                    Calories = 1,
                    Fat = 1,
                    SaturatedFat = 1,
                    Fiber = 1,
                    Sugar = 1
                },
                new MenuItem()
                {
                    Name = "Ground to Go",
                    Summary = "Love our coffee? Take it with you so you never have to be without!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "ground.png",
                    Id = 2,
                    Calories = 2,
                    Fat = 2,
                    SaturatedFat = 2,
                    Fiber = 2,
                    Sugar = 2
                },
                new MenuItem()
                {
                    Name = "Granola with Nuts",
                    Summary = "It's not flashy, but it sure is healthy.  Perfect for when you need the calories, but not the guilt.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "granola.png",
                    Id = 3,
                    Calories = 3,
                    Fat = 3,
                    SaturatedFat = 3,
                    Fiber = 3,
                    Sugar = 3
                },
                new MenuItem()
                {
                    Name = "Bean there, done that!",
                    Summary = "Do you prefer to grind your own coffee? No problem, we'll give you the beans.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "beans.jpg",
                    Id = 4,
                    Calories = 4,
                    Fat = 4,
                    SaturatedFat = 4,
                    Fiber = 4,
                    Sugar = 4
                },
                new MenuItem()
                {
                    Name = "Fresh Bagels",
                    Summary = "They're just as round as donuts, but far more healthy! Freshly made every morning before sunrise.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "bagel.png",
                    Id = 5,
                    Calories = 5,
                    Fat = 5,
                    SaturatedFat = 5,
                    Fiber = 5,
                    Sugar = 5
                },
                new MenuItem()
                {
                    Name = "Fresh Fruit",
                    Summary = "We've got strawberries, blueberries, apples, bananas - we could list them all, but we'd prefer you come take a look!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "strawberries.png",
                    Id = 6,
                    Calories = 6,
                    Fat = 6,
                    SaturatedFat =6,
                    Fiber = 6,
                    Sugar = 6
                }
            };
        }
    }
}