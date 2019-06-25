using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace async_winform_task_await
{
    class Repository
    {
        public async Task<int> HentTilfældigVærdi(CancellationToken token, bool fejl = false) {

            if (fejl)
                throw new ApplicationException("Fejl fra HentTilfældigVærdi()");

            using (var client = new HttpClient())
            {
                var r = await client.GetAsync("http://webdemo.cronberg.dk/service/dice_txt/3000", token);
                token.ThrowIfCancellationRequested();
                if (r.IsSuccessStatusCode)
                    return Convert.ToInt32(await r.Content.ReadAsStringAsync());
                else
                    throw new ApplicationException("Kan ikke hente tal");
            }
        }
    }
}
