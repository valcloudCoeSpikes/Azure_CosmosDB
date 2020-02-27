using System.Collections.Generic;
using System.Threading.Tasks;
using CosmosDemo.Models;

namespace CosmosDemo.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Item>> GetItemsAsync(string query);
        Task<Item> GetItemAsync(string id);
        Task AddItemAsync(Item item);
        Task UpdateItemAsync(string id, Item item);
        Task DeleteItemAsync(string id);

        Task<IEnumerable<ProjectTask>> GetTasksAsync(string query, string id);
        Task<ProjectTask> GetTaskAsync(string id);
        Task AddTaskAsync(ProjectTask projectTask);
        Task UpdateTaskAsync(string id, ProjectTask projectTask);
        Task DeleteTaskAsync(string id);
    }
}
