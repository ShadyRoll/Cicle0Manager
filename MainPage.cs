using Cicle0ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cicle0Manager
{
    public partial class MainPage : Form
    {
        List<int> numbersList;
        List<CheckBox> numbersCheckBoxes;

        readonly NoteDataBase dataBase;

        Note selectedNote;

        public MainPage()
        {
            InitializeComponent();
            InitVars();
            InitCheckBoxes();

            dataBase = new NoteDataBase($"../../../../cicle0.db3");
            UpdateNovelsList();
        }

        private void UpdateNovelsList()
        {
            novelslListView.Clear();
            List<Note> novels = dataBase.GetNotesAsync().StartAndResult();
            for (int i = 0; i < novels.Count; i++)
            {
                ListViewItem item = new ListViewItem()
                {
                    Text = novels[i].Title,
                    Tag = novels[i]
                };

                novelslListView.Items.Add(item);
            }
        }

        private void InitCheckBoxes()
        {
            for (int i = 0; i < numbersList.Count; i++)
            {
                numbersCheckBoxes.Add(new CheckBox()
                {
                    Location = new Point(titleTextBox.Location.X + (i % 7) * 100,
                        titleTextBox.Location.Y + titleTextBox.Height + (i / 7) * 30),
                    Width = 100,
                    Text = numbersList[i].ToString(),
                    Font = new Font("Microsoft Sans Serif", 14)
                });
                Controls.Add(numbersCheckBoxes[i]);
            }
        }

        private void InitVars()
        {
            numbersList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 13 };
            numbersCheckBoxes = new List<CheckBox>(numbersList.Count);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataBase.SaveNoteAsync(new Note()).StartAndResult();
            UpdateNovelsList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (novelslListView.SelectedItems.Count == 0)
                return;
            dataBase.DeleteNoteAsync((Note)novelslListView.SelectedItems[0].Tag).StartAndResult();
            UpdateNovelsList();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            UpdateNovelsList();
        }

        private void novelslListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (novelslListView.SelectedItems.Count == 0)
                return;
            selectedNote = (Note)novelslListView.SelectedItems[0].Tag;
            UpdateSelectedNote();
        }

        private void UpdateSelectedNote()
        {
            if (novelslListView.SelectedItems.Count == 0)
                return;

            List<int> authors = selectedNote.Authors.GetAuthores();

            for (int i = 0; i < numbersList.Count; i++)
            {
                numbersCheckBoxes[i].Checked = authors.Contains(numbersList[i]);
            }

            titleTextBox.Text = selectedNote.Title;
            novelTextBox.Text = selectedNote.Text;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            UpdateSelectedNote();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            selectedNote.Title = titleTextBox.Text;
            selectedNote.Text = novelTextBox.Text;
            selectedNote.Authors.SetAuthores(GetAuthoresFromBoxes());
            dataBase.SaveNoteAsync(selectedNote).StartAndResult();
            UpdateNovelsList();
        }

        private List<int> GetAuthoresFromBoxes()
        {
            List<int> authores = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersCheckBoxes[i].Checked)
                    authores.Add(numbersList[i]);
            }
            return authores;
        }
    }
}
