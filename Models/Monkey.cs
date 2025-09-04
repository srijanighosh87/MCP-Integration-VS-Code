using System;

namespace MCP_with_CSharp.Models;
public class Monkey
	{
        /// <summary>
        /// Monkey Name
        /// </summary>
		public string? Name { get; set; }

        /// <summary>
        /// Monkey Location
        /// </summary>
		public string? Location { get; set; }

        /// <summary>
        /// Monkey Details
        /// </summary>
		public string? Details { get; set; }

        /// <summary>
        /// Monkey Image
        /// </summary>
		public string? Image { get; set; }

        /// <summary>
        /// Monkey Population
        /// </summary>
		public int Population { get; set; }

        /// <summary>
        /// Monkey location Latitude
        /// </summary>
		public double Latitude { get; set; }

        /// <summary>
        /// Monkey location Longitude
        /// </summary>
		public double Longitude { get; set; }
	}
