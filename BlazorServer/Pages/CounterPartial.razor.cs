using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public partial class CounterPartial
    {
        private int currentCountPartial = 0;

        private void IncrementCountPartial()
        {
            currentCountPartial++;
        }
    }
}
