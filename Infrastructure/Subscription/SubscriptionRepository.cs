using Domain.Subscription.Model.Entities;
using Domain.Subscription.Repositories;
using Infrastructure.Shared.Persistence.EFC.Configuration;
using Infrastructure.Shared.Persistence.EFC.Repositories;

namespace Infrastructure.Subscription;

public class SubscriptionRepository(AppDbContext context) : BaseRepository<SubscriptionEntity>(context), ISubscriptionRepository
{
    
}