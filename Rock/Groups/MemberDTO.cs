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
    /// Data Transfer Object for Member object
    /// </summary>
    public partial class MemberDto : IDto
    {

#pragma warning disable 1591
        public bool IsSystem { get; set; }
        public int GroupId { get; set; }
        public int PersonId { get; set; }
        public int GroupRoleId { get; set; }
        public int Id { get; set; }
        public Guid Guid { get; set; }
#pragma warning restore 1591

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public MemberDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="member"></param>
        public MemberDto ( Member member )
        {
            CopyFromModel( member );
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is Member )
            {
                var member = (Member)model;
                this.IsSystem = member.IsSystem;
                this.GroupId = member.GroupId;
                this.PersonId = member.PersonId;
                this.GroupRoleId = member.GroupRoleId;
                this.Id = member.Id;
                this.Guid = member.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is Member )
            {
                var member = (Member)model;
                member.IsSystem = this.IsSystem;
                member.GroupId = this.GroupId;
                member.PersonId = this.PersonId;
                member.GroupRoleId = this.GroupRoleId;
                member.Id = this.Id;
                member.Guid = this.Guid;
            }
        }
    }
}
