﻿using Newtonsoft.Json;

namespace Chinchilla.ClickUp.Responses.Model
{

	/// <summary>
	/// Model object of Priority information response
	/// </summary>
	public class ResponseModelPriority
		: Helpers.IResponse
	{
		/// <summary>
		/// The id of the Priority
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// The name of the Priority
		/// </summary>
		[JsonProperty("priority")]
		public string Priority { get; set; }

		/// <summary>
		/// The color of the Priority
		/// </summary>
		[JsonProperty("color")]
		public string Color { get; set; }

		/// <summary>
		/// The order of the Priority
		/// </summary>
		[JsonProperty("orderindex")]
		public string OrderIndex { get; set; }
	}
}