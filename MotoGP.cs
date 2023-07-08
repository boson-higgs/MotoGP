/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/
/*********  BOSON-HIGGS | neutron.surge.sh  ********/
/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/

using System.Xml;

namespace MotoGP
{
    public partial class MotoGP : Form
    {
        public Records records = new Records();

        public MotoGP()
        {
            InitializeComponent();
            list.DataSource = records.Riders;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddRider add_rider = new AddRider(records);
            add_rider.ShowDialog();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if(list.SelectedItem != null)
            {
                records.Remove((Rider)list.SelectedItem);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter xw = XmlWriter.Create(@"riders_list.xml", settings))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("riders");
                foreach(Rider r in records.Riders)
                {
                    xw.WriteStartElement("rider");
                    xw.WriteAttributeString("number", r.Number.ToString());
                    xw.WriteElementString("name", r.Name);
                    xw.WriteElementString("surname", r.Surname);
                    xw.WriteElementString("team", r.Team);
                    xw.WriteElementString("factory_team", r.FactoryTeam.ToString());
                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Flush();
            }
            DialogResult result = MessageBox.Show("The list of riders was successfully exported to XML file.");
        }

        private void import_Click(object sender, EventArgs e)
        {
            using(XmlReader xr = XmlReader.Create(@"riders_list.xml"))
            {
                string name = "";
                string surname = "";
                int number = 0;
                string team = "";
                bool factory_team = false;
                string element = "";
                while(xr.Read())
                {
                    if(xr.NodeType == XmlNodeType.Element)
                    {
                        element = xr.Name;
                        if(element == "rider")
                        {
                            number = int.Parse(xr.GetAttribute("number"));
                        }
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {
                            case "name":
                                name = xr.Value;
                                break;
                            case "surname":
                                surname = xr.Value;
                                break;
                            case "team":
                                team = xr.Value;
                                break;
                            case "factory_team":
                                factory_team = bool.Parse(xr.Value);
                                break;
                        }
                    }
                    else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "rider"))
                    {
                        records.Add(name, surname, number, team, factory_team);
                    }
                }
            }
        }

        private void list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (list.SelectedItem != null)
            {
                Rider choosed = (Rider)list.SelectedItem;
                EditRider edit_rider = new EditRider(choosed);
                edit_rider.ShowDialog();
            }
        }

        private void MotoGP_Load(object sender, EventArgs e)
        {

        }
    }
}