﻿using Newtonsoft.Json;
using PaironsTech.ApiHelper.Interfaces;
using System.Collections.Generic;

namespace PaironsTech.ClickUpAPI.V1.Responses.Model
{

    /// <summary>
    /// Model object of Priorities information response
    /// </summary>
    public class ResponseModelPriorities : IResponseModel
    {

        /// <summary>
        /// Check if enabled Priorities
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// List of Model Priority with priorities information
        /// </summary>
        [JsonProperty("priorities")]
        public List<ResponseModelPriority> Priorities { get; set; }

    }

}