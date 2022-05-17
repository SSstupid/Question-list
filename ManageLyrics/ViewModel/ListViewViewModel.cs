using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ManageLyrics
{
    public class ListViewViewModel : BaseViewModel
    {
        public static List<ListModel> _songList { get; set; }

        public ListViewViewModel()
        {
            List<ListModel> fileDatas = new();
            fileDatas.Add(new ListModel() { files = "abccc" });
            _songList = fileDatas;
        }

        public void ListDragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
        }

        public void ListDrag(object sender, DragEventArgs e)
        {
           // List<ListModel> fileDatas = new();
            var AddItem = sender as ListView;
            string[] abc = (string[])e.Data.GetData(DataFormats.FileDrop);
            /*foreach (string fileName in abc)
            {
                _songList.Add(new ListModel() { files = fileName });
            }*/
            //_songList = fileDatas;

            //AddItem.ItemsSource = _songList;
            //AddItem.Items.Refresh();
        }
    }
}
