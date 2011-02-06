using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sharpnote;
using System.ComponentModel;
using System.Xml;
using System.Configuration;
using System.Drawing;

namespace Simplisticky {
    public class XmlController {
        private String document = "Notes.xml";
        private XmlDocument myxmlDocument;
        private XmlTextReader xmlReader;
        private XmlTextWriter xmlWriter;
        private ApplicationController app;

        private String key, created, modified, text;
        private int show, width, height, font, color;
        private Point topleft;

        private StickyNote note;



        public XmlController(ApplicationController _app) {

            app = _app;

            try {
                myxmlDocument = new XmlDocument();


            }
            catch (Exception e) {
                System.Console.WriteLine("Error in Constructor: " + e.Message);
                // TODO: Proper ERROR message here
            }
        }

         public void Read(List<StickyNote> notelist) {

            try {
                if (!System.IO.File.Exists(document)) {
                    // create new XML file here
                    using (System.IO.File.CreateText(document));
                    
                }
                myxmlDocument.Load(document);
                xmlReader = new XmlTextReader(document);

                while (xmlReader.Read()) {
                    switch (xmlReader.NodeType) {
                        case XmlNodeType.Element: // The node is an element.
                            if (xmlReader.Name == "key") {
                                key = xmlReader.ReadString();
                            }
                            if (xmlReader.Name == "created") {
                                created = xmlReader.ReadString();
                            }
                            if (xmlReader.Name == "modified") {
                                modified = xmlReader.ReadString();
                            }
                            if (xmlReader.Name == "text") {
                                text = xmlReader.ReadString();
                            }
                            if (xmlReader.Name == "show") {
                                show = Convert.ToInt32(xmlReader.ReadString());
                            }
                            if (xmlReader.Name == "topleft") {
                                String[] temp = xmlReader.ReadString().Split(new char[] {','});
                                topleft = new Point(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]));
                            }
                            if (xmlReader.Name == "width") {
                                width = Convert.ToInt32(xmlReader.ReadString());
                            }
                            if (xmlReader.Name == "height") {
                                height = Convert.ToInt32(xmlReader.ReadString());
                            }
                            if (xmlReader.Name == "font") {
                                font = Convert.ToInt32(xmlReader.ReadString());
                            }
                            if (xmlReader.Name == "color") {
                                color = Convert.ToInt32(xmlReader.ReadString());
                            }
                            break;
                        case XmlNodeType.EndElement:

                            if (xmlReader.Name == "note") { // Create a new Stickynote and insert it into the notelist
                                note = new StickyNote(key,created,modified,text,show,width,height,font,color,topleft,app);
                                app.Notelist.Add(note);
                                note.Show();
                            }
                            break;
                    }
                }
                xmlReader.Close();
            }
            catch (Exception e) {
                System.Console.WriteLine("ERROR in XMLREAD: " + e.Message);
            }
        }

        public void Write(List<StickyNote> notelist) {
            try {

                xmlWriter = new XmlTextWriter(document, null);
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("notelist");

                foreach (StickyNote note in app.Notelist) {

                    xmlWriter.WriteStartElement("note");

                    xmlWriter.WriteStartElement("key", "");
                    xmlWriter.WriteString(note.Key);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("show", "");
                    xmlWriter.WriteString(Convert.ToString(note.NoteShow));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("created", "");
                    xmlWriter.WriteString(note.NoteCreated);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("modified", "");
                    xmlWriter.WriteString(note.Modified);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("text", "");
                    xmlWriter.WriteString(note.Content);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("topleft", "");
                    xmlWriter.WriteString(Convert.ToString(note.Location.X)+","+Convert.ToString(note.Location.Y));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("width", "");
                    xmlWriter.WriteString(Convert.ToString(note.Width));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("height", "");
                    xmlWriter.WriteString(Convert.ToString(note.Height));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("font", "");
                    xmlWriter.WriteString(Convert.ToString(note.NoteFont));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("color", "");
                    xmlWriter.WriteString(Convert.ToString(note.NoteColor));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();

                xmlWriter.Close();
            }
            catch (Exception e) {
                System.Console.WriteLine("ERROR in XMLWRITE: " + e.Message);
            }
        }
    }
}
