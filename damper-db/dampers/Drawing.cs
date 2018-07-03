using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DamperDB {

    public class Drawing {

        public int id { get; set; }
        public String drawingName { get; set; }
        public int customerId { get; set; }
        public String customerName { get; set; }
        public int buildingId { get; set; }
        public String buildingName { get; set; }
        public int floorId { get; set; }
        public String floorName { get; set; }
        public byte[] drawingOriginal { get; set; }
        public byte[] drawingThumb { get; set; }
        public byte[] drawing { get; set; }
        public int damperId { get; set; }

    }
}