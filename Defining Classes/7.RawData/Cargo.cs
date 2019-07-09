﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo()
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public Cargo(int cargoWeight, string cargoType )
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
    }
}
