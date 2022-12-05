using System.Collections.ObjectModel;

namespace TestRecordStruct;

public partial class MainPageViewModel
{
    public MainPageViewModel()
    {
        /*RecordStructItem = new ObservableCollection<RecordStruct> 
        { 
            new RecordStruct(name : "name1", test : "test1"),
            new RecordStruct(name : "name2", test : "test2"),
            new RecordStruct(name : "name3", test : "test3"),
            new RecordStruct(name : "name4", test : "test4"),
            new RecordStruct(name : "name5", test : "test5"),
            new RecordStruct(name : "name6", test : "test6"),
        };*/
    }

    // ItemSource Binding
    public ObservableCollection<RecordStruct> RecordStructItem { get; set; }

    // SelectedItem Binding
    public RecordStruct SelectedItem { get; set; }
}
