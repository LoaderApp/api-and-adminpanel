//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoaderApiAndAdmin.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Nullable<int> VehicleImgId { get; set; }
        public string VehicleRegNo { get; set; }
        public string VehicleName { get; set; }
        public string VehichleCompany { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleNoOfWheels { get; set; }
        public string VehicleLength { get; set; }
        public string VehicleWidth { get; set; }
        public string VehichleHeight { get; set; }
        public Nullable<bool> VehicleIsBooked { get; set; }
    
        public virtual Image Image { get; set; }
        public virtual User User { get; set; }
    }
}
