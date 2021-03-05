using System;
using System.Collections.Generic;

namespace Bookish.Models {
    public class CheckoutCatalogueViewModel {
        public List<Checkout> CheckoutCatalogue { get; set; }

        public CheckoutCatalogueViewModel() {
            CheckoutCatalogue = new List<Checkout>();
        }

        public CheckoutCatalogueViewModel(List<Checkout> checkouts) {
           CheckoutCatalogue = checkouts;
        }
    }
}
