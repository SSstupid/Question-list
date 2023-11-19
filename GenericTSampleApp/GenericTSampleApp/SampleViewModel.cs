using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTSampleApp
{
    public class SampleViewModel : BaseViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        // where TSampleViewModel : SampleViewModel, new ()
        // 문제점 예제입니다.
        // CS0310 : 매개 변수가 없는 public 비추상 유형이어야 합니다.
        // 에러 문서 링크 : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0310?f1url=%3FappId%3Droslyn%26k%3Dk(CS0310)
        public SampleViewModel(BaseViewModel baseViewModel, string name)
        {
        }

    }
}
