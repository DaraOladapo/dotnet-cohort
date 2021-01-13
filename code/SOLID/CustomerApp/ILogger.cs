using System.Diagnostics;

namespace CustomerApp
{

    public interface ILogger
    {
        void Handle(string Error);
    }
}
