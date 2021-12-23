using MyCompany.MyGarage.Models.Exceptions;
using System;
using System.Diagnostics;

namespace MyCompany.MyGarage.Models
{
    [DebuggerDisplay("Id = {Id}, Type = {Type}")] // This attribute allow a better display of this instance in VS debug view
    public abstract class VehicleBase
    {

        /// <summary>
        /// Initialize a new <see cref="VehicleBase"/>
        /// </summary>
        public VehicleBase()
        {
            _id = Guid.NewGuid();
            _garageId = null;
        }

        private readonly Guid _id;
        /// <summary>
        /// Gets the vehicle unique identifier
        /// </summary>
        public Guid Id
        {
            get { return _id; }
        }


        private int? _garageId;
        /// <summary>
        /// Sets the garage identifier
        /// </summary>
        internal int? GarageId
        {
            set 
            {
                if (value <= 0) throw new MyGarageException($"You cannot set a garade with an identifier lower or equal than 0 (current : {value} for the vehicle {_id}");

                _garageId = value;
            }
            get { return _garageId; }
        }

        /// <summary>
        /// Gets value indicating if the vehicle is currently park or not
        /// </summary>
        public bool IsPark
        {
            get { return _garageId != null; }
        }

        /// <summary>
        /// Gets the vehicle type
        /// </summary>
        public abstract VehicleType Type { get; }
    }
}
