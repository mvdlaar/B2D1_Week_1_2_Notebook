using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2D1_Week_1_2_Notebook
{
    public partial class NotebookDemoForm : Form
    {
        private List<Notebook> notebooks;

        public NotebookDemoForm()
        {
            InitializeComponent();

            notebooks = new List<Notebook>();
        }

        private void btnAddNotebook_Click(object sender, EventArgs e)
        {
            Notebook newNotebook = new Notebook();
            notebooks.Add(newNotebook);

            int notebookIndex = lbxNotebooks.Items.Add("Notebook " + notebooks.Count.ToString());

            if (lbxNotebooks.SelectedIndex == -1)
            {
                lbxNotebooks.SelectedIndex = notebookIndex;
            }

        }

        private void lbxNotebooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxNotes.Items.Clear();
            if (lbxNotebooks.SelectedIndex != -1)
            {
                int i = 0;
                while (i < notebooks[lbxNotebooks.SelectedIndex].NumberOfNotes())
                {
                    lbxNotes.Items.Add(notebooks[lbxNotebooks.SelectedIndex].ShowNote(i));
                    i++;
                }
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (lbxNotebooks.SelectedIndex != -1)
            {
                notebooks[lbxNotebooks.SelectedIndex].StoreNote(tbNewNote.Text);
                lbxNotes.Items.Add(tbNewNote.Text);
            }
        }
    }
}
