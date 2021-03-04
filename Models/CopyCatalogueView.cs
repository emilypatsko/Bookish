using System;
using System.Collections.Generic;

namespace Bookish.Models {
    public class CopyCatalogueViewModel {
        public List<Copy> CopyCatalogue { get; set; }

        public CopyCatalogueViewModel() {
            CopyCatalogue = new List<Copy>();
        }

        public CopyCatalogueViewModel(List<Copy> copies) {
           CopyCatalogue = copies;
        }
    }
}
