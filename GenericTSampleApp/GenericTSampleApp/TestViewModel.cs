using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTSampleApp
{
    public class TestViewModel<TSampleViewModel> : BaseViewModel
        where TSampleViewModel : SampleViewModel, new ()
    {
    }
}
