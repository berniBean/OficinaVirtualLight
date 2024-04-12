using System.Threading.Tasks;

namespace WindowsFormsApp6.Helper.Strategy
{
    public class CopyPasteMakerContext<T>
    {
        private ICopyPaste<T> _copyPaste;

        public ICopyPaste<T> CopyPaste
        {
            set
            {
                _copyPaste = value;
            }
        }

        public CopyPasteMakerContext(ICopyPaste<T> copyPaste)
        {
            _copyPaste = copyPaste;
        }

        public async Task RunStrategyCpyPste()
        {

        }
    }
}
