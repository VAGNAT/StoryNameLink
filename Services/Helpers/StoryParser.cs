using Services.DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Helpers
{
    /// <summary>
    /// Template and story parser.
    /// </summary>
    public static partial class StoryParser
    {
        /// <summary>
        /// Find names and set color.
        /// </summary>
        /// <param name="story"></param>
        /// <returns></returns>
        public static StoryDto ParseName(this StoryDto story)
        {
            const int colorFrom = 100;
            const int colorTo = 240;
            var random = new Random();
            foreach (var str in story.Text.Split('\n', '\r'))
            {
                if (RegexName().IsMatch(str))
                {
                    if (!(bool)(story.Chips?.ContainsKey(str)!))
                    {
                        story.Chips.Add(str, new ChipDto() { Name = str, Color = $"rgb({random.Next(colorFrom, colorTo)},{colorFrom,colorTo},{colorFrom,colorTo})" });
                    }
                }
            }
            return story;
        }

        /// <summary>
        /// Replace name.
        /// </summary>
        /// <param name="story"></param>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        public static StoryDto ChangeName(this StoryDto story, string oldName, string newName)
        {
            if (oldName == newName)
            {
                return story;
            }
            story.Text = Regex.Replace(story.Text, $"{oldName}", newName);
            ChipDto changeName = story.Chips![oldName];
            story.Chips.Add(newName, new ChipDto() { Name = newName, Color = changeName.Color });
            story.Chips.Remove(oldName);
            return story;
        }

        [GeneratedRegex("(^(?<name>[A-Z][a-z]+:))(\\r||\\n)?$", RegexOptions.Multiline)]
        public static partial Regex RegexName();
    }
}
