using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace VehicleEngineLibrary
{
    class Cars
    {
        #region attributes

        private string model;
        private string make;        
        private int fuel_liters;
        private double maxFuel_liters;

        #endregion

        #region Constructors
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Cars()
        {
            model = "N/A";
            make = "N/A";
            maxFuel_liters = 0;
            fuel_liters = 0;
        }

        /// <summary>
        /// Constructor by setting car make, model and maximum fuel in liters
        /// </summary>
        /// <param name="CarMake">Brand/Make of car</param>
        /// <param name="CarModel">Type of car</param>
        /// <param name="MaximumFuel">Maximum capacity of fuel tank in liters</param>
        public Cars(string CarMake, string CarModel, double MaximumFuel)
        {
            model = CarModel;
            make = CarMake;
            fuel_liters = 0;
            maxFuel_liters = MaximumFuel;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Returns the make of the car
        /// </summary>
        /// <returns>Car Make</returns>
        public string GetModelName()
        {
            return make;
        }

        /// <summary>
        /// Returns the model name of the car
        /// </summary>
        /// <returns>Car Model</returns>
        public string GetModelName()
        {
            return model;
        }

        /// <summary>
        /// Returns the current fuel on the car
        /// </summary>
        /// <returns>Current fuel in liters</returns>
        public double GetCurrentFuel()
        {
            return fuel_liters;
        }

        /// <summary>
        /// Adds fuel in the car
        /// </summary>
        /// <param name="amount">the amount of fuel to add in liters</param>
        public void AddFuel(double amount)
        {
            fuel_liters += amount;
        }
        #endregion
    }
}
