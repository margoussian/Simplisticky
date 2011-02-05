using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simplisticky {
    class ApplicationController {

        private List<StickyNote> notelist;
        private XmlController xml;

        public ApplicationController() {
            
            notelist = new List<StickyNote>();
            xml = new XmlController(this);
            Initialize init = new Initialize(this);
            init.begin();
        }

        // Accessors

        public List<StickyNote> Notelist {
            get {
                return notelist;
            }
            set {
                notelist = value;
            }
        }
        
        public XmlController Xml {
            get {
                return xml;
            }
            set {
                xml = value;
            }
        }

    }
}
