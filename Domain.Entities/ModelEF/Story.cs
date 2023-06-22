using Domain.Entities.ModelEF.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.ModelEF
{
    /// <summary>
    /// History model data base
    /// </summary>
    public class Story : IEntity<int>
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// History text
        /// </summary>
        [Required]
        public required string Text { get; set; }        
    }
}