//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Linq;

using Rock.Data;

namespace Rock.Custom.CCVOnline.CommandCenter
{
	/// <summary>
	/// Auth POCO Service class
	/// </summary>
    public partial class RecordingService : Service<Recording>
    {
        public RecordingService()
            : base( new EFRepository<Recording>( new Rock.Custom.CCVOnline.Data.CCVContext() ) )
        {
        }
    }
}
