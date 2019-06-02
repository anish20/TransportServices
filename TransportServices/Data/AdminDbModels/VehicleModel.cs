using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransportServices.Data.AdminDbModels
{
    [Table("vehicle_entry")]
    public class VehicleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("vehicleNo")]
        public string VehicleNo { get; set; }
        [Column("biltyNo")]
        public string BiltyNo { get; set; }
        [Column("quantity_pmt")]
        public int QuantityPMT { get; set; }
        [Column("invoiceNo")]
        public string InvoiceNo { get; set; }
        [Column("transporterName")]
        public string TransporterName { get; set; }
        [Column("transportName")]
        public string TransportName { get; set; }
        [Column("driverName")]
        public string DriverName { get; set; }
        [Column("driverContact")]
        public long DriverContact { get; set; }
        [Column("vehicleInDate")]
        public DateTime VehicleInDate { get; set; }
        [Column("veheicleOutDate")]
        public DateTime VeheicleOutDate { get; set; }
        [Column("TotalTime")]
        public int TotalTime { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("remark")]
        public string Remark { get; set; }
        
    }
}
