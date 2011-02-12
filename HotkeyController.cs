using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simplisticky {
    public partial class HotkeyController : Form {
        ApplicationController app;
        private Hotkey hk;


        public HotkeyController(ApplicationController _app) {
            InitializeComponent();
            app = _app;
            registerGlobalKeyboardShortcuts();
            
        }

        private void registerGlobalKeyboardShortcuts() {
            hk = new Hotkey();
            hk.KeyCode = Keys.S;
            hk.Shift = true;
            hk.Alt = true;
            hk.Control = true;
            hk.Pressed += delegate { showAllNotes(); };
            if (!hk.GetCanRegister(this)) {
                Console.WriteLine("Error registering global keyboard shortcuts.");
                //feedback to user regarding this error.
            }
            else { hk.Register(this); }
        }

        private void showAllNotes() {   // Brings all notes to the foreground
            foreach (StickyNote n in app.Notelist) {
                n.Activate();
            }
        }
    }
}
