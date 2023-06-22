using System.ComponentModel.DataAnnotations;

namespace StoryNameLink.ViewModel
{
    /// <summary>
    /// View model of chip.
    /// </summary>
    public class ChipModel
    {
        /// <summary>
        /// Character`s name.
        /// </summary>
        [RegularExpression(@"(^(?<name>[A-Z][a-z]+:))$",
         ErrorMessage = "Name mismatch. Correct format: \"Clara:\"")]
        public required string Name { get; set; }

        /// <summary>
        /// Chip color.
        /// </summary>
        public required string Color { get; set; }        
    }
}
