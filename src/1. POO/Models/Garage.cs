using MyCompany.MyGarage.Models.Exceptions;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyCompany.MyGarage.Models
{
    [DebuggerDisplay("Id = {Id}, Vehicles = {_vehicles.Count}")] // This attribute allow a better display of this instance in VS debug view
    public class Garage
    {
        /// <summary>
        /// Manage the last assigned identifier.
        /// This value must be increment at the creation of a new garage.
        /// </summary>
        private static int LastId = 0;

        /// <summary>
        /// The class who manage logs. The goal is to use logger only
        /// in services.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Initialize a new <see cref="Garage"/>
        /// </summary>
        public Garage(ILogger logger)
        {
            _id = ++LastId;
            _vehicles = new List<VehicleBase>();
            _logger = logger;
        }

        private readonly List<VehicleBase> _vehicles;

        /// <summary>
        /// Gets the vehicle list from the garage
        /// </summary>
        public IEnumerable<VehicleBase> Vehicles
        {
            get { return _vehicles.AsReadOnly(); }
        }

        private readonly int _id;
        /// <summary>
        /// Gets the garage identifier
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Add a vehicle to the garage
        /// </summary>
        /// <param name="vehicleToAdd"></param>
        public void AddVehicle(VehicleBase vehicleToAdd)
        {
            if (vehicleToAdd.IsPark) throw new MyGarageException($"The vehicle {vehicleToAdd.Id} is already parked in the garage {vehicleToAdd.GarageId}.");

            _vehicles.Add(vehicleToAdd);
            vehicleToAdd.GarageId = _id;

            _logger.Information("The vehicle {vehicleId} of type {vehicleType} has been added to the garage {garageId}", vehicleToAdd.Id, vehicleToAdd.Type, _id);
        }

        /// <summary>
        /// Remove a vehicle from the garage
        /// </summary>
        /// <param name="vehicleIdToRemove"></param>
        public void RemoveVehicle(Guid vehicleIdToRemove)
        {
            VehicleBase existingVehicle = null;

            // You can use extension methods with list like FirstOrDefault but basics with foreach works too.
            foreach (var vehicle in _vehicles)
            {
                if(vehicle.Id == vehicleIdToRemove)
                {
                    existingVehicle = vehicle;
                    break;
                }
            }

            if(existingVehicle == null)
            {
                throw new MyGarageException($"The vehicle with identifier {vehicleIdToRemove} not exists in this garage");
            }

            _vehicles.Remove(existingVehicle);
            existingVehicle.GarageId = null;

            _logger.Information("The vehicle {vehicleId} of type {vehicleType} has been removed from the garage {garageId}", existingVehicle.Id, existingVehicle.Type, _id);
        }
    }
}
