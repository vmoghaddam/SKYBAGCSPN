﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class TempAirport
    {
        public string Id { get; set; }
        public string Ident { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string LatitudeDeg { get; set; }
        public string LongitudeDeg { get; set; }
        public string ElevationFt { get; set; }
        public string Continent { get; set; }
        public string IsoCountry { get; set; }
        public string IsoRegion { get; set; }
        public string Municipality { get; set; }
        public string ScheduledService { get; set; }
        public string GpsCode { get; set; }
        public string IataCode { get; set; }
        public string LocalCode { get; set; }
        public string HomeLink { get; set; }
        public string WikipediaLink { get; set; }
        public string Keywords { get; set; }
    }
}
