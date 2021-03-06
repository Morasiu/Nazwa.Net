﻿using System;
using Newtonsoft.Json;

namespace CatFacts.Net.Models {
	public class Fact {
		/// <summary>
		/// Unique ID for the Fact
		/// </summary>
		[JsonProperty("_id")]
		public string Id { get; set; }

		/// <summary>
		/// Version number of the Fact
		/// </summary>
		[JsonProperty("__v")]
		public int? V { get; set; }

		/// <summary>
		/// ID of the User who added the Fact
		/// </summary>
		public string User { get; set; }

		/// <summary>
		/// The Fact itself
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Date in which Fact was last modified
		/// </summary>
		public DateTime? UpdatedAt { get; set; }

		/// <summary>
		/// If the Fact is meant for one time use, this is the date that it is used
		/// </summary>
		public DateTime? SendDate { get; set; }

		/// <summary>
		/// Whether or not the Fact has been deleted (Soft deletes are used)
		/// </summary>
		public bool? Deleted { get; set; }

		/// <summary>
		/// Indicates who added the fact to the DB
		/// </summary>
		public Source? Source { get; set; }

		/// <summary>
		/// Whether or not the Fact has been sent by the CatBot. This value is reset each time every Fact is used
		/// </summary>
		public bool? Used { get; set; }

		/// <summary>
		/// Type of animal the Fact describes (e.g. ‘cat’, ‘dog’, ‘horse’)
		/// </summary>
		public string Type { get; set; }
	}

	public enum Source {
		User,
		Api
	}
}