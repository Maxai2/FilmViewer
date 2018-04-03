using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Common;

namespace WpfApp1.ViewModel {
    public class PaletteViewModel : NotifyableObject {
        public IEnumerable<Swatch> Swatches { get; set; }
        public PaletteViewModel() {
            Swatches = new SwatchesProvider().Swatches;
        }

        public ICommand SetThemeCommand {
            get {
                return new RelayCommand(val => ChangeTheme((bool)val));

            }
        }

        private void ChangeTheme(bool IsDark) {
            new PaletteHelper().SetLightDark(IsDark);
        }
        private static void ApplyPrimary(Swatch swatch) {
            new PaletteHelper().ReplacePrimaryColor(swatch);
        }

        public 

        public ICommand ApplyPrimaryCommand { get; } =
            new RelayCommand(val => ApplyPrimary((Swatch)val));

        private static void ApplyAccent(Swatch swatch) {
            new PaletteHelper().ReplaceAccentColor(swatch);
        }
    }
}
