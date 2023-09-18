using MvvmCross;

namespace GenericTSampleApp
{
    public class MainViewModel<TSampleViewModel> : BaseViewModel
        where TSampleViewModel : SampleViewModel
    {

        public TSampleViewModel SampleMethod(string id, string name)
        {
            var sample = ?????? TSampleViewModel { Id = id, Name = name }; // <= 막히는 부분 입니다.

            return sample;
            // var sample = Mvx.IoCProvider.IoCConstruct<TSampleViewModel>(new[] { id, name });
            // 원하는 기대 값은 위에 코드와 같이 <T>를 new 생성하는 방법 입니다.
        }
    }


    // 1. new () 추가 없이 구현하는 방식이 궁금합니다.
    // 이유는 new ()를 추가하면 상속 받는 클래스를 수정하고 수정하는 문제가 발생합니다.

    // 2. 가능하면 IoC로 관리 가능한 상태면 좋겠습니다.
    // 3. MvvmCross IoCConstruct를 MAUI에서 사용하는 컨테이너에 맞게 구현 할 수 있을까요?
    /* public class MainViewModel<TSampleViewModel> : BaseViewModel
    where TSampleViewModel : SampleViewModel, new ()
    {
        public TSampleViewModel SampleMethod(string id, string name)
        {
            var sample = new TSampleViewModel { Id = id, Name = name };

            return sample;
        }
    }
    */
}
