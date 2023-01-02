using System.Threading.Tasks;

namespace CleanArchitecture.InterfacesUtilidades
{
    public interface IWriter<T>
    {
        Task Writer(T data);
    }
}
