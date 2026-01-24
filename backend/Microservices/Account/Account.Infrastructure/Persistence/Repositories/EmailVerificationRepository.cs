using Account.Core.Entities;
using Account.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Account.Infrastructure.Persistence.Repositories;

public class EmailVerificationRepository(UsersDbContext context) : IEmailVerificationCodeRepository
{
    private readonly UsersDbContext _context = context;

    public async Task AddAsync(EmailVerificationCode entity, CancellationToken token = default)
    {
        await _context.EmailVerificationCodes.AddAsync(entity, token);
    }

    public void Delete(EmailVerificationCode entity)
    {
        _context.EmailVerificationCodes.Remove(entity);
    }

    public async Task<IEnumerable<EmailVerificationCode>> GetAllAsync(CancellationToken token = default)
    {
        return await _context.EmailVerificationCodes.ToListAsync(token);
    }

    public async Task<EmailVerificationCode?> GetByIdAsync(Guid id, CancellationToken token = default)
    {
        return await _context.EmailVerificationCodes.FindAsync([id], token);
    }

    public void Update(EmailVerificationCode entity)
    {
        _context.EmailVerificationCodes.Update(entity);
    }
}
