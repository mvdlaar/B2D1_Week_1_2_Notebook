namespace B2D1_Week_1_2_Notebook
{
    partial class NotebookDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxNotebooks = new System.Windows.Forms.ListBox();
            this.lblNotebooks = new System.Windows.Forms.Label();
            this.lbxNotes = new System.Windows.Forms.ListBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnAddNotebook = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.tbNewNote = new System.Windows.Forms.TextBox();
            this.lblNewNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxNotebooks
            // 
            this.lbxNotebooks.FormattingEnabled = true;
            this.lbxNotebooks.Location = new System.Drawing.Point(8, 23);
            this.lbxNotebooks.Name = "lbxNotebooks";
            this.lbxNotebooks.Size = new System.Drawing.Size(153, 147);
            this.lbxNotebooks.TabIndex = 0;
            this.lbxNotebooks.SelectedIndexChanged += new System.EventHandler(this.lbxNotebooks_SelectedIndexChanged);
            // 
            // lblNotebooks
            // 
            this.lblNotebooks.AutoSize = true;
            this.lblNotebooks.Location = new System.Drawing.Point(5, 7);
            this.lblNotebooks.Name = "lblNotebooks";
            this.lblNotebooks.Size = new System.Drawing.Size(59, 13);
            this.lblNotebooks.TabIndex = 1;
            this.lblNotebooks.Text = "Notebooks";
            // 
            // lbxNotes
            // 
            this.lbxNotes.FormattingEnabled = true;
            this.lbxNotes.Location = new System.Drawing.Point(203, 24);
            this.lbxNotes.Name = "lbxNotes";
            this.lbxNotes.Size = new System.Drawing.Size(142, 147);
            this.lbxNotes.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(204, 8);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.Text = "Notes";
            // 
            // btnAddNotebook
            // 
            this.btnAddNotebook.Location = new System.Drawing.Point(8, 176);
            this.btnAddNotebook.Name = "btnAddNotebook";
            this.btnAddNotebook.Size = new System.Drawing.Size(153, 23);
            this.btnAddNotebook.TabIndex = 4;
            this.btnAddNotebook.Text = "Add Notebook";
            this.btnAddNotebook.UseVisualStyleBackColor = true;
            this.btnAddNotebook.Click += new System.EventHandler(this.btnAddNotebook_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(371, 176);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(141, 23);
            this.btnAddNote.TabIndex = 5;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // tbNewNote
            // 
            this.tbNewNote.Location = new System.Drawing.Point(371, 150);
            this.tbNewNote.Name = "tbNewNote";
            this.tbNewNote.Size = new System.Drawing.Size(141, 20);
            this.tbNewNote.TabIndex = 6;
            // 
            // lblNewNote
            // 
            this.lblNewNote.AutoSize = true;
            this.lblNewNote.Location = new System.Drawing.Point(368, 134);
            this.lblNewNote.Name = "lblNewNote";
            this.lblNewNote.Size = new System.Drawing.Size(55, 13);
            this.lblNewNote.TabIndex = 7;
            this.lblNewNote.Text = "New Note";
            // 
            // NotebookDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.lblNewNote);
            this.Controls.Add(this.tbNewNote);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnAddNotebook);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lbxNotes);
            this.Controls.Add(this.lblNotebooks);
            this.Controls.Add(this.lbxNotebooks);
            this.Name = "NotebookDemoForm";
            this.Text = "Notebook Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNotebooks;
        private System.Windows.Forms.Label lblNotebooks;
        private System.Windows.Forms.ListBox lbxNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnAddNotebook;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.TextBox tbNewNote;
        private System.Windows.Forms.Label lblNewNote;
    }
}

