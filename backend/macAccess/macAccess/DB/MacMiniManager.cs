using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macAccess.DB
{
    public record MacMiniDTO(int id, string name, string mac, int cpu, int ram, int speicher, int netzwerk);

    public class MacMiniManager
    {
        private readonly MacAccessContext context;

        public MacMiniManager(MacAccessContext context)
        {
            this.context = context;
        }

        #region MacMini
        public async Task AddMacMini(MacMini macMini)
        {
            context.MacMinis.Add(macMini);
            await context.SaveChangesAsync();
        }

        public async Task<bool> RemoveMacMini(int id)
        {
            var macMini = await context.MacMinis.FirstOrDefaultAsync(h => h.Id == id);
            if (macMini == null)
                return false;

            context.MacMinis.Remove(macMini);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateMacMini(MacMini macMini)
        {
            if (macMini == null)
                return false;

            context.MacMinis.Update(macMini);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<MacMini> GetMacMini(int id)
        {
            return await context.MacMinis.Where(h => h.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<MacMiniDTO>> GetAllMacMini()
        {
            return (IEnumerable<MacMiniDTO>)await context.MacMiniDatas
                .Select(m => new MacMiniDTO(m.MacMini.Id, m.MacMini.Name, m.MacMini.Mac, m.CPU, m.RAM, m.Speicher, m.Netzwerk))
                .ToListAsync();
        }
        #endregion

        #region MacMiniData
        public async Task AddMacMiniData(MacMiniData macMiniData)
        {
            context.MacMiniDatas.Add(macMiniData);
            await context.SaveChangesAsync();
        }
        #endregion

    }
}
