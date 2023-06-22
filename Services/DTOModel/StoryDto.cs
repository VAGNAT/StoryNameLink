namespace Services.DTOModel
{
    /// <summary>
    /// Logical model of history.
    /// </summary>
    public class StoryDto
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// History text.
        /// </summary>
        public required string Text { get; set; }

        /// <summary>
        /// Collection of chips.
        /// </summary>
        public Dictionary<string, ChipDto>? Chips { get; set; }
    }
}
