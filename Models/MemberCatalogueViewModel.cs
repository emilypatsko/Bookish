using System;
using System.Collections.Generic;

namespace Bookish.Models {
    public class MemberCatalogueViewModel {
        public List<MemberModel> MemberCatalogue { get; set; }

        public MemberCatalogueViewModel() {
            MemberCatalogue = new List<MemberModel>();
        }

        public MemberCatalogueViewModel(List<MemberModel> members) {
            MemberCatalogue = members;
        }
    }
}