﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces;

namespace RPG.Classes
{
    public abstract class Spearman : ICreature
    {
        public abstract int HealthPoints { get; }
        public abstract int Attack { get; }
        public abstract int Defence { get; }
        public abstract double Speed { get; }
        public abstract int Mana { get; }
        public abstract string Name { get; }
    }