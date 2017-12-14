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
using Rock.Attribute;
using Rock.Extension;
using Rock.Model;

namespace Rock.Pbx
{
    /// <summary>
    /// MEF Component for PBX Systems
    /// </summary>
    [CustomDropdownListField( "Internal Phone Type", "The phone type to that is connected to the PBX.", @"  SELECT 
	dv.[Value] AS [Text],
	dv.[Id] AS [Value]
FROM 
	[DefinedValue] dv
	INNER JOIN [DefinedType] dt ON dt.[Id] = dv.[DefinedTypeId]
WHERE dt.[Guid] = '8345DD45-73C6-4F5E-BEBD-B77FC83F18FD'", true, order: 999 )]
    public abstract class PbxComponent : Component
    {
        public abstract bool SupportsOrigination { get; }

        public abstract bool Originate( string fromPhone, string toPhone, string callerId, out string message );

        public abstract bool Originate( Person fromPerson, string toPhone, string callerId, out string message );

        public abstract string DownloadCdr( DateTime? startDate = null );
    }

}