﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rock.Bus.Message
{
    /// <summary>
    /// Standard Rock Message
    /// </summary>
    public class RockMessage : ICloudEvent<ICollection<RockMessageData>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RockMessage"/> class.
        /// </summary>
        public RockMessage()
        {
            SpecVersion = "1.0";
            Id = Guid.NewGuid();
            Time = RockDateTime.Now;
            DataContentType = "application/json";
        }

        /// <summary>
        /// The spec version
        /// Ex: "1.0"
        /// </summary>
        public string SpecVersion { get; set; }

        /// <summary>
        /// Gets the type.
        /// Ex: "church.online.user.created"
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets the source.
        /// Ex: "https://live.example.church"
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// Ex: "16e8d84c-282e-48e2-9114-6ce02b5c2104"
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time.
        /// Ex: "2018-04-05T17:31:00Z"
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets the type of the data content.
        /// Ex: "application/json"
        /// </summary>
        public string DataContentType { get; set; }

        /// <summary>
        /// Gets or sets the data schema.
        /// Ex: "https://developers.online.church/docs/cloudevents/spec/user"
        /// </summary>
        public string DataSchema { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// Ex: { "key": "value" }
        /// </summary>
        public ICollection<RockMessageData> Data
        {
            get => _data ?? ( _data = new Collection<RockMessageData>() );
            set => _data = value;
        }
        private ICollection<RockMessageData> _data;
    }
}