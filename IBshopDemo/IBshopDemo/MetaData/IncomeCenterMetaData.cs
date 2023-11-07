using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class IncomeCenterMetaData
    {
        public int IncomecenterId { get; set; }

        public string IncomeCenterName { get; set; } = null!;
    }
    [ModelMetadataType(typeof(IncomeCenterMetaData))]
    public partial class IncomeCenter
    {

    }
}
