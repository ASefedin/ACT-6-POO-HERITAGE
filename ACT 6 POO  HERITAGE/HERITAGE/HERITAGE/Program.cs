﻿// See https://aka.ms/new-console-template for more information
using HERITAGE;

Console.WriteLine("Hello, World!");

Vehicule monVehicule = new Vehicule("bugatti", "chiron", "noir matte", 250000);
string info =  monVehicule.Affiche();
Console.WriteLine(info);
Velo monVelo = new Velo();