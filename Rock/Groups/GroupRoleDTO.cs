//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

using Rock.Data;

namespace Rock.Groups
{
    /// <summary>
    /// Data Transfer Object for GroupRole object
    /// </summary>
    public partial class GroupRoleDto : IDto
    {

#pragma warning disable 1591
        public bool IsSystem { get; set; }
        public int? GroupTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Order { get; set; }
        public int Id { get; set; }
        public Guid Guid { get; set; }
#pragma warning restore 1591

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public GroupRoleDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="groupRole"></param>
        public GroupRoleDto ( GroupRole groupRole )
        {
            CopyFromModel( groupRole );
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is GroupRole )
            {
                var groupRole = (GroupRole)model;
                this.IsSystem = groupRole.IsSystem;
                this.GroupTypeId = groupRole.GroupTypeId;
                this.Name = groupRole.Name;
                this.Description = groupRole.Description;
                this.Order = groupRole.Order;
                this.Id = groupRole.Id;
                this.Guid = groupRole.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is GroupRole )
            {
                var groupRole = (GroupRole)model;
                groupRole.IsSystem = this.IsSystem;
                groupRole.GroupTypeId = this.GroupTypeId;
                groupRole.Name = this.Name;
                groupRole.Description = this.Description;
                groupRole.Order = this.Order;
                groupRole.Id = this.Id;
                groupRole.Guid = this.Guid;
            }
        }
    }
}
