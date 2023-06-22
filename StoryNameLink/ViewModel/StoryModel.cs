namespace StoryNameLink.ViewModel
{
    /// <summary>
    /// View model of history.
    /// </summary>
    public class StoryModel : ICloneable
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
        public Dictionary<string, ChipModel>? Chips { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public StoryModel()
        {
                
        }

        /// <summary>
        /// Full constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="chips"></param>
        public StoryModel(int id, string text, Dictionary<string, ChipModel> chips)
        {
            Id = id;
            Text = text;
            Chips = chips;
        }

        /// <summary>
        /// Deep cloning.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new StoryModel(Id, Text, new Dictionary<string, ChipModel>(Chips!) ) { Text = Text };
        }
    }
}
