using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SamplePageOpenAfterGetItem;

public class AddItemPageViewModel
{

    public AddItemPageViewModel()
    {
        Wifis = new ObservableCollection<Wifi>();

        DummyGetWifi().ForEach(wifiItems => Wifis.Add(wifiItems));
    }

    public ObservableCollection<Wifi> Wifis { get; set; }

    public List<Wifi> DummyGetWifi()
    {
        //Wifi 스캔, 반환 값 기다리는 중 입니다.
        Task.Run(ScanWifiGetResult).GetAwaiter().GetResult();
        // Or Await Task.Run(ScanWifiGetResult).ConfigureAwait(false);
        //Wifi 스캔, 반환 값 기다리는 중 입니다.

        List<Wifi> wifi = new()
        {
            new Wifi() { Ssid = "Test1" },
            new Wifi() { Ssid = "Test2" },
            new Wifi() { Ssid = "Test3" },
            new Wifi() { Ssid = "Test4" },
            new Wifi() { Ssid = "Test5" },
            new Wifi() { Ssid = "Test6" },
            new Wifi() { Ssid = "Test7" },
        };

        return wifi;
    }

    public void ScanWifiGetResult()
    {
        Thread.Sleep(3000);
    }
}
