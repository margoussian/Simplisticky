using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simplisticky {
    class ApplicationController : ApplicationContext {

        private List<StickyNote> notelist;
        private XmlController xml;
        private MainWindow main;
        private Initialize init;

        public ApplicationController() {
            
            notelist = new List<StickyNote>();
            xml = new XmlController(this);
            init = new Initialize(this);
            init.begin();
        }

        // Accessors

        public MainWindow Main {
            get {
                return main;
            }
            set {
                main = value;
            }
        }

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
