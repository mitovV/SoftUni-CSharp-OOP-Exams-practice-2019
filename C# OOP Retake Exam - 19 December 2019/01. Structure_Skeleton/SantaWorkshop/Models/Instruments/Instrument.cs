﻿using SantaWorkshop.Models.Instruments.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Instruments
{
    public class Instrument : IInstrument
    {
        private const int DecreasesEnergyPoints = 10;

        private int power;

        public Instrument(int power)
        {
            Power = power;
        }

        public int Power
        {
            get => power;
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }
                power = value;
            }
        }

        public bool IsBroken() => this.Power == 0;

        public void Use() => this.Power -= DecreasesEnergyPoints;
    }
}