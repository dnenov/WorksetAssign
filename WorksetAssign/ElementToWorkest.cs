using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorksetAssign
{
    public partial class ElementToWorkest : System.Windows.Forms.Form
    {
        private SortedDictionary<string, WorksetId> worksetMapper;
        private SortedDictionary<string, Category> categoriesMapper;
        private Document doc;

        public ElementToWorkest(Document doc)
        {
            this.doc = doc;
            this.worksetMapper = WorksetMapper.getMapper(doc);
            this.categoriesMapper = CategoriesMapper.getMapper(doc);

            InitializeComponent();
            InitializeElements();
            InitializeWorksets();
        }

        private void InitializeElements()
        {
            elementsComboBox.Items.AddRange(categoriesMapper.Keys.ToArray());
        }

        private void InitializeWorksets()
        {
            worksetsComboBox.Items.AddRange(worksetMapper.Keys.ToArray());
        }

        #region Main
        private void assignButton_Click(object sender, EventArgs e)
        {
            if (worksetsComboBox.Text == "" || elementsComboBox.Text == "")
            {
                MessageBox.Show("Please assign Category and Workset values.");
            }
            else if (!worksetMapper.ContainsKey(worksetsComboBox.Text) || !categoriesMapper.ContainsKey(elementsComboBox.Text))
            {
                MessageBox.Show("Please choose a correct Category and Worsket value from the drop-down list.");
            }
            else
            {
                string message = "";
                string workset = worksetsComboBox.Text;
                string category = elementsComboBox.Text;
                WorksetAssign.Assign(doc, worksetMapper[workset], workset, categoriesMapper[category], category, progressBar, progressLabel, out message);
                progressLabel.Text = message;
            }
        }
        #endregion

        #region Form Control
        private void doneButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void elementsComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown += new PreviewKeyDownEventHandler(elementsComboBox_PreviewKeyDown);
        }

        private void elementsComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown -= elementsComboBox_PreviewKeyDown;
            if (cbo.DroppedDown) cbo.Focus();
        }

        private void worksetsComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown += new PreviewKeyDownEventHandler(worksetsComboBox_DropDown);
        }

        private void worksetsComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown -= worksetsComboBox_DropDown;
            if (cbo.DroppedDown) cbo.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

    }
}
