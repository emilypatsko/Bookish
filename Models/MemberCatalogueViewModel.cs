using System;
using System.Collections.Generic;

namespace Bookish.Models {
    public class MemberCatalogueViewModel {
        public List<Member> MemberCatalogue { get; set; }

        public MemberCatalogueViewModel() {
            MemberCatalogue = new List<Member>();
        }

        public MemberCatalogueViewModel(List<Member> members) {
            MemberCatalogue = members;
        }
    }
}