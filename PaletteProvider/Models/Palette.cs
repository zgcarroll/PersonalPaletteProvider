namespace PaletteProvider.Models
{
    // setting variables for the pallete program
    public class Palette
    {
        // wip classe
        public int Id { get; set; } // id of each palette
        public string Name { get; set; } // name of palette, might scrap
        public string IForgot { get; set; } // i geniunly dont remeber. Ill come back to this
        public string Theme { get; set; } // description or style
        public int PaletteSize { get; set; } // 3-5 colors, maybe trim to 4
    }
}