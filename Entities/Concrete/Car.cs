using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; } //id
        public int BrandId { get; set; } //marka id
        public int ColorId { get; set; } //renk id
        public int ModelYear { get; set; } //model yılı
        public double DailyPrice { get; set; } //günlük ücret
        public string Description { get; set; } // tanım

    }
}
