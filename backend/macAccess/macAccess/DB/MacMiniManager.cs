using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macAccess.DB
{
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

      /*  public async Task<bool> RemoveHomeStation(int id)
        {
            var homeStation = await context.HomeStations.FirstOrDefaultAsync(h => h.Id == id);
            if (homeStation == null)
                return false;

            context.HomeStations.Remove(homeStation);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateHomeStation(HomeStation homeStation)
        {
            if (homeStation == null)
                return false;

            context.HomeStations.Update(homeStation);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<HomeStation> GetHomeStation(int id)
        {
            return await context.HomeStations.Where(h => h.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<HomeStation>> GetAllHomeStation(int id)
        {
            return (IEnumerable<HomeStation>)await context.RegisterDatas.Where(rd => rd.User.Id == id)
                .Join(context.HomeStations, data => data.HomeStation.Id, home => home.Id, (home, data) => home)
                .ToListAsync();
        }*/
        #endregion

        #region MacMiniData
     
        #endregion

    }
}
