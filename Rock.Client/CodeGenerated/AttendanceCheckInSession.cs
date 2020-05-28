//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
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


namespace Rock.Client
{
    /// <summary>
    /// Base client model for AttendanceCheckInSession that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class AttendanceCheckInSessionEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public ICollection<Attendance> Attendances { get; set; }

        /// <summary />
        public string ClientIpAddress { get; set; }

        /// <summary />
        public int? DeviceId { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source AttendanceCheckInSession object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( AttendanceCheckInSession source )
        {
            this.Id = source.Id;
            this.Attendances = source.Attendances;
            this.ClientIpAddress = source.ClientIpAddress;
            this.DeviceId = source.DeviceId;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for AttendanceCheckInSession that includes all the fields that are available for GETs. Use this for GETs (use AttendanceCheckInSessionEntity for POST/PUTs)
    /// </summary>
    public partial class AttendanceCheckInSession : AttendanceCheckInSessionEntity
    {
        /// <summary />
        public Device Device { get; set; }

    }
}