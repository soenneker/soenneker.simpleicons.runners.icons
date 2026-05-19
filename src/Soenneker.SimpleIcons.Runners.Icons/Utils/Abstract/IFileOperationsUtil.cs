using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.SimpleIcons.Runners.Icons.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken);
}
