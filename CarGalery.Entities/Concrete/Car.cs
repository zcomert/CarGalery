﻿using CarGalery.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGalery.Entities.Concrete
{
    public class Car : IEntity
    {
        // En az üç alan - üç farklı tip
        public int CarId { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {

        }
        public Car(string model, decimal price)
        {
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"{CarId,-5} {Model,-30} {Price,-10}";
        }
    }
}
