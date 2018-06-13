using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetStandardConversionCrash
{
    public class Test
    {
        public async Task A(params object[] items)
        {
            SetTo0(items, await B());
        }

        private async Task<int> B() => 0;

        private void SetTo0(in IEnumerable<object> items, in int length)
        {
        }
    }
}
