using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BambooTray.App.Models;

// ReSharper disable once CheckNamespace
public static class ListViewExtensions
{
    public static IEnumerable<ListViewItem> Items(this ListView listView)
    {
        return listView.Items.Cast<ListViewItem>();
    }

    public static IEnumerable<ListViewItem> SelectedItems(this ListView listView)
    {
        return listView.SelectedItems.Cast<ListViewItem>();
    }

    public static MainViewModel GetViewModel(this ListViewItem listViewItem)
    {
        var mainViewModel = listViewItem.Tag as MainViewModel;
        return mainViewModel ?? MainViewModel.Null;
    }
}