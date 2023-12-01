using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Models;

namespace Pronia.Repositories.Implementations
{
    public class SliderRepository : ISliderRepository
    {
        private readonly DataContext _context;

        public SliderRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(Slider slider)
        {
            await _context.Sliders.AddAsync(slider);
        }

        public void Delete(Slider slider)
        {
            _context.Sliders.Remove(slider);
        }

        public async Task<List<Slider>> GetAllAsync()
        {
            return await _context.Sliders.ToListAsync();
        }

        public async Task<Slider> GetByIdAsync(int id)
        {
            return await _context.Sliders.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
