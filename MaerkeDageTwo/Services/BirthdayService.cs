using MaerkeDageTwo.Data;
using Microsoft.EntityFrameworkCore;

namespace MaerkeDageTwo.Services
{
    public class BirthdayService
    {
        private readonly AppDbContext _context;

        public BirthdayService(AppDbContext context)
        {
            _context = context;
        }

        // Create a new birthday
        public async Task CreateBirthdayAsync(Birthday birthday)
        {
            _context.Birthdays.Add(birthday);
            await _context.SaveChangesAsync();
        }

        // Retrieve a list of all birthdays
        public async Task<List<Birthday>> GetBirthdaysAsync()
        {
            return await _context.Birthdays.ToListAsync();
        }

        // Retrieve a specific birthday by ID
        public async Task<Birthday> GetBirthdayByIdAsync(int id)
        {
            return await _context.Birthdays.FindAsync(id);
        }

        // Update an existing birthday
        public async Task UpdateBirthdayAsync(Birthday birthday)
        {
            _context.Entry(birthday).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete a birthday by ID
        public async Task DeleteBirthdayAsync(int id)
        {
            var birthday = await _context.Birthdays.FindAsync(id);
            if (birthday != null)
            {
                _context.Birthdays.Remove(birthday);
                await _context.SaveChangesAsync();
            }
        }
    }
}
