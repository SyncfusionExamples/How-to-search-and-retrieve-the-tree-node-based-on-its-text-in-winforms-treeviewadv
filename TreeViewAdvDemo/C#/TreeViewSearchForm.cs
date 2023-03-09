using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace TreeViewAdvSearchDemo
{
    public partial class TreeViewSearchForm : MetroForm
    {
        #region Variables

        //Initialize the TreeViewAdvFindReplaceDialog
        TreeViewAdvFindReplaceDialog dialog = null;
        //Initialize the TreeViewAdv
        private TreeViewAdv TreeView;
        #endregion

        #region Consructor

        //To pass the TreeviewAdv argument to the form.
        public TreeViewSearchForm(TreeViewAdv tree)
        {
            InitializeComponent();
            TreeView = tree;
            this.TreeView.InactiveSelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            //To assign the TreeViewAdv to TreeViewSearchForm            
            dialog = new TreeViewAdvFindReplaceDialog(this.TreeView);

            //To add the TreeViewSearchRange in ComboBox
            Array searchRange = Enum.GetValues(typeof(TreeViewSearchRange));
            for (int i = 0; i < searchRange.Length; i++)
            {
                this.SearchRangeCombo.Items.Add(searchRange.GetValue(i));
            }

            //To add the TreeViewSearchOption in ComboBox
            Array SearchOptions = Enum.GetValues(typeof(TreeViewSearchOption));
            for (int i = 0; i < SearchOptions.Length; i++)
            {
                this.SearchOptionCombo.Items.Add(SearchOptions.GetValue(i));
            }

            //To add the TreeViewSearchNavigation in ComboBox
            Array NodeSearchType = Enum.GetValues(typeof(TreeViewSearchNavigation));
            for (int i = 0; i < NodeSearchType.Length; i++)
            {
                this.comboBox3.Items.Add(NodeSearchType.GetValue(i));
            }
            this.comboBox3.SelectedIndexChanged += new EventHandler(comboBox3_SelectedIndexChanged);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SearchOptionCombo.SelectedIndex = 0;
            this.SearchRangeCombo.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 1;
            this.findTextBox.Select();
        }
        #endregion

        #region Implementation

        //To get the TreeViewSearchNavigation
        void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dialog.TreeViewSearchNavigation = (TreeViewSearchNavigation)this.SearchRangeCombo.Items[this.comboBox3.Items.IndexOf(this.comboBox3.SelectedItem)];
        }

        //To get the TreeViewSearchRange
        private void SearchRangeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dialog.TreeViewSearchRange = (TreeViewSearchRange)this.SearchRangeCombo.Items[this.SearchRangeCombo.Items.IndexOf(this.SearchRangeCombo.SelectedItem)];
        }

        //To get the TreeViewSearchOption
        private void SearchOptionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dialog.TreeViewSearchOption = (TreeViewSearchOption)this.SearchOptionCombo.Items[this.SearchOptionCombo.Items.IndexOf(this.SearchOptionCombo.SelectedItem)];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //To Find TreeNodeAdv
        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Find(this.findTextBox.Text);
        }

        //To Find All the TreeNodeAdv
        private void button2_Click(object sender, EventArgs e)
        {
            dialog.FindAll(this.findTextBox.Text);
        }

        //To Replace the TreeNodeAdv
        private void button3_Click(object sender, EventArgs e)
        {
            this.TreeView.SelectedNodes.Clear();
            if (dialog.Find(this.findTextBox.Text))
                dialog.Replace(this.replaceTextbox.Text);
        }

        //To Replace All the TreeNodeAdv
        private void button4_Click(object sender, EventArgs e)
        {
            this.TreeView.SelectedNodes.Clear();
            if (dialog.FindAll(this.findTextBox.Text))
                dialog.ReplaceAll(this.replaceTextbox.Text);
        }
        #endregion
    }
}