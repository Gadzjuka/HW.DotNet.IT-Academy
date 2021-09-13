using MotorcycleRepoGeneric.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorcycleRepoGeneric.Repositories
{
    static class MotorcycleRepositoryProvider
    {
        public static List<Motorcycle> Motorcycles;

        static MotorcycleRepositoryProvider()
        {
            Log.Information($"MotorcycleRepositoryProvider constructor");
            Motorcycles = new List<Motorcycle>();
        }
    }
}
