using System.Xml.Linq;

namespace Honours.Models
{
    public class Cosmetic
    {
        public Guid ID { get; init; }
        public string MainColour { get; set; }
        public string Highlight { get; set; }
        public string Lowlight { get; set; }
        public string Contrast { get; set; }

        public Cosmetic(string mainColour, string highlight, string lowlight, string contrast) : this(Guid.NewGuid(), mainColour, highlight, lowlight, contrast) { }
        public Cosmetic(Guid id, string mainColour, string highlight, string lowlight, string contrast)
        {
            ID = id;
            MainColour = mainColour;
            Highlight = highlight;
            Lowlight = lowlight;
            Contrast = contrast;
        }
    }
}
