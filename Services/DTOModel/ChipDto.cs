namespace Services.DTOModel
{
    /// <summary>
    /// Logical model of chip.
    /// </summary>
    public class ChipDto
    {
        /// <summary>
        /// Character`s name.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Chip color.
        /// </summary>
        public required string Color { get; set; }
    }
}
