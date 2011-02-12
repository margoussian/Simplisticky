using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sharpnote;
using System.ComponentModel;
using System.Xml;
using System.Xml.Linq;
using System.Configuration;
using System.Drawing;

namespace Simplisticky {
    public class XmlController {
        private String document = "Notes.xml";
        private XmlDocument addDoc;
        private XmlDocument updateDoc;
        private XmlDocument activeDocument;
        private XmlTextReader xmlReader;
        private XmlTextWriter xmlWriter;
        private ApplicationController app;
        private bool loading;

        private String key, created, modified, text;
        private int show, width, height, font, color;
        private Point topleft;

        private StickyNote note;

        public XmlController(ApplicationController _app) {

            app = _app;

            try {
                activeDocument = new XmlDocument();
                activeDocument.Load(document);
//                addDoc = new XmlDocument();
//                updateDoc = new XmlDocument();
            }
            catch (Exception e) {
                System.Console.WriteLine("Error in Constructor: " + e.Message);
                // TODO: Proper ERROR message here
            }
        }

        public bool Loading {
            get {
                return loading;
            }
            set {
                loading = value;
            }
        }

        public void Read(List<StickyNote> notelist) {

            try {
                if (!System.IO.File.Exists(document)) {
                    // create new XML file here
                    XmlTextWriter textWritter = new XmlTextWriter(document, null);
                    textWritter.WriteStartDocument();
                    textWritter.WriteStartElement("notelist");
                    textWritter.WriteEndElement();

                    textWritter.Close();
                }
                else {

                    xmlReader = new XmlTextReader(document);
                    loading = true;
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
                                    String[] temp = xmlReader.ReadString().Split(new char[] { ',' });
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
                                    note = new StickyNote(key, created, modified, text, show, width, height, font, color, topleft, app, null);
                                    app.Notelist.Add(note);
                                    note.Show();
                                }
                                break;
                        }
                    }
                    loading = false;
                    xmlReader.Close();

                }
            }
            catch (Exception e) {
                System.Console.WriteLine("ERROR in XMLREAD: " + e.Message);
            }
        }

        public void Write(List<StickyNote> notelist) {
            try {
                if (!System.IO.File.Exists(document)) {
                    // create new XML file here
                    XmlTextWriter textWritter = new XmlTextWriter(document, null);
                    textWritter.WriteStartDocument();
                    textWritter.WriteStartElement("notelist");
                    textWritter.WriteEndElement();
                    textWritter.Close();
                }

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
                    xmlWriter.WriteString(Convert.ToString(note.Location.X) + "," + Convert.ToString(note.Location.Y));
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

        public void addRecord(StickyNote note) {
            try {
                //addDoc = new XmlDocument();
                //addDoc.Load(document);
                //Select main node	
                XmlElement root = activeDocument.DocumentElement;
                XmlElement new_record = activeDocument.CreateElement("note");
                new_record.InnerXml = "<key>" + note.Key + "</key>" +
                    "<show>" + note.NoteShow + "</show>" + "<created>" + note.NoteCreated + "</created>" +
                    "<modified>" + note.Modified + "</modified>" + "<text>" + note.Content + "</text>" +
                    "<topleft>" + Convert.ToString(note.Location.X) + "," + Convert.ToString(note.Location.Y) + "</topleft>" +
                    "<width>" + Convert.ToString(note.Width) + "</width>" + "<height>" + Convert.ToString(note.Height) + "</height>" +
                    "<font>" + Convert.ToString(note.NoteFont) + "</font>" + "<color>" + Convert.ToString(note.NoteColor) + "</color>";

                root.AppendChild(new_record);
                activeDocument.PreserveWhitespace = false;
                activeDocument.Save(document);
                //addDoc = null;
            }
            catch (Exception e) {
                System.Console.WriteLine("Error in Add: " + e.Message);
            }

        }

        public void updateRecord(StickyNote note) {
            try {
                //updateDoc = new XmlDocument();
                //updateDoc.Load(document);
                XmlNode old_record;
                XmlElement root = activeDocument.DocumentElement;

                old_record = root.SelectSingleNode("/notelist/note[key='" + note.Key + "']");

                XmlElement new_record = activeDocument.CreateElement("note");
                new_record.InnerXml = "<key>" + note.Key + "</key>" +
                    "<show>" + note.NoteShow + "</show>" + "<created>" + note.NoteCreated + "</created>" +
                    "<modified>" + note.Modified + "</modified>" + "<text>" + note.Content + "</text>" +
                    "<topleft>" + Convert.ToString(note.Location.X) + "," + Convert.ToString(note.Location.Y) + "</topleft>" +
                    "<width>" + Convert.ToString(note.Width) + "</width>" + "<height>" + Convert.ToString(note.Height) + "</height>" +
                    "<font>" + Convert.ToString(note.NoteFont) + "</font>" + "<color>" + Convert.ToString(note.NoteColor) + "</color>";

                root.ReplaceChild(new_record, old_record);
                activeDocument.PreserveWhitespace = false;
                activeDocument.Save(document);
                //activeDocument = null;

            }
            catch (Exception e) {
                System.Console.WriteLine("Error in Update: " + e.Message);
            }
        }
    }
}
