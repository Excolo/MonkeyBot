﻿using MonkeyBot.Database.Entities;
using System.Threading.Tasks;

namespace MonkeyBot.Database.Repositories
{
    public interface IBenzenFactsRespository : IRepository<BenzenFactEntity, string>
    {
        Task<string> GetRandomFactAsync();
    }
}