using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace beadando_FLX1D8;

public partial class MainPage : ContentPage
{
    ObservableCollection<string> notes;

    public MainPage()
    {
        InitializeComponent();
        notes = new ObservableCollection<string>();
        notesListView.ItemsSource = notes;
    }

    void OnAddNoteClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(noteEntry.Text))
        {
            notes.Add(noteEntry.Text);
            noteEntry.Text = string.Empty;
        }
    }
}

