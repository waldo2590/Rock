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
using System.Linq;

using Rock.Data;

namespace Rock.Cms
{
    /// <summary>
    /// Block Service class
    /// </summary>
    public partial class BlockService : Service<Block, BlockDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockService"/> class
        /// </summary>
        public BlockService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockService"/> class
        /// </summary>
        public BlockService(IRepository<Block> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override Block CreateNew()
        {
            return new Block();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<BlockDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<BlockDto> QueryableDto( IQueryable<Block> items )
        {
            return items.Select( m => new BlockDto()
                {
                    IsSystem = m.IsSystem,
                    PageId = m.PageId,
                    Layout = m.Layout,
                    BlockTypeId = m.BlockTypeId,
                    Zone = m.Zone,
                    Order = m.Order,
                    Name = m.Name,
                    OutputCacheDuration = m.OutputCacheDuration,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }
    }
}
