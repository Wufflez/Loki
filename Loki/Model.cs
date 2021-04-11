using System;
using System.CodeDom;
using System.Linq;

namespace Loki
{
    public class Model
    {
        /// <summary>
        /// Display name for this model
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Internal index for the model.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Creates a model from in internal player model index value.
        /// </summary>
        /// <param name="modelIndex">Internal index for the player model as stored in the character file.</param>
        /// <returns>A model that represents the internal <paramref name="modelIndex"/> provided</returns>
        public static Model FromIndex(int modelIndex) =>
            Models.FirstOrDefault(m => m.Index == modelIndex) ??
            throw new ArgumentOutOfRangeException(nameof(modelIndex),
                "Model index out of range of known player models");

        /// <summary>
        /// All the models that we know about in the game right now.
        /// </summary>
        public static Model[] Models =
        {
            new Model {Index = 0, DisplayName = Loki.Properties.Resources.Male},
            new Model {Index = 1, DisplayName = Loki.Properties.Resources.Female},
        };
    }
}
