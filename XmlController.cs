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
    class XmlController {
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
                myxmlDocument.Load(document);
                xmlReader = new XmlTextReader(document);
                if (xmlReader == null) {
                    // create new XML file here
                }

            }
            catch (Exception e) {
                System.Console.WriteLine("Error in Constructor: " + e.Message);
                // TODO: Proper ERROR message here
            }
        }

         public void Read(List<StickyNote> notelist) {

            try {
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
                                topleft = Parse<Point>(xmlReader.ReadString());
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
                      /*  case XmlNodeType.Text: 
                            Console.WriteLine(xmlReader.Value);
                            break; */
                        case XmlNodeType.EndElement:

                            if (xmlReader.Name == "note") { // Create a new Stickynote and insert it into the notelist

                                System.Console.WriteLine(key + " " + created + " " + modified + " " + text + " " + show + " " + width + " " + height + " " + font + " " + color + " " + topleft);
                                note = new StickyNote(key,created,modified,text,show,width,height,font,color,topleft);
                                
                                
                                app.Notelist.Add(note);
                                note.Show();
                                
                            }
                            break;
                    }
                }
                System.Console.WriteLine(app.Notelist.Count);
            }
            catch (Exception e) {
                System.Console.WriteLine("ERROR in Read: " + e.Message);
            }
        }

         static T Parse<T>(string text) {

             // might need ConvertFromString

             // (rather than Invariant)

             return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(text);

         }

        public void Write(Note n, StickyNote sn) {
            try {

                xmlWriter = new XmlTextWriter(document, null);

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("note");

                xmlWriter.WriteStartElement("key", "");
                xmlWriter.WriteString(n.Key);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("content", "");
                xmlWriter.WriteString(n.Content);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("created", "");
                System.Console.WriteLine("modified:" + n.Created.ToString());
                xmlWriter.WriteString(n.Created.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();

                xmlWriter.Close();
            }
            catch (Exception e) {
                System.Console.WriteLine("ERROR in Write: " + e.Message);
            }
        }
    }
}
