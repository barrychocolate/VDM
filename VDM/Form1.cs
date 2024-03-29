﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VDM
{
    public partial class frmVDM : Form
    {
        enum DockPostion { TopLeft = 0, TopRight, BottomRight, BottomLeft};

        //Defaults to Bottom right if no value found in registry
        private DockPostion windowDock = DockPostion.BottomRight;
        private string xml_path = @"C:\test\vdm.xml";
        private DataTable vdmData = null;
        private string dockPositionKey = @"HKEY_CURRENT_USER\Software\VDM";
        private string dockPositionValueName = "DockPosition"; // "(Default)" value

        public frmVDM()
        {
            InitializeComponent();
        }

        private void create_datatable()
        {
            vdmData = new DataTable { TableName = "VDM_Data" };

            DataColumn column = new DataColumn("id", System.Type.GetType("System.Int32"));
            vdmData.Columns.Add(column);

            column = new DataColumn("parent_id", System.Type.GetType("System.Int32"));
            column.AllowDBNull = true;
            vdmData.Columns.Add(column);

            column = new DataColumn("link_type", System.Type.GetType("System.Int32"));
            vdmData.Columns.Add(column);

            column = new DataColumn("name", System.Type.GetType("System.String"));
            vdmData.Columns.Add(column);

            column = new DataColumn("url", System.Type.GetType("System.String"));
            vdmData.Columns.Add(column);


            DataRow new_row = vdmData.NewRow();

            new_row["id"] = 1;
            new_row["parent_id"] = DBNull.Value;
            new_row["link_type"] = 1;
            new_row["name"] = "Root 1";
            new_row["url"] = "root 1 url";
            vdmData.Rows.Add(new_row);

            new_row = vdmData.NewRow();
            new_row["id"] = 2;
            new_row["parent_id"] = 1;
            new_row["link_type"] = 1;
            new_row["name"] = "Root 1 sub 1";
            new_row["url"] = "root 1 sub 1 url";
            vdmData.Rows.Add(new_row);

            new_row = vdmData.NewRow();
            new_row["id"] = 3;
            new_row["parent_id"] = DBNull.Value;
            new_row["link_type"] = 1;
            new_row["name"] = "Root 2";
            new_row["url"] = "root 2 url";
            vdmData.Rows.Add(new_row);
        }
        private void save_XML()
        {
           vdmData.WriteXml(xml_path, System.Data.XmlWriteMode.WriteSchema);
            status_label.Text = string.Format("DataTable saved");
        }
        private void load_XML()
        {
            vdmData = new DataTable();
            vdmData.ReadXml(xml_path);
            if (vdmData != null)
            {
                status_label.Text = string.Format("Data loaded from file");
            }
            else
            {
                status_label.Text = string.Format("Data did not load from file");
            }
        }

        private void PopulateTree()
        {
            // Demo code to test
            TreeNode node = tvwLinks.Nodes.Add("1", "test",0);
            node.Nodes.Add("2", "Node 1 Sub 1",1);
            node = tvwLinks.Nodes.Add("3","Node 2",0);
            node.Nodes.Add("4", "Node 3", 2);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            create_datatable();
            save_XML();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            load_XML();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            if (vdmData != null)
            {
                foreach (DataRow row in vdmData.Rows)
                {
                    // ... Write value of first field as integer.
                    status_label.Text = string.Format(row["id"].ToString());
                    //string.Format(row.Field<string>(0));

                }

                MessageBox.Show("all rows looped through");
            }
            else
            {
                MessageBox.Show("There is no data loaded");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            create_datatable();
        }

        private void BtnTreeview_Click(object sender, EventArgs e)
        {
            PopulateTree();
        }

        private void TvwLinks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get the selected node
            TreeNode node = tvwLinks.SelectedNode;
            
            //Check node has a name
            if (node.Name=="")
            {
                // Root node so do nothing 
                status_label.Text = string.Format("root node so do nothing");
                
            }
            else
            {
                // Create query string using the id of the selected node
                string select_query = string.Format("id = {0}", node.Name.ToString());

                // Query the datatables
                DataRow[] rows = vdmData.Select(select_query);

                // If a root or subroot node then do nothing otherwise use the url
                //MessageBox.Show(string.Format("Your selected url: {0}", rows[0][4].ToString()));
                status_label.Text = string.Format("Your selected url: {0}", rows[0][4].ToString());
            }

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Notify Icon Test Application";
            notifyIcon1.BalloonTipText = "You have just minimized the application." +
                                        Environment.NewLine +
                                        "Right-click on the icon for more options.";

            notifyIcon1.ShowBalloonTip(5000);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get prefared docking location from settings
            loadDockSetting();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // remove notify icon from system tray
            notifyIcon1.Icon = null;
            Dispose();
        }

    

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void DockTheForm()
        {
            //Dock the form using the supplied screen position
            Console.WriteLine(string.Format("Docking the form {0}" , windowDock.ToString()));

            //Set x and y to zero which is the default for top left docking
            int x = 0;
            int y = 0;

            if (windowDock == DockPostion.BottomRight ^ windowDock == DockPostion.TopRight)
            {
                x = (int)(System.Windows.SystemParameters.WorkArea.Width - this.Width);
            }

            if (windowDock == DockPostion.BottomLeft ^ windowDock == DockPostion.BottomRight)
            {
                y = (int)(System.Windows.SystemParameters.WorkArea.Height - this.Height);
            }
            //Now position form
            this.DesktopLocation = new Point(x, y);

            //Check the menu item for the docking position
            switch (windowDock)
            {
                case DockPostion.TopLeft:
                    UncheckOtherToolStripMenuItems(topLeftToolStripMenuItem);
                    break;
                case DockPostion.TopRight:
                    UncheckOtherToolStripMenuItems(topRightToolStripMenuItem);
                    break;
                case DockPostion.BottomRight:
                    UncheckOtherToolStripMenuItems(bottomRightToolStripMenuItem);
                    break;
                case DockPostion.BottomLeft:
                    UncheckOtherToolStripMenuItems(bottomLeftToolStripMenuItem);
                    break;
            }

            //Save the position to the registry
            SaveDockSetting();
        }

        public void UncheckOtherToolStripMenuItems(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;

            // Select the other MenuItens from the ParentMenu(OwnerItens) and unchecked this,
            // The current Linq Expression verify if the item is a real ToolStripMenuItem
            // and if the item is a another ToolStripMenuItem to uncheck this.
            foreach (var ltoolStripMenuItem in (from object
                                                    item in selectedMenuItem.Owner.Items
                                                let ltoolStripMenuItem = item as ToolStripMenuItem
                                                where ltoolStripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolStripMenuItem))
                (ltoolStripMenuItem).Checked = false;
        }

        private void BottomRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowDock = DockPostion.BottomRight;
            DockTheForm();
        }
        private void TopLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowDock = DockPostion.TopLeft;
            DockTheForm();
        }
        private void TopRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowDock = DockPostion.TopRight;
            DockTheForm();
        }
        private void BottomLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowDock = DockPostion.BottomLeft;
            DockTheForm();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0);
            int x = this.Left;
            int y = this.Top;

            x = x + 100;
            this.Location = new Point(x, y);
            Console.WriteLine(string.Format("The x is {0} and the y is {1}", x, y));
        }

        private void FrmVDM_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO show an about form
            AboutBox1 frmAbout = new AboutBox1();
            frmAbout.ShowDialog();
        }
        private void loadDockSetting()
        {
            string position;

            position = GetRegistrySetting(dockPositionKey, dockPositionValueName);

            Console.WriteLine(position);
            if (position != string.Empty) {
                //Setting was returned
                windowDock = (DockPostion)Convert.ToInt32(position.ToString());
                
            }

            DockTheForm();
        }

        private string GetRegistrySetting(string key, string valueName)
        {
            return Convert.ToString(Microsoft.Win32.Registry.GetValue(key, valueName, string.Empty));
        }

        private void SetRegistrySetting(string key, string valueName, string value)
        {
            Microsoft.Win32.Registry.SetValue(key, valueName, value, Microsoft.Win32.RegistryValueKind.String);
        }
        private void SaveDockSetting()
        {
            string value = Convert.ToString((int)windowDock);
            SetRegistrySetting(dockPositionKey, dockPositionValueName, value);
        }

        private void openLink(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void btnLoadLink_Click(object sender, EventArgs e)
        {
            string filelink = @"C:\test\test.txt";
            string folderlink = @"C:\test\";
            string url = @"www.bbc.co.uk";

            openLink(filelink);
            openLink(folderlink);
            openLink(url);
        }
    }
}
