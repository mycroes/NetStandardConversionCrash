using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetStandardConversionCrash
{
    public class Test
    {
        public async Task A(params object[] items)
        {
            C(items, await B());
        }

        private async Task<int> B() => 0;

        private void C(in IEnumerable<object> items, in int length)
        {
        }
    }
}
