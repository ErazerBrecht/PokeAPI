﻿using System.Threading.Tasks;

namespace BLL.Anime.Interfaces
{
    public interface IAnimeManager
    {
        Task<DAL_Database.DTO.Anime> GetById(int id);
    }
}