using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace TreeViewAdvSearchDemo
{
    public partial class TreeViewAdvSearchDemo : MetroForm
    {
        //Initialize the TreeViewSearchForm
        TreeViewSearchForm form;

        #region Constructor

        public TreeViewAdvSearchDemo()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.MinimumSize = this.Size;
            this.treeViewAdv1.SelectionMode = Syncfusion.Windows.Forms.Tools.TreeSelectionMode.MultiSelectAll;
            //To assign the TreeViewAdv to TreeViewSearchForm
            form = new TreeViewSearchForm(this.treeViewAdv1);
            this.treeViewAdv1.PreviewKeyDown += new PreviewKeyDownEventHandler(treeViewAdv1_PreviewKeyDown);
            this.treeViewAdv1.HideSelection = false;
            this.richTextBox1.AppendText("\n");
            this.treeViewAdv1.OnNodeAfterFound += new Syncfusion.Windows.Forms.Tools.TreeViewOnAfterFindArgs(treeViewAdv1_OnNodeAfterFound);
            this.treeViewAdv1.OnNodeBeforeFind += new Syncfusion.Windows.Forms.Tools.TreeViewOnBeforeFindArgs(treeViewAdv1_OnNodeBeforeFind);
            this.treeViewAdv1.OnNodeReplacing += new Syncfusion.Windows.Forms.Tools.TreeViewOnReplacingArgs(treeViewAdv1_OnNodeReplacing);
            this.treeViewAdv1.OnNodeReplaced += new Syncfusion.Windows.Forms.Tools.TreeViewOnReplacedArgs(treeViewAdv1_OnNodeReplaced);
        }

        #endregion

        void treeViewAdv1_OnNodeAfterFound(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvAfterFindArgs e)
        {
            this.richTextBox1.AppendText("\n AfterNodeMatchFound Event Triggered");
        }

        void treeViewAdv1_OnNodeReplaced(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvOnReplacedArgs e)
        {
            this.richTextBox1.AppendText("\n OnNodeTextReplaced Event Triggered");
        }

        void treeViewAdv1_OnNodeReplacing(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvOnReplacingArgs e)
        {
            this.richTextBox1.AppendText("\n OnNodeTextReplacing Event Triggered");
        }

        void treeViewAdv1_OnNodeBeforeFind(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvBeforeFindArgs e)
        {
            this.richTextBox1.AppendText("\n BeforeNodeMatchFound Event Triggered");
        }

        //To show the search dialog
        void treeViewAdv1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyValue == (Char)Keys.F)
            {
                form = new TreeViewSearchForm(this.treeViewAdv1);
                form.ShowDialog();
            }
        }
    }
}