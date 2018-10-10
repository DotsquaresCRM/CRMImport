// PROJECT : DSTools.SqlToCRMImport
// This project was developed by Tanguy Touzard
// CODEPLEX: http://xrmtoolbox.codeplex.com
// BLOG: http://mscrmtools.blogspot.com

using DSTools.SqlToCRMImport.AppCode;
using DSTools.SqlToCRMImport.Forms;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;
using XrmToolBox.Extensibility.Interfaces;

namespace DSTools.SqlToCRMImport
{
    public partial class CRMImport : PluginControlBase, IGitHubPlugin, ICodePlexPlugin, IPayPalPlugin, IHelpPlugin, IStatusBarMessenger, IShortcutReceiver, IAboutPlugin
    {
        #region Private Fields

        private List<string> entities;

        private Dictionary<string, List<Entity>> views;

        #endregion Private Fields
        #region Base tool implementation

        public CRMImport()
        {
            InitializeComponent(); 
        }
        public void LoadViews()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving Entites...",
                Work = (w, e) =>
                {
                    this.views = new Dictionary<string, List<Entity>>();

                    if (views.Count == 0)
                    {    
                        this.entities = new List<string>();
                        foreach (EntityMetadata Entity in GetEntities(Service))
                        {
                            if (!String.IsNullOrWhiteSpace(Entity.CollectionSchemaName))
                            {
                                this.entities.Add(Entity.CollectionSchemaName + " : " + Entity.LogicalName);
                            }
                        }
                        e.Result = entities;
                    }
                },
                ProgressChanged = e =>
                {
                    if (SendMessageToStatusBar != null)
                        SendMessageToStatusBar(this, new StatusBarMessageEventArgs(e.ProgressPercentage, e.UserState.ToString()));
                },
                PostWorkCallBack = e =>
                {
                    PopulateForm();
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });


        }
        public static EntityMetadata[] GetEntities(IOrganizationService organizationService)
        {
            Dictionary<string, string> attributesData = new Dictionary<string, string>();
            RetrieveAllEntitiesRequest metaDataRequest = new RetrieveAllEntitiesRequest();
            RetrieveAllEntitiesResponse metaDataResponse = new RetrieveAllEntitiesResponse();
            metaDataRequest.EntityFilters = EntityFilters.Entity;

            // Execute the request.

            metaDataResponse = (RetrieveAllEntitiesResponse)organizationService.Execute(metaDataRequest);

            var entities = metaDataResponse.EntityMetadata;

            return entities;
        }
        private void PopulateForm()
        {
            if (entities != null)
            {
                foreach (var entity in entities)
                {
                    cmbEntity.Items.Add(entity);
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private void ExtractViews(DataCollection<Entity> views)
        {
            var suffix = (views.FirstOrDefault().LogicalName == "savedquery") ? "|S" : "|U";

            foreach (var view in views)
            {
                var entityname = view["returnedtypecode"].ToString();

                if (!string.IsNullOrWhiteSpace(entityname))
                {
                    if (!this.views.ContainsKey(entityname + suffix))
                    {
                        this.views.Add(entityname + suffix, new List<Entity>());
                    }
                    this.views[entityname + suffix].Add(view);
                }
            }
        }
        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

        public override void ClosingPlugin(PluginCloseInfo info)
        {
                       base.ClosingPlugin(info);
        }

        

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            CancelWorker();
            tsbCancel.Enabled = false;
            
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbWhoAmI_Click(object sender, EventArgs e)
        {
            HideNotification();

            //    ExecuteMethod(ProcessWhoAmI);
        }

        #endregion Base tool implementation

        #region Github implementation

        public string RepositoryName
        {
            get { return "CRMImport"; }
        }

        public string UserName
        {
            get { return "DotsquaresCRM"; }
        }

        #endregion Github implementation

        #region CodePlex implementation

        public string CodePlexUrlName
        {
            get { return "CodePlex"; }
        }

        #endregion CodePlex implementation

        #region PayPal implementation

        public string DonationDescription
        {
            get { return "To create and App to allow users to record their motorcycle info and log their services and rides with the purpose of recording training notes to track their progress. There is a coaching aspect where videos supplied by professional coaches are made available through the App for users to download and watch. There are 2D and VR videos available."; }
        }

        public string EmailAccount
        {
            get { return "hemanttiwari01@paypal.com"; }
        }

        #endregion PayPal implementation

        #region Help implementation

        public string HelpUrl
        {
            get { return "https://www.dotsquares.com"; }
        }

        #endregion Help implementation

        #region Shortcut Receiver implementation

        public void ReceiveKeyDownShortcut(KeyEventArgs e)
        {
            //   MessageBox.Show("A KeyDown event was received!");
        }

        public void ReceiveKeyPressShortcut(KeyPressEventArgs e)
        {
            // MessageBox.Show("A KeyPress event was received!");
        }

        public void ReceiveKeyUpShortcut(KeyEventArgs e)
        {
            //MessageBox.Show("A KeyUp event was received!");
        }

        public void ReceivePreviewKeyDownShortcut(PreviewKeyDownEventArgs e)
        {
            //MessageBox.Show("A PreviewKeyDown event was received!");
        }

        public void ReceiveShortcut(KeyEventArgs e)
        {
           // MessageBox.Show(e.ToString());
        }

        #endregion Shortcut Receiver implementation

        private void SampleTool_Load(object sender, EventArgs e)
        {
            ExecuteMethod(this.LoadViews);
            //ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("http://github.com/MscrmTools/XrmToolBox"));
        }

        #region IAboutPlugin implementation

        public void ShowAboutDialog()
        {
            MessageBox.Show(@"This is a SQL To CRM Data Import plugin", @"SQL To CRM Data Import", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion IAboutPlugin implementation

        private void tsbWhoAmI_Click_1(object sender, EventArgs e)
        {
            ExecuteMethod(this.LoadViews);
        }

        private void btnLoadSql_Click(object sender, EventArgs e)
        {
            //GetConnection frm = new GetConnection();
            //DialogResult result = frm.ShowDialog();

            using (GetConnection form = new GetConnection())
            {
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(Connection.ConnectionString))
                    {
                        SqlConnection cnn;

                        cnn = new SqlConnection(Connection.ConnectionString);
                        cnn.Open();
                        List<string> lstDB = new List<string>();
                        using (SqlCommand cmd = new SqlCommand("select table_name  from " + Connection.Database + ".INFORMATION_SCHEMA.TABLES order by table_name asc", cnn))
                        {
                            using (SqlDataReader dr1 = cmd.ExecuteReader())
                            {
                                while (dr1.Read())
                                {
                                    lstDB.Add(dr1[0].ToString());
                                }
                            }
                        }
                        cnn.Close();
                        // ComboBox combo = new ComboBox();
                        cmbTables.DataSource = lstDB;
                        //combo.Name = "comboBoxTables";
                        //combo.DisplayMember = this.dS.Tables[0].Columns[++_i].ColumnName;
                        // combo.Location = new Point(100, 100);

                        //cmbTables.SelectedIndexChanged +=
                        //new System.EventHandler(ComboBox1_SelectedIndexChanged);
                        // this.Controls.Add(combo);
                    }
                }

            }

        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn;
            ComboBox comboBox = (ComboBox)sender;
            string selectedTable = (string)comboBox.SelectedItem;
            cnn = new SqlConnection(Connection.ConnectionString);
            cnn.Open();
            List<string> lstDB = new List<string>();
            lstTablesColumn.Items.Clear();
            lstSortedTablesColumn.Items.Clear();
            using (SqlCommand cmd = new SqlCommand("select COLUMN_NAME  from " + Connection.Database + ".INFORMATION_SCHEMA.columns where TABLE_NAME='" + selectedTable + "'", cnn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lstTablesColumn.Items.Add(dr[0].ToString());
                    }
                }
            }
            cnn.Close();
            //lstTablesColumn.DataSource = lstDB;
            //lstTablesColumn.SelectedIndex = -1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExecuteMethod(this.PopulateForm);
        }
        public Dictionary<string, string> GetAttributes(string entityName)
        {
            Dictionary<string, string> attributesData = new Dictionary<string, string>();

            RetrieveEntityRequest metaDataRequest = new RetrieveEntityRequest();
            RetrieveEntityResponse metaDataResponse = new RetrieveEntityResponse();
            metaDataRequest.EntityFilters = EntityFilters.Attributes;
            metaDataRequest.LogicalName = entityName;
            metaDataResponse = (RetrieveEntityResponse)Service.Execute(metaDataRequest);

            foreach (AttributeMetadata a in metaDataResponse.EntityMetadata.Attributes)
            {
                //if more than one label for said attribute, get the one matching the languade code we want...
                if (a.DisplayName.LocalizedLabels.Count() > 1)
                    attributesData.Add(a.LogicalName, a.DisplayName.LocalizedLabels.SingleOrDefault().Label);

                //else, get the only one available regardless of languade code...
                if (a.DisplayName.LocalizedLabels.Count() == 1)
                    attributesData.Add(a.LogicalName, a.DisplayName.LocalizedLabels[0].Label);
            }

            return attributesData;
        }
        private void cmbEntity_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            string[] entity = comboBox.SelectedItem.ToString().Split(':');

            Dictionary<string, string> dis = GetAttributes(entity[1].Trim());
            lstEntityColumn.Items.Clear();
            lstSortedEntityColumn.Items.Clear();
            foreach (var item in dis)
            {
                lstEntityColumn.Items.Add(item.Value + " : " + item.Key);
            }
            lstEntityColumn.SelectedIndex = -1;
        }



        private void btnMoveRTable_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox _listBox = lstTablesColumn;

                lstSortedTablesColumn.Items.Add(_listBox.SelectedItem.ToString());
                _listBox.Items.Remove(_listBox.SelectedItem);
            }
            catch
            {

            }
        }

        private void btnMoveLTable_Click(object sender, EventArgs e)
        {
            try
            {

                ListBox _listBox = lstSortedTablesColumn;

                lstTablesColumn.Items.Add(_listBox.SelectedItem.ToString());
                _listBox.Items.Remove(_listBox.SelectedItem);
            }
            catch
            {

            }
        }

        private void btnMoveREntity_Click(object sender, EventArgs e)
        {
            try
            {

                ListBox _listBox = lstSortedEntityColumn;

                lstEntityColumn.Items.Add(_listBox.SelectedItem.ToString());
                _listBox.Items.Remove(_listBox.SelectedItem);
            }
            catch
            {

            }
        }

        private void btnMoveLEntity_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox _listBox = lstEntityColumn;

                lstSortedEntityColumn.Items.Add(_listBox.SelectedItem.ToString());
                _listBox.Items.Remove(_listBox.SelectedItem);
            }
            catch
            {

            }
        }

        private void btnUpTable_Click(object sender, EventArgs e)
        {
            lstSortedTablesColumn.BeginUpdate();
            int numberOfSelectedItems = lstSortedTablesColumn.SelectedItems.Count;
            for (int i = 0; i < numberOfSelectedItems; i++)
            {
                // only if it's not the first item
                if (lstSortedTablesColumn.SelectedIndices[i] > 0)
                {
                    // the index of the item above the item that we wanna move up
                    int indexToInsertIn = lstSortedTablesColumn.SelectedIndices[i] - 1;
                    // insert UP the item that we want to move up
                    lstSortedTablesColumn.Items.Insert(indexToInsertIn, lstSortedTablesColumn.SelectedItems[i]);
                    // removing it from its old place
                    lstSortedTablesColumn.Items.RemoveAt(indexToInsertIn + 2);
                    // highlighting it in its new place
                    lstSortedTablesColumn.SelectedItem = lstSortedTablesColumn.Items[indexToInsertIn];
                }
            }
            lstSortedTablesColumn.EndUpdate();
        }

        private void btnDownTable_Click(object sender, EventArgs e)
        {
            lstSortedTablesColumn.BeginUpdate();
            int numberOfSelectedItems = lstSortedTablesColumn.SelectedItems.Count;
            // when going down, instead of moving through the selected items from top to bottom
            // we'll go from bottom to top, it's easier to handle this way.
            for (int i = numberOfSelectedItems - 1; i >= 0; i--)
            {
                // only if it's not the last item
                if (lstSortedTablesColumn.SelectedIndices[i] < lstSortedTablesColumn.Items.Count - 1)
                {
                    // the index of the item that is currently below the selected item
                    int indexToInsertIn = lstSortedTablesColumn.SelectedIndices[i] + 2;
                    // insert DOWN the item that we want to move down
                    lstSortedTablesColumn.Items.Insert(indexToInsertIn, lstSortedTablesColumn.SelectedItems[i]);
                    // removing it from its old place
                    lstSortedTablesColumn.Items.RemoveAt(indexToInsertIn - 2);
                    // highlighting it in its new place
                    lstSortedTablesColumn.SelectedItem = lstSortedTablesColumn.Items[indexToInsertIn - 1];
                }
            }
            lstSortedTablesColumn.EndUpdate();
        }

        private void btnUpEntity_Click(object sender, EventArgs e)
        {
            lstSortedEntityColumn.BeginUpdate();
            int numberOfSelectedItems = lstSortedEntityColumn.SelectedItems.Count;
            for (int i = 0; i < numberOfSelectedItems; i++)
            {
                // only if it's not the first item
                if (lstSortedEntityColumn.SelectedIndices[i] > 0)
                {
                    // the index of the item above the item that we wanna move up
                    int indexToInsertIn = lstSortedEntityColumn.SelectedIndices[i] - 1;
                    // insert UP the item that we want to move up
                    lstSortedEntityColumn.Items.Insert(indexToInsertIn, lstSortedEntityColumn.SelectedItems[i]);
                    // removing it from its old place
                    lstSortedEntityColumn.Items.RemoveAt(indexToInsertIn + 2);
                    // highlighting it in its new place
                    lstSortedEntityColumn.SelectedItem = lstSortedEntityColumn.Items[indexToInsertIn];
                }
            }
            lstSortedEntityColumn.EndUpdate();
        }

        private void btnDownEntity_Click(object sender, EventArgs e)
        {
            lstSortedEntityColumn.BeginUpdate();
            int numberOfSelectedItems = lstSortedEntityColumn.SelectedItems.Count;
            // when going down, instead of moving through the selected items from top to bottom
            // we'll go from bottom to top, it's easier to handle this way.
            for (int i = numberOfSelectedItems - 1; i >= 0; i--)
            {
                // only if it's not the last item
                if (lstSortedEntityColumn.SelectedIndices[i] < lstSortedEntityColumn.Items.Count - 1)
                {
                    // the index of the item that is currently below the selected item
                    int indexToInsertIn = lstSortedEntityColumn.SelectedIndices[i] + 2;
                    // insert DOWN the item that we want to move down
                    lstSortedEntityColumn.Items.Insert(indexToInsertIn, lstSortedEntityColumn.SelectedItems[i]);
                    // removing it from its old place
                    lstSortedEntityColumn.Items.RemoveAt(indexToInsertIn - 2);
                    // highlighting it in its new place
                    lstSortedEntityColumn.SelectedItem = lstSortedEntityColumn.Items[indexToInsertIn - 1];
                }
            }
            lstSortedEntityColumn.EndUpdate();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lstSortedEntityColumn.Items.Count == lstSortedTablesColumn.Items.Count)
            {

            }
            else
            {
                MessageBox.Show("Please Correct column Mapping with Entity Fields.");
            }
        }
    }
}